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
    public partial class OfferingFind : Form
    {
        public OfferingFind()
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

        private void Calculate_Total()
        {
            decimal total = 0;
            for (int i = 0; i < DdataGridViewOfrendas.Rows.Count - 1; ++i)
                total += decimal.Parse(DdataGridViewOfrendas.Rows[i].Cells[2].Value.ToString());

            LabelTotal.Text = total.ToString();
        }

        private void ButtonBuscarOfrenda_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (CheckBoxCulto.Checked == true && CheckBoxMes.Checked == false && CheckBoxAño.Checked == false)
            {
                string culto = TextBoxCulto.Text;
                if (!EvaluateTextBox.EString(culto, 50, true, "Culto"))
                    check = false;
                if (!Id.ExistsString("ofrenda", "culto", culto))
                {
                    MessageBox.Show("No se encontro Nombre de Culto");
                    check = false;
                }
                if (check)
                {
                    SqlConnection connection = new SqlConnection(General_Values.str_connection);
                    connection.Open();
                    string str_consult = "SELECT id, culto, monto, fecha FROM ofrenda WHERE culto = '" + culto + "';" ;
                    SqlCommand consult = new SqlCommand(str_consult, connection);
                    SqlDataReader record = consult.ExecuteReader();
                    DdataGridViewOfrendas.Rows.Clear();
                    while (record.Read())
                    {
                        int n = DdataGridViewOfrendas.Rows.Add();
                        DdataGridViewOfrendas.Rows[n].Cells[0].Value = record["id"];
                        DdataGridViewOfrendas.Rows[n].Cells[1].Value = record["culto"];
                        DdataGridViewOfrendas.Rows[n].Cells[2].Value = record["monto"];
                        DdataGridViewOfrendas.Rows[n].Cells[3].Value = record["fecha"];
                    }
                    connection.Close();
                }
            }

            else if (CheckBoxCulto.Checked == false && CheckBoxMes.Checked == true && CheckBoxAño.Checked == false)
            {
                string mes = TextBoxMes.Text;
                if (!EvaluateTextBox.EMounth(mes, true, "Mes"))
                    check = false;
                if (check)
                {
                    switch (mes)
                    {
                        case "Enero":
                            mes = "1";
                            break;
                        case "Febrero":
                            mes = "2";
                            break;
                        case "Marzo":
                            mes = "3";
                            break;
                        case "Abril":
                            mes = "4";
                            break;
                        case "Mayo":
                            mes = "5";
                            break;
                        case "Junio":
                            mes = "6";
                            break;
                        case "Julio":
                            mes = "7";
                            break;
                        case "Agosto":
                            mes = "8";
                            break;
                        case "Setiembre":
                            mes = "9";
                            break;
                        case "Octubre":
                            mes = "10";
                            break;
                        case "Noviembre":
                            mes = "11";
                            break;
                        case "Diciembre":
                            mes = "12";
                            break;
                    }
                    SqlConnection connection = new SqlConnection(General_Values.str_connection);
                    connection.Open();
                    string str_consult = "SELECT id, culto, monto, fecha FROM ofrenda;";
                    SqlCommand consult = new SqlCommand(str_consult, connection);
                    SqlDataReader record = consult.ExecuteReader();
                    DdataGridViewOfrendas.Rows.Clear();
                    while (record.Read())
                    {
                        DateTime temp = DateTime.Parse(record["fecha"].ToString());
                        if (temp.Month.ToString() == mes)
                        {
                            int n = DdataGridViewOfrendas.Rows.Add();
                            DdataGridViewOfrendas.Rows[n].Cells[0].Value = record["id"];
                            DdataGridViewOfrendas.Rows[n].Cells[1].Value = record["culto"];
                            DdataGridViewOfrendas.Rows[n].Cells[2].Value = record["monto"];
                            DdataGridViewOfrendas.Rows[n].Cells[3].Value = record["fecha"];
                        }
                    }
                    connection.Close();
                }
            }

            else if (CheckBoxCulto.Checked == false && CheckBoxMes.Checked == false && CheckBoxAño.Checked == true)
            {
                string año = TextBoxAño.Text;
                if (!EvaluateTextBox.EYear(año, true, "Año"))
                    check = false;
                if (check)
                {
                    SqlConnection connection = new SqlConnection(General_Values.str_connection);
                    connection.Open();
                    string str_consult = "SELECT id, culto, monto, fecha FROM ofrenda;";
                    SqlCommand consult = new SqlCommand(str_consult, connection);
                    SqlDataReader record = consult.ExecuteReader();
                    DdataGridViewOfrendas.Rows.Clear();
                    while (record.Read())
                    {
                        DateTime temp = DateTime.Parse(record["fecha"].ToString());
                        if (temp.Year.ToString() == año)
                        {
                            int n = DdataGridViewOfrendas.Rows.Add();
                            DdataGridViewOfrendas.Rows[n].Cells[0].Value = record["id"];
                            DdataGridViewOfrendas.Rows[n].Cells[1].Value = record["culto"];
                            DdataGridViewOfrendas.Rows[n].Cells[2].Value = record["monto"];
                            DdataGridViewOfrendas.Rows[n].Cells[3].Value = record["fecha"];
                        }
                    }
                    connection.Close();
                }
            }

            else if (CheckBoxCulto.Checked == true && CheckBoxMes.Checked == true && CheckBoxAño.Checked == false)
            {
                string culto = TextBoxCulto.Text;
                if (!EvaluateTextBox.EString(culto, 50, true, "Culto"))
                    check = false;
                if (!Id.ExistsString("ofrenda", "culto", culto))
                {
                    MessageBox.Show("No se encontro Nombre de Culto");
                    check = false;
                }

                string mes = TextBoxMes.Text;
                if (!EvaluateTextBox.EMounth(mes, true, "Mes"))
                    check = false;

                if (check)
                {
                    switch (mes)
                    {
                        case "Enero":
                            mes = "1";
                            break;
                        case "Febrero":
                            mes = "2";
                            break;
                        case "Marzo":
                            mes = "3";
                            break;
                        case "Abril":
                            mes = "4";
                            break;
                        case "Mayo":
                            mes = "5";
                            break;
                        case "Junio":
                            mes = "6";
                            break;
                        case "Julio":
                            mes = "7";
                            break;
                        case "Agosto":
                            mes = "8";
                            break;
                        case "Setiembre":
                            mes = "9";
                            break;
                        case "Octubre":
                            mes = "10";
                            break;
                        case "Noviembre":
                            mes = "11";
                            break;
                        case "Diciembre":
                            mes = "12";
                            break;
                    }

                    SqlConnection connection = new SqlConnection(General_Values.str_connection);
                    connection.Open();
                    string str_consult = "SELECT id, culto, monto, fecha FROM ofrenda WHERE culto = '" + culto + "';";
                    SqlCommand consult = new SqlCommand(str_consult, connection);
                    SqlDataReader record = consult.ExecuteReader();
                    DdataGridViewOfrendas.Rows.Clear();
                    while (record.Read())
                    {
                        DateTime temp = DateTime.Parse(record["fecha"].ToString());
                        if (temp.Month.ToString() == mes)
                        {
                            int n = DdataGridViewOfrendas.Rows.Add();
                            DdataGridViewOfrendas.Rows[n].Cells[0].Value = record["id"];
                            DdataGridViewOfrendas.Rows[n].Cells[1].Value = record["culto"];
                            DdataGridViewOfrendas.Rows[n].Cells[2].Value = record["monto"];
                            DdataGridViewOfrendas.Rows[n].Cells[3].Value = record["fecha"];
                        }
                    }
                    connection.Close();
                }
            }

            else if (CheckBoxCulto.Checked == true && CheckBoxMes.Checked == false && CheckBoxAño.Checked == true)
            {
                string culto = TextBoxCulto.Text;
                if (!EvaluateTextBox.EString(culto, 50, true, "Culto"))
                    check = false;
                if (!Id.ExistsString("ofrenda", "culto", culto))
                {
                    MessageBox.Show("No se encontro Nombre de Culto");
                    check = false;
                }

                string año = TextBoxAño.Text;
                if (!EvaluateTextBox.EYear(año, true, "Año"))
                    check = false;

                if (check)
                {
                    SqlConnection connection = new SqlConnection(General_Values.str_connection);
                    connection.Open();
                    string str_consult = "SELECT id, culto, monto, fecha FROM ofrenda WHERE culto = '" + culto + "';";
                    SqlCommand consult = new SqlCommand(str_consult, connection);
                    SqlDataReader record = consult.ExecuteReader();
                    DdataGridViewOfrendas.Rows.Clear();
                    while (record.Read())
                    {
                        DateTime temp = DateTime.Parse(record["fecha"].ToString());
                        if (temp.Year.ToString() == año)
                        {
                            int n = DdataGridViewOfrendas.Rows.Add();
                            DdataGridViewOfrendas.Rows[n].Cells[0].Value = record["id"];
                            DdataGridViewOfrendas.Rows[n].Cells[1].Value = record["culto"];
                            DdataGridViewOfrendas.Rows[n].Cells[2].Value = record["monto"];
                            DdataGridViewOfrendas.Rows[n].Cells[3].Value = record["fecha"];
                        }
                    }
                    connection.Close();
                }
            }

            else if (CheckBoxCulto.Checked == false && CheckBoxMes.Checked == true && CheckBoxAño.Checked == true)
            {
                string mes = TextBoxMes.Text;
                if (!EvaluateTextBox.EMounth(mes, true, "Mes"))
                    check = false;

                string año = TextBoxAño.Text;
                if (!EvaluateTextBox.EYear(año, true, "Año"))
                    check = false;

                if (check)
                {
                    switch (mes)
                    {
                        case "Enero":
                            mes = "1";
                            break;
                        case "Febrero":
                            mes = "2";
                            break;
                        case "Marzo":
                            mes = "3";
                            break;
                        case "Abril":
                            mes = "4";
                            break;
                        case "Mayo":
                            mes = "5";
                            break;
                        case "Junio":
                            mes = "6";
                            break;
                        case "Julio":
                            mes = "7";
                            break;
                        case "Agosto":
                            mes = "8";
                            break;
                        case "Setiembre":
                            mes = "9";
                            break;
                        case "Octubre":
                            mes = "10";
                            break;
                        case "Noviembre":
                            mes = "11";
                            break;
                        case "Diciembre":
                            mes = "12";
                            break;
                    }
                    SqlConnection connection = new SqlConnection(General_Values.str_connection);
                    connection.Open();
                    string str_consult = "SELECT id, culto, monto, fecha FROM ofrenda;";
                    SqlCommand consult = new SqlCommand(str_consult, connection);
                    SqlDataReader record = consult.ExecuteReader();
                    DdataGridViewOfrendas.Rows.Clear();
                    while (record.Read())
                    {
                        DateTime temp = DateTime.Parse(record["fecha"].ToString());
                        if (temp.Year.ToString() == año && temp.Month.ToString() == mes)
                        {
                            int n = DdataGridViewOfrendas.Rows.Add();
                            DdataGridViewOfrendas.Rows[n].Cells[0].Value = record["id"];
                            DdataGridViewOfrendas.Rows[n].Cells[1].Value = record["culto"];
                            DdataGridViewOfrendas.Rows[n].Cells[2].Value = record["monto"];
                            DdataGridViewOfrendas.Rows[n].Cells[3].Value = record["fecha"];
                        }
                    }
                    connection.Close();
                }
            }

            else if (CheckBoxCulto.Checked == true && CheckBoxMes.Checked == true && CheckBoxAño.Checked == true)
            {
                string culto = TextBoxCulto.Text;
                if (!EvaluateTextBox.EString(culto, 50, true, "Culto"))
                    check = false;
                if (!Id.ExistsString("ofrenda", "culto", culto))
                {
                    MessageBox.Show("No se encontro Nombre de Culto");
                    check = false;
                }

                string mes = TextBoxMes.Text;
                if (!EvaluateTextBox.EMounth(mes, true, "Mes"))
                    check = false;

                string año = TextBoxAño.Text;
                if (!EvaluateTextBox.EYear(año, true, "Año"))
                    check = false;

                if (check)
                {
                    switch (mes)
                    {
                        case "Enero":
                            mes = "1";
                            break;
                        case "Febrero":
                            mes = "2";
                            break;
                        case "Marzo":
                            mes = "3";
                            break;
                        case "Abril":
                            mes = "4";
                            break;
                        case "Mayo":
                            mes = "5";
                            break;
                        case "Junio":
                            mes = "6";
                            break;
                        case "Julio":
                            mes = "7";
                            break;
                        case "Agosto":
                            mes = "8";
                            break;
                        case "Setiembre":
                            mes = "9";
                            break;
                        case "Octubre":
                            mes = "10";
                            break;
                        case "Noviembre":
                            mes = "11";
                            break;
                        case "Diciembre":
                            mes = "12";
                            break;
                    }
                    SqlConnection connection = new SqlConnection(General_Values.str_connection);
                    connection.Open();
                    string str_consult = "SELECT id, culto, monto, fecha FROM ofrenda WHERE culto = '" + culto + "';";
                    SqlCommand consult = new SqlCommand(str_consult, connection);
                    SqlDataReader record = consult.ExecuteReader();
                    DdataGridViewOfrendas.Rows.Clear();
                    while (record.Read())
                    {
                        DateTime temp = DateTime.Parse(record["fecha"].ToString());
                        if (temp.Year.ToString() == año && temp.Month.ToString() == mes)
                        {
                            int n = DdataGridViewOfrendas.Rows.Add();
                            DdataGridViewOfrendas.Rows[n].Cells[0].Value = record["id"];
                            DdataGridViewOfrendas.Rows[n].Cells[1].Value = record["culto"];
                            DdataGridViewOfrendas.Rows[n].Cells[2].Value = record["monto"];
                            DdataGridViewOfrendas.Rows[n].Cells[3].Value = record["fecha"];
                        }
                    }
                    connection.Close();
                }
            }

            else if (CheckBoxCulto.Checked == false && CheckBoxMes.Checked == false && CheckBoxAño.Checked == false)
            {
                MessageBox.Show("Seleccione alguna opción a Buscar");
            }

            Calculate_Total();
        }

        private void ButtonEliminarCulto_Click(object sender, EventArgs e)
        {
            bool check = true;

            SqlConnection connection = new SqlConnection(General_Values.str_connection);

            connection.Open();
            string str_consult = "SELECT culto FROM ofrenda WHERE culto = '" + TextBoxIdEliminarCulto.Text + "';";
            SqlCommand consult = new SqlCommand(str_consult, connection);
            SqlDataReader record = consult.ExecuteReader();
            if (!record.Read())
                check = false;

            connection.Close();

            if (check)
                Id.DeleteIdRepetidos("ofrenda", "culto", TextBoxIdEliminarCulto.Text);
            else
                MessageBox.Show("Nombre de Culto no encontrado");

            RefreshPersonal();
        }

        private void ButtonEliminarOfrenda_Click(object sender, EventArgs e)
        {
            bool check = true;
            string id = TextBoxIdEliminarOfrenda.Text;
            if (!EvaluateTextBox.EIntPositive(id, true, "ID"))
                check = false;
            if (!Id.ExistsId("ofrenda", "id", id))
            {
                MessageBox.Show("Id ingresado no Existe");
                check = false;
            }

            if (check)
            {
                if (Id.DeleteId("ofrenda", "id", int.Parse(id)))
                    MessageBox.Show("ID eliminado correctamente");
            }
            RefreshPersonal();
        }

        private void ButtonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
