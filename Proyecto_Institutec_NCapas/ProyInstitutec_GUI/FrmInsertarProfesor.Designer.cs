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
            txtNomPro.Location = new Point(72, 28);
            txtNomPro.Name = "txtNomPro";
            txtNomPro.Size = new Size(205, 23);
            txtNomPro.TabIndex = 0;
            // 
            // txtApePat
            // 
            txtApePat.CharacterCasing = CharacterCasing.Upper;
            txtApePat.Location = new Point(114, 78);
            txtApePat.Name = "txtApePat";
            txtApePat.Size = new Size(163, 23);
            txtApePat.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(6, 31);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre:";
            // 
            // lblApePat
            // 
            lblApePat.AutoSize = true;
            lblApePat.Location = new Point(6, 78);
            lblApePat.Name = "lblApePat";
            lblApePat.Size = new Size(102, 15);
            lblApePat.TabIndex = 5;
            lblApePat.Text = "Apellido Parterno:";
            // 
            // lblApeMat
            // 
            lblApeMat.AutoSize = true;
            lblApeMat.Location = new Point(6, 132);
            lblApeMat.Name = "lblApeMat";
            lblApeMat.Size = new Size(102, 15);
            lblApeMat.TabIndex = 5;
            lblApeMat.Text = "Apellido Materno:";
            lblApeMat.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(296, 31);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(28, 15);
            lblDni.TabIndex = 5;
            lblDni.Text = "Dni:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 188);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 5;
            label5.Text = "Departamento";
            // 
            // txtTelf
            // 
            txtTelf.Location = new Point(114, 339);
            txtTelf.MaxLength = 9;
            txtTelf.Name = "txtTelf";
            txtTelf.Size = new Size(136, 23);
            txtTelf.TabIndex = 1;
            txtTelf.KeyPress += txtDni_KeyPress;
            // 
            // cboDep
            // 
            cboDep.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDep.FormattingEnabled = true;
            cboDep.Location = new Point(114, 188);
            cboDep.Name = "cboDep";
            cboDep.Size = new Size(163, 23);
            cboDep.TabIndex = 8;
            cboDep.SelectionChangeCommitted += cboDep_SelectionChangeCommitted;
            // 
            // groupBox1
            // 
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
            groupBox1.Location = new Point(32, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(478, 471);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Personales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 411);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 10;
            label2.Text = "Ingreso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 339);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 12;
            label4.Text = "Telefono:";
            // 
            // txtApeMat
            // 
            txtApeMat.CharacterCasing = CharacterCasing.Upper;
            txtApeMat.Location = new Point(114, 129);
            txtApeMat.Name = "txtApeMat";
            txtApeMat.Size = new Size(163, 23);
            txtApeMat.TabIndex = 16;
            // 
            // cboDistrito
            // 
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(114, 277);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(163, 23);
            cboDistrito.TabIndex = 15;
            // 
            // cboProvincia
            // 
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(114, 234);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(163, 23);
            cboProvincia.TabIndex = 14;
            cboProvincia.SelectionChangeCommitted += cboProvincia_SelectionChangeCommitted;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 280);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 13;
            label7.Text = "Distrito";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 234);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 12;
            label6.Text = "Provincia";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(330, 28);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 8;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(298, 192);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(65, 19);
            chkActivo.TabIndex = 10;
            chkActivo.Text = "Activo?";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(optM);
            groupBox2.Controls.Add(optF);
            groupBox2.Location = new Point(296, 90);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(139, 74);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Genero";
            // 
            // optM
            // 
            optM.AutoSize = true;
            optM.Checked = true;
            optM.Location = new Point(26, 47);
            optM.Name = "optM";
            optM.Size = new Size(36, 19);
            optM.TabIndex = 9;
            optM.TabStop = true;
            optM.Text = "M";
            optM.UseVisualStyleBackColor = true;
            // 
            // optF
            // 
            optF.AutoSize = true;
            optF.Location = new Point(92, 47);
            optF.Name = "optF";
            optF.Size = new Size(31, 19);
            optF.TabIndex = 10;
            optF.Text = "F";
            optF.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(236, 549);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(103, 40);
            btnIngresar.TabIndex = 11;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(417, 549);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 40);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmInsertarProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 603);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
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
    }
}