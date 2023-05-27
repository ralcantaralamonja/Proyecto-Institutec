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
            dtpFecIng = new DateTimePicker();
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
            btnIngresar = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtNomPro
            // 
            txtNomPro.CharacterCasing = CharacterCasing.Upper;
            txtNomPro.Location = new Point(103, 47);
            txtNomPro.Margin = new Padding(4, 5, 4, 5);
            txtNomPro.Name = "txtNomPro";
            txtNomPro.Size = new Size(291, 31);
            txtNomPro.TabIndex = 0;
            // 
            // txtApePat
            // 
            txtApePat.CharacterCasing = CharacterCasing.Upper;
            txtApePat.Location = new Point(163, 130);
            txtApePat.Margin = new Padding(4, 5, 4, 5);
            txtApePat.Name = "txtApePat";
            txtApePat.Size = new Size(231, 31);
            txtApePat.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(9, 52);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre:";
            // 
            // lblApePat
            // 
            lblApePat.AutoSize = true;
            lblApePat.Location = new Point(9, 130);
            lblApePat.Margin = new Padding(4, 0, 4, 0);
            lblApePat.Name = "lblApePat";
            lblApePat.Size = new Size(153, 25);
            lblApePat.TabIndex = 5;
            lblApePat.Text = "Apellido Parterno:";
            // 
            // lblApeMat
            // 
            lblApeMat.AutoSize = true;
            lblApeMat.Location = new Point(9, 220);
            lblApeMat.Margin = new Padding(4, 0, 4, 0);
            lblApeMat.Name = "lblApeMat";
            lblApeMat.Size = new Size(154, 25);
            lblApeMat.TabIndex = 5;
            lblApeMat.Text = "Apellido Materno:";
            lblApeMat.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(423, 52);
            lblDni.Margin = new Padding(4, 0, 4, 0);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(43, 25);
            lblDni.TabIndex = 5;
            lblDni.Text = "Dni:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 313);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(127, 25);
            label5.TabIndex = 5;
            label5.Text = "Departamento";
            // 
            // txtTelf
            // 
            txtTelf.Location = new Point(163, 565);
            txtTelf.Margin = new Padding(4, 5, 4, 5);
            txtTelf.MaxLength = 9;
            txtTelf.Name = "txtTelf";
            txtTelf.Size = new Size(193, 31);
            txtTelf.TabIndex = 1;
            txtTelf.KeyPress += txtDni_KeyPress;
            // 
            // cboDep
            // 
            cboDep.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDep.FormattingEnabled = true;
            cboDep.Location = new Point(163, 313);
            cboDep.Margin = new Padding(4, 5, 4, 5);
            cboDep.Name = "cboDep";
            cboDep.Size = new Size(231, 33);
            cboDep.TabIndex = 8;
            cboDep.SelectionChangeCommitted += cboDep_SelectionChangeCommitted;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpFecIng);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtApeMat);
            groupBox1.Controls.Add(cboDistrito);
            groupBox1.Controls.Add(cboProvincia);
            groupBox1.Controls.Add(txtTelf);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtDni);
            groupBox1.Controls.Add(chkActivo);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(cboDep);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(txtNomPro);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblApePat);
            groupBox1.Controls.Add(txtApePat);
            groupBox1.Controls.Add(lblDni);
            groupBox1.Controls.Add(lblApeMat);
            groupBox1.Location = new Point(46, 42);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(683, 785);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Personales";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dtpFecIng
            // 
            dtpFecIng.Format = DateTimePickerFormat.Short;
            dtpFecIng.Location = new Point(163, 675);
            dtpFecIng.Margin = new Padding(4, 5, 4, 5);
            dtpFecIng.Name = "dtpFecIng";
            dtpFecIng.Size = new Size(193, 31);
            dtpFecIng.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 685);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 10;
            label2.Text = "Ingreso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 565);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 12;
            label4.Text = "Telefono:";
            // 
            // txtApeMat
            // 
            txtApeMat.CharacterCasing = CharacterCasing.Upper;
            txtApeMat.Location = new Point(163, 215);
            txtApeMat.Margin = new Padding(4, 5, 4, 5);
            txtApeMat.Name = "txtApeMat";
            txtApeMat.Size = new Size(231, 31);
            txtApeMat.TabIndex = 16;
            // 
            // cboDistrito
            // 
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(163, 462);
            cboDistrito.Margin = new Padding(4, 5, 4, 5);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(231, 33);
            cboDistrito.TabIndex = 15;
            // 
            // cboProvincia
            // 
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(163, 390);
            cboProvincia.Margin = new Padding(4, 5, 4, 5);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(231, 33);
            cboProvincia.TabIndex = 14;
            cboProvincia.SelectionChangeCommitted += cboProvincia_SelectionChangeCommitted;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 467);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(70, 25);
            label7.TabIndex = 13;
            label7.Text = "Distrito";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 390);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(83, 25);
            label6.TabIndex = 12;
            label6.Text = "Provincia";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(471, 47);
            txtDni.Margin = new Padding(4, 5, 4, 5);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(141, 31);
            txtDni.TabIndex = 8;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(426, 320);
            chkActivo.Margin = new Padding(4, 5, 4, 5);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(96, 29);
            chkActivo.TabIndex = 10;
            chkActivo.Text = "Activo?";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(optM);
            groupBox2.Controls.Add(optF);
            groupBox2.Location = new Point(423, 150);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(251, 160);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Genero";
            // 
            // optM
            // 
            optM.AutoSize = true;
            optM.Checked = true;
            optM.Location = new Point(9, 70);
            optM.Margin = new Padding(4, 5, 4, 5);
            optM.Name = "optM";
            optM.Size = new Size(117, 29);
            optM.TabIndex = 9;
            optM.TabStop = true;
            optM.Text = "Masculino";
            optM.UseVisualStyleBackColor = true;
            // 
            // optF
            // 
            optF.AutoSize = true;
            optF.Location = new Point(141, 72);
            optF.Margin = new Padding(4, 5, 4, 5);
            optF.Name = "optF";
            optF.Size = new Size(105, 29);
            optF.TabIndex = 10;
            optF.Text = "Femenio";
            optF.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(337, 915);
            btnIngresar.Margin = new Padding(4, 5, 4, 5);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(147, 67);
            btnIngresar.TabIndex = 11;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(596, 915);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(133, 67);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmInsertarProfesor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(761, 1005);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            Controls.Add(groupBox1);
            Name = "FrmInsertarProfesor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insertar Profesor";
            Load += FrmInsertarProfesor_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
    }
}