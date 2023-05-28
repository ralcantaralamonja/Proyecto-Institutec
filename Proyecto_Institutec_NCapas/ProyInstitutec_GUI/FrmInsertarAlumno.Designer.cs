namespace ProyInstitutec_GUI
{
    partial class FrmInsertarAlumno
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
            txtNombre = new TextBox();
            label2 = new Label();
            txtApePat = new TextBox();
            label3 = new Label();
            txtApeMat = new TextBox();
            gpbSexoAlu = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cboDep = new ComboBox();
            cboProvincia = new ComboBox();
            cboDistrito = new ComboBox();
            groupBox2 = new GroupBox();
            txtCorreoAlu = new TextBox();
            mskTelAlu = new MaskedTextBox();
            dtpFecha_Nac = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            button1 = new Button();
            btnCancelar = new Button();
            chkActivo = new CheckBox();
            label10 = new Label();
            mskDNIAlu = new MaskedTextBox();
            label11 = new Label();
            cboCarrera = new ComboBox();
            label12 = new Label();
            cboFacultad = new ComboBox();
            optM = new RadioButton();
            optF = new RadioButton();
            gpbSexoAlu.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 30);
            label1.TabIndex = 0;
            label1.Text = "NOMBRES:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(256, 37);
            txtNombre.Margin = new Padding(4, 4, 4, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(585, 37);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 113);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(247, 30);
            label2.TabIndex = 2;
            label2.Text = "APELLIDO PATERNO:";
            // 
            // txtApePat
            // 
            txtApePat.Location = new Point(297, 110);
            txtApePat.Margin = new Padding(4, 4, 4, 4);
            txtApePat.Name = "txtApePat";
            txtApePat.Size = new Size(267, 37);
            txtApePat.TabIndex = 3;
            txtApePat.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 197);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(256, 30);
            label3.TabIndex = 4;
            label3.Text = "APELLIDO MATERNO:";
            // 
            // txtApeMat
            // 
            txtApeMat.Location = new Point(297, 194);
            txtApeMat.Margin = new Padding(4, 4, 4, 4);
            txtApeMat.Name = "txtApeMat";
            txtApeMat.Size = new Size(267, 37);
            txtApeMat.TabIndex = 5;
            // 
            // gpbSexoAlu
            // 
            gpbSexoAlu.Controls.Add(optF);
            gpbSexoAlu.Controls.Add(optM);
            gpbSexoAlu.Location = new Point(631, 82);
            gpbSexoAlu.Margin = new Padding(4, 4, 4, 4);
            gpbSexoAlu.Name = "gpbSexoAlu";
            gpbSexoAlu.Padding = new Padding(4, 4, 4, 4);
            gpbSexoAlu.Size = new Size(420, 180);
            gpbSexoAlu.TabIndex = 6;
            gpbSexoAlu.TabStop = false;
            gpbSexoAlu.Text = "GÉNERO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 382);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(211, 30);
            label4.TabIndex = 7;
            label4.Text = "DEPARTAMENTO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 442);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(154, 30);
            label5.TabIndex = 8;
            label5.Text = "PROVINCIA:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 503);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(120, 30);
            label6.TabIndex = 9;
            label6.Text = "DISTRITO:";
            // 
            // cboDep
            // 
            cboDep.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDep.FormattingEnabled = true;
            cboDep.Location = new Point(256, 372);
            cboDep.Margin = new Padding(4, 4, 4, 4);
            cboDep.Name = "cboDep";
            cboDep.Size = new Size(353, 38);
            cboDep.TabIndex = 10;
            // 
            // cboProvincia
            // 
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(256, 432);
            cboProvincia.Margin = new Padding(4, 4, 4, 4);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(353, 38);
            cboProvincia.TabIndex = 11;
            // 
            // cboDistrito
            // 
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(256, 495);
            cboDistrito.Margin = new Padding(4, 4, 4, 4);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(353, 38);
            cboDistrito.TabIndex = 12;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCorreoAlu);
            groupBox2.Controls.Add(mskTelAlu);
            groupBox2.Controls.Add(dtpFecha_Nac);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(46, 560);
            groupBox2.Margin = new Padding(4, 4, 4, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 4, 4, 4);
            groupBox2.Size = new Size(920, 220);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "DATOS PERSONALES";
            // 
            // txtCorreoAlu
            // 
            txtCorreoAlu.Location = new Point(316, 47);
            txtCorreoAlu.Margin = new Padding(4, 4, 4, 4);
            txtCorreoAlu.Name = "txtCorreoAlu";
            txtCorreoAlu.Size = new Size(481, 37);
            txtCorreoAlu.TabIndex = 6;
            txtCorreoAlu.TextChanged += txtCorreoAlu_TextChanged;
            // 
            // mskTelAlu
            // 
            mskTelAlu.Location = new Point(316, 164);
            mskTelAlu.Margin = new Padding(4, 4, 4, 4);
            mskTelAlu.Mask = "999999999";
            mskTelAlu.Name = "mskTelAlu";
            mskTelAlu.Size = new Size(208, 37);
            mskTelAlu.TabIndex = 5;
            // 
            // dtpFecha_Nac
            // 
            dtpFecha_Nac.CustomFormat = "dd/MM/yyyy ";
            dtpFecha_Nac.Format = DateTimePickerFormat.Short;
            dtpFecha_Nac.Location = new Point(472, 106);
            dtpFecha_Nac.Margin = new Padding(4, 4, 4, 4);
            dtpFecha_Nac.Name = "dtpFecha_Nac";
            dtpFecha_Nac.Size = new Size(231, 37);
            dtpFecha_Nac.TabIndex = 4;
            dtpFecha_Nac.Value = new DateTime(2023, 5, 26, 0, 0, 0, 0);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(178, 164);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(140, 30);
            label9.TabIndex = 2;
            label9.Text = "TELÉFONO:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(178, 113);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(296, 30);
            label8.TabIndex = 1;
            label8.Text = "FECHA DE NACIMIENTO:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(178, 50);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(125, 30);
            label7.TabIndex = 0;
            label7.Text = "CORREO:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Location = new Point(631, 799);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(179, 67);
            button1.TabIndex = 14;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ControlLight;
            btnCancelar.Location = new Point(829, 799);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(179, 67);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(759, 441);
            chkActivo.Margin = new Padding(4, 4, 4, 4);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(131, 34);
            chkActivo.TabIndex = 16;
            chkActivo.Text = "ACTIVO";
            chkActivo.UseVisualStyleBackColor = true;
            chkActivo.CheckedChanged += chkActivo_CheckedChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(42, 263);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(62, 30);
            label10.TabIndex = 17;
            label10.Text = "DNI:";
            // 
            // mskDNIAlu
            // 
            mskDNIAlu.Location = new Point(165, 260);
            mskDNIAlu.Margin = new Padding(4, 4, 4, 4);
            mskDNIAlu.Mask = "99999999";
            mskDNIAlu.Name = "mskDNIAlu";
            mskDNIAlu.Size = new Size(208, 37);
            mskDNIAlu.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(42, 330);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(132, 30);
            label11.TabIndex = 19;
            label11.Text = "CARRERA:";
            // 
            // cboCarrera
            // 
            cboCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCarrera.FormattingEnabled = true;
            cboCarrera.Location = new Point(256, 320);
            cboCarrera.Margin = new Padding(4, 4, 4, 4);
            cboCarrera.Name = "cboCarrera";
            cboCarrera.Size = new Size(323, 38);
            cboCarrera.TabIndex = 20;
            cboCarrera.SelectionChangeCommitted += cboCarrera_SelectionChangeCommitted;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(619, 323);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(142, 30);
            label12.TabIndex = 21;
            label12.Text = "FACULTAD:";
            // 
            // cboFacultad
            // 
            cboFacultad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFacultad.FormattingEnabled = true;
            cboFacultad.Location = new Point(780, 320);
            cboFacultad.Margin = new Padding(4, 4, 4, 4);
            cboFacultad.Name = "cboFacultad";
            cboFacultad.Size = new Size(271, 38);
            cboFacultad.TabIndex = 22;
            // 
            // optM
            // 
            optM.AutoSize = true;
            optM.Location = new Point(38, 82);
            optM.Name = "optM";
            optM.Size = new Size(182, 34);
            optM.TabIndex = 2;
            optM.TabStop = true;
            optM.Text = "MASCULINO";
            optM.UseVisualStyleBackColor = true;
            // 
            // optF
            // 
            optF.AutoSize = true;
            optF.Location = new Point(226, 82);
            optF.Name = "optF";
            optF.Size = new Size(162, 34);
            optF.TabIndex = 3;
            optF.TabStop = true;
            optF.Text = "FEMENINO";
            optF.UseVisualStyleBackColor = true;
            // 
            // FrmInsertarAlumno
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 877);
            Controls.Add(cboFacultad);
            Controls.Add(label12);
            Controls.Add(cboCarrera);
            Controls.Add(label11);
            Controls.Add(mskDNIAlu);
            Controls.Add(label10);
            Controls.Add(chkActivo);
            Controls.Add(btnCancelar);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(cboDistrito);
            Controls.Add(cboProvincia);
            Controls.Add(cboDep);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(gpbSexoAlu);
            Controls.Add(txtApeMat);
            Controls.Add(label3);
            Controls.Add(txtApePat);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FrmInsertarAlumno";
            Text = "Insertar Alumno";
            Load += FrmInsertarAlumno_Load;
            gpbSexoAlu.ResumeLayout(false);
            gpbSexoAlu.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtApePat;
        private Label label3;
        private TextBox txtApeMat;
        private GroupBox gpbSexoAlu;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cboDep;
        private ComboBox cboProvincia;
        private ComboBox cboDistrito;
        private GroupBox groupBox2;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtCorreoAlu;
        private MaskedTextBox mskTelAlu;
        private Button button1;
        private Button btnCancelar;
        private CheckBox chkActivo;
        private Label label10;
        private MaskedTextBox mskDNIAlu;
        internal DateTimePicker dtpFecha_Nac;
        private Label label11;
        private ComboBox cboCarrera;
        private Label label12;
        private ComboBox cboFacultad;
        private RadioButton optF;
        private RadioButton optM;
    }
}