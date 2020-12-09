using System.Collections.Generic;

namespace DesignPattern.Flyweight
{
    public class Flyweight
    {
        private Dictionary<string, Tartaruga> listaDeTartarugas = new();

        public Tartaruga GetTartaruga(string cor)
        {
            Tartaruga tartaruga = null;

            if (listaDeTartarugas.ContainsKey(cor))
                return listaDeTartarugas[cor];
            else
            {
                switch (cor.ToUpper())
                {
                    case "AZUL": tartaruga = new Azul(); break;
                    case "VERDE": tartaruga = new Verde(); break;
                    case "Laranja": tartaruga = new Laranja(); break;
                    case "VERMELHA": tartaruga = new Vermelha(); break;
                }

                listaDeTartarugas.Add(cor, tartaruga);
            }

            return tartaruga;
        }
    }
}
