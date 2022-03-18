using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.Acessos;
using Datos.Entidades;

namespace Ejercicio_3
{
    public partial class LoginUsuarios : Form
    {
        public LoginUsuarios()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            UserDA userDA = new UserDA();
            Users users = new Users();

            users = userDA.Login(UserTextBox.Text, PaswordTextBox.Text);

            if (users == null)
            {
                MessageBox.Show("Datos erroneos");
                return;
            }

            FrmListaUsers frmListaUsers = new FrmListaUsers();
            frmListaUsers.Show();

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
