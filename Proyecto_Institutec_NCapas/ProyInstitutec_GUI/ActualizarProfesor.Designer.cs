namespace ProyInstitutec_GUI
{
    partial class ActualizarProfesor
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
            grpDatos = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnGrabar = new Button();
            btnCancelar = new Button();
            txtNombre = new TextBox();
            textApellido = new TextBox();
            textDNI = new TextBox();
            textCorreo = new TextBox();
            textTelefono = new TextBox();
            cboEspecialidad = new ComboBox();
            cboDistrito = new ComboBox();
            cboGenero = new ComboBox();
            chkActivo = new RadioButton();
            chkInactivo = new RadioButton();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(chkInactivo);
            grpDatos.Controls.Add(chkActivo);
            grpDatos.Controls.Add(cboGenero);
            grpDatos.Controls.Add(cboDistrito);
            grpDatos.Controls.Add(cboEspecialidad);
            grpDatos.Controls.Add(textTelefono);
            grpDatos.Controls.Add(textCorreo);
            grpDatos.Controls.Add(textDNI);
            grpDatos.Controls.Add(textApellido);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(btnCancelar);
            grpDatos.Controls.Add(btnGrabar);
            grpDatos.Controls.Add(label9);
            grpDatos.Controls.Add(label8);
            grpDatos.Controls.Add(label7);
            grpDatos.Controls.Add(label6);
            grpDatos.Controls.Add(label5);
            grpDatos.Controls.Add(label4);
            grpDatos.Controls.Add(label3);
            grpDatos.Controls.Add(label2);
            grpDatos.Controls.Add(label1);
            grpDatos.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            grpDatos.Location = new Point(18, 18);
            grpDatos.Margin = new Padding(4, 5, 4, 5);
            grpDatos.Name = "grpDatos";
            grpDatos.Padding = new Padding(4, 5, 4, 5);
            grpDatos.Size = new Size(596, 578);
            grpDatos.TabIndex = 1;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 78);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 124);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Apellidos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 167);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "DNI:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 213);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 3;
            label4.Text = "Correo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 258);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 4;
            label5.Text = "Telefono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 309);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 5;
            label6.Text = "Especialidad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 366);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 6;
            label7.Text = "Distrito:";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(51, 437);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 7;
            label8.Text = "Género:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(307, 438);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 8;
            label9.Text = "Estado:";
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(307, 504);
            btnGrabar.Margin = new Padding(4, 5, 4, 5);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(108, 37);
            btnGrabar.TabIndex = 5;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(450, 507);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 37);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(153, 73);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(316, 26);
            txtNombre.TabIndex = 0;
            // 
            // textApellido
            // 
            textApellido.Cursor = Cursors.IBeam;
            textApellido.Location = new Point(153, 119);
            textApellido.Margin = new Padding(4, 5, 4, 5);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(316, 26);
            textApellido.TabIndex = 1;
            // 
            // textDNI
            // 
            textDNI.Cursor = Cursors.IBeam;
            textDNI.Location = new Point(153, 165);
            textDNI.Margin = new Padding(4, 5, 4, 5);
            textDNI.Name = "textDNI";
            textDNI.Size = new Size(122, 26);
            textDNI.TabIndex = 2;
            // 
            // textCorreo
            // 
            textCorreo.Cursor = Cursors.IBeam;
            textCorreo.Location = new Point(153, 212);
            textCorreo.Margin = new Padding(4, 5, 4, 5);
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(300, 26);
            textCorreo.TabIndex = 3;
            // 
            // textTelefono
            // 
            textTelefono.Cursor = Cursors.IBeam;
            textTelefono.Location = new Point(153, 253);
            textTelefono.Margin = new Padding(4, 5, 4, 5);
            textTelefono.Name = "textTelefono";
            textTelefono.Size = new Size(126, 26);
            textTelefono.TabIndex = 4;
            // 
            // cboEspecialidad
            // 
            cboEspecialidad.Cursor = Cursors.IBeam;
            cboEspecialidad.FormattingEnabled = true;
            cboEspecialidad.Location = new Point(153, 302);
            cboEspecialidad.Margin = new Padding(4, 5, 4, 5);
            cboEspecialidad.Name = "cboEspecialidad";
            cboEspecialidad.Size = new Size(300, 28);
            cboEspecialidad.TabIndex = 5;
            // 
            // cboDistrito
            // 
            cboDistrito.Cursor = Cursors.IBeam;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(130, 359);
            cboDistrito.Margin = new Padding(4, 5, 4, 5);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(300, 28);
            cboDistrito.TabIndex = 6;
            // 
            // cboGenero
            // 
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(121, 435);
            cboGenero.Margin = new Padding(4, 5, 4, 5);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(150, 28);
            cboGenero.TabIndex = 18;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(377, 436);
            chkActivo.Margin = new Padding(4, 5, 4, 5);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(77, 24);
            chkActivo.TabIndex = 8;
            chkActivo.TabStop = true;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // chkInactivo
            // 
            chkInactivo.AutoSize = true;
            chkInactivo.Location = new Point(460, 437);
            chkInactivo.Margin = new Padding(4, 5, 4, 5);
            chkInactivo.Name = "chkInactivo";
            chkInactivo.Size = new Size(89, 24);
            chkInactivo.TabIndex = 9;
            chkInactivo.TabStop = true;
            chkInactivo.Text = "Inactivo";
            chkInactivo.UseVisualStyleBackColor = true;
            // 
            // ActualizarProfesor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 611);
            Controls.Add(grpDatos);
            Name = "ActualizarProfesor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ActualizarProfesor";
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        internal GroupBox grpDatos;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton chkInactivo;
        private RadioButton chkActivo;
        private ComboBox cboGenero;
        internal ComboBox cboDistrito;
        private ComboBox cboEspecialidad;
        internal TextBox textTelefono;
        internal TextBox textCorreo;
        internal TextBox textDNI;
        private TextBox textApellido;
        internal TextBox txtNombre;
        private Button btnCancelar;
        private Button btnGrabar;
        private Label label9;
        private Label label8;
    }
}