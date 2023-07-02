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
            pcbFoto = new PictureBox();
            btnActualizarImagen = new Button();
            textDireccionAlum = new TextBox();
            label15 = new Label();
            gpbSexoAlu = new GroupBox();
            optF = new RadioButton();
            optM = new RadioButton();
            txtCorreoAlu = new TextBox();
            label14 = new Label();
            cboFacultad = new ComboBox();
            label12 = new Label();
            cboCarrera = new ComboBox();
            label11 = new Label();
            cboDistrito = new ComboBox();
            cboProvincia = new ComboBox();
            cboDep = new ComboBox();
            label5 = new Label();
            label7 = new Label();
            label13 = new Label();
            mskDNIAlu = new MaskedTextBox();
            label4 = new Label();
            chkActivo = new CheckBox();
            lblCodigo = new Label();
            label8 = new Label();
            dtpFecNac = new DateTimePicker();
            txtApeMat = new TextBox();
            txtApePat = new TextBox();
            label10 = new Label();
            label2 = new Label();
            mskTelAlu = new MaskedTextBox();
            btnCancelar = new Button();
            btnGrabar = new Button();
            label9 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).BeginInit();
            gpbSexoAlu.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pcbFoto);
            groupBox1.Controls.Add(btnActualizarImagen);
            groupBox1.Controls.Add(textDireccionAlum);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(gpbSexoAlu);
            groupBox1.Controls.Add(txtCorreoAlu);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(cboFacultad);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(cboCarrera);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(cboDistrito);
            groupBox1.Controls.Add(cboProvincia);
            groupBox1.Controls.Add(cboDep);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(mskDNIAlu);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(chkActivo);
            groupBox1.Controls.Add(lblCodigo);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dtpFecNac);
            groupBox1.Controls.Add(txtApeMat);
            groupBox1.Controls.Add(txtApePat);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(mskTelAlu);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnGrabar);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(17, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(988, 838);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // pcbFoto
            // 
            pcbFoto.BorderStyle = BorderStyle.FixedSingle;
            pcbFoto.Location = new Point(675, 446);
            pcbFoto.Margin = new Padding(4, 3, 4, 3);
            pcbFoto.Name = "pcbFoto";
            pcbFoto.Size = new Size(247, 211);
            pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFoto.TabIndex = 98;
            pcbFoto.TabStop = false;
            // 
            // btnActualizarImagen
            // 
            btnActualizarImagen.Location = new Point(698, 406);
            btnActualizarImagen.Name = "btnActualizarImagen";
            btnActualizarImagen.Size = new Size(197, 34);
            btnActualizarImagen.TabIndex = 25;
            btnActualizarImagen.Text = "Actualizar Foto";
            btnActualizarImagen.UseVisualStyleBackColor = true;
            btnActualizarImagen.Click += btnFoto_Click;
            // 
            // textDireccionAlum
            // 
            textDireccionAlum.Location = new Point(216, 757);
            textDireccionAlum.Margin = new Padding(4);
            textDireccionAlum.Name = "textDireccionAlum";
            textDireccionAlum.Size = new Size(323, 27);
            textDireccionAlum.TabIndex = 31;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(32, 760);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(107, 21);
            label15.TabIndex = 30;
            label15.Text = "DIRECCION:";
            // 
            // gpbSexoAlu
            // 
            gpbSexoAlu.Controls.Add(optF);
            gpbSexoAlu.Controls.Add(optM);
            gpbSexoAlu.Location = new Point(580, 27);
            gpbSexoAlu.Margin = new Padding(4);
            gpbSexoAlu.Name = "gpbSexoAlu";
            gpbSexoAlu.Padding = new Padding(4);
            gpbSexoAlu.Size = new Size(326, 99);
            gpbSexoAlu.TabIndex = 20;
            gpbSexoAlu.TabStop = false;
            gpbSexoAlu.Text = "GÉNERO";
            // 
            // optF
            // 
            optF.AutoSize = true;
            optF.Location = new Point(206, 48);
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
            optM.Location = new Point(18, 48);
            optM.Name = "optM";
            optM.Size = new Size(126, 25);
            optM.TabIndex = 0;
            optM.TabStop = true;
            optM.Text = "MASCULINO";
            optM.UseVisualStyleBackColor = true;
            // 
            // txtCorreoAlu
            // 
            txtCorreoAlu.Location = new Point(216, 577);
            txtCorreoAlu.Margin = new Padding(4);
            txtCorreoAlu.Name = "txtCorreoAlu";
            txtCorreoAlu.Size = new Size(323, 27);
            txtCorreoAlu.TabIndex = 19;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(28, 580);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(84, 21);
            label14.TabIndex = 22;
            label14.Text = "CORREO:";
            // 
            // cboFacultad
            // 
            cboFacultad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFacultad.FormattingEnabled = true;
            cboFacultad.Location = new Point(698, 316);
            cboFacultad.Margin = new Padding(4);
            cboFacultad.Name = "cboFacultad";
            cboFacultad.Size = new Size(271, 29);
            cboFacultad.TabIndex = 26;
            cboFacultad.SelectedIndexChanged += cboFacultad_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(580, 319);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(99, 21);
            label12.TabIndex = 25;
            label12.Text = "FACULTAD:";
            // 
            // cboCarrera
            // 
            cboCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCarrera.FormattingEnabled = true;
            cboCarrera.Location = new Point(216, 316);
            cboCarrera.Margin = new Padding(4);
            cboCarrera.Name = "cboCarrera";
            cboCarrera.Size = new Size(323, 29);
            cboCarrera.TabIndex = 11;
            cboCarrera.SelectedIndexChanged += cboCarrera_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(28, 316);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(92, 21);
            label11.TabIndex = 10;
            label11.Text = "CARRERA:";
            label11.Click += label11_Click;
            // 
            // cboDistrito
            // 
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(216, 508);
            cboDistrito.Margin = new Padding(4);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(323, 29);
            cboDistrito.TabIndex = 17;
            // 
            // cboProvincia
            // 
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(216, 443);
            cboProvincia.Margin = new Padding(4);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(323, 29);
            cboProvincia.TabIndex = 15;
            // 
            // cboDep
            // 
            cboDep.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDep.FormattingEnabled = true;
            cboDep.Location = new Point(216, 381);
            cboDep.Margin = new Padding(4);
            cboDep.Name = "cboDep";
            cboDep.Size = new Size(323, 29);
            cboDep.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 511);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(84, 21);
            label5.TabIndex = 16;
            label5.Text = "DISTRITO:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 446);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(106, 21);
            label7.TabIndex = 14;
            label7.Text = "PROVINCIA:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(32, 381);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(146, 21);
            label13.TabIndex = 12;
            label13.Text = "DEPARTAMENTO:";
            label13.Click += label13_Click;
            // 
            // mskDNIAlu
            // 
            mskDNIAlu.Location = new Point(216, 86);
            mskDNIAlu.Margin = new Padding(4);
            mskDNIAlu.Mask = "99999999";
            mskDNIAlu.Name = "mskDNIAlu";
            mskDNIAlu.Size = new Size(201, 27);
            mskDNIAlu.TabIndex = 3;
            mskDNIAlu.KeyPress += mskDNIAlu_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 89);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(43, 21);
            label4.TabIndex = 2;
            label4.Text = "DNI:";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(690, 177);
            chkActivo.Margin = new Padding(2);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(93, 25);
            chkActivo.TabIndex = 24;
            chkActivo.Text = "ACTIVO";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(216, 28);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(95, 23);
            lblCodigo.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 651);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(203, 21);
            label8.TabIndex = 20;
            label8.Text = "FECHA DE NACIMIENTO:";
            // 
            // dtpFecNac
            // 
            dtpFecNac.CustomFormat = "dd/MM/yyyy ";
            dtpFecNac.Format = DateTimePickerFormat.Short;
            dtpFecNac.Location = new Point(247, 648);
            dtpFecNac.Margin = new Padding(2);
            dtpFecNac.Name = "dtpFecNac";
            dtpFecNac.Size = new Size(133, 27);
            dtpFecNac.TabIndex = 21;
            dtpFecNac.Value = new DateTime(2023, 5, 26, 0, 0, 0, 0);
            // 
            // txtApeMat
            // 
            txtApeMat.Location = new Point(216, 259);
            txtApeMat.Margin = new Padding(2);
            txtApeMat.Name = "txtApeMat";
            txtApeMat.Size = new Size(323, 27);
            txtApeMat.TabIndex = 9;
            // 
            // txtApePat
            // 
            txtApePat.Location = new Point(216, 202);
            txtApePat.Margin = new Padding(2);
            txtApePat.Name = "txtApePat";
            txtApePat.Size = new Size(323, 27);
            txtApePat.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(32, 259);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(175, 21);
            label10.TabIndex = 8;
            label10.Text = "APELLIDO MATERNO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 204);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(169, 21);
            label2.TabIndex = 6;
            label2.Text = "APELLIDO PATERNO:";
            // 
            // mskTelAlu
            // 
            mskTelAlu.Location = new Point(216, 707);
            mskTelAlu.Margin = new Padding(2);
            mskTelAlu.Mask = "999999999";
            mskTelAlu.Name = "mskTelAlu";
            mskTelAlu.Size = new Size(164, 27);
            mskTelAlu.TabIndex = 29;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ControlLight;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(844, 744);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 40);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = SystemColors.ControlLight;
            btnGrabar.FlatStyle = FlatStyle.Flat;
            btnGrabar.Location = new Point(707, 744);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(125, 40);
            btnGrabar.TabIndex = 33;
            btnGrabar.Text = "GRABAR";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(580, 177);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(78, 21);
            label9.TabIndex = 23;
            label9.Text = "ESTADO:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 710);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(95, 21);
            label6.TabIndex = 28;
            label6.Text = "TELÉFONO:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(216, 139);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(323, 27);
            txtNombre.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 145);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 4;
            label3.Text = "NOMBRE:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 28);
            label1.Name = "label1";
            label1.Size = new Size(107, 21);
            label1.TabIndex = 0;
            label1.Text = "ID ALUMNO:";
            // 
            // FrmActualizarAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1024, 861);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmActualizarAlumno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Alumno";
            Load += FrmActualizarAlumno_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).EndInit();
            gpbSexoAlu.ResumeLayout(false);
            gpbSexoAlu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNombre;
        private Label label3;
        private Label label1;
        private TextBox textBox4;
        private Label label6;
        private ComboBox comboBox2;
        private Label label9;
        private Button btnGrabar;
        private Button btnCancelar;
        private MaskedTextBox mskTelAlu;
        private TextBox txtApeMat;
        private TextBox txtApePat;
        private Label label10;
        private Label label2;
        internal DateTimePicker dtpFecNac;
        private Label label8;
        private Label lblCodigo;
        private CheckBox chkActivo;
        private MaskedTextBox mskDNIAlu;
        private Label label4;
        private ComboBox cboFacultad;
        private Label label12;
        private ComboBox cboCarrera;
        private Label label11;
        private ComboBox cboDistrito;
        private ComboBox cboProvincia;
        private ComboBox cboDep;
        private Label label5;
        private Label label7;
        private Label label13;
        private TextBox txtCorreoAlu;
        private Label label14;
        private GroupBox gpbSexoAlu;
        private RadioButton optF;
        private RadioButton optM;
        private TextBox textDireccionAlum;
        private Label label15;
        private Button btnActualizarImagen;
        private PictureBox pcbFoto;
        private OpenFileDialog openFileDialog1;
    }
}