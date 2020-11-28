using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Adapter
{
    public interface IAcao
    {
        string Andar(string jogador);
        string Atirar();
    }
}
