using DevelopmentChallenge.Data.Classes.Enums;
using DevelopmentChallenge.Data.Classes.Formas.Interfaces;
using System;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class TrianguloEquilatero : IFormaGeometrica
    {
        public decimal Lado { get; }

        public TrianguloEquilatero(decimal lado)
        {
            Lado = lado;
        }

        public decimal CalcularArea() => ((decimal)Math.Sqrt(3) / 4) * Lado * Lado;
        public decimal CalcularPerimetro() => 3 * Lado;
        public TipoFormaEnum Tipo => TipoFormaEnum.TrianguloEquilatero;
    }
}
