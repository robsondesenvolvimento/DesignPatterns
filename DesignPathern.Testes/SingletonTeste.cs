using Xunit;
using Singletons = DesignPattern.Singleton;

namespace DesignPattern.Testes
{
    public class SingletonTeste
    {
        [Fact]
        public void RecuperandoInstanciaSingleton()
        {
            var singleton1 = Singletons.Singleton.GetInstancia;
            Assert.Equal("Bola em jogo", Singletons.Singleton.Status);

            var singleton2 = Singletons.Singleton.GetInstancia;
            Assert.Equal("Bola rolando", Singletons.Singleton.Status);
        }
    }
}
