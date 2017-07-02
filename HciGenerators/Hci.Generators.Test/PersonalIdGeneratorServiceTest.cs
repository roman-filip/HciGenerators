using System;
using System.Collections.Generic;
using System.Text;
using Hci.Generators.Web.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hci.Generators.Test
{
    [TestClass]
    public class PersonalIdGeneratorServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var generator = new PersonalIdGeneratorService();
            generator.GeneratePersonalIds();
        }
    }
}
