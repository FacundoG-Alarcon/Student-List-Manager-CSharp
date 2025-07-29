using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_1_PROGRAMACION_1
{
    public partial class Secundario : Form
    {
        private List<Alumno> alumnos; // Lista de alumnos
        private ListBox ListaAlumnos; // Referencia al ListBox del formulario principal

        // Constructor que recibe la lista de alumnos y el ListBox
        public Secundario(List<Alumno> alumnos, ListBox listaAlumnos)
        {
            InitializeComponent();
            this.alumnos = alumnos; // Asigna la lista recibida a la variable de instancia
            this.ListaAlumnos = listaAlumnos; // Asigna la referencia del ListBox
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void txtNombre2_TextChanged(object sender, EventArgs e)
        {
            // Este método no tiene implementación en tu código actual
            // Asegúrate de que realice la acción deseada si es necesario
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre2.Text))
            {
                // Agrega el nuevo alumno a la lista
                Alumno nuevoAlumno = new Alumno(txtNombre2.Text);
                alumnos.Add(nuevoAlumno);

                // Limpia el ListBox y lo llena con los nombres de los alumnos
                ListaAlumnos.Items.Clear();

                foreach (Alumno alumno in alumnos)
                {
                    ListaAlumnos.Items.Add(alumno.Nombre);
                }

                // Limpia el TextBox después de agregar el alumno
                txtNombre2.Text = "";
                MessageBox.Show("Alumno agregado correctamente a la lista.");
            }
            else
            {
                MessageBox.Show("Ingrese un nombre válido.");
            }
                this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ha cancelado la acción. Para volver vuelva a seleccionar el botón CARGAR", "AVISO");
            this.Close();

        }
    }
}