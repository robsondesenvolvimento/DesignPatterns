using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Adapter
{
    public class AdapterAviao : IAcao
    {
        private readonly Aviao _aviao;

        public AdapterAviao(Aviao aviao)
        {
            _aviao = aviao;
        }

        public string Andar(string jogador)
        {
            return _aviao.Voar(jogador);
        }

        public string Atirar()
        {
            return _aviao.SoltouMissil();
        }
    }
}
