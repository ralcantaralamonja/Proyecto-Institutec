namespace ProyInstitutec_GUI
{
    partial class FrmActualizarAlumno
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
            txtApeMat = new TextBox();
            txtApePat = new TextBox();
            label10 = new Label();
            label2 = new Label();
            cboFacultad = new ComboBox();
            mskTelAlu = new MaskedTextBox();
            mskDNIAlumno = new MaskedTextBox();
            LblCodAlu = new Label();
            btnCancelar = new Button();
            btnGrabar = new Button();
            chkActivo = new RadioButton();
            label9 = new Label();
            label8 = new Label();
            cboCarrera = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            txtCoreAlu = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtApeMat);
            groupBox1.Controls.Add(txtApePat);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboFacultad);
            groupBox1.Controls.Add(mskTelAlu);
            groupBox1.Controls.Add(mskDNIAlumno);
            groupBox1.Controls.Add(LblCodAlu);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnGrabar);
            groupBox1.Controls.Add(chkActivo);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cboCarrera);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtCoreAlu);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(24, 14);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(714, 680);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtApeMat
            // 
            txtApeMat.Location = new Point(169, 192);
            txtApeMat.Name = "txtApeMat";
            txtApeMat.Size = new Size(251, 26);
            txtApeMat.TabIndex = 73;
            // 
            // txtApePat
            // 
            txtApePat.Location = new Point(169, 150);
            txtApePat.Name = "txtApePat";
            txtApePat.Size = new Size(251, 26);
            txtApePat.TabIndex = 72;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(27, 198);
            label10.Name = "label10";
            label10.Size = new Size(132, 20);
            label10.TabIndex = 71;
            label10.Text = "Apellido Materno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 153);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 70;
            label2.Text = "Apellido Paterno:";
            // 
            // cboFacultad
            // 
            cboFacultad.FormattingEnabled = true;
            cboFacultad.Location = new Point(123, 471);
            cboFacultad.Name = "cboFacultad";
            cboFacultad.Size = new Size(332, 28);
            cboFacultad.TabIndex = 69;
            // 
            // mskTelAlu
            // 
            mskTelAlu.Location = new Point(136, 344);
            mskTelAlu.Mask = "999999999";
            mskTelAlu.Name = "mskTelAlu";
            mskTelAlu.Size = new Size(150, 26);
            mskTelAlu.TabIndex = 68;
            // 
            // mskDNIAlumno
            // 
            mskDNIAlumno.Location = new Point(169, 244);
            mskDNIAlumno.Mask = "99999999";
            mskDNIAlumno.Name = "mskDNIAlumno";
            mskDNIAlumno.Size = new Size(117, 26);
            mskDNIAlumno.TabIndex = 67;
            // 
            // LblCodAlu
            // 
            LblCodAlu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LblCodAlu.BorderStyle = BorderStyle.FixedSingle;
            LblCodAlu.Location = new Point(124, 35);
            LblCodAlu.Margin = new Padding(4, 0, 4, 0);
            LblCodAlu.Name = "LblCodAlu";
            LblCodAlu.Size = new Size(95, 30);
            LblCodAlu.TabIndex = 66;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(563, 620);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 65;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(412, 620);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(112, 34);
            btnGrabar.TabIndex = 64;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(123, 528);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(77, 24);
            chkActivo.TabIndex = 16;
            chkActivo.TabStop = true;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 530);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 14;
            label9.Text = "Estado:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 474);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 12;
            label8.Text = "Facultad:";
            // 
            // cboCarrera
            // 
            cboCarrera.FormattingEnabled = true;
            cboCarrera.Location = new Point(123, 411);
            cboCarrera.Name = "cboCarrera";
            cboCarrera.Size = new Size(332, 28);
            cboCarrera.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 414);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 10;
            label7.Text = "Carrera:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 350);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 8;
            label6.Text = "Teléfono";
            // 
            // txtCoreAlu
            // 
            txtCoreAlu.Location = new Point(169, 296);
            txtCoreAlu.Name = "txtCoreAlu";
            txtCoreAlu.Size = new Size(264, 26);
            txtCoreAlu.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 299);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 6;
            label5.Text = "Correo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 250);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 4;
            label4.Text = "DNI:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(169, 92);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(297, 26);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 98);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 30;
            label3.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 63;
            label1.Text = "ID Alumno:";
            // 
            // FrmActualizarAlumno
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 708);
            Controls.Add(groupBox1);
            Name = "FrmActualizarAlumno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Alumno";
            Load += FrmActualizarAlumno_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private Label label1;
        private TextBox txtCoreAlu;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private ComboBox comboBox2;
        private Label label8;
        private ComboBox cboCarrera;
        private Label label7;
        private RadioButton chkActivo;
        private Label label9;
        private Button btnGrabar;
        private Label LblCodAlu;
        private Button btnCancelar;
        private MaskedTextBox mskDNIAlumno;
        private MaskedTextBox mskTelAlu;
        private ComboBox cboFacultad;
        private TextBox txtApeMat;
        private TextBox txtApePat;
        private Label label10;
        private Label label2;
    }
}