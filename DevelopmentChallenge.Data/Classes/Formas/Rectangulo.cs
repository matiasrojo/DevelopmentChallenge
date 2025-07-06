using DevelopmentChallenge.Data.Classes.Enums;
using DevelopmentChallenge.Data.Classes.Formas.Interfaces;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class Rectangulo : IFormaGeometrica
    {
        public decimal Base { get; }
        public decimal Altura { get; }

        public Rectangulo(decimal @base, decimal altura)
        {
            Base = @base;
            Altura = altura;
        }

        public decimal CalcularArea() => Base * Altura;

        public decimal CalcularPerimetro() => 2 * (Base + Altura);

        public TipoFormaEnum Tipo => TipoFormaEnum.Rectangulo;
    }
}
