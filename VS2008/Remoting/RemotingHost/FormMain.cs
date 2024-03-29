﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FormMain.cs" company="Say No More">
//   2009
// </copyright>
// <summary>
//   Defines the FormMain type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Niko78.CSharp.RemotingHost
{
    using System;
    using System.Runtime.Remoting;
    using System.Runtime.Remoting.Channels;
    using System.Runtime.Remoting.Channels.Http;
    using System.Windows.Forms;
    using RemotingObject;

    /// <summary>
    /// Main form of App.
    /// </summary>
    public partial class FormMain : Form
    {
        /// <summary>
        /// Objeto remoto.
        /// </summary>
        private MyObjetoRemoto _myObjetoRemoto;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormMain"/> class.
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa el objeto remoto.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event argument.</param>
        private void InicializeHost_Click(object sender, EventArgs e)
        {
            try
            {
                RemotingConfiguration.Configure("ConfigHostRemoting.xml", false);
                btnInicializarPorMarsall.Enabled = false;
                MessageBox.Show("Objeto Inicializado con exito !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception er)
            {
                MessageBox.Show(string.Format("Error:\n{0}", er.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Inicializa el hosr remoting por marshalling de un objeto (singleton)
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event argument.</param>
        private void InicializarPorMarsall_Click(object sender, EventArgs e)
        {
            try
            {
                HttpServerChannel channel = new HttpServerChannel(8989);
                ChannelServices.RegisterChannel(channel, false);
                _myObjetoRemoto = new MyObjetoRemoto();
                RemotingServices.Marshal(_myObjetoRemoto, "MyObjetoRemoto.rem");
                MessageBox.Show("Objeto Inicializado con exito !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbxMarshalling.Enabled = true;
                btnInicializeHost.Enabled = false;
            }
            catch (Exception er)
            {
                MessageBox.Show(string.Format("Error:\n{0}", er.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Setea el nombre del objeto remoto.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event argument.</param>
        private void SetNombre_Click(object sender, EventArgs e)
        {
            try
            {
                _myObjetoRemoto.SetNombre(texSetNombre.Text);
            }
            catch (Exception er)
            {
                MessageBox.Show(string.Format("El objeto respondio:\n{0}", er.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Obtiene el nombre del objeto remoto.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event argument.</param>
        private void GetNombre_Click(object sender, EventArgs e)
        {
            try
            {
                texSetNombre.Text = _myObjetoRemoto.GetNombre();
                MessageBox.Show(texSetNombre.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception er)
            {
                MessageBox.Show(string.Format("El objeto respondio:\n{0}", er.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}