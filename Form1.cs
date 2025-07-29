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
    public partial class Form1 : Form
    {
        private List<Alumno> alumnos = new List<Alumno>();
        public Form1()
        {
            InitializeComponent();
        }

        public void btnNombreAlumno_TextChanged(object sender, EventArgs e)
        {
            Secundario form2 = new Secundario(alumnos,ListaAlumnos);
            
            form2.Show();
        }
       
        private void btnCargar_Click(object sender, EventArgs e)
        {
            //Invocación del input
            this.btnNombreAlumno_TextChanged(sender,e);

            ListaAlumnos.Items.Clear();

            foreach (Alumno alumno in alumnos)
            {
                ListaAlumnos.Items.Add(alumno.Nombre);
            }            
        }
        private void ListaAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                // Si el usuario selecciona "No", no hacemos nada y el formulario permanece abierto.
            }
            else
            {
                this.Close();
                Application.Exit();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // Verificamos si hay algún elemento seleccionado en la ListBox
            if (ListaAlumnos.Items.Count > 0)
            {
                string primerElemento = ListaAlumnos.Items[0].ToString();
                MessageBox.Show("El alumno eliminado es: " + primerElemento);
                
                ListaAlumnos.Items.RemoveAt(0);


                if (MessageBox.Show("Eliminaste un alumno", "Aviso", MessageBoxButtons.OK) == DialogResult.Yes)
                    // Eliminamos el elemento seleccionado
                    ListaAlumnos.Items.RemoveAt(ListaAlumnos.SelectedIndex);
            }
            else
            {
                // Mostramos un mensaje si no hay ningún elemento seleccionado
                MessageBox.Show("No hay alumnos en la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTope_Click(object sender, EventArgs e)
        {
            if (ListaAlumnos.Items.Count > 0)
            {
                // Obtenemos el primer elemento (índice 0)
                string primerElemento = ListaAlumnos.Items[0].ToString();

                // Mostramos el primer elemento en un MessageBox
                MessageBox.Show("El primer elemento es: " + primerElemento);
            }
            else
            {
                MessageBox.Show("La ListBox está vacía.");
            }
        }

        private void btnQuickSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombreAlumno.Text))
            {
                Alumno nuevoAlumno = new Alumno(txtNombreAlumno.Text);
                alumnos.Add(nuevoAlumno);
                ListaAlumnos.Items.Clear();

                foreach (Alumno alumno in alumnos)
                {
                    ListaAlumnos.Items.Add(alumno.Nombre);
                }
                txtNombreAlumno.Text = "";
                MessageBox.Show("Alumno agregado correctamente a la lista.");
            }
            else
            {
                MessageBox.Show("Ingrese un nombre valido");
            }
        }

        private void txtNombreAlumno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
