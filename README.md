**README.md**

# Selenium Automation Practice

Este repositorio contiene ejemplos básicos de automatización de pruebas utilizando Selenium WebDriver y NUnit en C#. Se han implementado tres historias de usuario simples para la búsqueda en Google, la apertura de YouTube y el inicio de sesión en Facebook.

## Historias de Usuario

### Historia de Usuario 1: Búsqueda en Google

**Caso de prueba:**
1. Abre Google.
2. Busca "quality-stream Introducción a la Automatización de Pruebas de Software".
3. Verifica que el título de la página sea "quality-stream Introducción a la Automatización de Pruebas de Software - Google Search".

### Historia de Usuario 2: Abrir YouTube

**Caso de prueba:**
1. Abre YouTube.
2. Verifica que la página de YouTube se ha cargado correctamente.

### Historia de Usuario 3: Iniciar Sesión en Facebook

**Caso de prueba:**
1. Abre Facebook (https://www.facebook.com/login/).
2. Ingresa un nombre de usuario y contraseña (se proporcionan datos de ejemplo).
3. Verifica que la sesión se inicia correctamente y la página de inicio se carga.

## Estructura del Proyecto

- **GoogleSearchTest.cs:** Contiene el caso de prueba para la búsqueda en Google.
- **YouTubeTest.cs:** Contiene el caso de prueba para abrir YouTube.
- **FacebookLoginTest.cs:** Contiene el caso de prueba para iniciar sesión en Facebook.

## Configuración del Entorno

- Asegúrate de tener el [controlador de Selenium para Firefox (geckodriver)](https://github.com/mozilla/geckodriver/releases) en tu PATH.
- Se requiere [NUnit](https://nunit.org/) para ejecutar las pruebas.

## Instrucciones para Ejecutar

1. Clona este repositorio a tu máquina local.
2. Asegúrate de tener configurado el entorno según las especificaciones anteriores.
3. Ejecuta las pruebas desde tu entorno de desarrollo o mediante la línea de comandos.

**Ejemplo de Ejecución en la Línea de Comandos:**
```bash
nunit3-console.exe NombreDelProyecto.dll
```

## Contribuciones

¡Contribuciones son bienvenidas! Si encuentras algún problema o tienes mejoras que sugerir, no dudes en abrir un problema o enviar una solicitud de extracción.

---

Este README proporciona una visión general del proyecto, las historias de usuario implementadas, la estructura del proyecto y cómo ejecutar las pruebas. Puedes personalizarlo más según tus necesidades específicas y la evolución del proyecto.
