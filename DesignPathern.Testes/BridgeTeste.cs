using Xunit;
using Design = DesignPattern.Bridge;

namespace DesignPattern.Testes
{
    public class BridgeTeste
    {
        [Fact]
        public void CriarFormaNaCorSelecionada()
        {
            var bridge = new Design.Bridge();

            bridge.FormaSolicitada = new Design.Forma1();
            bridge.FormaSolicitada.Cor = new Design.Laranja();

            Assert.Equal("T - Laranja", bridge.ExibeQualFormaEstaDescendoNaTela());
        }
    }
}
