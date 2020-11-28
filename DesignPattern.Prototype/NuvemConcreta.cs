namespace DesignPattern.Prototype
{
    public class NuvemConcreta : NuvemMolde
    {
        public string CorPreenchimento { get; private set; }
        public string CorContorno { get; private set; }

        public NuvemConcreta(string preenchimento, string cortorno)
        {
            this.CorPreenchimento = preenchimento;
            this.CorContorno = cortorno;
        }

        public override NuvemMolde Clone()
        {
            return this.MemberwiseClone() as NuvemMolde;
        }
    }
}
