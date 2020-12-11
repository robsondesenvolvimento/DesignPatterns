using System;

namespace DesignPattern.Composite
{
    public class FaseJogo : ComponenteFase
    {
        public FaseJogo(string nome) : base(nome)
        {
        }

        public override void Adicionar(ComponenteFase componente)
        {
            throw new NotImplementedException("Não é possivel adicionar a fase no jogo por aqui.");
        }

        public override string Mostrar()
        {
            return nome;
        }

        public override void Remover(ComponenteFase componente)
        {
            throw new NotImplementedException("Não é possível remover as fase do jogo por aqui.");
        }
    }
}
