# Prueba_Para_SIX_DEGREES_IT

Este es el ejercicio de Prueba Técnica fullstack para el proceso con la empresa SIX DEGREES IT SOLUTIONS construida con **.NET 8 (Web API)** en el backend, **Angular 16** en el frontend, y **SQL Server**
como base de datos.

---

## ⚙️ Requisitos previos

### Backend
- Visual Studio 2022 o superior
- .NET 8 SDK
- SQL Server (Express o Developer)
- SSMS (SQL Server Management Studio)

### Frontend
- Node.js (v18 o superior recomendado)
- Angular CLI (`npm install -g @angular/cli`)

---

## 🚀 Pasos para ejecutar el proyecto (Prueba_Para_SIX_DEGREES_IT)

### 🔹 1. Restaurar base de datos (Esto es muy importante)

1. Abrir SQL Server Management Studio (SSMS)
2. Ejecutar el script `PruebaSD.sql` ubicado en la carpeta `PruebaSD-backend`
3. Así creamos la base de datos llamada `PruebaSD` con la tabla `Usuario` (inicialmente en este proyecto, yo comencé creando la base de Datos)

---

### 🔹 2. Ejecutar el backend (.NET Web API)

1. Abrir la solución `PruebaSD.sln` en Visual Studio
2. Revisar la cadena de conexión en `appsettings.json`:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=TU_SERVIDOR;Database=PruebaSD;Trusted_Connection=True;"  //Necesario que pongas TU_SERVIDOR de Base de Datos para garantizar el funcionamiento
   }
   
   
### 🔹 3. Ejecutar el proyecto PruebasSD.API (.NET Web API)

Swagger estará disponible en:
http://localhost:5279/swagger (puerto puede variar) Aqui debes revisar el puerto pues en mi caso es el 5279 pero este puede cambiar


### 🔹 3. Ejecuta el Frontend (Angular)
ve a la carpeta del front abre una terminal y parate en la ubicación de la carpeta asi: cd prueba-sd-frontend
instala con npm 
npm install
ng serve
Generalmente Angular te abrira en el puerto 4200

