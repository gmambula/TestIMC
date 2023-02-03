using TesteCalculadoraSimples;

namespace ProjetoTestXunit
{
    public class UnitTest1
    {
        public class TesteCalculadoraXUnit
    {
        [Fact]
        public void TesteSomarDoisNumeros()
        {
            //Arrange - Prepara��o
            double pNum = 1;
            double sNum = 1;
            double tNum = 2;

                //Act - A��o    Calculadora.Somar(pNum, sNum);
                var resultado = operacoes.Somar(pNum, sNum);

            //Assert - Verifica��o
            Assert.Equal(tNum, resultado);
        }


        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(1, 2, 2)]
        public void TesteSomarDoisNumerosLista(double pNum, double sNum, double tNum)
        {
            //Act - A��o
            var resultado = operacoes.Somar(pNum, sNum);

                //Assert - Verifica��o
                Assert.Equal(tNum, resultado);
        }
    }
    }
}