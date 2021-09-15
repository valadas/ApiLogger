// MIT License
// Copyright Eraware

using System;

namespace Eraware.Modules.ApiLogger.Services
{
    /// <summary>
    /// Allows logging.
    /// </summary>
    internal interface ILoggingService
    {
        /// <summary>
        /// Logs an error.
        /// </summary>
        /// <param name="message">The error message.</param>
        void LogError(string message);

        /// <summary>
        /// Logs and error with an exception details.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="ex">The exception details.</param>
        void LogError(string message, Exception ex);
    }
}