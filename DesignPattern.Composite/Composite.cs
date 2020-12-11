namespace DesignPattern.Composite
{
    public class Composite : ComponenteFase
    {
        public Composite(string nome) : base(nome)
        {
        }

        public override void Adicionar(ComponenteFase componente)
        {
            FasesDoJogo.Add(componente);
        }

        public override string Mostrar()
        {
            return nome;
        }

        public override void Remover(ComponenteFase componente)
        {
            FasesDoJogo.Remove(componente);
        }
    }
}
