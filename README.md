# Ejercicio 6 (API en .NET con DDD, Arquitectura Hexagonal, Swagger, MySQL)

En este proyecto se ha creado una API en .NET con DDD, Arquitectura Hexagonal, Swagger en la cual los datos son leidos desde una base de datos MySQL corriendo en un contenedor.

## Ejecución del contenedor MySQL con la base de datos

La ejecución del contenedor se hace desde un archivo docker-compose.yml. Para ello debemos abrir una terminal y ubicarnos en la carpeta Api/Data/ de la solución y desde ahí ejecutar el siguiente comando:

```
docker-compose up
```

## Ejecución de la aplicación

Para probar la aplicación se deberán ejecutar los siguientes comandos desde la terminal, hubicados dentro de la carpeta Api de la solución.

```
dotnet build
dotnet run
```

Luego, acceder desde el navegador a la página de Swagger que permite probar la API.
```
https://localhost:7119/swagger/index.html
```
