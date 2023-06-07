namespace ProyInstitutec_GUI
{
    partial class FrmActualizarProfesor
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
            gbActulizar = new GroupBox();
            btnFoto = new Button();
            pcbFoto = new PictureBox();
            cboDistrito = new ComboBox();
            cboProvincia = new ComboBox();
            cboDep = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox2 = new GroupBox();
            optFemenino = new RadioButton();
            optMasculino = new RadioButton();
            txtNdocum = new TextBox();
            label6 = new Label();
            dtpFecIng = new DateTimePicker();
            lbltiempo = new Label();
            btnIngresar = new Button();
            btnSalir = new Button();
            groupBox1 = new GroupBox();
            optInactivo = new RadioButton();
            optActivo = new RadioButton();
            txtTelf = new TextBox();
            lblCodigo = new Label();
            txtApeMat = new TextBox();
            txtApePat = new TextBox();
            txtNompro = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            gbActulizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbActulizar
            // 
            gbActulizar.BackColor = SystemColors.Control;
            gbActulizar.Controls.Add(btnFoto);
            gbActulizar.Controls.Add(pcbFoto);
            gbActulizar.Controls.Add(cboDistrito);
            gbActulizar.Controls.Add(cboProvincia);
            gbActulizar.Controls.Add(cboDep);
            gbActulizar.Controls.Add(label9);
            gbActulizar.Controls.Add(label8);
            gbActulizar.Controls.Add(label7);
            gbActulizar.Controls.Add(groupBox2);
            gbActulizar.Controls.Add(txtNdocum);
            gbActulizar.Controls.Add(label6);
            gbActulizar.Controls.Add(dtpFecIng);
            gbActulizar.Controls.Add(lbltiempo);
            gbActulizar.Controls.Add(btnIngresar);
            gbActulizar.Controls.Add(btnSalir);
            gbActulizar.Controls.Add(groupBox1);
            gbActulizar.Controls.Add(txtTelf);
            gbActulizar.Controls.Add(lblCodigo);
            gbActulizar.Controls.Add(txtApeMat);
            gbActulizar.Controls.Add(txtApePat);
            gbActulizar.Controls.Add(txtNompro);
            gbActulizar.Controls.Add(label5);
            gbActulizar.Controls.Add(label4);
            gbActulizar.Controls.Add(label3);
            gbActulizar.Controls.Add(label2);
            gbActulizar.Controls.Add(label1);
            gbActulizar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbActulizar.Location = new Point(24, 14);
            gbActulizar.Margin = new Padding(4, 5, 4, 5);
            gbActulizar.Name = "gbActulizar";
            gbActulizar.Padding = new Padding(4, 5, 4, 5);
            gbActulizar.Size = new Size(841, 1007);
            gbActulizar.TabIndex = 0;
            gbActulizar.TabStop = false;
            gbActulizar.Text = "DATOS A ACTUALIZAR";
            gbActulizar.Enter += gbActulizar_Enter;
            // 
            // btnFoto
            // 
            btnFoto.Location = new Point(494, 723);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(259, 47);
            btnFoto.TabIndex = 26;
            btnFoto.Text = "CARGAR FOTO";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // pcbFoto
            // 
            pcbFoto.BorderStyle = BorderStyle.FixedSingle;
            pcbFoto.Location = new Point(513, 788);
            pcbFoto.Name = "pcbFoto";
            pcbFoto.Size = new Size(229, 202);
            pcbFoto.TabIndex = 25;
            pcbFoto.TabStop = false;
            // 
            // cboDistrito
            // 
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(30, 788);
            cboDistrito.Margin = new Padding(4, 5, 4, 5);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(408, 38);
            cboDistrito.TabIndex = 24;
            // 
            // cboProvincia
            // 
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(31, 647);
            cboProvincia.Margin = new Padding(4, 5, 4, 5);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(408, 38);
            cboProvincia.TabIndex = 23;
            // 
            // cboDep
            // 
            cboDep.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDep.FormattingEnabled = true;
            cboDep.Location = new Point(31, 508);
            cboDep.Margin = new Padding(4, 5, 4, 5);
            cboDep.Name = "cboDep";
            cboDep.Size = new Size(408, 38);
            cboDep.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 723);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(120, 30);
            label9.TabIndex = 18;
            label9.Text = "DISTRITO:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 592);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(154, 30);
            label8.TabIndex = 18;
            label8.Text = "PROVINCIA:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 468);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(211, 30);
            label7.TabIndex = 18;
            label7.Text = "DEPARTAMENTO:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(optFemenino);
            groupBox2.Controls.Add(optMasculino);
            groupBox2.Location = new Point(494, 245);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(286, 193);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Genero";
            // 
            // optFemenino
            // 
            optFemenino.AutoSize = true;
            optFemenino.Location = new Point(34, 115);
            optFemenino.Margin = new Padding(4, 5, 4, 5);
            optFemenino.Name = "optFemenino";
            optFemenino.Size = new Size(162, 34);
            optFemenino.TabIndex = 1;
            optFemenino.TabStop = true;
            optFemenino.Text = "FEMENINO";
            optFemenino.UseVisualStyleBackColor = true;
            // 
            // optMasculino
            // 
            optMasculino.AutoSize = true;
            optMasculino.Location = new Point(34, 45);
            optMasculino.Margin = new Padding(4, 5, 4, 5);
            optMasculino.Name = "optMasculino";
            optMasculino.Size = new Size(182, 34);
            optMasculino.TabIndex = 0;
            optMasculino.TabStop = true;
            optMasculino.Text = "MASCULINO";
            optMasculino.UseVisualStyleBackColor = true;
            // 
            // txtNdocum
            // 
            txtNdocum.Location = new Point(494, 178);
            txtNdocum.Margin = new Padding(4, 5, 4, 5);
            txtNdocum.MaxLength = 8;
            txtNdocum.Name = "txtNdocum";
            txtNdocum.Size = new Size(178, 37);
            txtNdocum.TabIndex = 16;
            txtNdocum.KeyPress += txtNdocum_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(494, 138);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(62, 30);
            label6.TabIndex = 15;
            label6.Text = "DNI:";
            // 
            // dtpFecIng
            // 
            dtpFecIng.Format = DateTimePickerFormat.Short;
            dtpFecIng.Location = new Point(176, 1028);
            dtpFecIng.Margin = new Padding(4, 5, 4, 5);
            dtpFecIng.Name = "dtpFecIng";
            dtpFecIng.Size = new Size(263, 37);
            dtpFecIng.TabIndex = 11;
            // 
            // lbltiempo
            // 
            lbltiempo.AutoSize = true;
            lbltiempo.Location = new Point(31, 1028);
            lbltiempo.Margin = new Padding(4, 0, 4, 0);
            lbltiempo.Name = "lbltiempo";
            lbltiempo.Size = new Size(126, 30);
            lbltiempo.TabIndex = 10;
            lbltiempo.Text = "INGRESO:";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.ControlLight;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Location = new Point(407, 1120);
            btnIngresar.Margin = new Padding(4, 5, 4, 5);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(179, 67);
            btnIngresar.TabIndex = 13;
            btnIngresar.Text = "GRABAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ControlLight;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(624, 1120);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(179, 67);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "CANCELAR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(optInactivo);
            groupBox1.Controls.Add(optActivo);
            groupBox1.Location = new Point(494, 494);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(230, 200);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "¿EL PROFESOR ESTA ACTIVO?";
            // 
            // optInactivo
            // 
            optInactivo.AutoSize = true;
            optInactivo.Location = new Point(30, 148);
            optInactivo.Margin = new Padding(4, 5, 4, 5);
            optInactivo.Name = "optInactivo";
            optInactivo.Size = new Size(154, 34);
            optInactivo.TabIndex = 1;
            optInactivo.TabStop = true;
            optInactivo.Text = "INACTIVO";
            optInactivo.UseVisualStyleBackColor = true;
            // 
            // optActivo
            // 
            optActivo.AutoSize = true;
            optActivo.Checked = true;
            optActivo.Location = new Point(30, 78);
            optActivo.Margin = new Padding(4, 5, 4, 5);
            optActivo.Name = "optActivo";
            optActivo.Size = new Size(130, 34);
            optActivo.TabIndex = 0;
            optActivo.TabStop = true;
            optActivo.Text = "ACTIVO";
            optActivo.UseVisualStyleBackColor = true;
            // 
            // txtTelf
            // 
            txtTelf.Location = new Point(176, 915);
            txtTelf.Margin = new Padding(4, 5, 4, 5);
            txtTelf.MaxLength = 9;
            txtTelf.Name = "txtTelf";
            txtTelf.Size = new Size(264, 37);
            txtTelf.TabIndex = 9;
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(233, 65);
            lblCodigo.Margin = new Padding(4, 0, 4, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(93, 37);
            lblCodigo.TabIndex = 1;
            // 
            // txtApeMat
            // 
            txtApeMat.Location = new Point(31, 393);
            txtApeMat.Margin = new Padding(4, 5, 4, 5);
            txtApeMat.Name = "txtApeMat";
            txtApeMat.Size = new Size(408, 37);
            txtApeMat.TabIndex = 7;
            // 
            // txtApePat
            // 
            txtApePat.Location = new Point(31, 285);
            txtApePat.Margin = new Padding(4, 5, 4, 5);
            txtApePat.Name = "txtApePat";
            txtApePat.Size = new Size(408, 37);
            txtApePat.TabIndex = 5;
            // 
            // txtNompro
            // 
            txtNompro.Location = new Point(31, 178);
            txtNompro.Margin = new Padding(4, 5, 4, 5);
            txtNompro.Name = "txtNompro";
            txtNompro.Size = new Size(408, 37);
            txtNompro.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 138);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(124, 30);
            label5.TabIndex = 2;
            label5.Text = "NOMBRE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 353);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(256, 30);
            label4.TabIndex = 6;
            label4.Text = "APELLIDO MATERNO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 245);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(247, 30);
            label3.TabIndex = 4;
            label3.Text = "APELLIDO PATERNO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 920);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 30);
            label2.TabIndex = 8;
            label2.Text = "TELEFONO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 65);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(167, 30);
            label1.TabIndex = 0;
            label1.Text = "ID PROFESOR";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmActualizarProfesor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 1050);
            Controls.Add(gbActulizar);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmActualizarProfesor";
            Text = "Actulizar Profesor";
            Load += FrmActualizarProfesor_Load;
            gbActulizar.ResumeLayout(false);
            gbActulizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbActulizar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblCodigo;
        private TextBox txtNompro;
        private TextBox txtApeMat;
        private TextBox txtApePat;
        private GroupBox groupBox1;
        private RadioButton optInactivo;
        private RadioButton optActivo;
        private TextBox txtTelf;
        private Button btnIngresar;
        private Button btnSalir;
        private DateTimePicker dtpFecIng;
        private Label lbltiempo;
        private GroupBox groupBox2;
        private RadioButton optMasculino;
        private Label label6;
        private RadioButton optFemenino;
        private TextBox txtNdocum;
        private Label label7;
        private Label label9;
        private Label label8;
        private ComboBox cboDep;
        private ComboBox cboProvincia;
        private ComboBox cboDistrito;
        private PictureBox pcbFoto;
        private Button btnFoto;
        private OpenFileDialog openFileDialog1;
    }
}