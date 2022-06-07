using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int cantidad = 230;
            int billetes50 = 4;
            int billetes20 = 1;
            int billetes10 = 1;

            bill billetes = new bill();
            billetes.EstablecerCantidad(cantidad);
            int billetesReales10 = billetes.BilleteDiez;
            int billetesReales20 = billetes.BilleteVeinte;
            int billetesReales50 = billetes.BilleteCincuenta;

            Assert.AreEqual(billetes10, billetesReales10, "billetes de 10 incorrectos");
            Assert.AreEqual(billetes20, billetesReales20, "billetes de 20 incorrectos");
            Assert.AreEqual(billetes50, billetesReales50, "billetes de 50 incorrectos");

         
            
            }



        [TestMethod]
        [ExpectedException (typeof(ArgumentOutOfRangeException))]
        public void EstablecerCantidadOutOfRange()
            {
            int cantidad = 325;

            bill billetes = new bill();
            billetes.EstablecerCantidad(cantidad);


            }




    }



