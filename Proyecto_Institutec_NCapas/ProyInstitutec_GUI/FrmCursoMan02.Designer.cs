namespace ProyInstitutec_GUI
{
    partial class FrmCursoMan02
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
            label1 = new Label();
            txtIngresarCurso = new TextBox();
            cboCarrera = new ComboBox();
            label2 = new Label();
            chkActivo = new CheckBox();
            btnGrabar = new Button();
            btnCancelar = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 26);
            label1.Name = "label1";
            label1.Size = new Size(198, 21);
            label1.TabIndex = 0;
            label1.Text = "INGRESE NUEVO CURSO";
            // 
            // txtIngresarCurso
            // 
            txtIngresarCurso.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIngresarCurso.Location = new Point(23, 58);
            txtIngresarCurso.Name = "txtIngresarCurso";
            txtIngresarCurso.Size = new Size(401, 27);
            txtIngresarCurso.TabIndex = 1;
            // 
            // cboCarrera
            // 
            cboCarrera.BackColor = SystemColors.ScrollBar;
            cboCarrera.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboCarrera.FormattingEnabled = true;
            cboCarrera.Location = new Point(23, 179);
            cboCarrera.Name = "cboCarrera";
            cboCarrera.Size = new Size(397, 29);
            cboCarrera.TabIndex = 4;
            cboCarrera.SelectedIndexChanged += cboCarrera_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 130);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkActivo.Location = new Point(23, 102);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(93, 25);
            chkActivo.TabIndex = 2;
            chkActivo.Text = "ACTIVO";
            chkActivo.UseVisualStyleBackColor = true;
            chkActivo.CheckedChanged += chkActivo_CheckedChanged;
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = SystemColors.ControlLight;
            btnGrabar.FlatStyle = FlatStyle.Flat;
            btnGrabar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGrabar.Location = new Point(164, 245);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(125, 40);
            btnGrabar.TabIndex = 5;
            btnGrabar.Text = "GRABAR";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ControlLight;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(295, 245);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 40);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 145);
            label3.Name = "label3";
            label3.Size = new Size(191, 21);
            label3.TabIndex = 7;
            label3.Text = "SELECCIONE CARRERA";
            // 
            // FrmCursoMan02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 311);
            Controls.Add(label3);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(chkActivo);
            Controls.Add(label2);
            Controls.Add(cboCarrera);
            Controls.Add(txtIngresarCurso);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCursoMan02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CREAR CURSO ";
            Load += FrmCursoMan02_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIngresarCurso;
        private ComboBox cboCarrera;
        private Label label2;
        private CheckBox chkActivo;
        private Button btnGrabar;
        private Button btnCancelar;
        private Label label3;
    }
}