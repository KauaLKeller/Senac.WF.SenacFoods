namespace SenacFoods
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            btnMinimizar = new Button();
            btnFechar = new Button();
            buttonEntrar = new Button();
            txtSenha = new TextBox();
            txtUser = new TextBox();
            label1 = new Label();
            label3 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 711);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnMinimizar);
            panel2.Controls.Add(btnFechar);
            panel2.Controls.Add(buttonEntrar);
            panel2.Controls.Add(txtSenha);
            panel2.Controls.Add(txtUser);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(872, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(878, 711);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Segoe UI", 14F);
            btnMinimizar.ForeColor = Color.Transparent;
            btnMinimizar.Location = new Point(710, 12);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(76, 58);
            btnMinimizar.TabIndex = 22;
            btnMinimizar.Text = "_";
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimize_Click;
            // 
            // btnFechar
            // 
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnFechar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 14F);
            btnFechar.ForeColor = Color.Transparent;
            btnFechar.Location = new Point(792, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(64, 58);
            btnFechar.TabIndex = 21;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // buttonEntrar
            // 
            buttonEntrar.FlatAppearance.BorderColor = Color.WhiteSmoke;
            buttonEntrar.FlatAppearance.BorderSize = 3;
            buttonEntrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            buttonEntrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            buttonEntrar.FlatStyle = FlatStyle.Flat;
            buttonEntrar.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEntrar.ForeColor = Color.White;
            buttonEntrar.Location = new Point(60, 602);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(271, 53);
            buttonEntrar.TabIndex = 19;
            buttonEntrar.Text = "Entrar";
            buttonEntrar.UseVisualStyleBackColor = true;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.Black;
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("PMingLiU-ExtB", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = Color.White;
            txtSenha.Location = new Point(67, 198);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(532, 36);
            txtSenha.TabIndex = 2;
            txtSenha.Text = "SENHA";
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.Black;
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("PMingLiU-ExtB", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUser.ForeColor = Color.White;
            txtUser.Location = new Point(67, 73);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(532, 36);
            txtUser.TabIndex = 0;
            txtUser.Text = "USUÁRIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(67, 89);
            label1.Name = "label1";
            label1.Size = new Size(516, 25);
            label1.TabIndex = 18;
            label1.Text = "________________________________________________________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(60, 212);
            label3.Name = "label3";
            label3.Size = new Size(516, 25);
            label3.TabIndex = 20;
            label3.Text = "________________________________________________________________________";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1750, 711);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            Text = "Form1";
            Load += FrmLogin_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private TextBox txtSenha;
        private Label label1;
        private Button buttonEntrar;
        private Label label3;
        private TextBox txtUser;
        private Button btnFechar;
        private Button btnMinimizar;
    }
}
