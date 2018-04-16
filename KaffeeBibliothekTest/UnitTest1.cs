using System;
using KaffeeBibliothek;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KaffeeBibliothekTest
{
    [TestClass]
    public class VollautomatenTests
    {
        [TestMethod]
        public void TestMilchbefüllung()
        {
            Vollautomat testautomat = new Vollautomat("XYZ");
            //3 Behälter mit jeweils einem Liter Fassungsvermögen
            testautomat.BaueMilchbehälterEin(3);
            testautomat.BefülleMilchContainer(2500);
            if(testautomat.Milchcontainer[0].Milchfüllstand != 1000)
            {
                Assert.Fail();
            }
            
            Assert.AreEqual(1000, testautomat.Milchcontainer[1].Milchfüllstand);
            Assert.AreEqual(500, testautomat.Milchcontainer[2].Milchfüllstand);
            
        }
    }
}
