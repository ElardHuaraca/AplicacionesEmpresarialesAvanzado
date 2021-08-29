using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class frmLogin : Form
    {
        private readonly User[] users = {
            new User{
                username = "elard",
                password = "123456"
            },
            new User{
                username = "user01",
                password = "123456"
            }
        };

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            bool sta = false;
            for (int i = 0; i < users.Length; i++)
            {
                if (txtUsuario.Text.Equals(users[i].username) && txtPassword.Text.Equals(users[i].password))
                {
                    sta = true;
                }
            }
            if (sta)
            {
                PrincipalMDI pricipal = new PrincipalMDI();
                pricipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error usuario Y/O contraseña incorrecta");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
