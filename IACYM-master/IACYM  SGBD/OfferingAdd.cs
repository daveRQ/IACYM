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
using IACYM__SGBD.Class;

namespace IACYM__SGBD
{
    public partial class OfferingAdd : Form
    {
        public OfferingAdd()
        {
            InitializeComponent();
            RefreshPersonal();
        }

        private void RefreshPersonal()
        {
            SqlConnection conexion = new SqlConnection(General_Values.str_connection);
            conexion.Open();
            string str_consult = "SELECT DISTINCT culto FROM ofrenda;";
            SqlCommand consult = new SqlCommand(str_consult, conexion);
            SqlDataReader record = consult.ExecuteReader();

            DataGridViewCultos.Rows.Clear();
            while (record.Read())
            {
                int n = DataGridViewCultos.Rows.Add();
                DataGridViewCultos.Rows[n].Cells[0].Value = record["culto"];
            }
            conexion.Close();
        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            bool check = true;

            int id = Id.ValueId("ofrenda", "id");
            
            string culto = TextBoxCulto.Text;
            if (!EvaluateTextBox.EString(culto, 50, true, "Nombre de Culto"))
                check = false;

            string monto = TextBoxMonto.Text;
            if (!EvaluateTextBox.EDecimal(monto, 10, 3, true, "monto"))
                check = false;

            string fecha = "";  
            fecha += MonthCalendarEmision.SelectionStart.Year.ToString() + "-";
            fecha += MonthCalendarEmision.SelectionStart.Month.ToString() + "-";
            fecha += MonthCalendarEmision.SelectionStart.Day.ToString();

            int id_iglesia = 1;
            if (check)
            {
                SqlConnection conexion = new SqlConnection(General_Values.str_connection);
                conexion.Open();
                string str_consult = "INSERT INTO ofrenda(id, culto, monto, fecha, id_iglesia) VALUES(" +
                       id + ", '" + culto + "', " + monto + ", '" + fecha + "', " + id_iglesia + ");";
                SqlCommand consult = new SqlCommand(str_consult, conexion);
                consult.ExecuteNonQuery();

                conexion.Close();

                MessageBox.Show("Los datos se guardaron correctamente");
                this.Close();
            }            
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
