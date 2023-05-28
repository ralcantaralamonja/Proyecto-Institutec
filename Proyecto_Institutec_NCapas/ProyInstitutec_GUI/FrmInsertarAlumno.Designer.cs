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
            optF = new CheckBox();
            optM = new CheckBox();
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
            gpbSexoAlu.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 31);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombres:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(126, 31);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(419, 31);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 94);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 2;
            label2.Text = "Apellido Paterno:";
            // 
            // txtApePat
            // 
            txtApePat.Location = new Point(183, 91);
            txtApePat.Name = "txtApePat";
            txtApePat.Size = new Size(192, 31);
            txtApePat.TabIndex = 3;
            txtApePat.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 164);
            label3.Name = "label3";
            label3.Size = new Size(154, 25);
            label3.TabIndex = 4;
            label3.Text = "Apellido Materno:";
            // 
            // txtApeMat
            // 
            txtApeMat.Location = new Point(183, 164);
            txtApeMat.Name = "txtApeMat";
            txtApeMat.Size = new Size(192, 31);
            txtApeMat.TabIndex = 5;
            // 
            // gpbSexoAlu
            // 
            gpbSexoAlu.Controls.Add(optF);
            gpbSexoAlu.Controls.Add(optM);
            gpbSexoAlu.Location = new Point(413, 77);
            gpbSexoAlu.Name = "gpbSexoAlu";
            gpbSexoAlu.Size = new Size(300, 150);
            gpbSexoAlu.TabIndex = 6;
            gpbSexoAlu.TabStop = false;
            gpbSexoAlu.Text = "Género";
            // 
            // optF
            // 
            optF.AutoSize = true;
            optF.Location = new Point(161, 66);
            optF.Name = "optF";
            optF.Size = new Size(116, 29);
            optF.TabIndex = 1;
            optF.Text = "Femenino";
            optF.UseVisualStyleBackColor = true;
            // 
            // optM
            // 
            optM.AutoSize = true;
            optM.Location = new Point(17, 66);
            optM.Name = "optM";
            optM.Size = new Size(118, 29);
            optM.TabIndex = 0;
            optM.Text = "Masculino";
            optM.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 318);
            label4.Name = "label4";
            label4.Size = new Size(131, 25);
            label4.TabIndex = 7;
            label4.Text = "Departamento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 368);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 8;
            label5.Text = "Provincia:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 419);
            label6.Name = "label6";
            label6.Size = new Size(74, 25);
            label6.TabIndex = 9;
            label6.Text = "Distrito:";
            // 
            // cboDep
            // 
            cboDep.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDep.FormattingEnabled = true;
            cboDep.Location = new Point(183, 310);
            cboDep.Name = "cboDep";
            cboDep.Size = new Size(232, 33);
            cboDep.TabIndex = 10;
            // 
            // cboProvincia
            // 
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(183, 360);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(231, 33);
            cboProvincia.TabIndex = 11;
            // 
            // cboDistrito
            // 
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(183, 416);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(253, 33);
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
            groupBox2.Location = new Point(33, 478);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(657, 180);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Personales";
            // 
            // txtCorreoAlu
            // 
            txtCorreoAlu.Location = new Point(259, 39);
            txtCorreoAlu.Name = "txtCorreoAlu";
            txtCorreoAlu.Size = new Size(345, 31);
            txtCorreoAlu.TabIndex = 6;
            txtCorreoAlu.TextChanged += txtCorreoAlu_TextChanged;
            // 
            // mskTelAlu
            // 
            mskTelAlu.Location = new Point(226, 137);
            mskTelAlu.Mask = "999999999";
            mskTelAlu.Name = "mskTelAlu";
            mskTelAlu.Size = new Size(150, 31);
            mskTelAlu.TabIndex = 5;
            // 
            // dtpFecha_Nac
            // 
            dtpFecha_Nac.CustomFormat = "dd/MM/yyyy ";
            dtpFecha_Nac.Format = DateTimePickerFormat.Short;
            dtpFecha_Nac.Location = new Point(337, 88);
            dtpFecha_Nac.Name = "dtpFecha_Nac";
            dtpFecha_Nac.Size = new Size(166, 31);
            dtpFecha_Nac.TabIndex = 4;
            dtpFecha_Nac.Value = new DateTime(2023, 5, 26, 0, 0, 0, 0);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(127, 143);
            label9.Name = "label9";
            label9.Size = new Size(83, 25);
            label9.TabIndex = 2;
            label9.Text = "Teléfono:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(127, 94);
            label8.Name = "label8";
            label8.Size = new Size(181, 25);
            label8.TabIndex = 1;
            label8.Text = "Fecha de Nacimiento:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(127, 42);
            label7.Name = "label7";
            label7.Size = new Size(70, 25);
            label7.TabIndex = 0;
            label7.Text = "Correo:";
            // 
            // button1
            // 
            button1.Location = new Point(458, 685);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 14;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(601, 685);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(532, 396);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(88, 29);
            chkActivo.TabIndex = 16;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            chkActivo.CheckedChanged += chkActivo_CheckedChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(30, 219);
            label10.Name = "label10";
            label10.Size = new Size(47, 25);
            label10.TabIndex = 17;
            label10.Text = "DNI:";
            // 
            // mskDNIAlu
            // 
            mskDNIAlu.Location = new Point(183, 219);
            mskDNIAlu.Mask = "99999999";
            mskDNIAlu.Name = "mskDNIAlu";
            mskDNIAlu.Size = new Size(150, 31);
            mskDNIAlu.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(30, 275);
            label11.Name = "label11";
            label11.Size = new Size(72, 25);
            label11.TabIndex = 19;
            label11.Text = "Carrera:";
            // 
            // cboCarrera
            // 
            cboCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCarrera.FormattingEnabled = true;
            cboCarrera.Location = new Point(183, 267);
            cboCarrera.Name = "cboCarrera";
            cboCarrera.Size = new Size(232, 33);
            cboCarrera.TabIndex = 20;
            cboCarrera.SelectionChangeCommitted += cboCarrera_SelectionChangeCommitted;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(431, 270);
            label12.Name = "label12";
            label12.Size = new Size(81, 25);
            label12.TabIndex = 21;
            label12.Text = "Facultad:";
            // 
            // cboFacultad
            // 
            cboFacultad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFacultad.FormattingEnabled = true;
            cboFacultad.Location = new Point(518, 267);
            cboFacultad.Name = "cboFacultad";
            cboFacultad.Size = new Size(195, 33);
            cboFacultad.TabIndex = 22;
            // 
            // FrmInsertarAlumno
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 731);
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
        private CheckBox optF;
        private CheckBox optM;
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
    }
}