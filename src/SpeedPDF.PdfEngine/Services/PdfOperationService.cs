using SpeedPDF.Core;
using SpeedPDF.Core.Abstractions;
namespace SpeedPDF.PdfEngine.Services
{
    /// <summary>Placeholder adapter; no PDF library has been selected or licensed yet.</summary>
    public sealed class PdfOperationService : IPdfOperationService
    {
        public OperationResult Merge(string[] inputPaths, string outputPath)
        {
            if (inputPaths == null || inputPaths.Length < 2) return OperationResult.Failure("Select at least two PDF files.");
            if (string.IsNullOrWhiteSpace(outputPath)) return OperationResult.Failure("An output path is required.");
            return OperationResult.Failure("PDF engine is not configured yet.");
        }
    }
}