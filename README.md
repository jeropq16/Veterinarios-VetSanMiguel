
# 🐾 Módulo de Gestión de Veterinarios – Sistema Veterinaria San Miguel

Este módulo forma parte del sistema de consola desarrollado en C# para la Veterinaria San Miguel, cuyo objetivo es gestionar eficientemente la información de clientes, mascotas, veterinarios y atenciones médicas. En esta célula, se implementa exclusivamente la funcionalidad relacionada con los veterinarios.

## 🎯 Objetivo del Módulo

Permitir el registro, consulta, edición y eliminación de veterinarios en la base de datos MySQL, utilizando Entity Framework Core y aplicando principios de Programación Orientada a Objetos (POO).

## 🧩 Funcionalidades Implementadas

- **Registrar Veterinario**: Permite ingresar un nuevo veterinario con sus datos personales (nombre, especialidad, teléfono, etc.).
- **Listar Veterinarios**: Muestra todos los veterinarios registrados en la base de datos.
- **Editar Veterinario**: Permite modificar los datos de un veterinario existente.
- **Eliminar Veterinario**: Elimina un veterinario de la base de datos.

## 🛠️ Tecnologías Utilizadas

- Lenguaje: C# (.NET Core)
- ORM: Entity Framework Core
- Base de datos: MySQL
- Arquitectura: Consola + POO + EF Core

## 🧠 Aplicación de POO

La clase `Veterinario` fue diseñada como una entidad con atributos y métodos que representan el comportamiento de un veterinario dentro del sistema. Se aplicaron los siguientes principios:

- **Encapsulamiento**: Los atributos están protegidos mediante propiedades.
- **Relaciones**: Un veterinario puede tener múltiples atenciones médicas (relación uno a muchos).
- **Sobrecarga de métodos**: Se implementó una sobrecarga en el método `EditarVeterinario`, permitiendo editar por ID o por nombre.


## 🗃️ Migraciones y Base de Datos

La clase `Veterinario` fue incluida en el `DbContext` principal del sistema. Se realizaron migraciones para crear la tabla correspondiente en MySQL, con claves primarias y relaciones adecuadas.

## 📊 Diagrama de Clases (Fragmento)

```plaintext
+------------------+
|   Veterinario    |
+------------------+
| Id               |
| Nombre           |
| Especialidad     |
| Telefono         |
+------------------+


## 📌 Consideraciones

- Validaciones básicas fueron implementadas para evitar registros duplicados.
- Se utilizó LINQ para consultar veterinarios con más atenciones (en el módulo de consultas avanzadas).
- El módulo está diseñado para integrarse fácilmente con el resto del sistema.

---
