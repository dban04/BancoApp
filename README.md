# BancoApp

BancoApp es una aplicación web para gestionar transacciones bancarias. Este proyecto utiliza ASP.NET Core y Entity Framework Core para la gestión de la base de datos SQL Server.

## Requisitos

- .NET 8.0 SDK
- SQL Server
- Visual Studio 2022

## Configuración del Proyecto

### Clonar el Repositorio

https://github.com/dban04/BancoApp.git

### Configurar la Base de Datos

1. Asegúrate de tener una instancia de SQL Server en ejecución.
2. Crea una base de datos nueva en SQL Server.
3. Actualiza la cadena de conexión en el archivo `appsettings.json` con los detalles de tu base de datos:

{ "ConnectionStrings": { "DefaultConnection": "Server=tu_servidor;Database=tu_base_de_datos;User Id=tu_usuario;Password=tu_contraseña;" } }


### Ejecutar Migraciones

Para crear las tablas necesarias en la base de datos, ejecuta las migraciones de Entity Framework Core:


### Ejecutar la Aplicación

1. Abre el proyecto en Visual Studio 2022.
2. Selecciona `BancoApp` como el proyecto de inicio.
3. Presiona `F5` para ejecutar la aplicación.

La aplicación estará disponible en `https://localhost:5001` (o el puerto configurado).

## Estructura del Proyecto

- `BancoApp/`: Contiene la aplicación web ASP.NET Core.
- `DB/`: Contiene el contexto de la base de datos y las migraciones de Entity Framework Core.

## Endpoints

La aplicación expone varios endpoints para gestionar transacciones. Puedes explorar estos endpoints utilizando Swagger, que estará disponible en `https://localhost:5001/swagger` cuando la aplicación esté en modo desarrollo.

## Servicios

- `ITransactionService`: Interfaz para el servicio de transacciones.
- `TransactionService`: Implementación del servicio de transacciones.

## Migraciones

Las migraciones de la base de datos se encuentran en el directorio `DB/Migrations`. Para agregar nuevas migraciones, utiliza el siguiente comando:
