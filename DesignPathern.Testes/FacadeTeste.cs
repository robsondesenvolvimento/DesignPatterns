using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Design = DesignPattern.Facade;

namespace DesignPattern.Testes
{
    public class FacadeTeste
    {
        [Fact]
        public void MascararReponsabilidade()
        {
            Design.Facade facade = new Design.Facade();

            Assert.Equal("Coletar recursos de energia para a base - Produzir armamento para guerreiros", facade.OperacaoA());
            Assert.Equal("Treinar guerreiros", facade.OperacaoB());
        }
    }
}
