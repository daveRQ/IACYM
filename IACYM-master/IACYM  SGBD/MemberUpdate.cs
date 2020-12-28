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
    public partial class MemberUpdate : Form
    {
        private int Code;
        private bool Change;
        public MemberUpdate(int codigo)
        {
            InitializeComponent();
            this.Code = codigo;
            this.Change = false;

            SqlConnection connection = new SqlConnection(General_Values.str_connection);
            connection.Open();


            string str_consult = "SELECT * FROM miembro WHERE codigo = " + Code + ";";

            SqlCommand consult = new SqlCommand(str_consult, connection);
            SqlDataReader record = consult.ExecuteReader();

            while (record.Read())
            {
                TextBoxCodigo.Text = record["codigo"].ToString();
                TextBoxNombre.Text = record["nombre"].ToString();
                TextBoxPaterno.Text = record["ap_paterno"].ToString();
                TextBoxMaterno.Text = record["ap_materno"].ToString();
                TextBoxDni.Text = record["dni"].ToString();

                //  0 = soltero    1 = casado    2 = viudo    3 = divorciado
                int e_civil = int.Parse(record["estado_civil"].ToString());
                if (e_civil == 0)
                    CheckBoxSoltero.Checked = true;
                else if (e_civil == 1)
                    CheckBoxCasado.Checked = true;
                else if (e_civil == 2)
                    CheckBoxViudo.Checked = true;
                else if (e_civil == 3)
                    CheckBoxDivorciado.Checked = true;

                TextBoxProvincia.Text = record["provincia"].ToString();
                TextBoxDistrito.Text = record["distrito"].ToString();
                TextBoxDireccion.Text = record["direccion"].ToString();
                TextBoxReferencia.Text = record["referencia"].ToString();

                // 0 = hombre    1 = mujer
                bool sexo = bool.Parse(record["sexo"].ToString());
                if (sexo == false)
                    CheckBoxMasculino.Checked = true;
                else if (sexo == true)
                    CheckBoxFemenino.Checked = true;

                TextBoxCelular.Text = record["celular"].ToString();
                TextBoxTelefono.Text = record["telefono"].ToString();
                TextBoxEmail.Text = record["email"].ToString();
                TextBoxEstudios.Text = record["estudios"].ToString();

                DateTimeNacimiento.Text = record["fch_nacimiento"].ToString();

                DateTimeBautismo.Text = record["fch_bautismo"].ToString();

                bool estado = bool.Parse(record["activo"].ToString());
                if (estado == false)
                    CheckBoxActivo.Checked = false;
                else if (estado == true)
                    CheckBoxActivo.Checked = true;

                try
                {
                    byte[] datos = (byte[])record["foto"];
                    PictureBoxFoto.Image = Photo.Bytes_To_Image(datos);
                }
                catch
                {

                }

            }
            connection.Close();
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonFoto_Click(object sender, EventArgs e)
        {
            using (var fd = new OpenFileDialog())
            {
                try
                {
                    if (fd.ShowDialog() == DialogResult.OK)
                    {
                        string imagen = fd.FileName;
                        PictureBoxFoto.Image = Image.FromFile(imagen);
                        this.Change = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
                }
            }
        }

        private void ButtonModificar_Click(object sender, EventArgs e)
        {
            bool check = true;

            string nombre = TextBoxNombre.Text;
            if (!EvaluateTextBox.EString(nombre, 20, true, "Nombres"))
                check = false;

            string ap_paterno = TextBoxPaterno.Text;
            if (!EvaluateTextBox.EString(ap_paterno, 10, true, "Apellido Paterno"))
                check = false;

            string ap_materno = TextBoxMaterno.Text;
            if (!EvaluateTextBox.EString(ap_materno, 10, true, "Apellido Materno"))
                check = false;

            string dni = TextBoxDni.Text;
            if (!EvaluateTextBox.EString(dni, 8, true, "DNI"))
                check = false;

            //  0 = soltero    1 = casado    2 = viudo    3 = divorciado
            int estado_civil = -1;
            if (CheckBoxSoltero.Checked == true)
                estado_civil = 0;
            else if (CheckBoxCasado.Checked == true)
                estado_civil = 1;
            else if (CheckBoxViudo.Checked == true)
                estado_civil = 2;
            else if (CheckBoxDivorciado.Checked == true)
                estado_civil = 3;

            if (estado_civil == -1)
            {
                MessageBox.Show("Estado Civl Requerido");
                check = false;
            }



            string provincia = TextBoxProvincia.Text;
            if (!EvaluateTextBox.EString(provincia, 30, true, "Provincia"))
                check = false;

            string distrito = TextBoxDistrito.Text;
            if (!EvaluateTextBox.EString(distrito, 30, true, "Distrito"))
                check = false;

            string direccion = TextBoxDireccion.Text;
            if (!EvaluateTextBox.EString(direccion, 50, true, "Dirección"))
                check = false;

            string referencia = TextBoxReferencia.Text;
            if (!EvaluateTextBox.EString(referencia, 40, false, "Referencia"))
                check = false;

            // 0 = hombre    1 = mujer
            bool sexo = false;
            if (CheckBoxFemenino.Checked == true)
                sexo = true;
            if (CheckBoxFemenino.Checked == false && CheckBoxMasculino.Checked == false)
            {
                MessageBox.Show("Sexo Requerido");
                check = false;
            }

            string celular = TextBoxCelular.Text;
            if (!EvaluateTextBox.EString(celular, 12, false, "Celular"))
                check = false;

            string telefono = TextBoxTelefono.Text;
            if (!EvaluateTextBox.EString(telefono, 10, false, "Telefono"))
                check = false;

            string email = TextBoxEmail.Text;
            if (!EvaluateTextBox.EString(email, 40, false, "E-mail"))
                check = false;

            string estudios = TextBoxEstudios.Text;
            if (!EvaluateTextBox.EString(estudios, 50, false, "Estudios"))
                check = false;


            string fch_nacimiento = "";
            fch_nacimiento += DateTimeNacimiento.Value.Year.ToString() + "-";
            fch_nacimiento += DateTimeNacimiento.Value.Month.ToString() + "-";
            fch_nacimiento += DateTimeNacimiento.Value.Day.ToString();

            string fch_bautismo = "";
            fch_bautismo += DateTimeBautismo.Value.Year.ToString() + "-";
            fch_bautismo += DateTimeBautismo.Value.Month.ToString() + "-";
            fch_bautismo += DateTimeBautismo.Value.Day.ToString();

            //FOTOOOO

            byte[] imagen = null;
            if (this.Change)
            {
                imagen = Photo.Image_To_Bytes(PictureBoxFoto.Image);
            }

            bool activo = true;
            if (CheckBoxActivo.Checked == false)
                activo = false;

            if (check)
            {
                SqlConnection connection = new SqlConnection(General_Values.str_connection);
                connection.Open();
                //string str_consult = "UPDATE miembro SET " +
                ////"codigo=" + TextBoxCodigo.Text + ", " +
                //"nombre='" + TextBoxNombre.Text + "', " +
                //"ap_paterno='" + TextBoxPaterno.Text + "', " +
                //"ap_materno='" + TextBoxMaterno.Text + "', " +
                //"dni='" + TextBoxDni.Text + "', " +
                //"estado_civil=" + estado_civil + ", " +
                //"provincia='" + TextBoxProvincia.Text + "', " +
                //"distrito='" + TextBoxDistrito.Text + "', " +
                //"direccion='" + TextBoxDistrito.Text + "', " +
                //"referencia='" + TextBoxReferencia.Text + "', " +
                //"sexo='" + sexo + "', " +
                //"celular='" + TextBoxCelular.Text + "', " +
                //"telefono='" + TextBoxTelefono.Text + "', " +
                //"email='" + TextBoxEmail.Text + "', " +
                //"estudios='" + TextBoxEstudios.Text + "', " +
                //"fch_nacimiento='" + fch_nacimiento + "', " +
                //"fch_bautismo='" + fch_bautismo + "', " +
                //"activo='" + activo + "'" +
                //"WHERE codigo = " + this.Code + "; ";
                string str_consult = "";
                SqlCommand comando;
                if (this.Change)
                {
                    str_consult = "UPDATE miembro SET nombre=@nombre, ap_paterno=@ap_paterno, ap_materno=@ap_materno, dni=@dni, estado_civil=@estado_civil, " +
                        "provincia=@provincia, distrito=@distrito, direccion=@direccion, referencia=@referencia, sexo=@sexo, celular=@celular, " +
                        "telefono=@telefono, email=@email, estudios=@estudios, fch_nacimiento=@fch_nacimiento, fch_bautismo=@fch_bautismo, foto=@foto, " +
                        "activo=@activo WHERE codigo=@codigo; ";

                    comando = new SqlCommand(str_consult, connection);

                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@ap_paterno", ap_paterno);
                    comando.Parameters.AddWithValue("@ap_materno", ap_materno);
                    comando.Parameters.AddWithValue("@dni", dni);
                    comando.Parameters.AddWithValue("@estado_civil", estado_civil);
                    comando.Parameters.AddWithValue("@provincia", provincia);
                    comando.Parameters.AddWithValue("@distrito", distrito);
                    comando.Parameters.AddWithValue("@direccion", direccion);
                    comando.Parameters.AddWithValue("@referencia", referencia);
                    comando.Parameters.AddWithValue("@sexo", sexo);
                    comando.Parameters.AddWithValue("@celular", celular);
                    comando.Parameters.AddWithValue("@telefono", telefono);
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@estudios", estudios);
                    comando.Parameters.AddWithValue("@fch_nacimiento", fch_nacimiento);
                    comando.Parameters.AddWithValue("@fch_bautismo", fch_bautismo);
                    comando.Parameters.AddWithValue("@foto", imagen);
                    comando.Parameters.AddWithValue("@activo", activo);
                    comando.Parameters.AddWithValue("@codigo", this.Code);
                }
                else
                {
                    str_consult = "UPDATE miembro SET nombre=@nombre, ap_paterno=@ap_paterno, ap_materno=@ap_materno, dni=@dni, estado_civil=@estado_civil, " +
                        "provincia=@provincia, distrito=@distrito, direccion=@direccion, referencia=@referencia, sexo=@sexo, celular=@celular, " +
                        "telefono=@telefono, email=@email, estudios=@estudios, fch_nacimiento=@fch_nacimiento, fch_bautismo=@fch_bautismo, " +
                        "activo=@activo WHERE codigo=@codigo; ";

                    comando = new SqlCommand(str_consult, connection);

                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@ap_paterno", ap_paterno);
                    comando.Parameters.AddWithValue("@ap_materno", ap_materno);
                    comando.Parameters.AddWithValue("@dni", dni);
                    comando.Parameters.AddWithValue("@estado_civil", estado_civil);
                    comando.Parameters.AddWithValue("@provincia", provincia);
                    comando.Parameters.AddWithValue("@distrito", distrito);
                    comando.Parameters.AddWithValue("@direccion", direccion);
                    comando.Parameters.AddWithValue("@referencia", referencia);
                    comando.Parameters.AddWithValue("@sexo", sexo);
                    comando.Parameters.AddWithValue("@celular", celular);
                    comando.Parameters.AddWithValue("@telefono", telefono);
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@estudios", estudios);
                    comando.Parameters.AddWithValue("@fch_nacimiento", fch_nacimiento);
                    comando.Parameters.AddWithValue("@fch_bautismo", fch_bautismo);
                    comando.Parameters.AddWithValue("@activo", activo);
                    comando.Parameters.AddWithValue("@codigo", this.Code);
                }


                comando.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Modificación Realizada con Exito");
                this.Close();
            }           
        }


        // Metodos CHECKBOX
        private void CheckBoxSoltero_Click(object sender, EventArgs e)
        {
            CheckBoxCasado.Checked = false;
            CheckBoxViudo.Checked = false;
            CheckBoxDivorciado.Checked = false;
        }

        private void CheckBoxCasado_Click(object sender, EventArgs e)
        {
            CheckBoxSoltero.Checked = false;
            CheckBoxViudo.Checked = false;
            CheckBoxDivorciado.Checked = false;
        }

        private void CheckBoxViudo_Click(object sender, EventArgs e)
        {
            CheckBoxSoltero.Checked = false;
            CheckBoxCasado.Checked = false;
            CheckBoxDivorciado.Checked = false;
        }

        private void CheckBoxDivorciado_Click(object sender, EventArgs e)
        {
            CheckBoxSoltero.Checked = false;
            CheckBoxCasado.Checked = false;
            CheckBoxViudo.Checked = false;
        }

        private void CheckBoxMasculino_Click(object sender, EventArgs e)
        {
            CheckBoxFemenino.Checked = false;
        }

        private void CheckBoxFemenino_Click(object sender, EventArgs e)
        {
            CheckBoxMasculino.Checked = false;
        }
    }
}
