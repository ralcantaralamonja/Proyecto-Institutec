namespace ProyInstitutec_GUI
{
    partial class InsertarCarrera
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
            txtDescripcion = new TextBox();
            label1 = new Label();
            cboFacultad = new ComboBox();
            label5 = new Label();
            btnCancelar = new Button();
            btnGrabar = new Button();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(115, 24);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(389, 23);
            txtDescripcion.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 27);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Descripcion:";
            // 
            // cboFacultad
            // 
            cboFacultad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFacultad.FormattingEnabled = true;
            cboFacultad.Location = new Point(115, 71);
            cboFacultad.Name = "cboFacultad";
            cboFacultad.Size = new Size(251, 23);
            cboFacultad.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 71);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 2;
            label5.Text = "Facultad:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(401, 138);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(103, 30);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(263, 138);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(103, 30);
            btnGrabar.TabIndex = 4;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // InsertarCarrera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 198);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(cboFacultad);
            Controls.Add(label5);
            Controls.Add(txtDescripcion);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InsertarCarrera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nueva Carrera";
            Load += InsertarCarrera_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescripcion;
        private Label label1;
        private ComboBox cboFacultad;
        private Label label5;
        private Button btnCancelar;
        private Button btnGrabar;
    }
}