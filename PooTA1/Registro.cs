using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PooTA1
{
    public partial class Registro : Form
    {
        JsonArchivo<Persona> bd = new JsonArchivo<Persona>("datos.json"); //puede ser de extension .json o .txt

        void mostrar(List<Persona> lista)
        {
            dataGridViewDatos.Rows.Clear();

            foreach (Persona p in lista)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = p.DNI });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = p.Nombre });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = p.edad });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = p.Direccion });
                dataGridViewDatos.Rows.Add(fila);
            }
            void mostrar(List<Persona> lista) { }

        }
        public Registro()
        {
            InitializeComponent();
            bd.Cargar();
            mostrar(bd.valores);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Persona p = bd.Buscar(x => x.DNI.ToString() == dataGridViewDatos.CurrentRow.Cells[0].Value.ToString())[0];
            textBoxDNI.Text = p.DNI.ToString();
            textBoxNombre.Text = p.Nombre;
            textBoxEdad.Text = p.edad.ToString();
            textBoxDireccion.Text = p.Direccion;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            Persona p = new Persona(int.Parse(textBoxDNI.Text), int.Parse(textBoxEdad.Text), textBoxNombre.Text, textBoxDireccion.Text);
            bd.Insertar(p);
            mostrar(bd.valores);
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            int DNI = int.Parse(textBoxDNI.Text);
            int Edad = int.Parse(textBoxEdad.Text);
            Persona p = new Persona(DNI, Edad, textBoxNombre.Text, textBoxDireccion.Text);
            bd.Actualizar(x => x.DNI == DNI, p);
            mostrar(bd.valores);

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int DNI = int.Parse(textBoxDNI.Text);
            bd.Eliminar(x => x.DNI == DNI);
            mostrar(bd.valores);
        }

        private void textBoxDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            var lista = bd.Buscar(x => x.Nombre.Contains(textBoxBuscar.Text));
            mostrar(lista);
        }
    }
}
