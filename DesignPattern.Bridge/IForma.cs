namespace DesignPattern.Bridge
{
    public interface IForma
    {
        string Descer();
        ICor Cor { get; set; }
    }
}
