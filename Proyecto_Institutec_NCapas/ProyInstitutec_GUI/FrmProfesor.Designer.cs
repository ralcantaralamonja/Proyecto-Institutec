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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfesor));
            mskDNIProfesor = new TextBox();
            dtgProfesor = new DataGridView();
            btnInsertar = new Button();
            btnActualizar = new Button();
            btnSalir = new Button();
            LblRegistros = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgProfesor).BeginInit();
            SuspendLayout();
            // 
            // mskDNIProfesor
            // 
            mskDNIProfesor.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mskDNIProfesor.Location = new Point(118, 15);
            mskDNIProfesor.Margin = new Padding(3, 2, 3, 2);
            mskDNIProfesor.MaxLength = 8;
            mskDNIProfesor.Name = "mskDNIProfesor";
            mskDNIProfesor.Size = new Size(181, 27);
            mskDNIProfesor.TabIndex = 1;
            mskDNIProfesor.TextChanged += mskDNIProfesor_TextChanged;
            // 
            // dtgProfesor
            // 
            dtgProfesor.AllowUserToAddRows = false;
            dtgProfesor.AllowUserToDeleteRows = false;
            dtgProfesor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgProfesor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgProfesor.BackgroundColor = SystemColors.ScrollBar;
            dtgProfesor.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(88, 183, 213);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgProfesor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgProfesor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(88, 183, 213);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgProfesor.DefaultCellStyle = dataGridViewCellStyle2;
            dtgProfesor.GridColor = Color.FromArgb(88, 183, 213);
            dtgProfesor.Location = new Point(13, 61);
            dtgProfesor.Margin = new Padding(4);
            dtgProfesor.Name = "dtgProfesor";
            dtgProfesor.ReadOnly = true;
            dtgProfesor.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(88, 183, 213);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgProfesor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgProfesor.RowHeadersVisible = false;
            dtgProfesor.RowHeadersWidth = 62;
            dtgProfesor.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(88, 183, 213);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Window;
            dtgProfesor.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dtgProfesor.RowTemplate.Height = 33;
            dtgProfesor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProfesor.Size = new Size(1313, 485);
            dtgProfesor.TabIndex = 2;
            dtgProfesor.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = SystemColors.ControlLight;
            btnInsertar.FlatStyle = FlatStyle.Flat;
            btnInsertar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsertar.Location = new Point(882, 613);
            btnInsertar.Margin = new Padding(4, 5, 4, 5);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(125, 40);
            btnInsertar.TabIndex = 5;
            btnInsertar.Text = "INSERTAR";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ControlLight;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnActualizar.Location = new Point(1015, 613);
            btnActualizar.Margin = new Padding(4, 5, 4, 5);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(125, 40);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ControlLight;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(1201, 613);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(125, 40);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // LblRegistros
            // 
            LblRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LblRegistros.BackColor = SystemColors.Window;
            LblRegistros.BorderStyle = BorderStyle.FixedSingle;
            LblRegistros.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblRegistros.Location = new Point(1242, 550);
            LblRegistros.Margin = new Padding(4, 0, 4, 0);
            LblRegistros.Name = "LblRegistros";
            LblRegistros.Size = new Size(84, 30);
            LblRegistros.TabIndex = 4;
            LblRegistros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 18);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 8;
            label1.Text = "FILTRO DNI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1135, 559);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 9;
            label2.Text = "REGISTROS:";
            // 
            // FrmProfesor
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 667);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LblRegistros);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(mskDNIProfesor);
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
        private TextBox mskDNIProfesor;
        private DataGridView dtgProfesor;
        private Button btnInsertar;
        private Button btnActualizar;
        private Button btnSalir;
        private Label LblRegistros;
        private Label label1;
        private Label label2;
    }
}