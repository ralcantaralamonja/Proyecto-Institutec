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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
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
            groupBox1.Location = new Point(24, 14);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(660, 622);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(162, 486);
            chkActivo.Margin = new Padding(3, 4, 3, 4);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(131, 34);
            chkActivo.TabIndex = 77;
            chkActivo.Text = "ACTIVO";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(209, 45);
            lblCodigo.Margin = new Padding(4, 0, 4, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(93, 37);
            lblCodigo.TabIndex = 76;
            lblCodigo.Click += lblCodigo_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 385);
            label8.Name = "label8";
            label8.Size = new Size(296, 30);
            label8.TabIndex = 75;
            label8.Text = "FECHA DE NACIMIENTO:";
            // 
            // dtpFecNac
            // 
            dtpFecNac.CustomFormat = "dd/MM/yyyy ";
            dtpFecNac.Format = DateTimePickerFormat.Short;
            dtpFecNac.Location = new Point(359, 380);
            dtpFecNac.Margin = new Padding(3, 4, 3, 4);
            dtpFecNac.Name = "dtpFecNac";
            dtpFecNac.Size = new Size(166, 37);
            dtpFecNac.TabIndex = 74;
            dtpFecNac.Value = new DateTime(2023, 5, 26, 0, 0, 0, 0);
            // 
            // txtApeMat
            // 
            txtApeMat.Location = new Point(308, 245);
            txtApeMat.Margin = new Padding(3, 4, 3, 4);
            txtApeMat.Name = "txtApeMat";
            txtApeMat.Size = new Size(251, 37);
            txtApeMat.TabIndex = 73;
            // 
            // txtApePat
            // 
            txtApePat.Location = new Point(308, 172);
            txtApePat.Margin = new Padding(3, 4, 3, 4);
            txtApePat.Name = "txtApePat";
            txtApePat.Size = new Size(251, 37);
            txtApePat.TabIndex = 72;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(46, 245);
            label10.Name = "label10";
            label10.Size = new Size(256, 30);
            label10.TabIndex = 71;
            label10.Text = "APELLIDO MATERNO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 175);
            label2.Name = "label2";
            label2.Size = new Size(247, 30);
            label2.TabIndex = 70;
            label2.Text = "APELLIDO PATERNO:";
            // 
            // mskTelAlu
            // 
            mskTelAlu.Location = new Point(215, 310);
            mskTelAlu.Margin = new Padding(3, 4, 3, 4);
            mskTelAlu.Mask = "999999999";
            mskTelAlu.Name = "mskTelAlu";
            mskTelAlu.Size = new Size(150, 37);
            mskTelAlu.TabIndex = 68;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ControlLight;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(457, 529);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(179, 67);
            btnCancelar.TabIndex = 65;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = SystemColors.ControlLight;
            btnGrabar.FlatStyle = FlatStyle.Flat;
            btnGrabar.Location = new Point(262, 529);
            btnGrabar.Margin = new Padding(4, 5, 4, 5);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(179, 67);
            btnGrabar.TabIndex = 64;
            btnGrabar.Text = "GRABAR";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(46, 464);
            label9.Name = "label9";
            label9.Size = new Size(112, 30);
            label9.TabIndex = 14;
            label9.Text = "ESTADO:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 315);
            label6.Name = "label6";
            label6.Size = new Size(140, 30);
            label6.TabIndex = 8;
            label6.Text = "TELÉFONO:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(198, 107);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(361, 37);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 110);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(124, 30);
            label3.TabIndex = 30;
            label3.Text = "NOMBRE:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 46);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(157, 30);
            label1.TabIndex = 63;
            label1.Text = "ID ALUMNO:";
            // 
            // FrmActualizarAlumno
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 650);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}