using DevelopmentChallenge.Data.Classes.Formas.Interfaces;
using DevelopmentChallenge.Data.Classes.Idiomas.Interfaces;
using DevelopmentChallenge.Data.Classes.Reportes.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes.Reportes
{
    public class HtmlFormatoReporte : IFormatoReporte
    {
        public string Generar(IEnumerable<IFormaGeometrica> formas, IIdioma idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
                return idioma.TituloListaVacia;

            sb.Append(idioma.TituloReporte);

            var grupos = formas.GroupBy(f => f.Tipo);

            int totalFormas = 0;
            decimal totalArea = 0;
            decimal totalPerimetro = 0;

            foreach (var grupo in grupos)
            {
                int cantidad = grupo.Count();
                decimal area = grupo.Sum(f => f.CalcularArea());
                decimal perimetro = grupo.Sum(f => f.CalcularPerimetro());
                string nombre = idioma.TraducirForma(grupo.Key, cantidad);

                sb.Append($"{cantidad} {nombre} | {idioma.Area} {idioma.FormatearNumero(area)} | {idioma.Perimetro} {idioma.FormatearNumero(perimetro)} <br/>");

                totalFormas += cantidad;
                totalArea += area;
                totalPerimetro += perimetro;
            }

            sb.Append($"TOTAL:<br/>{totalFormas} {idioma.Formas} {idioma.Perimetro} {idioma.FormatearNumero(totalPerimetro)} {idioma.Area} {idioma.FormatearNumero(totalArea)}");

            return sb.ToString();
        }
    }
}
