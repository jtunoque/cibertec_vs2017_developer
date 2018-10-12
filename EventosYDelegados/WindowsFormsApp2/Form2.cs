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
    public partial class Form2 : Form
    {
        public event AfterSelectedItemHandler onAfterSelectedItem;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var prod = new Producto();
            prod.Id = 1;
            prod.Nombre = "Producto 1";

            if (onAfterSelectedItem != null)
            {
                onAfterSelectedItem(prod);
            }
        }
    }
}
