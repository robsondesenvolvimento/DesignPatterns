namespace DesignPattern.Bridge
{
    public class Forma1 : IForma
    {
        public ICor Cor { get; set; }

        public string Descer()
        {
            return $"T - {Cor.Cor()}";
        }
    }
}
