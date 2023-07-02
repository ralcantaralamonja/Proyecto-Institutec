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
            optF = new RadioButton();
            optM = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cboDep = new ComboBox();
            cboProvincia = new ComboBox();
            cboDistrito = new ComboBox();
            groupBox2 = new GroupBox();
            txtDireccionAlum = new TextBox();
            label14 = new Label();
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
            label13 = new Label();
            btnImagen = new Button();
            pcbFoto = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            gpbSexoAlu.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 82);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 2;
            label1.Text = "NOMBRES:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(252, 79);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(267, 27);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 130);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(169, 21);
            label2.TabIndex = 4;
            label2.Text = "APELLIDO PATERNO:";
            // 
            // txtApePat
            // 
            txtApePat.Location = new Point(252, 127);
            txtApePat.Margin = new Padding(4);
            txtApePat.Name = "txtApePat";
            txtApePat.Size = new Size(267, 27);
            txtApePat.TabIndex = 5;
            txtApePat.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 178);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(175, 21);
            label3.TabIndex = 6;
            label3.Text = "APELLIDO MATERNO:";
            // 
            // txtApeMat
            // 
            txtApeMat.Location = new Point(252, 175);
            txtApeMat.Margin = new Padding(4);
            txtApeMat.Name = "txtApeMat";
            txtApeMat.Size = new Size(267, 27);
            txtApeMat.TabIndex = 7;
            // 
            // gpbSexoAlu
            // 
            gpbSexoAlu.Controls.Add(optF);
            gpbSexoAlu.Controls.Add(optM);
            gpbSexoAlu.Location = new Point(588, 37);
            gpbSexoAlu.Margin = new Padding(4);
            gpbSexoAlu.Name = "gpbSexoAlu";
            gpbSexoAlu.Padding = new Padding(4);
            gpbSexoAlu.Size = new Size(326, 99);
            gpbSexoAlu.TabIndex = 8;
            gpbSexoAlu.TabStop = false;
            gpbSexoAlu.Text = "GÉNERO";
            // 
            // optF
            // 
            optF.AutoSize = true;
            optF.Location = new Point(205, 47);
            optF.Name = "optF";
            optF.Size = new Size(112, 25);
            optF.TabIndex = 1;
            optF.TabStop = true;
            optF.Text = "FEMENINO";
            optF.UseVisualStyleBackColor = true;
            // 
            // optM
            // 
            optM.AutoSize = true;
            optM.Location = new Point(17, 47);
            optM.Name = "optM";
            optM.Size = new Size(126, 25);
            optM.TabIndex = 0;
            optM.TabStop = true;
            optM.Text = "MASCULINO";
            optM.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 309);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(146, 21);
            label4.TabIndex = 10;
            label4.Text = "DEPARTAMENTO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 374);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 21);
            label5.TabIndex = 14;
            label5.Text = "PROVINCIA:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 439);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(84, 21);
            label6.TabIndex = 14;
            label6.Text = "DISTRITO:";
            // 
            // cboDep
            // 
            cboDep.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDep.FormattingEnabled = true;
            cboDep.Location = new Point(252, 306);
            cboDep.Margin = new Padding(4);
            cboDep.Name = "cboDep";
            cboDep.Size = new Size(290, 29);
            cboDep.TabIndex = 11;
            cboDep.SelectionChangeCommitted += cboDep_SelectionChangeCommitted;
            // 
            // cboProvincia
            // 
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(252, 371);
            cboProvincia.Margin = new Padding(4);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(290, 29);
            cboProvincia.TabIndex = 16;
            cboProvincia.SelectionChangeCommitted += cboProvincia_SelectionChangeCommitted;
            // 
            // cboDistrito
            // 
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(252, 436);
            cboDistrito.Margin = new Padding(4);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(290, 29);
            cboDistrito.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDireccionAlum);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(txtCorreoAlu);
            groupBox2.Controls.Add(mskTelAlu);
            groupBox2.Controls.Add(dtpFecha_Nac);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(42, 504);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(524, 285);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "DATOS PERSONALES";
            // 
            // txtDireccionAlum
            // 
            txtDireccionAlum.Location = new Point(210, 231);
            txtDireccionAlum.Margin = new Padding(4);
            txtDireccionAlum.Name = "txtDireccionAlum";
            txtDireccionAlum.Size = new Size(294, 27);
            txtDireccionAlum.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(58, 231);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(107, 21);
            label14.TabIndex = 6;
            label14.Text = "DIRECCION:";
            // 
            // txtCorreoAlu
            // 
            txtCorreoAlu.Location = new Point(210, 52);
            txtCorreoAlu.Margin = new Padding(4);
            txtCorreoAlu.Name = "txtCorreoAlu";
            txtCorreoAlu.Size = new Size(294, 27);
            txtCorreoAlu.TabIndex = 0;
            // 
            // mskTelAlu
            // 
            mskTelAlu.Location = new Point(210, 168);
            mskTelAlu.Margin = new Padding(4);
            mskTelAlu.Mask = "999999999";
            mskTelAlu.Name = "mskTelAlu";
            mskTelAlu.Size = new Size(231, 27);
            mskTelAlu.TabIndex = 5;
            // 
            // dtpFecha_Nac
            // 
            dtpFecha_Nac.CustomFormat = "dd/MM/yyyy ";
            dtpFecha_Nac.Format = DateTimePickerFormat.Short;
            dtpFecha_Nac.Location = new Point(269, 109);
            dtpFecha_Nac.Margin = new Padding(4);
            dtpFecha_Nac.Name = "dtpFecha_Nac";
            dtpFecha_Nac.Size = new Size(142, 27);
            dtpFecha_Nac.TabIndex = 3;
            dtpFecha_Nac.Value = new DateTime(2023, 5, 26, 0, 0, 0, 0);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(58, 174);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(95, 21);
            label9.TabIndex = 4;
            label9.Text = "TELÉFONO:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(58, 115);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(203, 21);
            label8.TabIndex = 2;
            label8.Text = "FECHA DE NACIMIENTO:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(58, 52);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(84, 21);
            label7.TabIndex = 0;
            label7.Text = "CORREO:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Location = new Point(611, 773);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(179, 67);
            button1.TabIndex = 23;
            button1.Text = "GRABAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ControlLight;
            btnCancelar.Location = new Point(809, 773);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(179, 67);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(675, 184);
            chkActivo.Margin = new Padding(4);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(93, 25);
            chkActivo.TabIndex = 13;
            chkActivo.Text = "ACTIVO";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(42, 28);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(43, 21);
            label10.TabIndex = 0;
            label10.Text = "DNI:";
            // 
            // mskDNIAlu
            // 
            mskDNIAlu.Location = new Point(252, 25);
            mskDNIAlu.Margin = new Padding(4);
            mskDNIAlu.Mask = "99999999";
            mskDNIAlu.Name = "mskDNIAlu";
            mskDNIAlu.Size = new Size(201, 27);
            mskDNIAlu.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(38, 251);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(92, 21);
            label11.TabIndex = 8;
            label11.Text = "CARRERA:";
            // 
            // cboCarrera
            // 
            cboCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCarrera.FormattingEnabled = true;
            cboCarrera.Location = new Point(252, 241);
            cboCarrera.Margin = new Padding(4);
            cboCarrera.Name = "cboCarrera";
            cboCarrera.Size = new Size(290, 29);
            cboCarrera.TabIndex = 9;
            cboCarrera.SelectedIndexChanged += cboCarrera_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(595, 244);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(99, 21);
            label12.TabIndex = 11;
            label12.Text = "FACULTAD:";
            // 
            // cboFacultad
            // 
            cboFacultad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFacultad.FormattingEnabled = true;
            cboFacultad.Location = new Point(713, 241);
            cboFacultad.Margin = new Padding(4);
            cboFacultad.Name = "cboFacultad";
            cboFacultad.Size = new Size(271, 29);
            cboFacultad.TabIndex = 12;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(591, 184);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(78, 21);
            label13.TabIndex = 9;
            label13.Text = "ESTADO:";
            // 
            // btnImagen
            // 
            btnImagen.Location = new Point(713, 383);
            btnImagen.Name = "btnImagen";
            btnImagen.Size = new Size(197, 34);
            btnImagen.TabIndex = 22;
            btnImagen.Text = "Cargar Foto";
            btnImagen.UseVisualStyleBackColor = true;
            btnImagen.Click += btnImagen_Click;
            // 
            // pcbFoto
            // 
            pcbFoto.BorderStyle = BorderStyle.FixedSingle;
            pcbFoto.Location = new Point(690, 439);
            pcbFoto.Margin = new Padding(4, 3, 4, 3);
            pcbFoto.Name = "pcbFoto";
            pcbFoto.Size = new Size(247, 211);
            pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFoto.TabIndex = 26;
            pcbFoto.TabStop = false;
            pcbFoto.Click += pcbFoto_Click;
            // 
            // FrmInsertarAlumno
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 854);
            Controls.Add(pcbFoto);
            Controls.Add(btnImagen);
            Controls.Add(label13);
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
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmInsertarAlumno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insertar Alumno";
            Load += FrmInsertarAlumno_Load;
            gpbSexoAlu.ResumeLayout(false);
            gpbSexoAlu.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).EndInit();
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
        private Label label13;
        private TextBox txtDireccionAlum;
        private Label label14;
        private Button btnImagen;
        private PictureBox pcbFoto;
        private OpenFileDialog openFileDialog1;
    }
}