# Gestor Simple de Alumnos

Este repositorio contiene un sistema básico de gestión de alumnos desarrollado en C# utilizando Windows Forms. Permite a los usuarios cargar, borrar y visualizar el "tope" (primer elemento) de una lista de nombres de alumnos. El sistema utiliza dos formularios para la interacción del usuario: uno principal para la visualización y operaciones básicas, y uno secundario para la carga de nuevos nombres de alumnos.

## Características

* **Cargar Alumno**: Abre un formulario secundario donde se puede ingresar un nombre de alumno para agregarlo a la lista principal.
* **Borrar Alumno**: Elimina el alumno seleccionado de la lista.
* **Ver Tope de Lista**: Muestra en un mensaje el nombre del primer alumno en la lista.
* **Interfaz Sencilla**: Una interfaz de usuario clara con un `ListBox` para mostrar los alumnos y campos de texto para la entrada de datos.
* **Validación Básica**: Verifica que el campo de nombre no esté vacío al intentar agregar un alumno.

## Tecnologías Utilizadas

* C#
* Windows Forms

## Estructura del Proyecto

El proyecto se compone de los siguientes archivos principales:

* `Form1.cs`: Contiene la lógica principal de la aplicación. Maneja la visualización de la lista de alumnos, la invocación del formulario secundario para la carga, y las acciones de borrar y mostrar el tope de la lista.
* `Form1.Designer.cs`: Código generado automáticamente que define el diseño y los controles de la interfaz de usuario del `Form1`.
* `Secundario.cs`: Define la lógica para el formulario secundario que permite al usuario ingresar un nuevo nombre de alumno. Agrega el nombre a la lista compartida con `Form1` y cierra la ventana.
* `Secundario.Designer.cs`: Código generado automáticamente que define el diseño y los controles de la interfaz de usuario del formulario `Secundario`.
* `Alumno.cs`: Define la clase `Alumno`, que representa un objeto estudiante con una única propiedad: `Nombre`.
* `Program.cs`: El punto de entrada principal de la aplicación, que inicializa y ejecuta `Form1`.

## Cómo Usar

1.  **Clonar el Repositorio**:
    ```bash
    git clone [https://github.com/FacundoG-Alarcon/Student-List-Manager-CSharp.git](https://github.com/tu-usuario/Student-List-Manager-CSharp.git)
    ```
2.  **Abrir en Visual Studio**: Abre el archivo `.sln` (Solución de Visual Studio) en Visual Studio. El nombre de la solución podría ser similar a `TP_1_PROGRAMACION_1.sln` según el namespace.
3.  **Ejecutar la Aplicación**: Compila y ejecuta el proyecto presionando `F5` o haciendo clic en el botón "Iniciar" en Visual Studio.

### Interfaz de la Aplicación

* **Formulario Principal (`Form1`)**:
    * `ListBox` de Alumnos: Muestra los nombres de los alumnos cargados.
    * Botón "CARGAR": Abre el formulario `Secundario` para añadir un nuevo alumno.
    * Botón "BORRAR": Elimina el alumno seleccionado de la lista.
    * Botón "TOPE": Muestra el primer elemento de la lista en un cuadro de mensaje.
    * Botón "SALIR": Cierra la aplicación con una confirmación.
    * Campo de texto `txtNombreAlumno` y botón `btnQuickSubmit`: Permiten una carga rápida de alumnos directamente desde el formulario principal.
* **Formulario Secundario (`Secundario`)**:
    * Campo de texto `txtNombre2`: Para ingresar el nombre del nuevo alumno.
    * Botón "Aceptar": Agrega el nombre del alumno a la lista y cierra el formulario.
    * Botón "Cancelar": Cierra el formulario sin agregar el alumno.

## Detalles de la Clase `Alumno`

La clase `Alumno` es muy sencilla y contiene solo la siguiente propiedad:

* `Nombre` (string): Representa el nombre del alumno.

El constructor de la clase `Alumno` inicializa esta propiedad:
```csharp
public Alumno(string nombre)
{
    Nombre = nombre;
}