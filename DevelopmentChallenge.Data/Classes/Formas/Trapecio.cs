using DevelopmentChallenge.Data.Classes.Enums;
using DevelopmentChallenge.Data.Classes.Formas.Interfaces;
using System;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class Trapecio : IFormaGeometrica
    {
        public decimal BaseMayor { get; }
        public decimal BaseMenor { get; }
        public decimal Altura { get; }

        public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura)
        {
            BaseMayor = baseMayor;
            BaseMenor = baseMenor;
            Altura = altura;
        }

        public decimal CalcularArea() => ((BaseMayor + BaseMenor) * Altura) / 2;

        public decimal CalcularPerimetro()
        {
            decimal diferencia = Math.Abs(BaseMayor - BaseMenor) / 2;
            decimal lado = (decimal)Math.Sqrt((double)(diferencia * diferencia + Altura * Altura));
            return BaseMayor + BaseMenor + 2 * lado;
        }

        public TipoFormaEnum Tipo => TipoFormaEnum.Trapecio;
    }
}
