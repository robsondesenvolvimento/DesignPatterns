namespace DesignPattern.AbstractFactory
{
    public class RevestimentoBaseProtoss : IRevestimento
    {
        public string Composicao()
        {
            return "Base revestida pela cor amarela";
        }
    }
}
