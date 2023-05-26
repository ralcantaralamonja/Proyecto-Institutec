﻿namespace ProyInstitutec_GUI
{
    partial class ActualizarCarrera
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
            btnCancelar = new Button();
            btnGrabar = new Button();
            cboFacultad = new ComboBox();
            label5 = new Label();
            txtDescripcion = new TextBox();
            label1 = new Label();
            lblCodigo = new Label();
            label7 = new Label();
            chkActivo = new CheckBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(334, 231);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 40);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.FlatStyle = FlatStyle.Flat;
            btnGrabar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGrabar.Location = new Point(203, 231);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(125, 40);
            btnGrabar.TabIndex = 7;
            btnGrabar.Text = "GRABAR";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // cboFacultad
            // 
            cboFacultad.BackColor = SystemColors.ScrollBar;
            cboFacultad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFacultad.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboFacultad.FormattingEnabled = true;
            cboFacultad.Location = new Point(21, 175);
            cboFacultad.Name = "cboFacultad";
            cboFacultad.Size = new Size(439, 29);
            cboFacultad.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(21, 151);
            label5.Name = "label5";
            label5.Size = new Size(210, 21);
            label5.TabIndex = 5;
            label5.Text = "SELECCIONE FACTULTAD:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.Location = new Point(21, 105);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(439, 27);
            txtDescripcion.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 81);
            label1.Name = "label1";
            label1.Size = new Size(161, 21);
            label1.TabIndex = 3;
            label1.Text = "NOMBRE CARRERA";
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodigo.Location = new Point(115, 27);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(70, 23);
            lblCodigo.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(21, 28);
            label7.Name = "label7";
            label7.Size = new Size(86, 21);
            label7.TabIndex = 0;
            label7.Text = "CÓDIGO:";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkActivo.Location = new Point(334, 27);
            chkActivo.Margin = new Padding(4, 3, 4, 3);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(93, 25);
            chkActivo.TabIndex = 2;
            chkActivo.Text = "ACTIVO";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // ActualizarCarrera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 299);
            Controls.Add(chkActivo);
            Controls.Add(lblCodigo);
            Controls.Add(label7);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(cboFacultad);
            Controls.Add(label5);
            Controls.Add(txtDescripcion);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ActualizarCarrera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ACTUALIZAR CARRERA";
            Load += ActualizarCarrera_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGrabar;
        private ComboBox cboFacultad;
        private Label label5;
        private TextBox txtDescripcion;
        private Label label1;
        private Label lblCodigo;
        private Label label7;
        private CheckBox chkActivo;
    }
}