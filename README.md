
# Backend - Event Logger Application

## Descripción

Este es el backend de la aplicación **Event Logger**, encargado de gestionar los registros de eventos y exponer API RESTful para su consumo. La aplicación está construida con **C#** y utiliza **MongoDB** como base de datos. El backend maneja las solicitudes y realiza la lógica de negocio, como la creación, búsqueda y filtrado de eventos.

## Requisitos Previos

- **.NET Core SDK 6.0 o superior**: [Descargar aquí](https://dotnet.microsoft.com/download/dotnet/6.0)
- **MongoDB**: Instalar localmente o configurar una conexión a una instancia en la nube (por ejemplo, MongoDB Atlas).
- **Docker** (opcional): Para ejecutar el servicio en un contenedor.
  
## Instalación

1. Clona el repositorio:
   ```bash
   git clone https://github.com/marianaph6/EventLogger.Backend
   ```

2. Restaura las dependencias:
   ```bash
   dotnet restore
   ```

3. Ejecuta el proyecto:
   ```bash
   dotnet run --project src/EventLoggerBackend
   ```

## Diseño e Implementación

- **Arquitectura**: La aplicación sigue una arquitectura de capas con separación de responsabilidades (controladores, servicios, repositorios).
- **Base de Datos**: MongoDB se utiliza para almacenar y gestionar los logs de eventos. Cada registro de evento contiene campos como `EventType` y `DateEvent`.
- **Manejo de Errores**: El backend utiliza middleware para manejar excepciones globales y registrar errores.

## Consideraciones

- El campo `Id` de la entidad `EventLog` puede ser de tipo `ObjectId` en MongoDB. Asegúrate de que los modelos y las consultas sean consistentes en este sentido.
- El filtrado de eventos permite consultar logs por tipo y fechas específicas.
