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
            groupBox2 = new GroupBox();
            optFemenino = new RadioButton();
            optMasculino = new RadioButton();
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
            txtNdocum = new TextBox();
            gbActulizar.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbActulizar
            // 
            gbActulizar.BackColor = SystemColors.Control;
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
            gbActulizar.Location = new Point(22, 12);
            gbActulizar.Name = "gbActulizar";
            gbActulizar.Size = new Size(589, 660);
            gbActulizar.TabIndex = 0;
            gbActulizar.TabStop = false;
            gbActulizar.Text = "DATOS A ACTUALIZAR";
            gbActulizar.Enter += gbActulizar_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(optFemenino);
            groupBox2.Controls.Add(optMasculino);
            groupBox2.Location = new Point(346, 171);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Genero";
            // 
            // optFemenino
            // 
            optFemenino.AutoSize = true;
            optFemenino.Location = new Point(24, 69);
            optFemenino.Name = "optFemenino";
            optFemenino.Size = new Size(112, 25);
            optFemenino.TabIndex = 1;
            optFemenino.TabStop = true;
            optFemenino.Text = "FEMENINO";
            optFemenino.UseVisualStyleBackColor = true;
            // 
            // optMasculino
            // 
            optMasculino.AutoSize = true;
            optMasculino.Location = new Point(24, 27);
            optMasculino.Name = "optMasculino";
            optMasculino.Size = new Size(126, 25);
            optMasculino.TabIndex = 0;
            optMasculino.TabStop = true;
            optMasculino.Text = "MASCULINO";
            optMasculino.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(346, 39);
            label6.Name = "label6";
            label6.Size = new Size(43, 21);
            label6.TabIndex = 15;
            label6.Text = "DNI:";
            // 
            // dtpFecIng
            // 
            dtpFecIng.Format = DateTimePickerFormat.Short;
            dtpFecIng.Location = new Point(184, 345);
            dtpFecIng.Name = "dtpFecIng";
            dtpFecIng.Size = new Size(136, 27);
            dtpFecIng.TabIndex = 11;
            // 
            // lbltiempo
            // 
            lbltiempo.AutoSize = true;
            lbltiempo.Location = new Point(22, 350);
            lbltiempo.Name = "lbltiempo";
            lbltiempo.Size = new Size(144, 21);
            lbltiempo.TabIndex = 10;
            lbltiempo.Text = "FECHA INGRESO:";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.ControlLight;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Location = new Point(22, 553);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(125, 40);
            btnIngresar.TabIndex = 13;
            btnIngresar.Text = "GRABAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ControlLight;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(184, 553);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(125, 40);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "CANCELAR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(optInactivo);
            groupBox1.Controls.Add(optActivo);
            groupBox1.Location = new Point(22, 398);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(287, 120);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "¿DESABILITAR PROFESOR?";
            // 
            // optInactivo
            // 
            optInactivo.AutoSize = true;
            optInactivo.Location = new Point(151, 47);
            optInactivo.Name = "optInactivo";
            optInactivo.Size = new Size(109, 25);
            optInactivo.TabIndex = 1;
            optInactivo.TabStop = true;
            optInactivo.Text = "INACTIVO";
            optInactivo.UseVisualStyleBackColor = true;
            // 
            // optActivo
            // 
            optActivo.AutoSize = true;
            optActivo.Checked = true;
            optActivo.Location = new Point(21, 47);
            optActivo.Name = "optActivo";
            optActivo.Size = new Size(92, 25);
            optActivo.TabIndex = 0;
            optActivo.TabStop = true;
            optActivo.Text = "ACTIVO";
            optActivo.UseVisualStyleBackColor = true;
            // 
            // txtTelf
            // 
            txtTelf.Location = new Point(22, 303);
            txtTelf.MaxLength = 9;
            txtTelf.Name = "txtTelf";
            txtTelf.Size = new Size(287, 27);
            txtTelf.TabIndex = 9;
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(163, 39);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(66, 23);
            lblCodigo.TabIndex = 1;
            // 
            // txtApeMat
            // 
            txtApeMat.Location = new Point(22, 236);
            txtApeMat.Name = "txtApeMat";
            txtApeMat.Size = new Size(287, 27);
            txtApeMat.TabIndex = 7;
            // 
            // txtApePat
            // 
            txtApePat.Location = new Point(22, 171);
            txtApePat.Name = "txtApePat";
            txtApePat.Size = new Size(287, 27);
            txtApePat.TabIndex = 5;
            // 
            // txtNompro
            // 
            txtNompro.Location = new Point(22, 107);
            txtNompro.Name = "txtNompro";
            txtNompro.Size = new Size(287, 27);
            txtNompro.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 83);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 2;
            label5.Text = "NOMBRE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 212);
            label4.Name = "label4";
            label4.Size = new Size(175, 21);
            label4.TabIndex = 6;
            label4.Text = "APELLIDO MATERNO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 147);
            label3.Name = "label3";
            label3.Size = new Size(169, 21);
            label3.TabIndex = 4;
            label3.Text = "APELLIDO PATERNO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 276);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 8;
            label2.Text = "TELEFONO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 39);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 0;
            label1.Text = "ID PROFESOR";
            // 
            // txtNdocum
            // 
            txtNdocum.Location = new Point(346, 107);
            txtNdocum.MaxLength = 8;
            txtNdocum.Name = "txtNdocum";
            txtNdocum.Size = new Size(126, 27);
            txtNdocum.TabIndex = 16;
            txtNdocum.KeyPress += txtNdocum_KeyPress;
            // 
            // FrmActualizarProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 706);
            Controls.Add(gbActulizar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmActualizarProfesor";
            Text = "Actulizar Profesor";
            Load += FrmActualizarProfesor_Load;
            gbActulizar.ResumeLayout(false);
            gbActulizar.PerformLayout();
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
    }
}