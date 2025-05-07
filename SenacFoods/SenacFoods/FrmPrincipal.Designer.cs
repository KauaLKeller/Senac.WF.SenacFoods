namespace SenacFoods
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnComanda = new Button();
            btnUsuarios = new Button();
            btnPedido = new Button();
            btnCardapio = new Button();
            btnFechar = new Button();
            btnMinimizar = new Button();
            lblMensagem = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnComanda);
            groupBox1.Controls.Add(btnUsuarios);
            groupBox1.Controls.Add(btnPedido);
            groupBox1.Controls.Add(btnCardapio);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(379, 146);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1013, 371);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Senac Foods";
            // 
            // btnComanda
            // 
            btnComanda.BackColor = Color.SeaGreen;
            btnComanda.FlatAppearance.BorderSize = 0;
            btnComanda.Font = new Font("Yu Gothic UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComanda.ForeColor = Color.Black;
            btnComanda.Location = new Point(300, 104);
            btnComanda.Name = "btnComanda";
            btnComanda.Size = new Size(168, 168);
            btnComanda.TabIndex = 3;
            btnComanda.Text = "Comanda";
            btnComanda.UseVisualStyleBackColor = false;
            btnComanda.Click += btnComanda_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.Cyan;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.Font = new Font("Yu Gothic UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuarios.ForeColor = Color.Black;
            btnUsuarios.Location = new Point(800, 104);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(168, 168);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "Usuários";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnPedido
            // 
            btnPedido.BackColor = Color.Aquamarine;
            btnPedido.FlatAppearance.BorderSize = 0;
            btnPedido.Font = new Font("Yu Gothic UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPedido.ForeColor = Color.Black;
            btnPedido.Location = new Point(550, 104);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(168, 168);
            btnPedido.TabIndex = 1;
            btnPedido.Text = "Pedido Cozinha";
            btnPedido.UseVisualStyleBackColor = false;
            btnPedido.Click += btnPedido_Click;
            // 
            // btnCardapio
            // 
            btnCardapio.BackColor = Color.PaleGreen;
            btnCardapio.FlatAppearance.BorderSize = 0;
            btnCardapio.Font = new Font("Yu Gothic UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCardapio.ForeColor = Color.Black;
            btnCardapio.Location = new Point(50, 104);
            btnCardapio.Name = "btnCardapio";
            btnCardapio.Size = new Size(168, 168);
            btnCardapio.TabIndex = 0;
            btnCardapio.Text = "Cardápio";
            btnCardapio.UseVisualStyleBackColor = false;
            btnCardapio.Click += btnCardapio_Click;
            // 
            // btnFechar
            // 
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnFechar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 14F);
            btnFechar.ForeColor = Color.Transparent;
            btnFechar.Location = new Point(1695, 28);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(64, 58);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Segoe UI", 14F);
            btnMinimizar.ForeColor = Color.Transparent;
            btnMinimizar.Location = new Point(1613, 28);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(76, 58);
            btnMinimizar.TabIndex = 23;
            btnMinimizar.Text = "_";
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Segoe UI Variable Display", 21F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMensagem.ForeColor = Color.White;
            lblMensagem.Location = new Point(696, 86);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(274, 56);
            lblMensagem.TabIndex = 24;
            lblMensagem.Text = "lblMensagem";
            lblMensagem.Click += lblMensagem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1771, 720);
            Controls.Add(lblMensagem);
            Controls.Add(btnMinimizar);
            Controls.Add(btnFechar);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FrmPrincipal_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCardapio;
        private Button btnComanda;
        private Button btnUsuarios;
        private Button btnPedido;
        private Button btnFechar;
        private Button btnMinimizar;
        private Label lblMensagem;
    }
}