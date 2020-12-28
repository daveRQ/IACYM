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
    public partial class MissionaryOfferingAdd : Form
    {
        public MissionaryOfferingAdd()
        {
            InitializeComponent();

            TextBoxMes.Text = DateTime.Now.Month.ToString();
            switch (TextBoxMes.Text)
            {
                case "1":
                    TextBoxMes.Text = "Enero";
                    break;
                case "2":
                    TextBoxMes.Text = "Febrero";
                    break;
                case "3":
                    TextBoxMes.Text = "Marzo";
                    break;
                case "4":
                    TextBoxMes.Text = "Abril";
                    break;
                case "5":
                    TextBoxMes.Text = "Mayo";
                    break;
                case "6":
                    TextBoxMes.Text = "Junio";
                    break;
                case "7":
                    TextBoxMes.Text = "Julio";
                    break;
                case "8":
                    TextBoxMes.Text = "Agosto";
                    break;
                case "9":
                    TextBoxMes.Text = "Setiembre";
                    break;
                case "10":
                    TextBoxMes.Text = "Octubre";
                    break;
                case "11":
                    TextBoxMes.Text = "Noviembre";
                    break;
                case "12":
                    TextBoxMes.Text = "Diciembre";
                    break;
            }
            TextBoxAño.Text = DateTime.Now.Year.ToString();
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            bool check = true;

            int id = Id.ValueId("ofrenda_misionera", "id");

            string monto = TextBoxMonto.Text;
            if (!EvaluateTextBox.EDecimal(monto, 10, 3, true, "Monto"))
                check = false;

            string mes = TextBoxMes.Text;
            if (!EvaluateTextBox.EMounth(mes, true, "Mes"))
                check = false;

            string año = TextBoxAño.Text;
            if (!EvaluateTextBox.EYear(año, true, "Año"))
                check = false;

            string fch_emision = "";
            fch_emision += MonthCalendarEmision.SelectionStart.Year.ToString() + "-";
            fch_emision += MonthCalendarEmision.SelectionStart.Month.ToString() + "-";
            fch_emision += MonthCalendarEmision.SelectionStart.Day.ToString();

            string cod_miembro = TextBoxCodigo.Text;
            if (!EvaluateTextBox.EIntPositive(cod_miembro, true, "Codigo"))
                check = false;
            else if (!Id.ExistsId("miembro", "codigo", cod_miembro))
            {
                MessageBox.Show("Codigo no encontrado");
                check = false;
            }


            if (check)
            {
                SqlConnection connection = new SqlConnection(General_Values.str_connection);
                connection.Open();
                string str_consult2 = "INSERT INTO ofrenda_misionera(id, monto, mes, año, fch_emision, cod_miembro) VALUES (" +
                    +id + ", " + monto + ", '" + mes + "', '" + año + "', '" + fch_emision + "', " + cod_miembro + ");";

                SqlCommand consulta2 = new SqlCommand(str_consult2, connection);
                consulta2.ExecuteNonQuery();

                MessageBox.Show("Los datos se guardaron correctamente");
                connection.Close();
                this.Close();
            }
        }
    }
}