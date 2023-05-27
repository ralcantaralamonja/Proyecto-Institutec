namespace ProyInstitutec_GUI
{
    partial class frmLogin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.FromArgb(242, 242, 242);
            txtLogin.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogin.Location = new Point(311, 91);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(398, 31);
            txtLogin.TabIndex = 2;
            txtLogin.Text = "USUARIO";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(242, 242, 242);
            txtPassword.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = SystemColors.WindowText;
            txtPassword.Location = new Point(311, 142);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(398, 31);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "PASSWORD";
            txtPassword.TextChanged += txtPassword_TextChanged;
            txtPassword.KeyPress += txtPassword_KeyPress;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = SystemColors.ControlLight;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = SystemColors.ControlText;
            btnAceptar.Location = new Point(311, 193);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(398, 40);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "INGRESAR";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ControlLight;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(311, 239);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(398, 40);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "SALIR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(88, 183, 213);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 291);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(399, 29);
            label1.Name = "label1";
            label1.Size = new Size(238, 33);
            label1.TabIndex = 7;
            label1.Text = "INSTITUTEC LOGIN";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(764, 291);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmLogin";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INICIAR SESIÓN - INSTITUTEC 2023";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Button btnAceptar;
        private Button btnCancelar;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Label label1;
    }
}