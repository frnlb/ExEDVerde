using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExamenVerde;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVerde.Tests
{
    [TestClass()]
    public class ClienteTests
    {
        [TestMethod()]
        public void RestaSaldoTest()
        {
            var saldoNuevo = 5;

            var cliente = new Cliente();

            cliente.RestaSaldo(saldoNuevo);

            var valorEsperado = 95;

            Assert.AreEqual(valorEsperado, cliente.Saldo);
        }

        [TestMethod()]
        public void SumaSaldoTest()
        {
            var saldoNuevo = 5;

            var cliente = new Cliente();

            cliente.SumaSaldo(saldoNuevo);

            var valorEsperado = 105;

            Assert.AreEqual(valorEsperado, cliente.Saldo);
        }
    }
}