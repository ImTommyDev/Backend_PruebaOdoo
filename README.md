# Backend_PruebaOdoo

Este proyecto es la **primera prueba** de integración entre una aplicación de backend en **.NET** y una base de datos de **Odoo** utilizando **PostgreSQL**.

El objetivo de este proyecto es configurar un entorno que permita conectarse a la base de datos de Odoo desde una aplicación .NET para hacer consultas y manipular los datos de manera sencilla. La aplicación se basa en **Windows Forms**, pero su enfoque está principalmente en el **backend** y en el manejo de la base de datos a través de consultas SQL.

## 🚀 **Instalación y configuración**

El proceso de instalación ha incluido varios pasos clave, los cuales se resumen a continuación:

### 1. **Instalación de Docker**
   - Se ha configurado un entorno utilizando **Docker** para ejecutar los contenedores de **Odoo** y **PostgreSQL**.
   - Se creó una red interna entre los contenedores para asegurar la comunicación entre Odoo (aplicación ERP) y la base de datos PostgreSQL.

### 2. **Instalación de Odoo**
   - **Odoo** fue instalado en un contenedor Docker. Se utilizó la imagen oficial de Odoo y se configuró correctamente para ser accesible a través del puerto `8069` en el navegador.
   - Durante la instalación de Odoo, se configuraron datos iniciales (demo data) para tener tablas y datos listos para hacer pruebas de conexión.

### 3. **Configuración de PostgreSQL**
   - Se instaló **PostgreSQL** en otro contenedor Docker para almacenar los datos de Odoo.
   - Se creó una base de datos `odoo` y se configuró un usuario con acceso para la conexión desde la aplicación .NET.
   - Se conectó la base de datos con Odoo y se verificó que las tablas de Odoo (por ejemplo, `res_users`, `sale_order`, etc.) estuvieran disponibles.

### 4. **Conexión de la aplicación .NET con PostgreSQL**
   - En Visual Studio, se configuró un proyecto de **Windows Forms** utilizando **.NET 7**.
   - Se instaló el paquete **Npgsql** desde NuGet para permitir la conexión de la aplicación .NET con la base de datos PostgreSQL.
   - Se estableció la conexión entre el backend de la aplicación .NET y la base de datos de Odoo, y se realizaron consultas básicas para extraer datos.

## 📋 **Lo que se ha logrado**

- Se ha creado un entorno funcional con **Docker**, **Odoo** y **PostgreSQL**.
- Se ha logrado integrar una aplicación en **.NET** con la base de datos de Odoo, permitiendo la conexión y ejecución de consultas SQL.
- La aplicación está configurada para poder obtener y mostrar datos desde la base de datos Odoo.

## 🔧 **Tecnologías utilizadas**

- **.NET 8** (C#)
- **Windows Forms**
- **PostgreSQL** (usado por Odoo)
- **Npgsql** (driver de PostgreSQL para C#)
- **Docker** (para contenedores Odoo y PostgreSQL)
- **Odoo** (ERP)

**¡Gracias por visitar este proyecto!** Si tienes alguna duda o sugerencia, no dudes en abrir un **issue** o contribuir al proyecto.
