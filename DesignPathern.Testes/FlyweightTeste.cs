using Xunit;
using Design = DesignPattern.Flyweight;

namespace DesignPattern.Testes
{
    public class FlyweightTeste
    {
        [Fact]
        public void MostrarCorTartarugaInstanciada()
        {
            var flyweight = new Design.Flyweight();
            Design.Tartaruga tartaruga;

            tartaruga = flyweight.GetTartaruga("vermelha");
            Assert.Equal("tartaruga dentro do casco, rodando no chão - VERMELHA", tartaruga.Mostra("vermelha"));

            tartaruga = flyweight.GetTartaruga("azul");
            Assert.Equal("tartaruga dentro do casco, rodando no chão - AZUL", tartaruga.Mostra("azul"));

            tartaruga = flyweight.GetTartaruga("vermelha");
            Assert.Equal("tartaruga dentro do casco, rodando no chão - VERMELHA", tartaruga.Mostra("vermelha"));
        }
    }
}
