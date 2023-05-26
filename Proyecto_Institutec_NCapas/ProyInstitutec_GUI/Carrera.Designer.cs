namespace ProyInstitutec_GUI
{
    partial class Carrera
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtNomCarrera = new TextBox();
            dgtCarrera = new DataGridView();
            CodCar = new DataGridViewTextBoxColumn();
            DesCar = new DataGridViewTextBoxColumn();
            DesFac = new DataGridViewTextBoxColumn();
            label2 = new Label();
            lblRegistros = new Label();
            btnSalir = new Button();
            btnActualizar = new Button();
            btnInsertar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgtCarrera).BeginInit();
            SuspendLayout();
            // 
            // txtNomCarrera
            // 
            txtNomCarrera.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomCarrera.Location = new Point(200, 9);
            txtNomCarrera.Margin = new Padding(3, 2, 3, 2);
            txtNomCarrera.Name = "txtNomCarrera";
            txtNomCarrera.Size = new Size(309, 27);
            txtNomCarrera.TabIndex = 2;
            txtNomCarrera.TextChanged += txtNomCarrera_TextChanged;
            // 
            // dgtCarrera
            // 
            dgtCarrera.AllowUserToAddRows = false;
            dgtCarrera.AllowUserToDeleteRows = false;
            dgtCarrera.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgtCarrera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgtCarrera.BackgroundColor = SystemColors.ScrollBar;
            dgtCarrera.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(88, 183, 213);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgtCarrera.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgtCarrera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtCarrera.Columns.AddRange(new DataGridViewColumn[] { CodCar, DesCar, DesFac });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(88, 183, 213);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgtCarrera.DefaultCellStyle = dataGridViewCellStyle3;
            dgtCarrera.GridColor = Color.FromArgb(88, 183, 213);
            dgtCarrera.Location = new Point(12, 50);
            dgtCarrera.Name = "dgtCarrera";
            dgtCarrera.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Empty;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(88, 183, 213);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgtCarrera.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgtCarrera.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = Color.Empty;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(88, 183, 213);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.Window;
            dgtCarrera.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgtCarrera.RowTemplate.Height = 25;
            dgtCarrera.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgtCarrera.Size = new Size(726, 296);
            dgtCarrera.TabIndex = 3;
            // 
            // CodCar
            // 
            CodCar.DataPropertyName = "CodCar";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            CodCar.DefaultCellStyle = dataGridViewCellStyle2;
            CodCar.HeaderText = "Codigo";
            CodCar.Name = "CodCar";
            CodCar.ReadOnly = true;
            // 
            // DesCar
            // 
            DesCar.DataPropertyName = "DesCar";
            DesCar.HeaderText = "Descripcion";
            DesCar.Name = "DesCar";
            DesCar.ReadOnly = true;
            // 
            // DesFac
            // 
            DesFac.DataPropertyName = "DesFac";
            DesFac.HeaderText = "Facultad";
            DesFac.Name = "DesFac";
            DesFac.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(550, 372);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 4;
            label2.Text = "REGISTROS:";
            // 
            // lblRegistros
            // 
            lblRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistros.BackColor = SystemColors.Window;
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegistros.Location = new Point(658, 365);
            lblRegistros.Margin = new Padding(4, 0, 4, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(80, 34);
            lblRegistros.TabIndex = 5;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSalir
            // 
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(613, 420);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(125, 40);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnActualizar.Location = new Point(430, 420);
            btnActualizar.Margin = new Padding(4, 5, 4, 5);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(125, 40);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.FlatStyle = FlatStyle.Flat;
            btnInsertar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsertar.Location = new Point(297, 420);
            btnInsertar.Margin = new Padding(4, 5, 4, 5);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(125, 40);
            btnInsertar.TabIndex = 8;
            btnInsertar.Text = "INSERTAR";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(182, 21);
            label1.TabIndex = 11;
            label1.Text = "FILTRO DE BUSQUEDA:";
            // 
            // Carrera
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 480);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(dgtCarrera);
            Controls.Add(txtNomCarrera);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Carrera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Carrera";
            Load += Carrera_Load;
            ((System.ComponentModel.ISupportInitialize)dgtCarrera).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNomCarrera;
        private DataGridView dgtCarrera;
        private Label label2;
        private Label lblRegistros;
        private Button btnSalir;
        private Button btnActualizar;
        private Button btnInsertar;
        private DataGridViewTextBoxColumn CodCar;
        private DataGridViewTextBoxColumn DesCar;
        private DataGridViewTextBoxColumn DesFac;
        private Label label1;
    }
}