using DevelopmentChallenge.Data.Classes.Enums;
using DevelopmentChallenge.Data.Classes.Idiomas.Interfaces;
using System.Globalization;

namespace DevelopmentChallenge.Data.Classes.Idiomas
{
    public class Ingles : IIdioma
    {
        public string TituloReporte => "<h1>Shapes report</h1>";
        public string TituloListaVacia => "<h1>Empty list of shapes!</h1>";
        public string Formas => "shapes";
        public string Area => "Area";
        public string Perimetro => "Perimeter";

        public string TraducirForma(TipoFormaEnum tipo, int cantidad)
        {
            switch (tipo)
            {
                case TipoFormaEnum.Cuadrado:
                    return cantidad == 1 ? "Square" : "Squares";
                case TipoFormaEnum.Circulo:
                    return cantidad == 1 ? "Circle" : "Circles";
                case TipoFormaEnum.TrianguloEquilatero:
                    return cantidad == 1 ? "Triangle" : "Triangles";
                case TipoFormaEnum.Trapecio:
                    return cantidad == 1 ? "Trapezoid" : "Trapezoids";
                case TipoFormaEnum.Rectangulo:
                    return cantidad == 1 ? "Rectangle" : "Rectangles";
                default:
                    return "Unknown shape";
            }
        }

        public string FormatearNumero(decimal numero)
        {
            return numero.ToString("#.##", new CultureInfo("en-US"));
        }
    }
}
