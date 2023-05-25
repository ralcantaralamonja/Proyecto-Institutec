namespace ProyInstitutec_GUI
{
    partial class FrmCursoMan03
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
            lblCodigo = new Label();
            label7 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            chkActivo = new CheckBox();
            comboBox1 = new ComboBox();
            btnCancelar = new Button();
            btnGrabar = new Button();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(115, 27);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(66, 23);
            lblCodigo.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 35);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 2;
            label7.Text = "Código:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 77);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre Curso:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(115, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(345, 23);
            textBox1.TabIndex = 5;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(334, 27);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(126, 19);
            chkActivo.TabIndex = 16;
            chkActivo.Text = "¿Curso Disponible?";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(32, 121);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(428, 23);
            comboBox1.TabIndex = 17;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(357, 243);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(103, 30);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(219, 243);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(103, 30);
            btnGrabar.TabIndex = 18;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            // 
            // FrmCursoMan03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 299);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(comboBox1);
            Controls.Add(chkActivo);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(lblCodigo);
            Controls.Add(label7);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCursoMan03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCursoMan03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label label7;
        private Label label1;
        private TextBox textBox1;
        private CheckBox chkActivo;
        private ComboBox comboBox1;
        private Button btnCancelar;
        private Button btnGrabar;
    }
}