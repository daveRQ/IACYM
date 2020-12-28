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
    public partial class MemberAdd : Form
    {
        public MemberAdd()
        {
            InitializeComponent();
            TextBoxCodigo.Text = Id.ValueId("miembro", "codigo").ToString();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
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
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
                }
            }
        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            bool check = true;
           
            string codigo = Id.ValueId("miembro", "codigo").ToString(); ;
            
            string nombre = TextBoxNombre.Text;
            if(!EvaluateTextBox.EString(nombre, 20, true, "Nombres"))
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
            fch_nacimiento += DateNacimiento.Value.Year.ToString() + "-";
            fch_nacimiento += DateNacimiento.Value.Month.ToString() + "-";
            fch_nacimiento += DateNacimiento.Value.Day.ToString();

            string fch_bautismo = "";
            fch_bautismo += DateBautismo.Value.Year.ToString() + "-";
            fch_bautismo += DateBautismo.Value.Month.ToString() + "-";
            fch_bautismo += DateBautismo.Value.Day.ToString();

            //FOTOOOO
            byte[] imagen = null;
            if (PictureBoxFoto.Image != null)
            {
                imagen = Photo.Image_To_Bytes(PictureBoxFoto.Image);
            }

            bool activo = true;
            if (CheckBoxActivo.Checked == false)
                activo = false;

            int id_iglesia = 1;

            if (check)
            {
                if (imagen == null)
                {
                    SqlConnection conexion = new SqlConnection(General_Values.str_connection);

                    string cadena = "INSERT INTO miembro (codigo, nombre, ap_paterno, ap_materno, dni, estado_civil, provincia, distrito, " +
                        "direccion, referencia, sexo, celular, telefono, email, estudios, fch_nacimiento, fch_bautismo, activo, id_iglesia) " +
                        "values (@codigo, @nombre, @ap_paterno, @ap_materno, @dni, @estado_civil, @provincia, @distrito, @direccion, " +
                        "@referencia, @sexo, @celular, @telefono, @email, @estudios, @fch_nacimiento, @fch_bautismo, @activo, @id_iglesia)";

                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    comando.Parameters.AddWithValue("@codigo", codigo);
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
                    comando.Parameters.AddWithValue("@id_iglesia", id_iglesia);

                    MessageBox.Show("Los datos se guardaron correctamente");

                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();

                    this.Close();
                }
                else
                {
                    SqlConnection conexion = new SqlConnection(General_Values.str_connection);

                    string cadena = "INSERT INTO miembro (codigo, nombre, ap_paterno, ap_materno, dni, estado_civil, provincia, distrito, " +
                        "direccion, referencia, sexo, celular, telefono, email, estudios, fch_nacimiento, fch_bautismo, foto, activo, id_iglesia) " +
                        "values (@codigo, @nombre, @ap_paterno, @ap_materno, @dni, @estado_civil, @provincia, @distrito, @direccion, " +
                        "@referencia, @sexo, @celular, @telefono, @email, @estudios, @fch_nacimiento, @fch_bautismo, @foto, @activo, @id_iglesia)";

                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    comando.Parameters.AddWithValue("@codigo", codigo);
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
                    comando.Parameters.AddWithValue("@id_iglesia", id_iglesia);

                    MessageBox.Show("Los datos se guardaron correctamente");

                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();

                    this.Close();
                }
            }
        }

        // Metodos CHECKBOXs
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
