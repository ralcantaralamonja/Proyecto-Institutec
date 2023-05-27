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
            lbltiempo = new Label();
            dtpFecIng = new DateTimePicker();
            gbActulizar.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbActulizar
            // 
            gbActulizar.BackColor = SystemColors.Control;
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
            gbActulizar.Location = new Point(22, 12);
            gbActulizar.Name = "gbActulizar";
            gbActulizar.Size = new Size(633, 333);
            gbActulizar.TabIndex = 0;
            gbActulizar.TabStop = false;
            gbActulizar.Text = "Datos a Actualizar ";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(408, 201);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(85, 40);
            btnIngresar.TabIndex = 9;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(523, 201);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(85, 40);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Cancelar";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(optInactivo);
            groupBox1.Controls.Add(optActivo);
            groupBox1.Location = new Point(408, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "¿Desabilitar al profesor?";
            // 
            // optInactivo
            // 
            optInactivo.AutoSize = true;
            optInactivo.Location = new Point(100, 46);
            optInactivo.Name = "optInactivo";
            optInactivo.Size = new Size(67, 19);
            optInactivo.TabIndex = 1;
            optInactivo.TabStop = true;
            optInactivo.Text = "Inactivo";
            optInactivo.UseVisualStyleBackColor = true;
            // 
            // optActivo
            // 
            optActivo.AutoSize = true;
            optActivo.Checked = true;
            optActivo.Location = new Point(15, 47);
            optActivo.Name = "optActivo";
            optActivo.Size = new Size(59, 19);
            optActivo.TabIndex = 0;
            optActivo.TabStop = true;
            optActivo.Text = "Activo";
            optActivo.UseVisualStyleBackColor = true;
            // 
            // txtTelf
            // 
            txtTelf.Location = new Point(129, 211);
            txtTelf.MaxLength = 9;
            txtTelf.Name = "txtTelf";
            txtTelf.Size = new Size(136, 23);
            txtTelf.TabIndex = 7;
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(129, 33);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(66, 23);
            lblCodigo.TabIndex = 6;
            // 
            // txtApeMat
            // 
            txtApeMat.Location = new Point(129, 158);
            txtApeMat.Name = "txtApeMat";
            txtApeMat.Size = new Size(191, 23);
            txtApeMat.TabIndex = 5;
            // 
            // txtApePat
            // 
            txtApePat.Location = new Point(129, 115);
            txtApePat.Name = "txtApePat";
            txtApePat.Size = new Size(191, 23);
            txtApePat.TabIndex = 5;
            // 
            // txtNompro
            // 
            txtNompro.Location = new Point(129, 76);
            txtNompro.Name = "txtNompro";
            txtNompro.Size = new Size(214, 23);
            txtNompro.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 79);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 1;
            label5.Text = "Nombre :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 166);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 1;
            label4.Text = "Apellido Materno :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 123);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 1;
            label3.Text = "Apellido Paterno :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 214);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Telefono :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 34);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "ID Profesor";
            // 
            // lbltiempo
            // 
            lbltiempo.AutoSize = true;
            lbltiempo.Location = new Point(26, 279);
            lbltiempo.Name = "lbltiempo";
            lbltiempo.Size = new Size(86, 15);
            lbltiempo.TabIndex = 10;
            lbltiempo.Text = "Fecha ingreso :";
            // 
            // dtpFecIng
            // 
            dtpFecIng.Format = DateTimePickerFormat.Short;
            dtpFecIng.Location = new Point(129, 273);
            dtpFecIng.Name = "dtpFecIng";
            dtpFecIng.Size = new Size(136, 23);
            dtpFecIng.TabIndex = 11;
            // 
            // FrmActualizarProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 381);
            Controls.Add(gbActulizar);
            Name = "FrmActualizarProfesor";
            Text = "Actulizar Profesor";
            Load += FrmActualizarProfesor_Load;
            gbActulizar.ResumeLayout(false);
            gbActulizar.PerformLayout();
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
    }
}