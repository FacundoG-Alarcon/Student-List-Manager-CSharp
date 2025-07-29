# Sistema de Registro de Alumnos

Este repositorio contiene un sistema sencillo de registro de alumnos desarrollado en C# utilizando Windows Forms. Permite a los usuarios agregar, modificar y eliminar registros de estudiantes, y ver informaci�n adicional del estudiante, como antig�edad, materias pendientes y edad de ingreso.

## Caracter�sticas

* **Agregar Nuevo Alumno**: Registra nuevos alumnos ingresando su legajo, nombre, apellido, fecha de nacimiento, fecha de ingreso y cantidad de materias aprobadas.
* **Modificar Datos del Alumno**: Actualiza la informaci�n de los registros de alumnos existentes.
* **Eliminar Alumno**: Elimina registros de alumnos del sistema.
* **Ver Detalles del Alumno**: Al seleccionar un alumno en la tabla principal, se muestra su antig�edad en la instituci�n, la cantidad de materias pendientes de aprobaci�n y su edad al momento de ingresar.
* **Validaci�n de Datos**: Validaci�n b�sica para asegurar que los campos requeridos no est�n vac�os y que las entradas num�ricas sean v�lidas.

## Tecnolog�as Utilizadas

* C#
* Windows Forms

## Estructura del Proyecto

El proyecto consta de tres archivos principales:

* `Form1.cs`: Contiene la l�gica de la ventana principal de la aplicaci�n, manejando las interacciones del usuario y la gesti�n de datos para `dataGridView1` y `dataGridView2`.
* `Form1.Designer.cs`: C�digo generado autom�ticamente que define el dise�o y los controles de la interfaz de usuario de `Form1`.
* `ALUMNO.cs`: Define la clase `ALUMNO`, que representa un objeto estudiante e incluye propiedades y m�todos para calcular la antig�edad, las materias restantes y la edad de ingreso.

## C�mo Usar

1.  **Clonar el Repositorio**:
    ```bash
    git clone [https://github.com/FacundoG-Alarcon/Student-Management-App.git](Student-Registration-System)
    ```
2.  **Abrir en Visual Studio**: Abre el archivo `trabajo_integrador_unidad_1.sln` en Visual Studio.
3.  **Ejecutar la Aplicaci�n**: Compila y ejecuta el proyecto presionando `F5` o haciendo clic en el bot�n "Iniciar" en Visual Studio.

## Interfaz de la Aplicaci�n

* **Tabla de Datos Principal (dataGridView1)**: Muestra la lista de alumnos con su Legajo, Nombre, Apellido y Edad.
* **Tabla de Detalles (dataGridView2)**: Muestra los detalles calculados para el alumno seleccionado: "Antig�edad", "Materias no aprobadas" y "Edad de ingreso".
* **Campos de Entrada**:
    * `txtlegajo`: Legajo del alumno.
    * `txtNombre`: Nombre del alumno.
    * `txtapellido`: Apellido del alumno.
    * `txtEdad`: Edad del alumno (este campo se completa autom�ticamente seg�n la fecha de nacimiento).
    * `dateTimePicker2`: Fecha de Nacimiento.
    * `dateTimePicker1`: Fecha de Ingreso.
    * `txtCant_aprobadas`: Cantidad de materias aprobadas.
* **Botones**:
    * `AGREGAR ALUMNO`: Agrega un nuevo registro de alumno.
    * `BORRAR ALUMNO`: Elimina el registro del alumno seleccionado.
    * `MODIFICAR`: Actualiza el registro del alumno seleccionado con la nueva informaci�n de los campos de entrada.

## Detalles de la Clase `ALUMNO`

La clase `ALUMNO` tiene las siguientes propiedades:

* `Legajo` (int): ID del estudiante.
* `Nombre` (string): Nombre del estudiante.
* `Apellido` (string): Apellido del estudiante.
* `Edad` (int): Propiedad de solo lectura calculada en funci�n de `fechanacimiento`.
* `fechanacimiento` (DateTime): Fecha de nacimiento del estudiante.
* `fechaingreso` (DateTime): Fecha de ingreso del estudiante.
* `cantMateriaAprobadas` (int): N�mero de materias que el estudiante ha aprobado.
* `Activo` (bool): Indica si el estudiante est� activo (siempre verdadero en esta implementaci�n).
* `Fecha_Nacimiento` (DateTime): Propiedad de solo escritura para establecer `fechanacimiento`.
* `Fecha_Ingreso` (DateTime): Propiedad de solo escritura para establecer `fechaingreso`.
* `Cant_Materia_Aprobadas` (int): Propiedad de solo escritura para establecer `cantMateriaAprobadas`.

La clase `ALUMNO` tambi�n incluye los siguientes m�todos:

* `Antiguedad()`: Calcula y devuelve la antig�edad del estudiante en la instituci�n como una cadena (ej. "X a�os, Y meses, Z d�as").
* `Materias_No_Aprobadas()`: Calcula y devuelve el n�mero de materias que el estudiante a�n tiene que aprobar, asumiendo un total de 36 materias.
* `Edad_De_Ingreso()`: Calcula y devuelve la edad del estudiante al momento de su ingreso.

## Autor

Facundo Alarc�n