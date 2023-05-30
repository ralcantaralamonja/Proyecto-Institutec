namespace ProyInstitutec_GUI
{
    partial class FrmInsertarProfesor
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
            txtNomPro = new TextBox();
            txtApePat = new TextBox();
            lblNombre = new Label();
            lblApePat = new Label();
            lblApeMat = new Label();
            lblDni = new Label();
            label5 = new Label();
            txtTelf = new TextBox();
            cboDep = new ComboBox();
            groupBox1 = new GroupBox();
            btnCancelar = new Button();
            dtpFecIng = new DateTimePicker();
            btnIngresar = new Button();
            label2 = new Label();
            label4 = new Label();
            txtApeMat = new TextBox();
            cboDistrito = new ComboBox();
            cboProvincia = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            txtDni = new TextBox();
            chkActivo = new CheckBox();
            groupBox2 = new GroupBox();
            optM = new RadioButton();
            optF = new RadioButton();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txtNomPro
            // 
            txtNomPro.CharacterCasing = CharacterCasing.Upper;
            txtNomPro.Location = new Point(19, 66);
            txtNomPro.Name = "txtNomPro";
            txtNomPro.Size = new Size(313, 27);
            txtNomPro.TabIndex = 1;
            // 
            // txtApePat
            // 
            txtApePat.CharacterCasing = CharacterCasing.Upper;
            txtApePat.Location = new Point(19, 129);
            txtApePat.Name = "txtApePat";
            txtApePat.Size = new Size(313, 27);
            txtApePat.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(19, 42);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(83, 21);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "NOMBRE:";
            // 
            // lblApePat
            // 
            lblApePat.AutoSize = true;
            lblApePat.Location = new Point(18, 105);
            lblApePat.Name = "lblApePat";
            lblApePat.Size = new Size(165, 21);
            lblApePat.TabIndex = 2;
            lblApePat.Text = "APELLIDO PATERNO";
            // 
            // lblApeMat
            // 
            lblApeMat.AutoSize = true;
            lblApeMat.Location = new Point(19, 168);
            lblApeMat.Name = "lblApeMat";
            lblApeMat.Size = new Size(175, 21);
            lblApeMat.TabIndex = 4;
            lblApeMat.Text = "APELLIDO MATERNO:";
            lblApeMat.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(350, 42);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(43, 21);
            lblDni.TabIndex = 6;
            lblDni.Text = "DNI:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 241);
            label5.Name = "label5";
            label5.Size = new Size(146, 21);
            label5.TabIndex = 11;
            label5.Text = "DEPARTAMENTO:";
            // 
            // txtTelf
            // 
            txtTelf.Location = new Point(119, 456);
            txtTelf.MaxLength = 9;
            txtTelf.Name = "txtTelf";
            txtTelf.Size = new Size(212, 27);
            txtTelf.TabIndex = 18;
            txtTelf.KeyPress += txtDni_KeyPress;
            // 
            // cboDep
            // 
            cboDep.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDep.FormattingEnabled = true;
            cboDep.Location = new Point(18, 265);
            cboDep.Name = "cboDep";
            cboDep.Size = new Size(314, 29);
            cboDep.TabIndex = 12;
            cboDep.SelectionChangeCommitted += cboDep_SelectionChangeCommitted;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(dtpFecIng);
            groupBox1.Controls.Add(btnIngresar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtApeMat);
            groupBox1.Controls.Add(cboDistrito);
            groupBox1.Controls.Add(cboProvincia);
            groupBox1.Controls.Add(txtTelf);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtDni);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(cboDep);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(txtNomPro);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblApePat);
            groupBox1.Controls.Add(txtApePat);
            groupBox1.Controls.Add(lblDni);
            groupBox1.Controls.Add(lblApeMat);
            groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(542, 622);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS PERSONALES";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ControlLight;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(401, 576);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 40);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dtpFecIng
            // 
            dtpFecIng.Format = DateTimePickerFormat.Short;
            dtpFecIng.Location = new Point(119, 517);
            dtpFecIng.Name = "dtpFecIng";
            dtpFecIng.Size = new Size(216, 27);
            dtpFecIng.TabIndex = 20;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.ControlLight;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.Location = new Point(268, 576);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(125, 40);
            btnIngresar.TabIndex = 21;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 523);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 19;
            label2.Text = "INGRESO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 462);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 17;
            label4.Text = "TELEFONO:";
            // 
            // txtApeMat
            // 
            txtApeMat.CharacterCasing = CharacterCasing.Upper;
            txtApeMat.Location = new Point(19, 194);
            txtApeMat.Name = "txtApeMat";
            txtApeMat.Size = new Size(313, 27);
            txtApeMat.TabIndex = 5;
            // 
            // cboDistrito
            // 
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(18, 411);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(314, 29);
            cboDistrito.TabIndex = 16;
            // 
            // cboProvincia
            // 
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(18, 341);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(314, 29);
            cboProvincia.TabIndex = 14;
            cboProvincia.SelectionChangeCommitted += cboProvincia_SelectionChangeCommitted;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 387);
            label7.Name = "label7";
            label7.Size = new Size(84, 21);
            label7.TabIndex = 15;
            label7.Text = "DISTRITO:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 317);
            label6.Name = "label6";
            label6.Size = new Size(106, 21);
            label6.TabIndex = 13;
            label6.Text = "PROVINCIA:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(350, 66);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(176, 27);
            txtDni.TabIndex = 7;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(24, 52);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(93, 25);
            chkActivo.TabIndex = 10;
            chkActivo.Text = "ACTIVO";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(optM);
            groupBox2.Controls.Add(optF);
            groupBox2.Location = new Point(350, 129);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(176, 96);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "GENERO";
            // 
            // optM
            // 
            optM.AutoSize = true;
            optM.Checked = true;
            optM.Location = new Point(45, 26);
            optM.Name = "optM";
            optM.Size = new Size(126, 25);
            optM.TabIndex = 0;
            optM.TabStop = true;
            optM.Text = "MASCULINO";
            optM.UseVisualStyleBackColor = true;
            // 
            // optF
            // 
            optF.AutoSize = true;
            optF.Location = new Point(45, 57);
            optF.Name = "optF";
            optF.Size = new Size(112, 25);
            optF.TabIndex = 1;
            optF.Text = "FEMENINO";
            optF.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chkActivo);
            groupBox3.Location = new Point(350, 265);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(176, 116);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            groupBox3.Text = "¿EL PROFESOR ESTA ACTIVO?";
            // 
            // FrmInsertarProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(570, 630);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmInsertarProfesor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CREAR PROFESOR";
            Load += FrmInsertarProfesor_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNomPro;
        private TextBox txtApePat;
        private Label lblNombre;
        private Label lblApePat;
        private Label lblApeMat;
        private Label lblDni;
        private Label label5;
        private TextBox txtTelf;
        private ComboBox cboDep;
        private GroupBox groupBox1;
        private RadioButton optF;
        private RadioButton optM;
        private CheckBox chkActivo;
        private GroupBox groupBox2;
        internal TextBox txtDni;
        private Label label4;
        private Label label2;
        private Button btnIngresar;
        private Button btnCancelar;
        private ComboBox cboDistrito;
        private ComboBox cboProvincia;
        private Label label7;
        private Label label6;
        private TextBox txtApeMat;
        private DateTimePicker dtpFecIng;
        private GroupBox groupBox3;
    }
}