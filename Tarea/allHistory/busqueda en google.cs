using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace AutomatizacionGoogle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configuración del geckodriver (asegúrate de tener geckodriver en tu PATH o proporciona la ruta completa)
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
            IWebDriver driver = new FirefoxDriver(service);

            // URL de Google
            string url = "https://www.google.com/";

            // Término de búsqueda
            string terminoBusqueda = "automatización con Selenium en C#";

            // Realizar búsqueda en Google
            RealizarBusquedaGoogle(driver, url, terminoBusqueda);

            // Esperar entrada del usuario antes de cerrar el navegador
            Console.WriteLine("Presiona Enter para cerrar el navegador.");
            Console.ReadLine();

            // Cerrar el navegador
            driver.Quit();
        }

        static void RealizarBusquedaGoogle(IWebDriver driver, string url, string terminoBusqueda)
        {
            // Navegar a la página de Google
            driver.Navigate().GoToUrl(url);

            // Encontrar el cuadro de búsqueda
            IWebElement cuadroBusqueda = driver.FindElement(By.Name("q"));

            // Ingresar el término de búsqueda
            cuadroBusqueda.SendKeys(terminoBusqueda);

            // Enviar la búsqueda presionando Enter
            cuadroBusqueda.SendKeys(Keys.Enter);

            // Esperar a que se carguen los resultados de búsqueda (puedes ajustar el tiempo según sea necesario)
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

            // Imprimir el título de la página para verificar que se haya realizado la búsqueda
            Console.WriteLine($"Resultados de la búsqueda en Google para: {terminoBusqueda}");
            Console.WriteLine($"Título de la página: {driver.Title}");
        }
    }
}
