using Microsoft.VisualStudio.TestTools.UnitTesting;
using MorseDecoder;
using System.IO;

namespace MorseCodeTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSomethingWrittenInOutput()
        {
            FileEditor editor = new FileEditor("text1.txt","solution.txt");
            editor.presentResults();

            FileInfo info = new FileInfo("solution.txt");
            long size = info.Length;
            if (size > 0)
                Assert.IsTrue(true);
            else
                Assert.IsTrue(false);
        }
    }
}
