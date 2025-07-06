using DevelopmentChallenge.Data.Classes.Enums;

namespace DevelopmentChallenge.Data.Classes.Idiomas.Interfaces
{
    public interface IIdioma
    {
        string TituloReporte { get; }
        string TituloListaVacia { get; }
        string Formas { get; }
        string Area { get; }
        string Perimetro { get; }

        string TraducirForma(TipoFormaEnum tipo, int cantidad);
        string FormatearNumero(decimal numero);
    }
}
