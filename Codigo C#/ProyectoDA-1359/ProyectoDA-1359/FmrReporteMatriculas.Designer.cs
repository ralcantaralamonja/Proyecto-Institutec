namespace ProyectoDA_1359
{
    partial class FmrReporteMatriculas
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
            this.label4 = new System.Windows.Forms.Label();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.mskAño = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.dtgReporteDocentes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.mskAlumnos = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReporteDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 47;
            this.label4.Text = "CURSO:";
            // 
            // cboCurso
            // 
            this.cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(291, 22);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(153, 23);
            this.cboCurso.TabIndex = 1;
            // 
            // mskAño
            // 
            this.mskAño.Location = new System.Drawing.Point(89, 19);
            this.mskAño.Mask = "9999";
            this.mskAño.Name = "mskAño";
            this.mskAño.Size = new System.Drawing.Size(100, 23);
            this.mskAño.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "AÑO";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(492, 69);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(135, 34);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(490, 19);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(137, 34);
            this.btnReporte.TabIndex = 3;
            this.btnReporte.Text = "REPORTE";
            this.btnReporte.UseVisualStyleBackColor = true;
            // 
            // dtgReporteDocentes
            // 
            this.dtgReporteDocentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgReporteDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReporteDocentes.Location = new System.Drawing.Point(32, 133);
            this.dtgReporteDocentes.Name = "dtgReporteDocentes";
            this.dtgReporteDocentes.RowTemplate.Height = 25;
            this.dtgReporteDocentes.Size = new System.Drawing.Size(623, 293);
            this.dtgReporteDocentes.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 48;
            this.label1.Text = "ALUMNOS:";
            // 
            // mskAlumnos
            // 
            this.mskAlumnos.Location = new System.Drawing.Point(121, 80);
            this.mskAlumnos.Name = "mskAlumnos";
            this.mskAlumnos.Size = new System.Drawing.Size(100, 23);
            this.mskAlumnos.TabIndex = 2;
            // 
            // FmrReporteMatriculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 466);
            this.Controls.Add(this.mskAlumnos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboCurso);
            this.Controls.Add(this.mskAño);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.dtgReporteDocentes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FmrReporteMatriculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE DE MATRICULAS";
            ((System.ComponentModel.ISupportInitialize)(this.dtgReporteDocentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private ComboBox cboCurso;
        private MaskedTextBox mskAño;
        private Label label3;
        private Button btnSalir;
        private Button btnReporte;
        private DataGridView dtgReporteDocentes;
        private Label label1;
        private MaskedTextBox mskAlumnos;
    }
}