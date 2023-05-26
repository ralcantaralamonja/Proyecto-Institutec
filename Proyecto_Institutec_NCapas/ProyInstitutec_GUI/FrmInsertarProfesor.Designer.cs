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
            grpDatos = new GroupBox();
            chkInactivo = new RadioButton();
            chkActivo = new RadioButton();
            cboGenero = new ComboBox();
            cboDistrito = new ComboBox();
            cboEspecialidad = new ComboBox();
            textTelefono = new TextBox();
            textCorreo = new TextBox();
            textDNI = new TextBox();
            textApellido = new TextBox();
            txtNombre = new TextBox();
            btnCancelar = new Button();
            btnGrabar = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
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
            grpDatos.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpDatos.Location = new Point(13, 11);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(502, 430);
            grpDatos.TabIndex = 1;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos";
            // 
            // chkInactivo
            // 
            chkInactivo.AutoSize = true;
            chkInactivo.Location = new Point(223, 317);
            chkInactivo.Name = "chkInactivo";
            chkInactivo.Size = new Size(94, 25);
            chkInactivo.TabIndex = 9;
            chkInactivo.TabStop = true;
            chkInactivo.Text = "Inactivo";
            chkInactivo.UseVisualStyleBackColor = true;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(136, 317);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(81, 25);
            chkActivo.TabIndex = 8;
            chkActivo.TabStop = true;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // cboGenero
            // 
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(136, 271);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(348, 29);
            cboGenero.TabIndex = 18;
            // 
            // cboDistrito
            // 
            cboDistrito.Cursor = Cursors.IBeam;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(136, 236);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(348, 29);
            cboDistrito.TabIndex = 6;
            // 
            // cboEspecialidad
            // 
            cboEspecialidad.Cursor = Cursors.IBeam;
            cboEspecialidad.FormattingEnabled = true;
            cboEspecialidad.Location = new Point(136, 201);
            cboEspecialidad.Name = "cboEspecialidad";
            cboEspecialidad.Size = new Size(348, 29);
            cboEspecialidad.TabIndex = 5;
            // 
            // textTelefono
            // 
            textTelefono.Cursor = Cursors.IBeam;
            textTelefono.Location = new Point(136, 168);
            textTelefono.Name = "textTelefono";
            textTelefono.Size = new Size(106, 27);
            textTelefono.TabIndex = 4;
            // 
            // textCorreo
            // 
            textCorreo.Cursor = Cursors.IBeam;
            textCorreo.Location = new Point(136, 135);
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(348, 27);
            textCorreo.TabIndex = 3;
            // 
            // textDNI
            // 
            textDNI.Cursor = Cursors.IBeam;
            textDNI.Location = new Point(136, 104);
            textDNI.Name = "textDNI";
            textDNI.Size = new Size(106, 27);
            textDNI.TabIndex = 2;
            // 
            // textApellido
            // 
            textApellido.Cursor = Cursors.IBeam;
            textApellido.Location = new Point(136, 68);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(348, 27);
            textApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(136, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(348, 27);
            txtNombre.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(371, 384);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 40);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(240, 384);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(125, 40);
            btnGrabar.TabIndex = 5;
            btnGrabar.Text = "GRABAR";
            btnGrabar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 321);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(68, 21);
            label9.TabIndex = 8;
            label9.Text = "Estado:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 274);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(73, 21);
            label8.TabIndex = 7;
            label8.Text = "Género:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 239);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(67, 21);
            label7.TabIndex = 6;
            label7.Text = "Distrito:";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 204);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(113, 21);
            label6.TabIndex = 5;
            label6.Text = "Especialidad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 171);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 4;
            label5.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 138);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 21);
            label4.TabIndex = 3;
            label4.Text = "Correo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 104);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 21);
            label3.TabIndex = 2;
            label3.Text = "DNI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 71);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 1;
            label2.Text = "Apellidos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 32);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // FrmInsertarProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 454);
            Controls.Add(grpDatos);
            Margin = new Padding(2);
            Name = "FrmInsertarProfesor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insertar Profesor";
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