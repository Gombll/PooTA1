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

        void mostrar(List<Persona> lista) { }
        
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona p = new Persona(int.Parse(textBoxDNI.Text), int.Parse(textBoxEdad.Text), textBoxNombre.Text,textBoxDireccion.Text);
            bd.Insertar(p);
            mostrar(bd.valores);
        }
    }
}
