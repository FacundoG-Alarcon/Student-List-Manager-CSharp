# Gestor Simple de Alumnos

Este repositorio contiene un sistema b�sico de gesti�n de alumnos desarrollado en C# utilizando Windows Forms. Permite a los usuarios cargar, borrar y visualizar el "tope" (primer elemento) de una lista de nombres de alumnos. El sistema utiliza dos formularios para la interacci�n del usuario: uno principal para la visualizaci�n y operaciones b�sicas, y uno secundario para la carga de nuevos nombres de alumnos.

## Caracter�sticas

* **Cargar Alumno**: Abre un formulario secundario donde se puede ingresar un nombre de alumno para agregarlo a la lista principal.
* **Borrar Alumno**: Elimina el alumno seleccionado de la lista.
* **Ver Tope de Lista**: Muestra en un mensaje el nombre del primer alumno en la lista.
* **Interfaz Sencilla**: Una interfaz de usuario clara con un `ListBox` para mostrar los alumnos y campos de texto para la entrada de datos.
* **Validaci�n B�sica**: Verifica que el campo de nombre no est� vac�o al intentar agregar un alumno.

## Tecnolog�as Utilizadas

* C#
* Windows Forms

## Estructura del Proyecto

El proyecto se compone de los siguientes archivos principales:

* `Form1.cs`: Contiene la l�gica principal de la aplicaci�n. Maneja la visualizaci�n de la lista de alumnos, la invocaci�n del formulario secundario para la carga, y las acciones de borrar y mostrar el tope de la lista.
* `Form1.Designer.cs`: C�digo generado autom�ticamente que define el dise�o y los controles de la interfaz de usuario del `Form1`.
* `Secundario.cs`: Define la l�gica para el formulario secundario que permite al usuario ingresar un nuevo nombre de alumno. Agrega el nombre a la lista compartida con `Form1` y cierra la ventana.
* `Secundario.Designer.cs`: C�digo generado autom�ticamente que define el dise�o y los controles de la interfaz de usuario del formulario `Secundario`.
* `Alumno.cs`: Define la clase `Alumno`, que representa un objeto estudiante con una �nica propiedad: `Nombre`.
* `Program.cs`: El punto de entrada principal de la aplicaci�n, que inicializa y ejecuta `Form1`.

## C�mo Usar

1.  **Clonar el Repositorio**:
    ```bash
    git clone [https://github.com/FacundoG-Alarcon/Student-List-Manager-CSharp.git](https://github.com/tu-usuario/Student-List-Manager-CSharp.git)
    ```
2.  **Abrir en Visual Studio**: Abre el archivo `.sln` (Soluci�n de Visual Studio) en Visual Studio. El nombre de la soluci�n podr�a ser similar a `TP_1_PROGRAMACION_1.sln` seg�n el namespace.
3.  **Ejecutar la Aplicaci�n**: Compila y ejecuta el proyecto presionando `F5` o haciendo clic en el bot�n "Iniciar" en Visual Studio.

### Interfaz de la Aplicaci�n

* **Formulario Principal (`Form1`)**:
    * `ListBox` de Alumnos: Muestra los nombres de los alumnos cargados.
    * Bot�n "CARGAR": Abre el formulario `Secundario` para a�adir un nuevo alumno.
    * Bot�n "BORRAR": Elimina el alumno seleccionado de la lista.
    * Bot�n "TOPE": Muestra el primer elemento de la lista en un cuadro de mensaje.
    * Bot�n "SALIR": Cierra la aplicaci�n con una confirmaci�n.
    * Campo de texto `txtNombreAlumno` y bot�n `btnQuickSubmit`: Permiten una carga r�pida de alumnos directamente desde el formulario principal.
* **Formulario Secundario (`Secundario`)**:
    * Campo de texto `txtNombre2`: Para ingresar el nombre del nuevo alumno.
    * Bot�n "Aceptar": Agrega el nombre del alumno a la lista y cierra el formulario.
    * Bot�n "Cancelar": Cierra el formulario sin agregar el alumno.

## Detalles de la Clase `Alumno`

La clase `Alumno` es muy sencilla y contiene solo la siguiente propiedad:

* `Nombre` (string): Representa el nombre del alumno.

El constructor de la clase `Alumno` inicializa esta propiedad:
```csharp
public Alumno(string nombre)
{
    Nombre = nombre;
}