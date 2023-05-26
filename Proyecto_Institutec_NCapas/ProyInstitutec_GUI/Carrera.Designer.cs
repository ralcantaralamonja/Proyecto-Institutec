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
            label1 = new Label();
            txtNomCarrera = new TextBox();
            dgtCarrera = new DataGridView();
            CodCar = new DataGridViewTextBoxColumn();
            DesCar = new DataGridViewTextBoxColumn();
            DesFac = new DataGridViewTextBoxColumn();
            Est_carr = new DataGridViewTextBoxColumn();
            label2 = new Label();
            lblRegistros = new Label();
            btnSalir = new Button();
            btnActualizar = new Button();
            btnInsertar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgtCarrera).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(221, 21);
            label1.TabIndex = 0;
            label1.Text = "FILTRO NOMBRE CARRERA:";
            // 
            // txtNomCarrera
            // 
            txtNomCarrera.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomCarrera.Location = new Point(240, 12);
            txtNomCarrera.Margin = new Padding(3, 2, 3, 2);
            txtNomCarrera.Name = "txtNomCarrera";
            txtNomCarrera.Size = new Size(309, 27);
            txtNomCarrera.TabIndex = 1;
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
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(88, 183, 213);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgtCarrera.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgtCarrera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtCarrera.Columns.AddRange(new DataGridViewColumn[] { CodCar, DesCar, DesFac, Est_carr });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(88, 183, 213);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgtCarrera.DefaultCellStyle = dataGridViewCellStyle3;
            dgtCarrera.GridColor = Color.FromArgb(88, 183, 213);
            dgtCarrera.Location = new Point(13, 54);
            dgtCarrera.Name = "dgtCarrera";
            dgtCarrera.ReadOnly = true;
            dgtCarrera.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(88, 183, 213);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgtCarrera.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgtCarrera.RowHeadersVisible = false;
            dgtCarrera.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(88, 183, 213);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.Window;
            dgtCarrera.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgtCarrera.RowTemplate.Height = 25;
            dgtCarrera.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgtCarrera.Size = new Size(1157, 503);
            dgtCarrera.TabIndex = 2;
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
            // Est_carr
            // 
            Est_carr.DataPropertyName = "Est_carr";
            Est_carr.HeaderText = "Estado";
            Est_carr.Name = "Est_carr";
            Est_carr.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(980, 564);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 3;
            label2.Text = "REGISTROS";
            // 
            // lblRegistros
            // 
            lblRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistros.BackColor = SystemColors.Window;
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(1086, 564);
            lblRegistros.Margin = new Padding(4, 0, 4, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(80, 34);
            lblRegistros.TabIndex = 4;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ControlLight;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(1045, 609);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(125, 40);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ControlLight;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnActualizar.Location = new Point(846, 609);
            btnActualizar.Margin = new Padding(4, 5, 4, 5);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(125, 40);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "ACTUALZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = SystemColors.ControlLight;
            btnInsertar.FlatStyle = FlatStyle.Flat;
            btnInsertar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsertar.Location = new Point(715, 609);
            btnInsertar.Margin = new Padding(4, 5, 4, 5);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(125, 40);
            btnInsertar.TabIndex = 5;
            btnInsertar.Text = "INSERTAR";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // Carrera
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(dgtCarrera);
            Controls.Add(txtNomCarrera);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Carrera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MANTENIMIENTO CARRERA";
            Load += Carrera_Load;
            ((System.ComponentModel.ISupportInitialize)dgtCarrera).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
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
        private DataGridViewTextBoxColumn Est_carr;
    }
}