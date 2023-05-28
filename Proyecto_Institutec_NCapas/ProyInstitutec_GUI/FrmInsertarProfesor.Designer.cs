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
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtNomPro
            // 
            txtNomPro.CharacterCasing = CharacterCasing.Upper;
            txtNomPro.Location = new Point(27, 110);
            txtNomPro.Margin = new Padding(4, 5, 4, 5);
            txtNomPro.Name = "txtNomPro";
            txtNomPro.Size = new Size(445, 37);
            txtNomPro.TabIndex = 1;
            // 
            // txtApePat
            // 
            txtApePat.CharacterCasing = CharacterCasing.Upper;
            txtApePat.Location = new Point(27, 215);
            txtApePat.Margin = new Padding(4, 5, 4, 5);
            txtApePat.Name = "txtApePat";
            txtApePat.Size = new Size(445, 37);
            txtApePat.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(27, 70);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(124, 30);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "NOMBRE:";
            // 
            // lblApePat
            // 
            lblApePat.AutoSize = true;
            lblApePat.Location = new Point(26, 175);
            lblApePat.Margin = new Padding(4, 0, 4, 0);
            lblApePat.Name = "lblApePat";
            lblApePat.Size = new Size(240, 30);
            lblApePat.TabIndex = 2;
            lblApePat.Text = "APELLIDO PATERNO";
            // 
            // lblApeMat
            // 
            lblApeMat.AutoSize = true;
            lblApeMat.Location = new Point(27, 280);
            lblApeMat.Margin = new Padding(4, 0, 4, 0);
            lblApeMat.Name = "lblApeMat";
            lblApeMat.Size = new Size(256, 30);
            lblApeMat.TabIndex = 4;
            lblApeMat.Text = "APELLIDO MATERNO:";
            lblApeMat.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(500, 70);
            lblDni.Margin = new Padding(4, 0, 4, 0);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(62, 30);
            lblDni.TabIndex = 6;
            lblDni.Text = "DNI:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 402);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(211, 30);
            label5.TabIndex = 11;
            label5.Text = "DEPARTAMENTO:";
            // 
            // txtTelf
            // 
            txtTelf.Location = new Point(170, 760);
            txtTelf.Margin = new Padding(4, 5, 4, 5);
            txtTelf.MaxLength = 9;
            txtTelf.Name = "txtTelf";
            txtTelf.Size = new Size(301, 37);
            txtTelf.TabIndex = 18;
            txtTelf.KeyPress += txtDni_KeyPress;
            // 
            // cboDep
            // 
            cboDep.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDep.FormattingEnabled = true;
            cboDep.Location = new Point(26, 442);
            cboDep.Margin = new Padding(4, 5, 4, 5);
            cboDep.Name = "cboDep";
            cboDep.Size = new Size(447, 38);
            cboDep.TabIndex = 12;
            cboDep.SelectionChangeCommitted += cboDep_SelectionChangeCommitted;
            // 
            // groupBox1
            // 
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
            groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(17, 20);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(774, 1036);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS PERSONALES";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ControlLight;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(573, 960);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(179, 67);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dtpFecIng
            // 
            dtpFecIng.Format = DateTimePickerFormat.Short;
            dtpFecIng.Location = new Point(170, 862);
            dtpFecIng.Margin = new Padding(4, 5, 4, 5);
            dtpFecIng.Name = "dtpFecIng";
            dtpFecIng.Size = new Size(307, 37);
            dtpFecIng.TabIndex = 20;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.ControlLight;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.Location = new Point(383, 960);
            btnIngresar.Margin = new Padding(4, 5, 4, 5);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(179, 67);
            btnIngresar.TabIndex = 21;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 872);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 30);
            label2.TabIndex = 19;
            label2.Text = "INGRESO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 770);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(140, 30);
            label4.TabIndex = 17;
            label4.Text = "TELEFONO:";
            // 
            // txtApeMat
            // 
            txtApeMat.CharacterCasing = CharacterCasing.Upper;
            txtApeMat.Location = new Point(27, 323);
            txtApeMat.Margin = new Padding(4, 5, 4, 5);
            txtApeMat.Name = "txtApeMat";
            txtApeMat.Size = new Size(445, 37);
            txtApeMat.TabIndex = 5;
            // 
            // cboDistrito
            // 
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(26, 685);
            cboDistrito.Margin = new Padding(4, 5, 4, 5);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(447, 38);
            cboDistrito.TabIndex = 16;
            // 
            // cboProvincia
            // 
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(26, 568);
            cboProvincia.Margin = new Padding(4, 5, 4, 5);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(447, 38);
            cboProvincia.TabIndex = 14;
            cboProvincia.SelectionChangeCommitted += cboProvincia_SelectionChangeCommitted;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 645);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(120, 30);
            label7.TabIndex = 15;
            label7.Text = "DISTRITO:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 528);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(154, 30);
            label6.TabIndex = 13;
            label6.Text = "PROVINCIA:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(500, 110);
            txtDni.Margin = new Padding(4, 5, 4, 5);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(250, 37);
            txtDni.TabIndex = 7;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(500, 402);
            chkActivo.Margin = new Padding(4, 5, 4, 5);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(131, 34);
            chkActivo.TabIndex = 10;
            chkActivo.Text = "ACTIVO";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(optM);
            groupBox2.Controls.Add(optF);
            groupBox2.Location = new Point(500, 215);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(251, 160);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "GENERO";
            // 
            // optM
            // 
            optM.AutoSize = true;
            optM.Checked = true;
            optM.Location = new Point(64, 43);
            optM.Margin = new Padding(4, 5, 4, 5);
            optM.Name = "optM";
            optM.Size = new Size(182, 34);
            optM.TabIndex = 0;
            optM.TabStop = true;
            optM.Text = "MASCULINO";
            optM.UseVisualStyleBackColor = true;
            // 
            // optF
            // 
            optF.AutoSize = true;
            optF.Location = new Point(64, 95);
            optF.Margin = new Padding(4, 5, 4, 5);
            optF.Name = "optF";
            optF.Size = new Size(162, 34);
            optF.TabIndex = 1;
            optF.Text = "FEMENINO";
            optF.UseVisualStyleBackColor = true;
            // 
            // FrmInsertarProfesor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(814, 1050);
            Controls.Add(groupBox1);
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