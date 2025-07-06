using DevelopmentChallenge.Data.Classes.Enums;
using DevelopmentChallenge.Data.Classes.Idiomas.Interfaces;
using System.Globalization;

namespace DevelopmentChallenge.Data.Classes.Idiomas
{
    public class Castellano : IIdioma
    {
        public string TituloReporte => "<h1>Reporte de Formas</h1>";
        public string TituloListaVacia => "<h1>Lista vacía de formas!</h1>";
        public string Formas => "formas";
        public string Area => "Area";
        public string Perimetro => "Perimetro";

        public string TraducirForma(TipoFormaEnum tipo, int cantidad)
        {
            switch (tipo)
            {
                case TipoFormaEnum.Cuadrado:
                    return cantidad == 1 ? "Cuadrado" : "Cuadrados";
                case TipoFormaEnum.Circulo:
                    return cantidad == 1 ? "Círculo" : "Círculos";
                case TipoFormaEnum.TrianguloEquilatero:
                    return cantidad == 1 ? "Triángulo" : "Triángulos";
                case TipoFormaEnum.Trapecio:
                    return cantidad == 1 ? "Trapecio" : "Trapecios";
                case TipoFormaEnum.Rectangulo:
                    return cantidad == 1 ? "Rectángulo" : "Rectángulos";
                default:
                    return "Forma desconocida";
            }
        }

        public string FormatearNumero(decimal numero)
        {
            return numero.ToString("#.##", new CultureInfo("es-AR"));
        }
    }
}
