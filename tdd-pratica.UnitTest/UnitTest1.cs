using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tdd_pratica.UnitTest
{
    [TestClass]
    public class GirarListaTest
    {
        [TestMethod]
        public void DeveriaMoverPrimeiroItemParaOFinal()
        {
            var lista = new int[] { 1, 2, 3, 4 };
            var gira = new GiraLista();

            var nova = gira.Girar(lista);

            Assert.AreEqual(lista.Length, nova.Length);
            Assert.AreEqual(lista[1], nova[0]);
        }
    }
}