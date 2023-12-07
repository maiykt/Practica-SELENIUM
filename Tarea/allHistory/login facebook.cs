using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace AutomatizacionFacebook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configuración del geckodriver (asegúrate de tener geckodriver en tu PATH o proporciona la ruta completa)
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
            IWebDriver driver = new FirefoxDriver(service);

            // URL de inicio de sesión de Facebook
            string url = "https://www.facebook.com/login/";

            // Credenciales del usuario
            string usuario = "tu_correo_electronico";
            string contraseña = "tu_contraseña";

            // Iniciar sesión en Facebook
            IniciarSesionFacebook(driver, url, usuario, contraseña);

            // Esperar entrada del usuario antes de cerrar el navegador
            Console.WriteLine("Presiona Enter para cerrar el navegador.");
            Console.ReadLine();

            // Cerrar el navegador
            driver.Quit();
        }

        static void IniciarSesionFacebook(IWebDriver driver, string url, string usuario, string contraseña)
        {
            // Navegar a la página de inicio de sesión de Facebook
            driver.Navigate().GoToUrl(url);

            // Ingresar credenciales de inicio de sesión
            IWebElement inputUsuario = driver.FindElement(By.Id("email"));
            inputUsuario.SendKeys(usuario);

            IWebElement inputContraseña = driver.FindElement(By.Id("pass"));
            inputContraseña.SendKeys(contraseña);

            // Hacer clic en el botón de inicio de sesión
            IWebElement botonInicioSesion = driver.FindElement(By.Name("login"));
            botonInicioSesion.Click();

            // Esperar a que se cargue la página de inicio de Facebook (puedes ajustar el tiempo según sea necesario)
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

            // Verificar el inicio de sesión (puedes agregar verificaciones adicionales según sea necesario)
            if (driver.Url.Contains("https://www.facebook.com/"))
            {
                Console.WriteLine("Inicio de sesión exitoso en Facebook.");
            }
            else
            {
                Console.WriteLine("Error al iniciar sesión en Facebook.");
            }
        }
    }
}
