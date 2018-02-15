using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class conccion
    {
        SqlConnection cnx = new SqlConnection("server = HECTOJO; database = t6; integrated security = true;");

        public void guardar(getset mo)
        {
            string strl = "guardaru";
            SqlCommand cmd = new SqlCommand(strl, cnx);
            cnx.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nomb", mo.nomb);
            cmd.Parameters.AddWithValue("@apell", mo.apell);
            cmd.Parameters.AddWithValue("@direcc",mo.direcc);
            cmd.Parameters.AddWithValue("@tel", mo.tel);
            cmd.ExecuteNonQuery();
            cnx.Close();

        }

        public DataTable consulataconresul(string strl)
        {
            SqlDataAdapter ad;
            DataTable dt = new DataTable();
            try
            {
                cnx.Open();
                SqlCommand cmd;
                cmd = cnx.CreateCommand();
                cmd.CommandText = strl;
                ad = new SqlDataAdapter(cmd);
                ad.Fill(dt);
            }
            catch (SqlException ex)
            {
                MessageBox.Show (ex.Message);
            }

            cnx.Close();
            return dt;
        }
        


    }
}
