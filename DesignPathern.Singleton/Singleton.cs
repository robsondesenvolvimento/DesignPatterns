namespace DesignPattern.Singleton
{
    public sealed class Singleton
    {
        private static Singleton _instancia = null;

        public static string Status { get; private set; } = "Bola parada";

        public static Singleton GetInstancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Singleton();
                    Status = "Bola em jogo";
                }
                else
                    Status = "Bola rolando";


                return _instancia;
            }
        }
    }
}
