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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            mskNomCarrera = new TextBox();
            dgtCarrera = new DataGridView();
            CodCar = new DataGridViewTextBoxColumn();
            DesCar = new DataGridViewTextBoxColumn();
            DesFac = new DataGridViewTextBoxColumn();
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
            label1.Location = new Point(30, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 13);
            label1.TabIndex = 1;
            label1.Text = "Ingrese nombre de la Carrera:";
            // 
            // mskNomCarrera
            // 
            mskNomCarrera.Location = new Point(212, 22);
            mskNomCarrera.Margin = new Padding(3, 2, 3, 2);
            mskNomCarrera.Name = "mskNomCarrera";
            mskNomCarrera.Size = new Size(309, 20);
            mskNomCarrera.TabIndex = 2;
            // 
            // dgtCarrera
            // 
            dgtCarrera.AllowUserToAddRows = false;
            dgtCarrera.AllowUserToDeleteRows = false;
            dgtCarrera.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgtCarrera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgtCarrera.BackgroundColor = SystemColors.AppWorkspace;
            dgtCarrera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtCarrera.Columns.AddRange(new DataGridViewColumn[] { CodCar, DesCar, DesFac });
            dgtCarrera.Location = new Point(23, 77);
            dgtCarrera.Name = "dgtCarrera";
            dgtCarrera.ReadOnly = true;
            dgtCarrera.RowHeadersVisible = false;
            dgtCarrera.RowTemplate.Height = 25;
            dgtCarrera.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgtCarrera.Size = new Size(692, 217);
            dgtCarrera.TabIndex = 3;
            // 
            // CodCar
            // 
            CodCar.DataPropertyName = "CodCar";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            CodCar.DefaultCellStyle = dataGridViewCellStyle3;
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
            label2.Location = new Point(560, 368);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 13);
            label2.TabIndex = 4;
            label2.Text = "Registros:";
            // 
            // lblRegistros
            // 
            lblRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(635, 358);
            lblRegistros.Margin = new Padding(4, 0, 4, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(80, 34);
            lblRegistros.TabIndex = 5;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(605, 420);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 35);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(444, 420);
            btnActualizar.Margin = new Padding(4, 5, 4, 5);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(112, 35);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(283, 420);
            btnInsertar.Margin = new Padding(4, 5, 4, 5);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(112, 35);
            btnInsertar.TabIndex = 8;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            // 
            // Carrera
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 480);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(dgtCarrera);
            Controls.Add(mskNomCarrera);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
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

        private Label label1;
        private TextBox mskNomCarrera;
        private DataGridView dgtCarrera;
        private Label label2;
        private Label lblRegistros;
        private Button btnSalir;
        private Button btnActualizar;
        private Button btnInsertar;
        private DataGridViewTextBoxColumn CodCar;
        private DataGridViewTextBoxColumn DesCar;
        private DataGridViewTextBoxColumn DesFac;
    }
}