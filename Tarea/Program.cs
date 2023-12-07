using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace TuNamespace
{
    [TestFixture]
    public class PruebasDeYouTube
    {
        private IWebDriver driver;

        [SetUp]
        public void Inicializar()
        {
            // Configurar el navegador y abrir la página de YouTube
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
            driver = new FirefoxDriver(service);
            driver.Navigate().GoToUrl("https://www.youtube.com/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void BusquedaEnYouTube()
        {
            // Buscar una cadena en la barra de búsqueda
            string cadenaABuscar = "prueba automatizada con Selenium";
            IWebElement searchBox = driver.FindElement(By.Name("search_query"));
            searchBox.Clear();
            searchBox.SendKeys(cadenaABuscar);
            searchBox.SendKeys(Keys.Enter);

            // Esperar a que los resultados de la búsqueda estén presentes (puedes ajustar el tiempo según sea necesario)
            System.Threading.Thread.Sleep(5000);

            // Verificar que la página de resultados de búsqueda contiene la cadena buscada
            string resultadoPagina = driver.PageSource;
            Assert.IsTrue(resultadoPagina.Contains(cadenaABuscar), $"La cadena '{cadenaABuscar}' no se encontró en los resultados de búsqueda.");
        }

        [TearDown]
        public void Finalizar()
        {
            // Cerrar el navegador al finalizar la prueba
            driver.Quit();
        }
    }
}
