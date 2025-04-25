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
            textBox1 = new TextBox();
            TextSenha = new TextBox();
            label1 = new Label();
            buttonEntrar = new Button();
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
            panel1.Size = new Size(368, 671);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonEntrar);
            panel2.Controls.Add(TextSenha);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(401, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(878, 671);
            panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("PMingLiU-ExtB", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(67, 73);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(532, 36);
            textBox1.TabIndex = 0;
            textBox1.Text = "USUÁRIO";
            // 
            // TextSenha
            // 
            TextSenha.BackColor = Color.Black;
            TextSenha.BorderStyle = BorderStyle.None;
            TextSenha.Font = new Font("PMingLiU-ExtB", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TextSenha.ForeColor = Color.White;
            TextSenha.Location = new Point(67, 198);
            TextSenha.Multiline = true;
            TextSenha.Name = "TextSenha";
            TextSenha.Size = new Size(532, 36);
            TextSenha.TabIndex = 2;
            TextSenha.Text = "SENHA";
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
            // buttonEntrar
            // 
            buttonEntrar.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            buttonEntrar.FlatAppearance.BorderSize = 0;
            buttonEntrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            buttonEntrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            buttonEntrar.FlatStyle = FlatStyle.Flat;
            buttonEntrar.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEntrar.ForeColor = Color.White;
            buttonEntrar.Location = new Point(67, 288);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(271, 53);
            buttonEntrar.TabIndex = 19;
            buttonEntrar.Text = "Entrar";
            buttonEntrar.UseVisualStyleBackColor = true;
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
            ClientSize = new Size(1279, 671);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private TextBox TextSenha;
        private Label label1;
        private Button buttonEntrar;
        private Label label3;
    }
}
