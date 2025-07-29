# Sistema de Registro de Alumnos

Este repositorio contiene un sistema sencillo de registro de alumnos desarrollado en C# utilizando Windows Forms. Permite a los usuarios agregar, modificar y eliminar registros de estudiantes, y ver información adicional del estudiante, como antigüedad, materias pendientes y edad de ingreso.

## Características

* **Agregar Nuevo Alumno**: Registra nuevos alumnos ingresando su legajo, nombre, apellido, fecha de nacimiento, fecha de ingreso y cantidad de materias aprobadas.
* **Modificar Datos del Alumno**: Actualiza la información de los registros de alumnos existentes.
* **Eliminar Alumno**: Elimina registros de alumnos del sistema.
* **Ver Detalles del Alumno**: Al seleccionar un alumno en la tabla principal, se muestra su antigüedad en la institución, la cantidad de materias pendientes de aprobación y su edad al momento de ingresar.
* **Validación de Datos**: Validación básica para asegurar que los campos requeridos no estén vacíos y que las entradas numéricas sean válidas.

## Tecnologías Utilizadas

* C#
* Windows Forms

## Estructura del Proyecto

El proyecto consta de tres archivos principales:

* `Form1.cs`: Contiene la lógica de la ventana principal de la aplicación, manejando las interacciones del usuario y la gestión de datos para `dataGridView1` y `dataGridView2`.
* `Form1.Designer.cs`: Código generado automáticamente que define el diseño y los controles de la interfaz de usuario de `Form1`.
* `ALUMNO.cs`: Define la clase `ALUMNO`, que representa un objeto estudiante e incluye propiedades y métodos para calcular la antigüedad, las materias restantes y la edad de ingreso.

## Cómo Usar

1.  **Clonar el Repositorio**:
    ```bash
    git clone [https://github.com/FacundoG-Alarcon/Student-Management-App.git](Student-Registration-System)
    ```
2.  **Abrir en Visual Studio**: Abre el archivo `trabajo_integrador_unidad_1.sln` en Visual Studio.
3.  **Ejecutar la Aplicación**: Compila y ejecuta el proyecto presionando `F5` o haciendo clic en el botón "Iniciar" en Visual Studio.

## Interfaz de la Aplicación

* **Tabla de Datos Principal (dataGridView1)**: Muestra la lista de alumnos con su Legajo, Nombre, Apellido y Edad.
* **Tabla de Detalles (dataGridView2)**: Muestra los detalles calculados para el alumno seleccionado: "Antigüedad", "Materias no aprobadas" y "Edad de ingreso".
* **Campos de Entrada**:
    * `txtlegajo`: Legajo del alumno.
    * `txtNombre`: Nombre del alumno.
    * `txtapellido`: Apellido del alumno.
    * `txtEdad`: Edad del alumno (este campo se completa automáticamente según la fecha de nacimiento).
    * `dateTimePicker2`: Fecha de Nacimiento.
    * `dateTimePicker1`: Fecha de Ingreso.
    * `txtCant_aprobadas`: Cantidad de materias aprobadas.
* **Botones**:
    * `AGREGAR ALUMNO`: Agrega un nuevo registro de alumno.
    * `BORRAR ALUMNO`: Elimina el registro del alumno seleccionado.
    * `MODIFICAR`: Actualiza el registro del alumno seleccionado con la nueva información de los campos de entrada.

## Detalles de la Clase `ALUMNO`

La clase `ALUMNO` tiene las siguientes propiedades:

* `Legajo` (int): ID del estudiante.
* `Nombre` (string): Nombre del estudiante.
* `Apellido` (string): Apellido del estudiante.
* `Edad` (int): Propiedad de solo lectura calculada en función de `fechanacimiento`.
* `fechanacimiento` (DateTime): Fecha de nacimiento del estudiante.
* `fechaingreso` (DateTime): Fecha de ingreso del estudiante.
* `cantMateriaAprobadas` (int): Número de materias que el estudiante ha aprobado.
* `Activo` (bool): Indica si el estudiante está activo (siempre verdadero en esta implementación).
* `Fecha_Nacimiento` (DateTime): Propiedad de solo escritura para establecer `fechanacimiento`.
* `Fecha_Ingreso` (DateTime): Propiedad de solo escritura para establecer `fechaingreso`.
* `Cant_Materia_Aprobadas` (int): Propiedad de solo escritura para establecer `cantMateriaAprobadas`.

La clase `ALUMNO` también incluye los siguientes métodos:

* `Antiguedad()`: Calcula y devuelve la antigüedad del estudiante en la institución como una cadena (ej. "X años, Y meses, Z días").
* `Materias_No_Aprobadas()`: Calcula y devuelve el número de materias que el estudiante aún tiene que aprobar, asumiendo un total de 36 materias.
* `Edad_De_Ingreso()`: Calcula y devuelve la edad del estudiante al momento de su ingreso.

## Autor

Facundo Alarcón