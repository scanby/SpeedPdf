using System;
using System.Diagnostics;
using SpeedPDF.Core.Abstractions;
namespace SpeedPDF.Infrastructure.Logging
{
    public sealed class TraceAppLogger : IAppLogger
    {
        public void Information(string message) { Trace.TraceInformation(message); }
        public void Warning(string message) { Trace.TraceWarning(message); }
        public void Error(string message, Exception exception) { Trace.TraceError("{0} | {1}", message, exception); }
    }
}