using DevelopmentChallenge.Data.Classes.Formas;
using DevelopmentChallenge.Data.Classes.Formas.Interfaces;
using DevelopmentChallenge.Data.Classes.Idiomas;
using DevelopmentChallenge.Data.Classes.Reportes;
using NUnit.Framework;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class HtmlFormatoReporteTests
    {
        private HtmlFormatoReporte reporte;
        private Castellano castellano;
        private Ingles ingles;
        private Italiano italiano;

        [SetUp]
        public void Setup()
        {
            reporte = new HtmlFormatoReporte();
            castellano = new Castellano();
            ingles = new Ingles();
            italiano = new Italiano();
        }

        [Test]
        public void Generar_ResumenListaVacia_Castellano()
        {
            var resultado = reporte.Generar(new List<IFormaGeometrica>(), castellano);
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>", resultado);
        }

        [Test]
        public void Generar_ResumenListaVacia_Ingles()
        {
            var resultado = reporte.Generar(new List<IFormaGeometrica>(), ingles);
            Assert.AreEqual("<h1>Empty list of shapes!</h1>", resultado);
        }

        [Test]
        public void Generar_ResumenListaConUnCuadrado_Castellano()
        {
            var formas = new List<IFormaGeometrica> { new Cuadrado(5) };
            var resultado = reporte.Generar(formas, castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25",
                resultado);
        }

        [Test]
        public void Generar_ResumenListaConMasCuadrados_Ingles()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };
            var resultado = reporte.Generar(formas, ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35",
                resultado);
        }

        [Test]
        public void Generar_ResumenListaConMasTipos_Ingles()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };
            var resultado = reporte.Generar(formas, ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13.01 | Perimeter 18.06 <br/>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>TOTAL:<br/>7 shapes Perimeter 97.66 Area 91.65",
                resultado);
        }

        [Test]
        public void Generar_ResumenListaConMasTipos_Castellano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };
            var resultado = reporte.Generar(formas, castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resultado);
        }

        [Test]
        public void Generar_ResumenListaConMasTipos_Italiano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };
            var resultado = reporte.Generar(formas, italiano);

            Assert.AreEqual(
                "<h1>Rapporto delle forme</h1>2 Quadrati | Area 29 | Perimetro 28 <br/>2 Cerchi | Area 13,01 | Perimetro 18,06 <br/>3 Triangoli | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 forme Perimetro 97,66 Area 91,65",
                resultado);
        }

        [Test]
        public void Generar_ResumenSoloRectanguloYTrapecio_Castellano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Rectangulo(4, 2),
                new Rectangulo(6, 3),
                new Trapecio(5, 3, 4),
                new Trapecio(8, 4, 5)
            };

            var resultado = reporte.Generar(formas, castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Rectángulos | Area 26 | Perimetro 30 <br/>2 Trapecios | Area 46 | Perimetro 39,02 <br/>TOTAL:<br/>4 formas Perimetro 69,02 Area 72",
                resultado);
        }

        [Test]
        public void Generar_ResumenSoloRectanguloYTrapecio_Ingles()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Rectangulo(4, 2),
                new Rectangulo(6, 3),
                new Trapecio(5, 3, 4),
                new Trapecio(8, 4, 5)
            };

            var resultado = reporte.Generar(formas, ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Rectangles | Area 26 | Perimeter 30 <br/>2 Trapezoids | Area 46 | Perimeter 39.02 <br/>TOTAL:<br/>4 shapes Perimeter 69.02 Area 72",
                resultado);
        }

        [Test]
        public void Generar_ResumenSoloRectanguloYTrapecio_Italiano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Rectangulo(4, 2),
                new Rectangulo(6, 3),
                new Trapecio(5, 3, 4),
                new Trapecio(8, 4, 5)
            };

            var resultado = reporte.Generar(formas, italiano);

            Assert.AreEqual(
                "<h1>Rapporto delle forme</h1>2 Rettangoli | Area 26 | Perimetro 30 <br/>2 Trapezi | Area 46 | Perimetro 39,02 <br/>TOTAL:<br/>4 forme Perimetro 69,02 Area 72",
                resultado);
        }
    }
}
