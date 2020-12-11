using System.Collections.Generic;

namespace DesignPattern.Composite
{
    public abstract class ComponenteFase
    {
        public List<ComponenteFase> FasesDoJogo { get; private set; }

        protected string nome;

        public ComponenteFase(string nome)
        {
            this.nome = nome;
            FasesDoJogo = new();
        }

        public abstract void Adicionar(ComponenteFase componente);
        public abstract void Remover(ComponenteFase componente);
        public abstract string Mostrar();
    }
}
