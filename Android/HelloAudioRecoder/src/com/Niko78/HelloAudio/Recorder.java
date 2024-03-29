package com.Niko78.HelloAudio;

import com.Niko78.HelloAudio.Recoders.BaseRecoder;
import com.Niko78.HelloAudio.Runners.WaveUpdater;
import com.Niko78.HelloAudio.Views.WaveView;

import android.media.AudioFormat;
import android.media.AudioRecord;
import android.media.MediaRecorder;

public class Recorder extends BaseRecoder  
{
	private WaveView _associatedView;	
	float average = 0.0F;	


	public Recorder(WaveView associatedView) 
	{
		super();
		this.setFrequency(8000);
		this.setChannelConfiguration(AudioFormat.CHANNEL_CONFIGURATION_MONO);
		this.setPaused(false);
		_associatedView = associatedView;		
	}

	public void CaptureSound() throws InterruptedException 
	{
		// Wait until we�re recording�
		synchronized (mutex) 	
		{
			while (!this.isRecording) 
			{
				mutex.wait();
			}
		}

		// We�re important�
		android.os.Process.setThreadPriority(android.os.Process.THREAD_PRIORITY_URGENT_AUDIO);

		// 	Allocate Recorder and Start Recording�
		int bufferRead = 0;
		int bufferSize = AudioRecord.getMinBufferSize(this.getFrequency(), this.getChannelConfiguration(), this.getAudioEncoding());
		
		bufferSize = 16000;
		
		AudioRecord recordInstance = new AudioRecord(MediaRecorder.AudioSource.MIC, this.getFrequency(), this.getChannelConfiguration(), this.getAudioEncoding(), bufferSize);

		//int state = recordInstance.getState();

		short[] tempBuffer = new short[bufferSize];
		
		// Start Recording
		recordInstance.startRecording();
		
		while (this.isRecording) 
		{
			// 	Are we paused?
			synchronized (mutex) 
			{
				if (this.isPaused) 
				{
					mutex.wait(250);
					continue;
				}
			}

			// Read Audio buffer 
			bufferRead = recordInstance.read(tempBuffer, 0, bufferSize);
			
			if (bufferRead == AudioRecord.ERROR_INVALID_OPERATION) 
			{
				throw new IllegalStateException("read() returned AudioRecord.ERROR_INVALID_OPERATION");
			} 
			else if (bufferRead == AudioRecord.ERROR_BAD_VALUE) 
			{
				throw new IllegalStateException("read() returned AudioRecord.ERROR_BAD_VALUE");
			}
			else if (bufferRead == AudioRecord.ERROR_INVALID_OPERATION) 
			{
				throw new IllegalStateException("�read() returned AudioRecord.ERROR_INVALID_OPERATION");
			}

			average = 0.0F;
			
			for (int idxBuffer = 0; idxBuffer < bufferRead; ++idxBuffer) 
			{
				average = average + tempBuffer[idxBuffer];
			}
			
			average = average / bufferRead;
			
			WaveUpdater waveUpdater = new WaveUpdater(_associatedView, tempBuffer);

			_associatedView.post(waveUpdater);
		}

		// Close resources�
		recordInstance.stop();
	}


}