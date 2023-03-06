namespace TesteUnidade.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void Calculadora_Somar_RetornarValorSoma()
        {
            //Arrange
            var calculadora = new Calculadora();
            //Act
            var resultado = calculadora.Somar(2, 2);
            //Assert
            Assert.Equal(4, resultado);

        }
        [Theory]
        [InlineData(1,1,2)]
        [InlineData(null, 1, 1)]
        [InlineData(1, null, 1)]
        public void Calculadora_Somar_RetornarValorSomaCorretos(double v1, double v2, double total)
        {
            //Arrange
            var calculadora = new Calculadora();
            //Act
            var resultado = calculadora.Somar(v1, v2);
            //Assert
            Assert.Equal(total, resultado);

        }

        [Fact]
        public void Calculadora_Divisao_RetornarValorSoma()
        {
            //Arrange
            var calculadora = new Calculadora();
            //Act
            var resultado = calculadora.Dividir(4, 2);
            //Assert
            Assert.Equal(2, resultado);

        }
    }
}