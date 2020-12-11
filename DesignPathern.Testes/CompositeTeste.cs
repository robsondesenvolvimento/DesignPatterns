using System.Linq;
using Xunit;
using Design = DesignPattern.Composite;

namespace DesignPattern.Testes
{
    public class CompositeTeste
    {
        [Fact]
        public void CompositeMostrar()
        {
            var mapa = new Design.Composite("MAPA DAS CAVERNAS");

            var caverna1 = new Design.Composite("Caverna 1");
            caverna1.Adicionar(new Design.FaseJogo("Sub Fase 1"));
            caverna1.Adicionar(new Design.FaseJogo("Sub Fase 2"));
            caverna1.Adicionar(new Design.FaseJogo("Sub Fase 3"));

            var caverna2 = new Design.Composite("Caverna 2");
            caverna2.Adicionar(new Design.FaseJogo("Sub Fase 4"));
            caverna2.Adicionar(new Design.FaseJogo("Sub Fase 5"));

            var portaSecreta = new Design.Composite("Porta Secreta");
            portaSecreta.Adicionar(new Design.FaseJogo("Sub Fase Secreta X"));

            mapa.Adicionar(caverna1);
            mapa.Adicionar(caverna2);
            mapa.Adicionar(portaSecreta);

            var listaDeFases = mapa.FasesDoJogo;

            Assert.Equal("Caverna 1", listaDeFases.ElementAt(0).Mostrar());
            Assert.Equal("Sub Fase 1", listaDeFases.ElementAt(0).FasesDoJogo.ElementAt(0).Mostrar());
            Assert.Equal("Caverna 2", listaDeFases.ElementAt(1).Mostrar());

        }
    }
}
