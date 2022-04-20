using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tdd_pratica.UnitTest
{
    [TestClass]
    public class GirarListaTest
    {
        [TestMethod]
        public void DeveriaMoverPrimeiroItemParaOFinal4Itens()
        {
            var lista = new List<int> { 1, 2, 3, 4 };
            var gira = new GiraLista();

            var nova = gira.Girar(lista);

            Assert.AreEqual(lista.Count, nova.Count);
            Assert.AreEqual(lista[1], nova[0]);
            Assert.AreEqual(lista[0], nova[3]);
        }

        [TestMethod]
        public void DeveriaMoverPrimeiroItemParaOFinal3Itens()
        {
            var lista = new List<int> { 11, 12, 13 };
            var gira = new GiraLista();

            var nova = gira.Girar(lista);

            Assert.AreEqual(lista.Count, nova.Count);
            Assert.AreEqual(lista[1], nova[0]);
            Assert.AreEqual(lista[0], nova[2]);
        }

        [TestMethod]
        public void DeveriaMoverPrimeiroItemParaOFinalNItens()
        {
            var lista = new List<int> { 21, 22, 23, 24, 25, 26 };
            var gira = new GiraLista();

            var nova = gira.Girar(lista);

            Assert.AreEqual(lista.Count, nova.Count);
            Assert.AreEqual(lista[1], nova[0]);
            Assert.AreEqual(lista[0], nova[2]);
        }
    }
}