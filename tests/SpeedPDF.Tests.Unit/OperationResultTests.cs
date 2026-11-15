using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpeedPDF.Core;
namespace SpeedPDF.Tests.Unit
{
    [TestClass]
    public class OperationResultTests
    {
        [TestMethod]
        public void Success_ReturnsSuccessfulResult()
        {
            var result = OperationResult.Success("Completed");
            Assert.IsTrue(result.Succeeded);
            Assert.AreEqual("Completed", result.Message);
        }
        [TestMethod]
        public void Failure_ReturnsFailedResult()
        {
            var result = OperationResult.Failure("Invalid input");
            Assert.IsFalse(result.Succeeded);
            Assert.AreEqual("Invalid input", result.Message);
        }
    }
}