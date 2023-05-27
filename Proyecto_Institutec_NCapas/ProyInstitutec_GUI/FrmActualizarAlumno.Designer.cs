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
            lblCodigo = new Label();
            label8 = new Label();
            dtpFecha_Nac = new DateTimePicker();
            txtApeMat = new TextBox();
            txtApePat = new TextBox();
            label10 = new Label();
            label2 = new Label();
            mskTelAlu = new MaskedTextBox();
            LblCodAlu = new Label();
            btnCancelar = new Button();
            btnGrabar = new Button();
            label9 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            label1 = new Label();
            chkActivo = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkActivo);
            groupBox1.Controls.Add(lblCodigo);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dtpFecha_Nac);
            groupBox1.Controls.Add(txtApeMat);
            groupBox1.Controls.Add(txtApePat);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(mskTelAlu);
            groupBox1.Controls.Add(LblCodAlu);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnGrabar);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(24, 14);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(660, 578);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(146, 46);
            lblCodigo.Margin = new Padding(4, 0, 4, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(93, 37);
            lblCodigo.TabIndex = 76;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 389);
            label8.Name = "label8";
            label8.Size = new Size(163, 20);
            label8.TabIndex = 75;
            label8.Text = "Fecha de Nacimiento:";
            // 
            // dtpFecha_Nac
            // 
            dtpFecha_Nac.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            dtpFecha_Nac.Format = DateTimePickerFormat.Short;
            dtpFecha_Nac.Location = new Point(231, 384);
            dtpFecha_Nac.Name = "dtpFecha_Nac";
            dtpFecha_Nac.Size = new Size(166, 26);
            dtpFecha_Nac.TabIndex = 74;
            dtpFecha_Nac.Value = new DateTime(2023, 5, 26, 0, 0, 0, 0);
            // 
            // txtApeMat
            // 
            txtApeMat.Location = new Point(215, 242);
            txtApeMat.Name = "txtApeMat";
            txtApeMat.Size = new Size(251, 26);
            txtApeMat.TabIndex = 73;
            // 
            // txtApePat
            // 
            txtApePat.Location = new Point(215, 172);
            txtApePat.Name = "txtApePat";
            txtApePat.Size = new Size(251, 26);
            txtApePat.TabIndex = 72;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(46, 245);
            label10.Name = "label10";
            label10.Size = new Size(132, 20);
            label10.TabIndex = 71;
            label10.Text = "Apellido Materno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 175);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 70;
            label2.Text = "Apellido Paterno:";
            // 
            // mskTelAlu
            // 
            mskTelAlu.Location = new Point(215, 310);
            mskTelAlu.Mask = "999999999";
            mskTelAlu.Name = "mskTelAlu";
            mskTelAlu.Size = new Size(150, 26);
            mskTelAlu.TabIndex = 68;
            // 
            // LblCodAlu
            // 
            LblCodAlu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LblCodAlu.BorderStyle = BorderStyle.FixedSingle;
            LblCodAlu.Location = new Point(70, -67);
            LblCodAlu.Margin = new Padding(4, 0, 4, 0);
            LblCodAlu.Name = "LblCodAlu";
            LblCodAlu.Size = new Size(95, 30);
            LblCodAlu.TabIndex = 66;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(478, 516);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 65;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(342, 516);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(112, 34);
            btnGrabar.TabIndex = 64;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(46, 464);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 14;
            label9.Text = "Estado:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 316);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 8;
            label6.Text = "Teléfono:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(215, 107);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(297, 26);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 110);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 30;
            label3.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 63;
            label1.Text = "ID Alumno:";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(146, 460);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(78, 24);
            chkActivo.TabIndex = 77;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // FrmActualizarAlumno
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 606);
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
        private TextBox txtNombre;
        private Label label3;
        private Label label1;
        private TextBox textBox4;
        private Label label6;
        private ComboBox comboBox2;
        private Label label9;
        private Button btnGrabar;
        private Label LblCodAlu;
        private Button btnCancelar;
        private MaskedTextBox mskTelAlu;
        private TextBox txtApeMat;
        private TextBox txtApePat;
        private Label label10;
        private Label label2;
        internal DateTimePicker dtpFecha_Nac;
        private Label label8;
        private Label lblCodigo;
        private CheckBox chkActivo;
    }
}