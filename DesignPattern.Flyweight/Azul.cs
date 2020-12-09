namespace DesignPattern.Flyweight
{
    public class Azul : Tartaruga
    {
        public Azul()
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
