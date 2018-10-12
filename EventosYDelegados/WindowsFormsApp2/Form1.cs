using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Entities;
using static WindowsFormsApp2.Eventos.Listeners;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new Form2();
            frm.onAfterSelectedItem += new AfterSelectedItemHandler(LlenarProductoSeleccionado);
            frm.ShowDialog();
        }

        private void LlenarProductoSeleccionado(Object obj)
        {
            var prod = (Producto)obj;
        }
    }
}
