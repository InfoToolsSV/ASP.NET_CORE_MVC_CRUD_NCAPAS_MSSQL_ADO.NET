# Título del Proyecto: CRUD en N Capas con ASP.NET Core MVC, ADO.NET y MSSQL

## Descripción:
Este proyecto es un ejemplo de una aplicación CRUD (Crear, Leer, Actualizar, Eliminar) desarrollada en ASP.NET Core MVC utilizando una arquitectura en N Capas. La aplicación utiliza ADO.NET para interactuar con una base de datos MSSQL para realizar operaciones CRUD en una tabla de productos.

## Tecnologías Utilizadas:
- ASP.NET Core MVC
- ADO.NET
- MSSQL Server
- .NET 8

## Capturas de Pantalla:
[Ver Video Tutorial](https://youtu.be/BbBzcVVTQs8)

## Patrón de Arquitectura:
La aplicación sigue una arquitectura en N Capas, donde se separa la lógica de presentación, lógica de negocio y acceso a datos en diferentes capas para una mejor modularidad y mantenibilidad del código.

## Archivos del Proyecto:
- PresentationLayer/Controllers/ : Controladores de ASP.NET Core MVC
- DataAccess/Producto.cs : Modelo de datos de la aplicación
- PresentationLayer/Views/ : Vistas de la aplicación
- DataAccess/ProductoData.cs : Clase de acceso a datos y configuración de la base de datos
- BusinessLayer/ProductoService.cs : Servicios de aplicación y lógica de negocio

## Instrucciones de Ejecución:
1. Asegúrate de tener instalado .NET 8 y MSSQL Server en tu sistema.
2. Clona este repositorio en tu máquina local.
3. Abre el proyecto en tu entorno de desarrollo preferido.
4. Crea la base de datos y la tabla de productos en MSSQL Server utilizando el script proporcionado en el directorio raíz.
5. Actualiza la cadena de conexión en el archivo `appsettings.json` con los detalles de tu servidor de base de datos.
6. Ejecuta el proyecto y navega a la URL para probar la aplicación.

## Licencia:
Este proyecto se distribuye bajo la [Licencia MIT](https://opensource.org/licenses/MIT).

## Agradecimientos:
Agradecimientos a la comunidad de desarrolladores de ASP.NET Core y .NET por proporcionar una plataforma sólida y herramientas para el desarrollo de aplicaciones web modernas.
