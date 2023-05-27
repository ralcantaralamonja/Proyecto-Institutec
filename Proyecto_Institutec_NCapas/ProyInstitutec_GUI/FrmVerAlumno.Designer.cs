namespace ProyInstitutec_GUI
{
    partial class FrmVerAlumno
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
            label1 = new Label();
            mskDNIAlumno = new TextBox();
            dtgAlumno = new DataGridView();
            label2 = new Label();
            lblRegistros = new Label();
            btnInsertar = new Button();
            btnActualizar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgAlumno).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 55);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese DNI del Alumno:";
            // 
            // mskDNIAlumno
            // 
            mskDNIAlumno.Location = new Point(254, 52);
            mskDNIAlumno.Margin = new Padding(4, 5, 4, 5);
            mskDNIAlumno.Name = "mskDNIAlumno";
            mskDNIAlumno.Size = new Size(112, 26);
            mskDNIAlumno.TabIndex = 3;
            mskDNIAlumno.TextChanged += mskDNIAlumno_TextChanged;
            // 
            // dtgAlumno
            // 
            dtgAlumno.AllowUserToAddRows = false;
            dtgAlumno.AllowUserToDeleteRows = false;
            dtgAlumno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgAlumno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgAlumno.BackgroundColor = SystemColors.AppWorkspace;
            dtgAlumno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAlumno.Location = new Point(62, 92);
            dtgAlumno.Margin = new Padding(4, 5, 4, 5);
            dtgAlumno.Name = "dtgAlumno";
            dtgAlumno.ReadOnly = true;
            dtgAlumno.RowHeadersVisible = false;
            dtgAlumno.RowHeadersWidth = 62;
            dtgAlumno.RowTemplate.Height = 33;
            dtgAlumno.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgAlumno.Size = new Size(1233, 471);
            dtgAlumno.TabIndex = 2;
            dtgAlumno.CellContentClick += dtgAlumno_CellContentClick;
            dtgAlumno.CellDoubleClick += dtgAlumno_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1132, 578);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 4;
            label2.Text = "Registros:";
            // 
            // lblRegistros
            // 
            lblRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(1221, 577);
            lblRegistros.Margin = new Padding(4, 0, 4, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(80, 34);
            lblRegistros.TabIndex = 5;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(868, 632);
            btnInsertar.Margin = new Padding(4, 5, 4, 5);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(112, 35);
            btnInsertar.TabIndex = 6;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(1029, 632);
            btnActualizar.Margin = new Padding(4, 5, 4, 5);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(112, 35);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1190, 632);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 35);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmVerAlumno
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 709);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(dtgAlumno);
            Controls.Add(mskDNIAlumno);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FrmVerAlumno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VerAlumno";
            Load += VerAlumno_Load;
            ((System.ComponentModel.ISupportInitialize)dtgAlumno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox mskDNIAlumno;
        private DataGridView dtgAlumno;
        private Label label2;
        private Label lblRegistros;
        private Button btnInsertar;
        private Button btnActualizar;
        private Button btnSalir;
    }
}