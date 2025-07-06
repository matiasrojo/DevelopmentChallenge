using DevelopmentChallenge.Data.Classes.Enums;
using DevelopmentChallenge.Data.Classes.Idiomas.Interfaces;
using System.Globalization;

namespace DevelopmentChallenge.Data.Classes.Idiomas
{
    public class Italiano : IIdioma
    {
        public string TituloReporte => "<h1>Rapporto delle forme</h1>";
        public string TituloListaVacia => "<h1>Elenco vuoto di forme!</h1>";
        public string Formas => "forme";
        public string Area => "Area";
        public string Perimetro => "Perimetro";

        public string TraducirForma(TipoFormaEnum tipo, int cantidad)
        {
            switch (tipo)
            {
                case TipoFormaEnum.Cuadrado:
                    return cantidad == 1 ? "Quadrato" : "Quadrati";
                case TipoFormaEnum.Circulo:
                    return cantidad == 1 ? "Cerchio" : "Cerchi";
                case TipoFormaEnum.TrianguloEquilatero:
                    return cantidad == 1 ? "Triangolo" : "Triangoli";
                case TipoFormaEnum.Trapecio:
                    return cantidad == 1 ? "Trapezio" : "Trapezi";
                case TipoFormaEnum.Rectangulo:
                    return cantidad == 1 ? "Rettangolo" : "Rettangoli";
                default:
                    return "Forma sconosciuta";
            }
        }

        public string FormatearNumero(decimal numero)
        {
            return numero.ToString("#.##", new CultureInfo("it-IT"));
        }
    }
}
