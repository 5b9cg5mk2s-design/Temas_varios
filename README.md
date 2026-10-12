# Laboratorio # [Número]

**Fecha:** 12/10/2026

## Contenido del Repositorio

Este laboratorio desarrolla diversos conceptos fundamentales de programación en C# y acceso a bases de datos. A través de cinco problemas independientes se implementan consultas SQL, manejo seguro de consultas parametrizadas, sobrecarga de métodos, recursividad y análisis de frecuencias utilizando estructuras de datos.

El proyecto utiliza una base de datos SQLite en memoria para simular operaciones reales de consulta y modificación de datos sin necesidad de instalaciones adicionales.

## Tecnologías Utilizadas

- Lenguaje: C#
- Framework: .NET
- Base de Datos: SQLite (In-Memory Database)
- Librería: Microsoft.Data.Sqlite
- Estructuras de Datos: Arrays y Dictionary
- Herramientas: Visual Studio, Git, GitHub

## Capturas de Pantalla y Problemas

### Interfaz Principal

<img width="841" height="516" alt="image" src="https://github.com/user-attachments/assets/8d9481b2-a086-4ae5-987b-4f96781d2ec2" />

### Problema 1: Consultas SQL

**Descripción:**

Se realizaron tres consultas SQL sobre una tabla de estudiantes creada en una base de datos SQLite en memoria:

- Consulta de todos los registros.
- Consulta de estudiantes mayores de 20 años.
- Consulta agrupada por carrera utilizando COUNT() y GROUP BY.

Conceptos aplicados:

- SELECT
- WHERE
- GROUP BY
- COUNT()
- SqliteConnection
- SqliteCommand
- SqliteDataReader

<img width="749" height="636" alt="image" src="https://github.com/user-attachments/assets/1243d2e2-09a3-459d-b867-ba5603e0f755" />


---

### Problema 2: Inyección SQL y Consultas Parametrizadas

**Descripción:**

Se demuestra la diferencia entre construir consultas mediante concatenación de cadenas y utilizar consultas parametrizadas.

Se implementan:

- INSERT mediante cadenas.
- UPDATE mediante cadenas.
- Ejemplo práctico de Inyección SQL.
- UPDATE usando parámetros.
- INSERT usando parámetros.

Conceptos aplicados:

- SQL Injection
- Parámetros SQL
- Seguridad en bases de datos
- ExecuteNonQuery()

<img width="1061" height="938" alt="image" src="https://github.com/user-attachments/assets/1450f29b-13ac-4225-9453-492632903b84" />


---

### Problema 3: Métodos Sobrecargados

**Descripción:**

Se implementó una clase llamada `Calculadora` que contiene varios métodos `Sumar()` utilizando sobrecarga de métodos.

Versiones implementadas:

- Suma de dos enteros.
- Suma de tres enteros.
- Suma de dos números decimales.
- Suma de un arreglo de enteros.

Conceptos aplicados:

- Polimorfismo
- Sobrecarga de métodos
- Arreglos
- Programación Orientada a Objetos

<img width="569" height="220" alt="image" src="https://github.com/user-attachments/assets/3b322bb3-1ed1-4ba4-b28c-4ff962ce0df5" />


---

### Problema 4: Factorial mediante Recursividad

**Descripción:**

Se desarrolló un algoritmo recursivo para calcular el factorial de un número ingresado por el usuario.

El programa:

- Solicita un número entre 0 y 20.
- Valida la entrada.
- Calcula el factorial utilizando llamadas recursivas.
- Presenta el resultado en pantalla.

Conceptos aplicados:

- Recursividad
- Caso base
- Validación de datos
- Funciones

<img width="511" height="187" alt="image" src="https://github.com/user-attachments/assets/a90fb1d9-e746-4939-9626-3a03ace139cd" />


---

### Problema 5: Frecuencia de Elementos

**Descripción:**

Se utilizó un arreglo de números enteros para calcular la frecuencia de aparición de cada valor.

Para ello se implementó un objeto `Dictionary<int,int>` que almacena:

- Clave: número.
- Valor: cantidad de apariciones.

Conceptos aplicados:

- Diccionarios
- Colecciones genéricas
- Iteración con foreach
- Análisis de datos

<img width="600" height="367" alt="image" src="https://github.com/user-attachments/assets/14156c2e-a62c-4389-8e18-1a4addb72e75" />


## Estructura de Carpetas o Directorios

```plaintext
LaboratorioTemasVarios/
│
├── Program.cs
├── BaseDatos.cs
├── Calculadora.cs
├── Problema1.cs
├── Problema2.cs
├── Problema3.cs
├── Problema4.cs
├── Problema5.cs
│
└── README.md
```

### Descripción de los Archivos

- **Program.cs:** Menú principal de navegación entre los problemas.
- **BaseDatos.cs:** Gestión de la base de datos SQLite en memoria y visualización de registros.
- **Calculadora.cs:** Implementación de métodos sobrecargados.
- **Problema1.cs:** Consultas SQL.
- **Problema2.cs:** Inyección SQL y consultas parametrizadas.
- **Problema3.cs:** Sobrecarga de métodos.
- **Problema4.cs:** Factorial utilizando recursividad.
- **Problema5.cs:** Cálculo de frecuencias mediante diccionarios.

## Instrucciones de Ejecución / Uso

### 1. Clonar el repositorio

```bash
git clone https://github.com/usuario/LaboratorioTemasVarios.git
```

### 2. Abrir el proyecto

Abrir la solución en Visual Studio.

### 3. Restaurar dependencias

```bash
dotnet restore
```

### 4. Compilar el proyecto

```bash
dotnet build
```

### 5. Ejecutar la aplicación

```bash
dotnet run
```

### 6. Seleccionar una opción del menú

El sistema mostrará el siguiente menú:

```plaintext
1. Problema 1
2. Problema 2
3. Problema 3
4. Problema 4
5. Problema 5
0. Salir
```

Seleccione el número correspondiente para ejecutar cada ejercicio.

## Conceptos Aplicados

### Acceso a Bases de Datos

Uso de SQLite para realizar consultas, inserciones y actualizaciones sobre una base de datos relacional.

### Seguridad Informática

Comparación entre consultas vulnerables a Inyección SQL y consultas parametrizadas.

### Programación Orientada a Objetos

Implementación de clases especializadas para encapsular funcionalidades específicas.

### Polimorfismo

Aplicación de sobrecarga de métodos mediante múltiples versiones del método `Sumar()`.

### Recursividad

Solución del problema del factorial utilizando llamadas recursivas.

### Estructuras de Datos

Uso de arreglos y diccionarios para el procesamiento y conteo de información.

## Autor y Contexto

- Nombre: Johandry González
- Cédula: 20-14-5043
- Institución: Universidad Tecnológica de Panamá (UTP)
- Facultad: Ingeniería de Sistemas Computacionales
- Asignatura: Herramientas de programación aplicada III
- Fecha de Realización: 12/10/2026

## Referencias

- Microsoft Learn - ADO.NET y SQLite
  https://learn.microsoft.com/

- Microsoft Learn - SQL Parameters
  https://learn.microsoft.com/sql/

- Microsoft Learn - Recursion in C#
  https://learn.microsoft.com/dotnet/csharp/

- SQLite Documentation
  https://www.sqlite.org/docs.html

- GitHub Docs
  https://docs.github.com/
