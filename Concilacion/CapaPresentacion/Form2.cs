using Concilacion.CapaPresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concilacion.CapaPresentacion
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String saldo = textBox1.Text.ToString();
            Form1 f = new Form1(saldo);
            f.Show();
            this.Hide();
        }
    }
}
