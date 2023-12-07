using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TuNamespace
{
    class busqueda 
    {
        static void Main(string[] args)
        {
            // Configura el path al geckodriver.exe (asegúrate de que esté en tu PATH o especifica la ubicación completa)
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
            IWebDriver driver = new FirefoxDriver(service);

            // Abre la página de YouTube
            driver.Navigate().GoToUrl("https://www.youtube.com/");
            driver.Manage().Window.Maximize();

            // Busca un nombre en la barra de búsqueda
            IWebElement searchBox = driver.FindElement(By.Name("search_query"));
            searchBox.Clear();
            searchBox.SendKeys("Nombre a buscar");

            // Presiona Enter para realizar la búsqueda
            searchBox.SendKeys(Keys.Enter);

            // Espera un momento para que se carguen los resultados (puedes ajustar el tiempo según sea necesario)
            System.Threading.Thread.Sleep(5000);

            // Espera la entrada del usuario antes de cerrar el navegador
            Console.WriteLine("Presiona Enter para cerrar el navegador...");
            Console.ReadLine();

            // Cierra el navegador al finalizar
            driver.Quit();
        }
    }
}