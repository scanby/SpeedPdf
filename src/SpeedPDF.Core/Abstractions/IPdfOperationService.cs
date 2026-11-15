namespace SpeedPDF.Core.Abstractions
{
    /// <summary>PDF use-case contract independent from a concrete PDF vendor.</summary>
    public interface IPdfOperationService
    {
        OperationResult Merge(string[] inputPaths, string outputPath);
    }
}