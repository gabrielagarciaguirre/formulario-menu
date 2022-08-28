using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario_menu
{
    public partial class Form1 : Form
    {
        public object menuBindingSource { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2clientes p = new Form2clientes();
            p.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4productos p = new Form4productos();
            p.ShowDialog();
        }

        private void procesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2procesos p = new Form2procesos();
            p.ShowDialog();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formconsultas p = new Formconsultas();
            p.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
