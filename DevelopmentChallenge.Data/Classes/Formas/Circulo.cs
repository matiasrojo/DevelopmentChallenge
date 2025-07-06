using DevelopmentChallenge.Data.Classes.Enums;
using DevelopmentChallenge.Data.Classes.Formas.Interfaces;
using System;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class Circulo : IFormaGeometrica
    {
        public decimal Diametro { get; }

        public Circulo(decimal diametro)
        {
            Diametro = diametro;
        }

        public decimal CalcularArea() => (decimal)Math.PI * (Diametro / 2) * (Diametro / 2);
        public decimal CalcularPerimetro() => (decimal)Math.PI * Diametro;
        public TipoFormaEnum Tipo => TipoFormaEnum.Circulo;
    }
}
