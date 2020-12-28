using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;

namespace IACYM__SGBD.Class
{
    public static class Photo
    {
        //public static byte[] Image_To_Bytes(Image imagen)
        //{
        //    MemoryStream ms = new MemoryStream();
        //    imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
        //    return ms.ToArray();
        //}

        public static byte[] Image_To_Bytes(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }

        public static Image Bytes_To_Image(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image imagenNueva = Image.FromStream(ms);
            ms.Close();
            return imagenNueva;
        }
    }

    public static class General_Values
    {
        public static string server = "HP-DAVE";
        public static string database = "iacym";
        //public static string str_connection = "server=HP-DAVE ; database=iacym ; integrated security = true";
        public static string str_connection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
    }

    public static class Id
    {
        // Error si hay ids menores que no existan
        public static int ValueId(string name_table, string name_id)
        {
            int id = 1;

            SqlConnection connection = new SqlConnection(General_Values.str_connection);
            connection.Open();

            string str_consult = "SELECT COUNT(" + name_id + ") as maximo FROM " + name_table + ";";
            SqlCommand consult = new SqlCommand(str_consult, connection);

            SqlDataReader record = consult.ExecuteReader();
            if (record.Read())
                id = int.Parse(record["maximo"].ToString()) + 1;

            connection.Close();

            return id;
        }

        public static bool DeleteId(string name_table, string name_id, int value_id)
        {
            bool check = false;

            SqlConnection connection = new SqlConnection(General_Values.str_connection);

            connection.Open();
            string str_consult = "SELECT " + name_id + " FROM " + name_table + " WHERE " + name_id + " = " + value_id + ";";
            SqlCommand consult = new SqlCommand(str_consult, connection);
            SqlDataReader record = consult.ExecuteReader();
            if (record.Read())
                check = true;
            else
                check = false;

            connection.Close();


            if (check == true)
            {
                connection.Open();
                string str_consult1 = "DELETE FROM " + name_table + " WHERE " + name_id + " = " + value_id + ";";
                SqlCommand consult1 = new SqlCommand(str_consult1, connection);
                consult1.ExecuteNonQuery();
                connection.Close();


                bool seguir = true;
                value_id += 1;
                while (seguir)
                {
                    connection.Open();
                    string str_consult2 = "SELECT " + name_id + " FROM " + name_table + " WHERE " + name_id + " = " + value_id + ";";
                    SqlCommand consult2 = new SqlCommand(str_consult2, connection);
                    SqlDataReader record2 = consult2.ExecuteReader();
                    if (record2.Read())
                        seguir = true;
                    else
                        seguir = false;
                    connection.Close();

                    if (seguir)
                    {
                        connection.Open();
                        string str_consult3 = "UPDATE " + name_table + " SET " + name_id + " = " + (value_id - 1) + " WHERE " + name_id + " = " + value_id + ";";
                        SqlCommand consult3 = new SqlCommand(str_consult3, connection);
                        consult3.ExecuteNonQuery();
                        connection.Close();
                    }
                    value_id++;
                }
            }

            return check;
        }

        public static bool DeleteIdRepetidos(string name_table, string name_column, string value_column)
        {
            bool check = false;
            int value_id = 0;
            SqlConnection connection = new SqlConnection(General_Values.str_connection);

            connection.Open();
            string str_consult = "SELECT MIN(id) AS minimo  FROM " + name_table + " WHERE " + name_column + " = '" + value_column + "';";
            SqlCommand consult = new SqlCommand(str_consult, connection);
            SqlDataReader record = consult.ExecuteReader();
            if (record.Read())
            {
                value_id = int.Parse(record["minimo"].ToString());
                check = true;
            }
            else
                check = false;
            connection.Close();


            if (check == true)
            {
                int max = 0;
                connection.Open();
                string str_consult_max = "SELECT COUNT(" + name_column + ") as maximo FROM " + name_table + ";";
                SqlCommand consult_max = new SqlCommand(str_consult_max, connection);
                SqlDataReader record_max = consult_max.ExecuteReader();
                if (record_max.Read())
                    max = int.Parse(record_max["maximo"].ToString());
                connection.Close();


                connection.Open();
                string str_consult1 = "DELETE FROM " + name_table + " WHERE " + name_column + " = '" + value_column + "';";
                SqlCommand consult1 = new SqlCommand(str_consult1, connection);
                consult1.ExecuteNonQuery();
                connection.Close();

                bool find = true;

                value_id += 1;
                int cuanto_resto = 1;
                while (value_id <= max)
                {
                    connection.Open();
                    string str_consult2 = "SELECT id FROM " + name_table + " WHERE id = " + value_id + ";";
                    SqlCommand consult2 = new SqlCommand(str_consult2, connection);
                    SqlDataReader record2 = consult2.ExecuteReader();
                    if (record2.Read())
                        find = true;
                    else
                    {
                        cuanto_resto += 1;
                        find = false;
                    }
                    connection.Close();

                    if (find)
                    {
                        connection.Open();
                        string str_consult3 = "UPDATE " + name_table + " SET id = " + (value_id - cuanto_resto) + " WHERE id = " + value_id + ";";
                        SqlCommand consult3 = new SqlCommand(str_consult3, connection);
                        consult3.ExecuteNonQuery();
                        connection.Close();
                    }
                    value_id++;
                }
            }

            return check;
        }

