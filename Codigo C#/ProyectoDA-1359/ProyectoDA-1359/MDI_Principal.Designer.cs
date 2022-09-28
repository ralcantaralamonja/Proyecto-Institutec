namespace ProyectoDA_1359
{
    partial class MDI_Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirDelAplicativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarifaDeCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionDeMstriculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeMatriculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeDocentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.DocenteToolStripMenuItem,
            this.informacionDeMstriculasToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9);
            this.menuStrip1.Size = new System.Drawing.Size(875, 43);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarAlumnosToolStripMenuItem,
            this.buscarAlumnosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirDelAplicativoToolStripMenuItem});
            this.alumnosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alumnosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.alumnosToolStripMenuItem.Image = global::ProyectoDA_1359.Properties.Resources.user1;
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // registrarAlumnosToolStripMenuItem
            // 
            this.registrarAlumnosToolStripMenuItem.Image = global::ProyectoDA_1359.Properties.Resources.user1_preferences;
            this.registrarAlumnosToolStripMenuItem.Name = "registrarAlumnosToolStripMenuItem";
            this.registrarAlumnosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.registrarAlumnosToolStripMenuItem.Text = "Registro de alumnos";
            this.registrarAlumnosToolStripMenuItem.Click += new System.EventHandler(this.registrarAlumnosToolStripMenuItem_Click);
            // 
            // buscarAlumnosToolStripMenuItem
            // 
            this.buscarAlumnosToolStripMenuItem.Image = global::ProyectoDA_1359.Properties.Resources._72006_search_icon;
            this.buscarAlumnosToolStripMenuItem.Name = "buscarAlumnosToolStripMenuItem";
            this.buscarAlumnosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.buscarAlumnosToolStripMenuItem.Text = "Buscar alumnos";
            this.buscarAlumnosToolStripMenuItem.Click += new System.EventHandler(this.buscarAlumnosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(194, 6);
            // 
            // salirDelAplicativoToolStripMenuItem
            // 
            this.salirDelAplicativoToolStripMenuItem.Image = global::ProyectoDA_1359.Properties.Resources.Shutdown_32x32_32;
            this.salirDelAplicativoToolStripMenuItem.Name = "salirDelAplicativoToolStripMenuItem";
            this.salirDelAplicativoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.salirDelAplicativoToolStripMenuItem.Text = "Salir del aplicativo";
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCursosToolStripMenuItem,
            this.BuscarCursosToolStripMenuItem,
            this.tarifaDeCursoToolStripMenuItem});
            this.cursosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cursosToolStripMenuItem.Image = global::ProyectoDA_1359.Properties.Resources.report;
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.cursosToolStripMenuItem.Text = "Cursos";
            // 
            // agregarCursosToolStripMenuItem
            // 
            this.agregarCursosToolStripMenuItem.Image = global::ProyectoDA_1359.Properties.Resources.Editar;
            this.agregarCursosToolStripMenuItem.Name = "agregarCursosToolStripMenuItem";
            this.agregarCursosToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.agregarCursosToolStripMenuItem.Text = "Agregar cursos ";
            this.agregarCursosToolStripMenuItem.Click += new System.EventHandler(this.agregarCursosToolStripMenuItem_Click);
            // 
            // BuscarCursosToolStripMenuItem
            // 
            this.BuscarCursosToolStripMenuItem.Image = global::ProyectoDA_1359.Properties.Resources._72006_search_icon;
            this.BuscarCursosToolStripMenuItem.Name = "BuscarCursosToolStripMenuItem";
            this.BuscarCursosToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.BuscarCursosToolStripMenuItem.Text = "Buscar Cursos";
            this.BuscarCursosToolStripMenuItem.Click += new System.EventHandler(this.BuscarCursosToolStripMenuItem_Click);
            // 
            // tarifaDeCursoToolStripMenuItem
            // 
            this.tarifaDeCursoToolStripMenuItem.Image = global::ProyectoDA_1359.Properties.Resources._1737376_dollar_money_sign_icon;
            this.tarifaDeCursoToolStripMenuItem.Name = "tarifaDeCursoToolStripMenuItem";
            this.tarifaDeCursoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.tarifaDeCursoToolStripMenuItem.Text = "Tarifa de Curso";
            this.tarifaDeCursoToolStripMenuItem.Click += new System.EventHandler(this.tarifaDeCursoToolStripMenuItem_Click);
            // 
            // DocenteToolStripMenuItem
            // 
            this.DocenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarDocenteToolStripMenuItem,
            this.buscarDocenteToolStripMenuItem});
            this.DocenteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DocenteToolStripMenuItem.Image = global::ProyectoDA_1359.Properties.Resources.id_card;
            this.DocenteToolStripMenuItem.Name = "DocenteToolStripMenuItem";
            this.DocenteToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.DocenteToolStripMenuItem.Text = "Docente";
            // 
            // registrarDocenteToolStripMenuItem
            // 
            this.registrarDocenteToolStripMenuItem.Image = global::ProyectoDA_1359.Properties.Resources.note;
            this.registrarDocenteToolStripMenuItem.Name = "registrarDocenteToolStripMenuItem";
            this.registrarDocenteToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.registrarDocenteToolStripMenuItem.Text = "Registrar Docente";
            this.registrarDocenteToolStripMenuItem.Click += new System.EventHandler(this.registrarDocenteToolStripMenuItem_Click);
            // 
            // buscarDocenteToolStripMenuItem
            // 
            this.buscarDocenteToolStripMenuItem.Image = global::ProyectoDA_1359.Properties.Resources._72006_search_icon;
            this.buscarDocenteToolStripMenuItem.Name = "buscarDocenteToolStripMenuItem";
            this.buscarDocenteToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.buscarDocenteToolStripMenuItem.Text = "Buscar Docente";
            this.buscarDocenteToolStripMenuItem.Click += new System.EventHandler(this.buscarDocenteToolStripMenuItem_Click);
            // 
            // informacionDeMstriculasToolStripMenuItem
            // 
            this.informacionDeMstriculasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeCursosToolStripMenuItem,
            this.reporteDeMatriculasToolStripMenuItem,
            this.reporteDeDocentesToolStripMenuItem,
            this.reporteDeAlumnosToolStripMenuItem});
            this.informacionDeMstriculasToolStripMenuItem.Image = global::ProyectoDA_1359.Properties.Resources.cabinet;
            this.informacionDeMstriculasToolStripMenuItem.Name = "informacionDeMstriculasToolStripMenuItem";
            this.informacionDeMstriculasToolStripMenuItem.Size = new System.Drawing.Size(81, 25);
            this.informacionDeMstriculasToolStripMenuItem.Text = "Reportes";
            // 
            // reporteDeCursosToolStripMenuItem
            // 
            this.reporteDeCursosToolStripMenuItem.Image = global::ProyectoDA_1359.Properties.Resources.Control_Panel;
            this.reporteDeCursosToolStripMenuItem.Name = "reporteDeCursosToolStripMenuItem";
            this.reporteDeCursosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.reporteDeCursosToolStripMenuItem.Text = "Reporte de cursos";
            this.reporteDeCursosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeCursosToolStripMenuItem_Click);
            // 
            // reporteDeMatriculasToolStripMenuItem
            // 
            this.reporteDeMatriculasToolStripMenuItem.Image = global::ProyectoDA_1359.Properties.Resources.note1;
            this.reporteDeMatriculasToolStripMenuItem.Name = "reporteDeMatriculasToolStripMenuItem";
            this.reporteDeMatriculasToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.reporteDeMatriculasToolStripMenuItem.Text = "Reporte de matriculas";
            this.reporteDeMatriculasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeMatriculasToolStripMenuItem_Click);
            // 
            // reporteDeDocentesToolStripMenuItem
            // 
            this.reporteDeDocentesToolStripMenuItem.Image = global::ProyectoDA_1359.Properties.Resources.id_card;
            this.reporteDeDocentesToolStripMenuItem.Name = "reporteDeDocentesToolStripMenuItem";
            this.reporteDeDocentesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.reporteDeDocentesToolStripMenuItem.Text = "Reporte de docentes";
            this.reporteDeDocentesToolStripMenuItem.Click += new System.EventHandler(this.reporteDeDocentesToolStripMenuItem_Click);
            // 
            // reporteDeAlumnosToolStripMenuItem
            // 
            this.reporteDeAlumnosToolStripMenuItem.Image = global::ProyectoDA_1359.Properties.Resources.user1;
            this.reporteDeAlumnosToolStripMenuItem.Name = "reporteDeAlumnosToolStripMenuItem";
            this.reporteDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.reporteDeAlumnosToolStripMenuItem.Text = "Reporte de Alumnos";
            this.reporteDeAlumnosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeAlumnosToolStripMenuItem_Click);
            // 
            // MDI_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoDA_1359.Properties.Resources.backgroun;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(875, 496);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI_Principal";
            this.Text = "   ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDI_Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem alumnosToolStripMenuItem;
        private ToolStripMenuItem registrarAlumnosToolStripMenuItem;
        private ToolStripMenuItem cursosToolStripMenuItem;
        private ToolStripMenuItem agregarCursosToolStripMenuItem;
        private ToolStripMenuItem BuscarCursosToolStripMenuItem;
        private ToolStripMenuItem DocenteToolStripMenuItem;
        private ToolStripMenuItem registrarDocenteToolStripMenuItem;
        private ToolStripMenuItem buscarAlumnosToolStripMenuItem;
        private ToolStripMenuItem buscarDocenteToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem salirDelAplicativoToolStripMenuItem;
        private ToolStripMenuItem tarifaDeCursoToolStripMenuItem;
        private ToolStripMenuItem informacionDeMstriculasToolStripMenuItem;
        private ToolStripMenuItem reporteDeCursosToolStripMenuItem;
        private ToolStripMenuItem reporteDeMatriculasToolStripMenuItem;
        private ToolStripMenuItem reporteDeDocentesToolStripMenuItem;
        private ToolStripMenuItem reporteDeAlumnosToolStripMenuItem;
    }
}