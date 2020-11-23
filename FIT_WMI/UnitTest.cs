using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FIT_WMI
{
  [TestClass]

  public class UnitTest
    {

            [TestMethod]
            public void OnLoginSuccess()
            {
            Form1 frm1 = new Form1();

            frm1._rID = "brk.233";
            frm1._rPASS = "2345";

            Assert.IsTrue(frm1.ConnectTest());

            }

       
            [TestMethod]
            public void OnLoginFail()
            {
            Form1 frm1 = new Form1();

            frm1._rID = "brk.233";
            frm1._rPASS = "asd123"; //wrong pass


            Assert.IsTrue(frm1.addAlarm());


            }

            [TestMethod]
            public void AddTransaction()
            {
            Form1 frm1 = new Form1();

            frm1._rID = "brk.233";
            frm1._rPASS = "2345";


            Assert.IsTrue(frm1.addTransaction());


            }

    }

}
