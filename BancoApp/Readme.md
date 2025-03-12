# BancoApp

BancoApp es una aplicaci�n web para gestionar transacciones bancarias. Este proyecto utiliza ASP.NET Core y Entity Framework Core para la gesti�n de la base de datos SQL Server.

## Requisitos

- .NET 8.0 SDK
- SQL Server
- Visual Studio 2022

## Configuraci�n del Proyecto

### Clonar el Repositorio

https://github.com/dban04/BancoApp.git

### Configurar la Base de Datos

1. Aseg�rate de tener una instancia de SQL Server en ejecuci�n.
2. Crea una base de datos nueva en SQL Server.
3. Actualiza la cadena de conexi�n en el archivo `appsettings.json` con los detalles de tu base de datos:

{ "ConnectionStrings": { "DefaultConnection": "Server=tu_servidor;Database=tu_base_de_datos;User Id=tu_usuario;Password=tu_contrase�a;" } }


### Ejecutar Migraciones

Para crear las tablas necesarias en la base de datos, ejecuta las migraciones de Entity Framework Core:


### Ejecutar la Aplicaci�n

1. Abre el proyecto en Visual Studio 2022.
2. Selecciona `BancoApp` como el proyecto de inicio.
3. Presiona `F5` para ejecutar la aplicaci�n.

La aplicaci�n estar� disponible en `https://localhost:5001` (o el puerto configurado).

## Estructura del Proyecto

- `BancoApp/`: Contiene la aplicaci�n web ASP.NET Core.
- `DB/`: Contiene el contexto de la base de datos y las migraciones de Entity Framework Core.

## Endpoints

La aplicaci�n expone varios endpoints para gestionar transacciones. Puedes explorar estos endpoints utilizando Swagger, que estar� disponible en `https://localhost:5001/swagger` cuando la aplicaci�n est� en modo desarrollo.

## Servicios

- `ITransactionService`: Interfaz para el servicio de transacciones.
- `TransactionService`: Implementaci�n del servicio de transacciones.

## Migraciones

Las migraciones de la base de datos se encuentran en el directorio `DB/Migrations`. Para agregar nuevas migraciones, utiliza el siguiente comando: