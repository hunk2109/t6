namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnbuscarx = new System.Windows.Forms.Button();
            this.txtbusc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbbuscar = new System.Windows.Forms.ComboBox();
            this.dgbc = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnlimp = new System.Windows.Forms.Button();
            this.btnguar = new System.Windows.Forms.Button();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtdirec = new System.Windows.Forms.TextBox();
            this.txtapell = new System.Windows.Forms.TextBox();
            this.txtnomb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbc)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(518, 332);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnbuscarx);
            this.tabPage1.Controls.Add(this.txtbusc);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cmbbuscar);
            this.tabPage1.Controls.Add(this.dgbc);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(510, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnbuscarx
            // 
            this.btnbuscarx.Location = new System.Drawing.Point(371, 6);
            this.btnbuscarx.Name = "btnbuscarx";
            this.btnbuscarx.Size = new System.Drawing.Size(75, 23);
            this.btnbuscarx.TabIndex = 4;
            this.btnbuscarx.Text = "Buscar";
            this.btnbuscarx.UseVisualStyleBackColor = true;
            this.btnbuscarx.Click += new System.EventHandler(this.btnbuscarx_Click);
            // 
            // txtbusc
            // 
            this.txtbusc.Location = new System.Drawing.Point(193, 6);
            this.txtbusc.Name = "txtbusc";
            this.txtbusc.Size = new System.Drawing.Size(172, 20);
            this.txtbusc.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Buscar por";
            // 
            // cmbbuscar
            // 
            this.cmbbuscar.FormattingEnabled = true;
            this.cmbbuscar.Items.AddRange(new object[] {
            "ID",
            "Nombre",
            "Apellido",
            "Telefono"});
            this.cmbbuscar.Location = new System.Drawing.Point(65, 6);
            this.cmbbuscar.Name = "cmbbuscar";
            this.cmbbuscar.Size = new System.Drawing.Size(121, 21);
            this.cmbbuscar.TabIndex = 1;
            // 
            // dgbc
            // 
            this.dgbc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgbc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbc.Location = new System.Drawing.Point(7, 33);
            this.dgbc.Name = "dgbc";
            this.dgbc.Size = new System.Drawing.Size(494, 252);
            this.dgbc.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnlimp);
            this.tabPage2.Controls.Add(this.btnguar);
            this.tabPage2.Controls.Add(this.txttel);
            this.tabPage2.Controls.Add(this.txtdirec);
            this.tabPage2.Controls.Add(this.txtapell);
            this.tabPage2.Controls.Add(this.txtnomb);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(511, 291);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registro";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnlimp
            // 
            this.btnlimp.Location = new System.Drawing.Point(95, 169);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Size = new System.Drawing.Size(75, 23);
            this.btnlimp.TabIndex = 9;
            this.btnlimp.Text = "Limpiar";
            this.btnlimp.UseVisualStyleBackColor = true;
            // 
            // btnguar
            // 
            this.btnguar.Location = new System.Drawing.Point(10, 169);
            this.btnguar.Name = "btnguar";
            this.btnguar.Size = new System.Drawing.Size(75, 23);
            this.btnguar.TabIndex = 8;
            this.btnguar.Text = "Guardar";
            this.btnguar.UseVisualStyleBackColor = true;
            this.btnguar.Click += new System.EventHandler(this.btnguar_Click);
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(70, 118);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(100, 20);
            this.txttel.TabIndex = 7;
            // 
            // txtdirec
            // 
            this.txtdirec.Location = new System.Drawing.Point(70, 76);
            this.txtdirec.Name = "txtdirec";
            this.txtdirec.Size = new System.Drawing.Size(100, 20);
            this.txtdirec.TabIndex = 6;
            // 
            // txtapell
            // 
            this.txtapell.Location = new System.Drawing.Point(70, 41);
            this.txtapell.Name = "txtapell";
            this.txtapell.Size = new System.Drawing.Size(100, 20);
            this.txtapell.TabIndex = 5;
            // 
            // txtnomb
            // 
            this.txtnomb.Location = new System.Drawing.Point(70, 9);
            this.txtnomb.Name = "txtnomb";
            this.txtnomb.Size = new System.Drawing.Size(100, 20);
            this.txtnomb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 332);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbc)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnlimp;
        private System.Windows.Forms.Button btnguar;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtdirec;
        private System.Windows.Forms.TextBox txtapell;
        private System.Windows.Forms.TextBox txtnomb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbuscarx;
        private System.Windows.Forms.TextBox txtbusc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbbuscar;
        private System.Windows.Forms.DataGridView dgbc;
    }
}

