using Concilacion.CapaLogica;
using Concilacion.CapaPresentacion;
using Navegador.Utilidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concilacion
{
    public partial class Form1 : Form
    {

        private string saldo;

        public Form1()
        {
            InitializeComponent();


        }

        public Form1(string saldo)
        {
            this.saldo = saldo;
            InitializeComponent();

        }

        private void sa_Load(object sender, EventArgs e)
        {
            ControladorFormulario cf = new ControladorFormulario();
            cf.LLenarDataGrid(dataGridView1);
            lbBanco.Text = this.saldo;

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }

            dataGridView2.Columns.Add("newColumnName", "Transaccion");
            dataGridView2.Columns.Add("newColumnName", "Valor");
            dataGridView2.Columns.Add("newColumnName", "Banco");
            dataGridView2.Columns.Add("newColumnName", "TipoPago");
            dataGridView2.Columns.Add("newColumnName", "Fecha");
            dataGridView2.Columns.Add("newColumnName", "Observaciones");
            lbLibro.Text = sum.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string transaccion = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                string valor = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                string cuenta = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                string banco = dataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;
                string tipo = dataGridView1.SelectedRows[0].Cells[ 4].Value + string.Empty;
                

                txTransaccio.Text = transaccion;
                txValor.Text = valor;
                cbCuenta.Text = cuenta;
                txBanco.Text = banco;
                cbTipoPago.Text = tipo;
            }
        }

        private void navegador1_RecibidorActualizar(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int filas = (dataGridView1.RowCount - 1);
           
            if (rbCorrecta.Checked == true) {
                for (int i = 0; i < filas; i++)
                {
                   

                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == txTransaccio.Text.ToString())
                    {
                        DataGridViewRow dgrFila = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                        for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++ ) {
                            dgrFila.Cells[j].Value = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }

                        dataGridView1.Rows.RemoveAt(i);
                        dataGridView2.Rows.Add(dgrFila);
                        int sum = 0;
                        for (int k = 0; k < dataGridView2.Rows.Count; ++k)
                        {
                            sum += Convert.ToInt32(dataGridView2.Rows[k].Cells[1].Value);
                        }
                        lbLibro.Text = sum.ToString();
                        break;
                    }

                }
            } else if (rbIncorrecta.Checked == true) {
                
         
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                axAcroPDF1.src = ofd.FileName;
            }


        }

        private void navegador1_RecibidorInsertar(object sender, EventArgs e)
        {
            string bd = navegador1.sNombreBD;
            string server = navegador1.sServidor;
            string user = navegador1.sUsuario;
            string pass = navegador1.sPass;
            string nametabla = navegador1.sNombreTabla;


            int filas = (dataGridView2.RowCount - 1);

            for (int i = 0; i < filas; i++)
            {
                String campo1 = dataGridView2.Rows[i].Cells[0].Value.ToString();
                String campo2 = dataGridView2.Rows[i].Cells[1].Value.ToString();
                String campo3 = dataGridView2.Rows[i].Cells[2].Value.ToString();
              

                ArrayList listavalores = new ArrayList();
                ArrayList listacampos = new ArrayList();


                listavalores.Add(0);
                listavalores.Add(campo1);
                listavalores.Add(campo2);
                listavalores.Add(campo3);


                listacampos.Add("CorrConciliacion");
                listacampos.Add("noTransaccion");
                listacampos.Add("valor");
                listacampos.Add("fecha");



                GeneradorSQL gsql = new GeneradorSQL(server, bd, user, pass, nametabla);
                gsql.setCodigoInstDML(1);
                gsql.setCampos(listacampos);
                gsql.setValores(listavalores);
                gsql.ejecutar();
                MessageBox.Show("Dato insertado");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
