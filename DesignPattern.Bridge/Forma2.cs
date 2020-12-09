namespace DesignPattern.Bridge
{
    public class Forma2 : IForma
    {
        public ICor Cor { get; set; }

        public string Descer()
        {
            return $"U - {Cor.Cor()}";
        }
    }
}
