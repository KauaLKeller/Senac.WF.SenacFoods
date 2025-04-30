using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacFoods
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
            var frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void btnCardapio_Click(object sender, EventArgs e)
        {
            var frmCardapio = new FrmCardapio();
            frmCardapio.ShowDialog();
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            var frmComanda = new FrmComanda();
            frmComanda.ShowDialog();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            var frmPedido = new FrmPedidoCozinha();
            frmPedido.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            var frmUsuarios = new FrmUsuario();
            frmUsuarios.ShowDialog();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
