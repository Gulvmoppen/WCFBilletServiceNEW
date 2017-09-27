using Microsoft.VisualStudio.TestTools.UnitTesting;
using WCFBilletServiceNEW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFBilletServiceNEW.Tests
{
    [TestClass()]
    public class BillettenTests
    {
        [TestMethod()]
        public void BilPrisTest()
        {
            //Arrange
            Billetten bil = new Billetten();
            //Act
            int denint = bil.BilPris();
            //Assert
            Assert.AreEqual(bil.BilPris(), denint);
        }

        [TestMethod()]
        public void BilPrisMedBrobizzTest()
        {
            //Arrange
            Billetten bil = new Billetten();
            //Act
            int denint = bil.BilPrisMedBrobizz();
            //Assert
            Assert.AreEqual(bil.BilPrisMedBrobizz(), denint);
        }

        [TestMethod()]
        public void BilPrisØresundTest()
        {
            //Arrange
            Billetten bil = new Billetten();
            
            //Act
            int denint = bil.BilPrisØresund();
            //Assert
            Assert.AreEqual(bil.BilPrisØresund(), denint);
        }

        [TestMethod()]
        public void BilPrisØresundMedBroBizzTest()
        {
            //Arrange
            Billetten bil = new Billetten();
            //Act
            int denint = bil.BilPrisØresundMedBroBizz();
            //Assert
            Assert.AreEqual(bil.BilPrisØresundMedBroBizz(), denint);
        }

        [TestMethod()]
        public void McPrisTest()
        {
            //Arrange
            Billetten mc = new Billetten();
            //Act
            int denint = mc.McPris();
            //Assert
            Assert.AreEqual(mc.McPris(), denint);
        }

        [TestMethod()]
        public void McPrisMedBrobizzTest()
        {
            //Arrange
            Billetten mc =  new Billetten();
            //Act
            int denint = mc.McPrisMedBrobizz();
            //Assert
            Assert.AreEqual(mc.McPrisMedBrobizz(), denint);
        }

        [TestMethod()]
        public void McPrisMedØresund()
        {
            //Arrange
            Billetten mc = new Billetten();
            //Act
            int denint = mc.McPrisMedØresund();
            //Assert
            Assert.AreEqual(mc.McPrisMedØresund(),denint);
        }

        [TestMethod()]
        public void McPrisØresundMedBroBizzTest()
        { 
        
            //Arrange
            Billetten mc = new Billetten();

            //Act
            int denint = mc.McPrisØresundMedBroBizz();
            //Assert
            Assert.AreEqual(mc.McPrisØresundMedBroBizz(), denint);
        }
    }
}