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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 19);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingresar Nuevo Curso";
            // 
            // txtIngresarCurso
            // 
            txtIngresarCurso.Location = new Point(23, 48);
            txtIngresarCurso.Name = "txtIngresarCurso";
            txtIngresarCurso.Size = new Size(401, 23);
            txtIngresarCurso.TabIndex = 1;
            // 
            // cboCarrera
            // 
            cboCarrera.FormattingEnabled = true;
            cboCarrera.Location = new Point(23, 150);
            cboCarrera.Name = "cboCarrera";
            cboCarrera.Size = new Size(397, 23);
            cboCarrera.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 132);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 4;
            label2.Text = "Carrera:";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(27, 94);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(125, 19);
            chkActivo.TabIndex = 5;
            chkActivo.Text = "¿Curso Habilitado?";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(275, 245);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 6;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(368, 245);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmCursoMan02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 291);
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
            Text = "FrmCursoMan02";
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
    }
}