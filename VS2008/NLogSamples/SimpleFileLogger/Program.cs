﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Say No More">
//   2009
// </copyright>
// <summary>
//   Simple logger demo program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SimpleFileLogger
{
    using NLog;

    /// <summary>
    /// Simple logger demo program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Nlog Logger.
        /// </summary>
        private static readonly Logger MyLogger = LogManager.GetLogger("MyLogger");

        /// <summary>
        /// Application entry point.
        /// </summary>
        /// <param name="args">Comnad line Arguments.</param>
        public static void Main(string[] args)
        {
            for (int i = 0; i < 300; i++)
            {
                MyLogger.Info("This is a simple logger again!" + i, new object[] { 1, 2 });
            }
        }
    }
}