        public static bool ExistsId(string name_table, string name_id, string value_id)
        {
            bool check = true;

            SqlConnection connection = new SqlConnection(General_Values.str_connection);

            connection.Open();
            string str_consult = "SELECT " + name_id + " FROM " + name_table + " WHERE " + name_id + " = " + value_id + ";"; ;
            SqlCommand consult = new SqlCommand(str_consult, connection);
            SqlDataReader record = consult.ExecuteReader();
            if (!record.Read())
                check = false;
                
            connection.Close();

            return check;
        }

        public static bool ExistsString(string name_table, string name_id, string value_id)
        {
            bool check = true;

            SqlConnection connection = new SqlConnection(General_Values.str_connection);

            connection.Open();
            string str_consult = "SELECT " + name_id + " FROM " + name_table + " WHERE " + name_id + " = '" + value_id + "';"; ;
            SqlCommand consult = new SqlCommand(str_consult, connection);
            SqlDataReader record = consult.ExecuteReader();
            if (!record.Read())
                check = false;

            connection.Close();

            return check;
        }
    }

    public static class EvaluateTextBox
    {
        public static bool EString(string cad, int tam, bool requerid, string name_parameter)
        {
            if (requerid && cad.Length == 0)
            {
                MessageBox.Show(name_parameter + " Requerido");
                return false;
            }
            else if (cad.Length > tam)
            {
                MessageBox.Show(name_parameter + " solo admite " + tam.ToString() + " caracteres.\n Usted ingreso " + cad.Length + " caracteres");
                return false;
            }
            return true;
        }

        public static bool EMounth(string cad, bool requerid, string name_parameter)
        {
            string[] mounths = new string[] {"Enero","Febrero","Marzo","Abril","Mayo","Junio",
                                            "Julio","Agosto","Setiembre","Octubre","Noviembre","Diciembre"};
            if (requerid && cad.Length == 0)
            {
                MessageBox.Show(name_parameter + " Requerido");
                return false;
            }

            bool find = false;
            foreach (string i in mounths)
            {
                if (cad == i)
                {
                    find = true;
                    break;
                }
            }

            if (!find)
            {
                MessageBox.Show(name_parameter + ": Dato Errado");
                return false;
            }

            return true;
        }

        public static bool EYear(string cad, bool requerid, string name_parameter)
        {
            if (requerid && cad.Length == 0)
            {
                MessageBox.Show(name_parameter + " Requerido");
                return false;
            }

            int result = 0;
            if (!int.TryParse(cad, out result))
            {
                MessageBox.Show(name_parameter + ": Dato Errado");
                return false;
            }

            if (result < 1900 || result > 2100)
            {
                MessageBox.Show(name_parameter + ": Dato Errado");
                return false;
            }
            return true;
        }

        public static bool EIntPositive(string cad, bool requerid, string name_parameter)
        {
            if (requerid && cad.Length == 0)
            {
                MessageBox.Show(name_parameter + " Requerido");
                return false;
            }

            int result = 0;
            if (!int.TryParse(cad, out result))
            {
                MessageBox.Show(name_parameter + ": Dato Errado");
                return false;
            }

            if (result < 1)
            {
                MessageBox.Show(name_parameter + ": Dato Errado");
                return false;
            }
            return true;
        }

        public static bool EDecimal(string cad, int part_entire, int part_decimal, bool requerid, string name_parameter)
        {
            if (requerid && cad.Length == 0)
            {
                MessageBox.Show(name_parameter + " Requerido");
                return false;
            }

            int only_int = 0;
            if (int.TryParse(cad, out only_int))
            {
                if (cad.Length > part_entire)
                    return false;
                return true;
            }
            else
            {
                if (cad.Contains(","))
                {
                    MessageBox.Show(name_parameter + ": Use . en vez de ,");
                    return false;
                }

                decimal result = 0;
                if (!decimal.TryParse(cad, out result))
                {
                    MessageBox.Show(name_parameter + ": Dato Errado");
                    return false;
                }

                string ent = "";
                string dec = "";

                int position = cad.IndexOf(".");
                ent = cad.Substring(0, position);
                dec = cad.Substring(position + 1, cad.Length - 1 - position);

                if (ent.Length > part_entire || dec.Length > part_decimal)
                {
                    MessageBox.Show(name_parameter + ": Dato Errado");
                    return false;
                }

                return true;
            }
        }
    }
}
