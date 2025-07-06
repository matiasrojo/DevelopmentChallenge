using DevelopmentChallenge.Data.Classes.Enums;
using DevelopmentChallenge.Data.Classes.Formas.Interfaces;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class Cuadrado : IFormaGeometrica
    {
        public decimal Lado { get; }

        public Cuadrado(decimal lado)
        {
            Lado = lado;
        }

        public decimal CalcularArea() => Lado * Lado;
        public decimal CalcularPerimetro() => 4 * Lado;
        public TipoFormaEnum Tipo => TipoFormaEnum.Cuadrado;
    }
}
