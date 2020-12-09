namespace DesignPattern.Flyweight
{
    public abstract class Tartaruga
    {
        protected string condicao;
        protected string acao;
        public string Cor { get; set; }

        public abstract string Mostra(string cor);
    }
}
