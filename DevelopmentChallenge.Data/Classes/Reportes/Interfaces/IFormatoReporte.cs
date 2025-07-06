using DevelopmentChallenge.Data.Classes.Formas.Interfaces;
using DevelopmentChallenge.Data.Classes.Idiomas.Interfaces;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes.Reportes.Interfaces
{
    public interface IFormatoReporte
    {
        string Generar(IEnumerable<IFormaGeometrica> formas, IIdioma idioma);
    }
}
