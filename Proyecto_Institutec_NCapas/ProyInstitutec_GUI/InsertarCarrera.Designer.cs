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
            chkActivo = new CheckBox();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.Location = new Point(23, 58);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(401, 27);
            txtDescripcion.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 26);
            label1.Name = "label1";
            label1.Size = new Size(219, 21);
            label1.TabIndex = 0;
            label1.Text = "INGRESE NUEVA CARRERA";
            // 
            // cboFacultad
            // 
            cboFacultad.BackColor = SystemColors.ScrollBar;
            cboFacultad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFacultad.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboFacultad.FormattingEnabled = true;
            cboFacultad.Location = new Point(23, 179);
            cboFacultad.Name = "cboFacultad";
            cboFacultad.Size = new Size(397, 29);
            cboFacultad.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(23, 145);
            label5.Name = "label5";
            label5.Size = new Size(206, 21);
            label5.TabIndex = 3;
            label5.Text = "SELECCIONE FACTULTAD";
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(295, 245);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 40);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.FlatStyle = FlatStyle.Flat;
            btnGrabar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGrabar.Location = new Point(164, 245);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(125, 40);
            btnGrabar.TabIndex = 5;
            btnGrabar.Text = "GRABAR";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkActivo.Location = new Point(23, 102);
            chkActivo.Margin = new Padding(4, 3, 4, 3);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(93, 25);
            chkActivo.TabIndex = 2;
            chkActivo.Text = "ACTIVO";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // InsertarCarrera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 311);
            Controls.Add(chkActivo);
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
            Text = "CREAR CARRERA";
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
        private CheckBox chkActivo;
    }
}