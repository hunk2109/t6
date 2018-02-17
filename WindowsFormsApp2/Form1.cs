using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnguar_Click(object sender, EventArgs e)
        {
            try
            {
                getset mo = new getset();
                conccion da = new conccion();
                mo.nomb = txtnomb.Text;
                mo.apell = txtapell.Text;
                mo.direcc = txtdirec.Text;
                mo.tel = int.Parse(txttel.Text);
                da.guardar(mo);
                MessageBox.Show("Datos guardar");
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnbuscarx_Click(object sender, EventArgs e)
        {
            conccion oper = new conccion();
            if (cmbbuscar.Text == ("ID"))
            {
                dgbc.DataSource = oper.consulataconresul("select * from usuario where u_id like '%" + txtbusc.Text + "%'");


            }
            else if (cmbbuscar.Text == ("Nombre"))
            {
                dgbc.DataSource = oper.consulataconresul("select * from usuario where nombre like '%" + txtbusc.Text + "%'");

            }
            else if(cmbbuscar.Text ==("Apellido"))
            {
                dgbc.DataSource = oper.consulataconresul("select * from usuario where apellido like '%" + txtbusc.Text + "%'");
            }

            else if(cmbbuscar.Text ==("Direccion"))
            {
                dgbc.DataSource = oper.consulataconresul("select * from usuario where direccion like '%" + txtbusc.Text + "%'");
            }

            else if(cmbbuscar.Text ==("Telefono"))
            {
                dgbc.DataSource = oper.consulataconresul("select * from usuario where telefono like '%" + txtbusc.Text + "%'");
            }

            else
            {
                MessageBox.Show("No se encontro nada ");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conccion cnx = new conccion();
            dgbc.DataSource = cnx.consulataconresul("select * from usuario");
        }
    }
}
