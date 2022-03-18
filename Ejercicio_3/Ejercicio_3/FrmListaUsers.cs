using Datos.Acessos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class FrmListaUsers : Form
    {
        public FrmListaUsers()
        {
            InitializeComponent();
        }
        UserDA userDA = new UserDA();


        private void FrmListaUsers_Load(object sender, EventArgs e)
        {
            ListarUsers();
        }

        private void ListarUsers()
        {
            ListaUsersDataGridView.DataSource = userDA.Listausers();

        }
    }
}
