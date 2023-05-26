namespace ProyInstitutec_GUI
{
    partial class ActualizarCarrera
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
            btnCancelar = new Button();
            btnGrabar = new Button();
            cboFacultad = new ComboBox();
            label5 = new Label();
            txtDescripcion = new TextBox();
            label1 = new Label();
            lblCodigo = new Label();
            label7 = new Label();
            chkActivo = new CheckBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(372, 205);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(103, 30);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(234, 205);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(103, 30);
            btnGrabar.TabIndex = 8;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // cboFacultad
            // 
            cboFacultad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFacultad.FormattingEnabled = true;
            cboFacultad.Location = new Point(119, 120);
            cboFacultad.Name = "cboFacultad";
            cboFacultad.Size = new Size(218, 23);
            cboFacultad.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 120);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 4;
            label5.Text = "Facultad:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(119, 73);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(356, 23);
            txtDescripcion.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 76);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 2;
            label1.Text = "Descripcion:";
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(119, 30);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(70, 23);
            lblCodigo.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 30);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 0;
            label7.Text = "Código:";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(119, 165);
            chkActivo.Margin = new Padding(4, 3, 4, 3);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(65, 19);
            chkActivo.TabIndex = 7;
            chkActivo.Text = "Activo?";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.Location = new Point(32, 166);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(93, 21);
            label8.TabIndex = 6;
            label8.Text = "Estado:";
            // 
            // ActualizarCarrera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 247);
            Controls.Add(chkActivo);
            Controls.Add(label8);
            Controls.Add(lblCodigo);
            Controls.Add(label7);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(cboFacultad);
            Controls.Add(label5);
            Controls.Add(txtDescripcion);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ActualizarCarrera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Carrera";
            Load += ActualizarCarrera_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGrabar;
        private ComboBox cboFacultad;
        private Label label5;
        private TextBox txtDescripcion;
        private Label label1;
        private Label lblCodigo;
        private Label label7;
        private CheckBox chkActivo;
        internal Label label8;
    }
}