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
            txtCurso = new TextBox();
            chkActivo = new CheckBox();
            cboCarrera = new ComboBox();
            btnCancelar = new Button();
            btnGrabar = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodigo.Location = new Point(115, 27);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(66, 23);
            lblCodigo.TabIndex = 1;
            lblCodigo.Click += lblCodigo_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(21, 28);
            label7.Name = "label7";
            label7.Size = new Size(86, 21);
            label7.TabIndex = 0;
            label7.Text = "CÓDIGO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 81);
            label1.Name = "label1";
            label1.Size = new Size(175, 21);
            label1.TabIndex = 3;
            label1.Text = "NOMBRE DEL CURSO:";
            // 
            // txtCurso
            // 
            txtCurso.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCurso.Location = new Point(21, 105);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(439, 27);
            txtCurso.TabIndex = 4;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkActivo.Location = new Point(334, 27);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(82, 25);
            chkActivo.TabIndex = 2;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            chkActivo.CheckedChanged += chkActivo_CheckedChanged;
            // 
            // cboCarrera
            // 
            cboCarrera.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboCarrera.FormattingEnabled = true;
            cboCarrera.Location = new Point(21, 175);
            cboCarrera.Name = "cboCarrera";
            cboCarrera.Size = new Size(439, 29);
            cboCarrera.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(334, 231);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 40);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.FlatStyle = FlatStyle.Flat;
            btnGrabar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGrabar.Location = new Point(203, 231);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(125, 40);
            btnGrabar.TabIndex = 6;
            btnGrabar.Text = "GRABAR";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 151);
            label3.Name = "label3";
            label3.Size = new Size(191, 21);
            label3.TabIndex = 9;
            label3.Text = "SELECCIONE CARRERA";
            // 
            // FrmCursoMan03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(483, 299);
            Controls.Add(label3);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(cboCarrera);
            Controls.Add(chkActivo);
            Controls.Add(txtCurso);
            Controls.Add(label1);
            Controls.Add(lblCodigo);
            Controls.Add(label7);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCursoMan03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCursoMan03";
            Load += FrmCursoMan03_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label label7;
        private Label label1;
        private TextBox txtCurso;
        private CheckBox chkActivo;
        private ComboBox cboCarrera;
        private Button btnCancelar;
        private Button btnGrabar;
        private Label label3;
    }
}