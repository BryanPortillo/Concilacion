namespace Concilacion
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txTransaccio = new System.Windows.Forms.TextBox();
            this.txValor = new System.Windows.Forms.TextBox();
            this.cbCuenta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txBanco = new System.Windows.Forms.TextBox();
            this.cbTipoPago = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbLibro = new System.Windows.Forms.Label();
            this.lbBanco = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.navegador1 = new Navegador.Navegador();
            this.button1 = new System.Windows.Forms.Button();
            this.rbCorrecta = new System.Windows.Forms.RadioButton();
            this.rbIncorrecta = new System.Windows.Forms.RadioButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conciliacion Bancaria";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(790, 211);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NoTransaccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cuenta";
            // 
            // txTransaccio
            // 
            this.txTransaccio.Location = new System.Drawing.Point(134, 131);
            this.txTransaccio.Name = "txTransaccio";
            this.txTransaccio.Size = new System.Drawing.Size(100, 20);
            this.txTransaccio.TabIndex = 5;
            this.txTransaccio.Tag = "noTransaccion";
            // 
            // txValor
            // 
            this.txValor.Location = new System.Drawing.Point(134, 158);
            this.txValor.Name = "txValor";
            this.txValor.Size = new System.Drawing.Size(100, 20);
            this.txValor.TabIndex = 6;
            // 
            // cbCuenta
            // 
            this.cbCuenta.FormattingEnabled = true;
            this.cbCuenta.Location = new System.Drawing.Point(134, 184);
            this.cbCuenta.Name = "cbCuenta";
            this.cbCuenta.Size = new System.Drawing.Size(100, 21);
            this.cbCuenta.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Banco";
            // 
            // txBanco
            // 
            this.txBanco.Location = new System.Drawing.Point(134, 214);
            this.txBanco.Name = "txBanco";
            this.txBanco.Size = new System.Drawing.Size(100, 20);
            this.txBanco.TabIndex = 9;
            // 
            // cbTipoPago
            // 
            this.cbTipoPago.FormattingEnabled = true;
            this.cbTipoPago.Location = new System.Drawing.Point(574, 138);
            this.cbTipoPago.Name = "cbTipoPago";
            this.cbTipoPago.Size = new System.Drawing.Size(121, 21);
            this.cbTipoPago.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(491, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "tipo pago";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 684);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Saldo Total(Libro bancos):";
            // 
            // lbLibro
            // 
            this.lbLibro.AutoSize = true;
            this.lbLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLibro.Location = new System.Drawing.Point(297, 684);
            this.lbLibro.Name = "lbLibro";
            this.lbLibro.Size = new System.Drawing.Size(54, 25);
            this.lbLibro.TabIndex = 16;
            this.lbLibro.Text = "0.00";
            // 
            // lbBanco
            // 
            this.lbBanco.AutoSize = true;
            this.lbBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBanco.Location = new System.Drawing.Point(742, 684);
            this.lbBanco.Name = "lbBanco";
            this.lbBanco.Size = new System.Drawing.Size(54, 25);
            this.lbBanco.TabIndex = 18;
            this.lbBanco.Text = "0.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(529, 684);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(207, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "Saldo Total(Banco):";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(134, 51);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(559, 47);
            this.navegador1.sNombreBD = "hotelfase2";
            this.navegador1.sNombreTabla = "conciliacion";
            this.navegador1.sPass = "";
            this.navegador1.sResult = null;
            this.navegador1.sServidor = "localhost";
            this.navegador1.sUsuario = "root";
            this.navegador1.TabIndex = 19;
            this.navegador1.RecibidorInsertar += new System.EventHandler(this.navegador1_RecibidorInsertar);
            this.navegador1.RecibidorActualizar += new System.EventHandler(this.navegador1_RecibidorActualizar);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "Conciliar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbCorrecta
            // 
            this.rbCorrecta.AutoSize = true;
            this.rbCorrecta.Location = new System.Drawing.Point(494, 178);
            this.rbCorrecta.Name = "rbCorrecta";
            this.rbCorrecta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbCorrecta.Size = new System.Drawing.Size(101, 17);
            this.rbCorrecta.TabIndex = 21;
            this.rbCorrecta.TabStop = true;
            this.rbCorrecta.Text = "Cuenta correcta";
            this.rbCorrecta.UseVisualStyleBackColor = true;
            // 
            // rbIncorrecta
            // 
            this.rbIncorrecta.AutoSize = true;
            this.rbIncorrecta.Location = new System.Drawing.Point(626, 178);
            this.rbIncorrecta.Name = "rbIncorrecta";
            this.rbIncorrecta.Size = new System.Drawing.Size(110, 17);
            this.rbIncorrecta.TabIndex = 22;
            this.rbIncorrecta.TabStop = true;
            this.rbIncorrecta.Text = "Cuenta Incorrecta";
            this.rbIncorrecta.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(26, 459);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(790, 211);
            this.dataGridView2.TabIndex = 23;
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(822, 51);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(469, 619);
            this.axAcroPDF1.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(919, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 30);
            this.button2.TabIndex = 25;
            this.button2.Text = "Abrir PDF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1293, 733);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.rbIncorrecta);
            this.Controls.Add(this.rbCorrecta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.lbBanco);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbLibro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbTipoPago);
            this.Controls.Add(this.txBanco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCuenta);
            this.Controls.Add(this.txValor);
            this.Controls.Add(this.txTransaccio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "5100 - Concilacion Bancaria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.sa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txTransaccio;
        private System.Windows.Forms.TextBox txValor;
        private System.Windows.Forms.ComboBox cbCuenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txBanco;
        private System.Windows.Forms.ComboBox cbTipoPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbLibro;
        private System.Windows.Forms.Label lbBanco;
        private System.Windows.Forms.Label label11;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbCorrecta;
        private System.Windows.Forms.RadioButton rbIncorrecta;
        private System.Windows.Forms.DataGridView dataGridView2;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Button button2;
    }
}

