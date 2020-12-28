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
    public partial class MemberComments : Form
    {
        private int Code;
        public MemberComments(int codigo)
        {
            InitializeComponent();
            Code = codigo;

            RefreshPersonal();
        }

        private void RefreshPersonal()
        {
            SqlConnection connection = new SqlConnection(General_Values.str_connection);
            connection.Open();

            string str_consult = "SELECT id, fecha FROM comentario WHERE cod_miembro = " + Code + ";";
            SqlCommand consult = new SqlCommand(str_consult, connection);
            SqlDataReader record = consult.ExecuteReader();

            DataGridViewComentarios.Rows.Clear();
            while (record.Read())
            {
                int n = DataGridViewComentarios.Rows.Add();
                DataGridViewComentarios.Rows[n].Cells[0].Value = record["id"];
                DataGridViewComentarios.Rows[n].Cells[1].Value = record["fecha"].ToString();
            }
            connection.Close();

        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            bool check = true;

            int id = Id.ValueId("comentario", "id");
            string fecha = "";
            fecha += DateTime.Now.Year.ToString() + "-";
            fecha += DateTime.Now.Month.ToString() + "-";
            fecha += DateTime.Now.Day.ToString() + " ";
            fecha += DateTime.Now.Hour.ToString() + ":";
            fecha += DateTime.Now.Minute.ToString() + ":";
            fecha += DateTime.Now.Second.ToString();
            string comentario = TextBoxAgregarComentario.Text;

            if (!EvaluateTextBox.EString(comentario, 200, true, "Comentario"))
                check = false;

            if (check)
            {
                SqlConnection connection = new SqlConnection(General_Values.str_connection);

                connection.Open();
                string str_consult = "INSERT INTO comentario(id, fecha, comentario, cod_miembro) VALUES(" + id + ", '" + fecha + "', '" + comentario + "', " + this.Code + ");";
                SqlCommand consult = new SqlCommand(str_consult, connection);
                consult.ExecuteNonQuery();
                connection.Close();

                TextBoxAgregarComentario.Clear();
                MessageBox.Show("Comentario Agregado Satisfactoriamente");
                RefreshPersonal();
            }
        }

        private void ButtonBorrar_Click(object sender, EventArgs e)
        {
            bool check = true;

            string id = TextBoxIdBorrar.Text;

            if (!EvaluateTextBox.EIntPositive(id, true, "ID"))
                check = false;

            if (check)
            {
                if (Id.DeleteId("comentario", "id", int.Parse(id)))
                    MessageBox.Show("Borrado Exitoso");
                else
                    MessageBox.Show("ID Ingresado INCORRECTO");
                RefreshPersonal();
            }
        }

        private void ButtonVerComentarios_Click(object sender, EventArgs e)
        {
            bool check = true;
            string id = TextBoxId.Text;

            if (!EvaluateTextBox.EIntPositive(id, true, "ID"))
                check = false;

            if (check)
            {
                SqlConnection connection = new SqlConnection(General_Values.str_connection);

                connection.Open();
                string str_consult = "SELECT comentario FROM comentario WHERE id = " + id + ";";
                SqlCommand consult = new SqlCommand(str_consult, connection);
                SqlDataReader record = consult.ExecuteReader();

                if (record.Read())
                    TextBoxVerComentario.Text = record["comentario"].ToString();
                else
                    MessageBox.Show("ID ingresado INCORRECTO");
            
                connection.Close();
            }
        }

        private void ButtonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
