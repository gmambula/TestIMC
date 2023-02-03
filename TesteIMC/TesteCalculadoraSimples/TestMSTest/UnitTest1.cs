using TesteCalculadoraSimples;

namespace TestMSTest
{
    [TestClass]
    public class UnitTest1  
    {
        [TestMethod]
        public void TesteSomarDoisNumeros()
        {
            //Arrange - Preparação
            double pNum = 1;
            double sNum = 1;
            double tNum = 2;

            //Act - Ação 
            var resultado = operacoes.Somar(pNum, sNum);

            //Assert - Verificação
            Assert.AreEqual(tNum, resultado);
        }


        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(1, 2, 2)]
        public void TesteSomarDoisNumerosLista(double pNum, double sNum, double tNum)
        {
            //Act - Ação
            var resultado = operacoes.Somar(pNum, sNum);

            //Assert - Verificação
            Assert.AreEqual(tNum, resultado);
        }
    }
}