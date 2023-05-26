namespace ProyInstitutec_GUI
{
    partial class FrmProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfesor));
            label1 = new Label();
            mskDNIProfesor = new TextBox();
            dtgProfesor = new DataGridView();
            btnInsertar = new Button();
            btnActualizar = new Button();
            btnSalir = new Button();
            label2 = new Label();
            LblRegistros = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgProfesor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 13);
            label1.TabIndex = 0;
            label1.Text = "Ingrese Dni del Profesor:";
            label1.Click += label1_Click;
            // 
            // mskDNIProfesor
            // 
            mskDNIProfesor.Location = new Point(176, 38);
            mskDNIProfesor.Margin = new Padding(3, 2, 3, 2);
            mskDNIProfesor.MaxLength = 8;
            mskDNIProfesor.Name = "mskDNIProfesor";
            mskDNIProfesor.Size = new Size(181, 20);
            mskDNIProfesor.TabIndex = 1;
            mskDNIProfesor.TextChanged += mskDNIProfesor_TextChanged;
            // 
            // dtgProfesor
            // 
            dtgProfesor.AllowUserToAddRows = false;
            dtgProfesor.AllowUserToDeleteRows = false;
            dtgProfesor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgProfesor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgProfesor.BackgroundColor = SystemColors.AppWorkspace;
            dtgProfesor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProfesor.Location = new Point(36, 94);
            dtgProfesor.Margin = new Padding(4);
            dtgProfesor.Name = "dtgProfesor";
            dtgProfesor.ReadOnly = true;
            dtgProfesor.RowHeadersVisible = false;
            dtgProfesor.RowHeadersWidth = 62;
            dtgProfesor.RowTemplate.Height = 33;
            dtgProfesor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProfesor.Size = new Size(1279, 452);
            dtgProfesor.TabIndex = 2;
            dtgProfesor.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(868, 632);
            btnInsertar.Margin = new Padding(4, 5, 4, 5);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(112, 35);
            btnInsertar.TabIndex = 5;
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
            btnActualizar.TabIndex = 6;
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
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1131, 592);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 13);
            label2.TabIndex = 3;
            label2.Text = "Registros:";
            label2.Click += label2_Click;
            // 
            // LblRegistros
            // 
            LblRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LblRegistros.BorderStyle = BorderStyle.FixedSingle;
            LblRegistros.Location = new Point(1221, 577);
            LblRegistros.Margin = new Padding(4, 0, 4, 0);
            LblRegistros.Name = "LblRegistros";
            LblRegistros.Size = new Size(80, 34);
            LblRegistros.TabIndex = 4;
            LblRegistros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmProfesor
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 709);
            Controls.Add(LblRegistros);
            Controls.Add(label2);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(mskDNIProfesor);
            Controls.Add(label1);
            Controls.Add(dtgProfesor);
            Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "FrmProfesor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ver Profesor";
            Load += FrmProfesor_Load;
            ((System.ComponentModel.ISupportInitialize)dtgProfesor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox mskDNIProfesor;
        private DataGridView dtgProfesor;
        private Button btnInsertar;
        private Button btnActualizar;
        private Button btnSalir;
        private Label label2;
        private Label LblRegistros;
    }
}