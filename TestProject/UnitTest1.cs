using System;
using System.IO;
using Xunit;

namespace TestProject
{
    public class UnitTest1
    {
        private const string Expected = "Hello World!";
        [Fact]
        public void Test1()
        {


            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                ConsoleApp.Program.Main();

                var result = sw.ToString().Trim();

                Assert.Equal(Expected, result);
            }
        }
    }
}
