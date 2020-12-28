using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IACYM__SGBD
{
    public partial class CheckToComments : Form
    {
        private int Code;
        public CheckToComments(int codigo)
        {
            InitializeComponent();

            this.Code = codigo;

            Password();
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            if (TextBoxContraseña.Text == "contraseña")
            {
                MemberComments M_C = new MemberComments(this.Code);
                M_C.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña Errada");
                this.Close();
            }
        }

        private void Password()
        {
            // Set to no text.
            TextBoxContraseña.Text = "";
            // The password character is an asterisk.  
            TextBoxContraseña.PasswordChar = '*';
            // The control will allow no more than 14 characters.  
            TextBoxContraseña.MaxLength = 14;
        }
    }
}
