namespace DesignPattern.Flyweight
{
    public class Vermelha : Tartaruga
    {
        public Vermelha()
        {
            this.condicao = "tartaruga dentro do casco, ";
            this.acao = "rodando no chão - ";
        }

        public override string Mostra(string cor)
        {
            this.Cor = cor;
            return $"{condicao}{acao}{Cor.ToUpper()}";
        }
    }
}
