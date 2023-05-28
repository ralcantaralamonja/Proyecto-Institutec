namespace ProyInstitutec_GUI
{
    partial class FrmCursoMan01
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            txtFiltro = new TextBox();
            lblRegistros = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCerrar = new Button();
            btnActualizar = new Button();
            btnInsertar = new Button();
            dtgDatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // txtFiltro
            // 
            txtFiltro.BackColor = SystemColors.ButtonHighlight;
            txtFiltro.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFiltro.Location = new Point(200, 12);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(335, 27);
            txtFiltro.TabIndex = 1;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // lblRegistros
            // 
            lblRegistros.BackColor = SystemColors.Window;
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegistros.Location = new Point(1086, 564);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(84, 30);
            lblRegistros.TabIndex = 4;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(980, 564);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 3;
            label2.Text = "REGISTROS:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(185, 21);
            label1.TabIndex = 0;
            label1.Text = "FILTRO POR CARRERA:";
            label1.Click += label1_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.BackColor = SystemColors.ControlLight;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.Location = new Point(1045, 609);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(125, 40);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "SALIR";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnActualizar.BackColor = SystemColors.ControlLight;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnActualizar.Location = new Point(846, 609);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(125, 40);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInsertar.BackColor = SystemColors.ControlLight;
            btnInsertar.FlatStyle = FlatStyle.Flat;
            btnInsertar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsertar.ForeColor = SystemColors.ControlText;
            btnInsertar.Location = new Point(715, 609);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(125, 40);
            btnInsertar.TabIndex = 5;
            btnInsertar.Text = "INSERTAR";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnAgregar_Click;
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(88, 183, 213);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.Window;
            dtgDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.BackgroundColor = SystemColors.ScrollBar;
            dtgDatos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(88, 183, 213);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dtgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(88, 183, 213);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dtgDatos.DefaultCellStyle = dataGridViewCellStyle8;
            dtgDatos.GridColor = Color.FromArgb(88, 183, 213);
            dtgDatos.Location = new Point(13, 54);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dtgDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(88, 183, 213);
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.Window;
            dtgDatos.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dtgDatos.RowTemplate.Height = 25;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(1157, 503);
            dtgDatos.TabIndex = 2;
            dtgDatos.TabStop = false;
            // 
            // FrmCursoMan01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(1184, 661);
            Controls.Add(txtFiltro);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(dtgDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCursoMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MANTENIMIENTO CURSO";
            Load += FrmCursoMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFiltro;
        private Label lblRegistros;
        private Label label2;
        private Label label1;
        private Button btnCerrar;
        private Button btnActualizar;
        private Button btnInsertar;
        private DataGridView dtgDatos;
    }
}