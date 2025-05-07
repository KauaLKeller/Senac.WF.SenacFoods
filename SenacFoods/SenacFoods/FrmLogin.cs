namespace SenacFoods
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            bool loginValido = ValidarLogin(txtUser.Text, txtSenha.Text);
            if (loginValido)
            {
                this.Hide();
                var frmPrincipal = new FrmPrincipal(txtUser.Text, txtSenha.Text);
                frmPrincipal.Show();
            }
        }

        private bool ValidarLogin(string nome, string senha)
        {
            if(nome == "admin" && senha == "123")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Login ou senha inválidos");
            }
                return false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
