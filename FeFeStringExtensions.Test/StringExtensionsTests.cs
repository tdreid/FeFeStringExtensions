namespace FeFeStringExtensions.Test
{
    using System;
    using System.IO;
    using Fefe.Extensions.Strings;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StringExtensionsTests
    {
        [TestClass]
        public class TheAppendSeperatorMethod : StringExtensionsTests
        {
            [TestMethod]
            public void AddsASeparatorIfItIsNotPresentAtEnd()
            {
                string extended = "C:\\This\\Path\\Has\\No\\Trailing\\Separator";
                Assert.AreEqual(string.Format("{0}{1}", extended, Path.DirectorySeparatorChar), extended.AppendPathSeparator());
            }

            [TestMethod]
            public void LeavesTheStringUnalteredIfItIsNotPresentAtEnd()
            {
                string extended = "C:\\This\\Path\\Has\\A\\Trailing\\Separator\\";
                Assert.AreEqual(extended, extended.AppendPathSeparator());
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentNullException))]
            public void ThrowsAnArgumentNullExceptionIfTheStringIsNull()
            {
                string extended = null;

                string expectedString = extended.AppendPathSeparator();
            }
        }
    }
}
