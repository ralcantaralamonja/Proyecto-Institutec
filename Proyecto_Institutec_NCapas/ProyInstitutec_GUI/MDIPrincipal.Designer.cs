namespace ProyInstitutec_GUI
{
    partial class MDIPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIPrincipal));
            menuStrip1 = new MenuStrip();
            mantenimientoToolStripMenuItem = new ToolStripMenuItem();
            profesorToolStripMenuItem = new ToolStripMenuItem();
            estudianteToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            carreraToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            salirToolStripMenuItem1 = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblUsuario = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mantenimientoToolStripMenuItem, consultasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(826, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // mantenimientoToolStripMenuItem
            // 
            mantenimientoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { profesorToolStripMenuItem, estudianteToolStripMenuItem, salirToolStripMenuItem, carreraToolStripMenuItem, toolStripMenuItem2, salirToolStripMenuItem1 });
            mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            mantenimientoToolStripMenuItem.Size = new Size(148, 29);
            mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // profesorToolStripMenuItem
            // 
            profesorToolStripMenuItem.BackgroundImage = (Image)resources.GetObject("profesorToolStripMenuItem.BackgroundImage");
            profesorToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            profesorToolStripMenuItem.Name = "profesorToolStripMenuItem";
            profesorToolStripMenuItem.Size = new Size(181, 34);
            profesorToolStripMenuItem.Text = "Profesor";
            profesorToolStripMenuItem.Click += profesorToolStripMenuItem_Click;
            // 
            // estudianteToolStripMenuItem
            // 
            estudianteToolStripMenuItem.BackgroundImage = (Image)resources.GetObject("estudianteToolStripMenuItem.BackgroundImage");
            estudianteToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            estudianteToolStripMenuItem.Name = "estudianteToolStripMenuItem";
            estudianteToolStripMenuItem.Size = new Size(181, 34);
            estudianteToolStripMenuItem.Text = "Alumno";
            estudianteToolStripMenuItem.Click += estudianteToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.BackgroundImage = (Image)resources.GetObject("salirToolStripMenuItem.BackgroundImage");
            salirToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(181, 34);
            salirToolStripMenuItem.Text = "Curso";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // carreraToolStripMenuItem
            // 
            carreraToolStripMenuItem.BackgroundImage = (Image)resources.GetObject("carreraToolStripMenuItem.BackgroundImage");
            carreraToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            carreraToolStripMenuItem.Name = "carreraToolStripMenuItem";
            carreraToolStripMenuItem.Size = new Size(181, 34);
            carreraToolStripMenuItem.Text = "Carrera";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(178, 6);
            // 
            // salirToolStripMenuItem1
            // 
            salirToolStripMenuItem1.BackgroundImage = (Image)resources.GetObject("salirToolStripMenuItem1.BackgroundImage");
            salirToolStripMenuItem1.BackgroundImageLayout = ImageLayout.None;
            salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            salirToolStripMenuItem1.Size = new Size(181, 34);
            salirToolStripMenuItem1.Text = "Salir";
            salirToolStripMenuItem1.Click += salirToolStripMenuItem1_Click_1;
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(105, 29);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblUsuario });
            statusStrip1.Location = new Point(0, 742);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(826, 32);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(76, 25);
            toolStripStatusLabel1.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            lblUsuario.BackColor = Color.Black;
            lblUsuario.ForeColor = SystemColors.ButtonHighlight;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(179, 25);
            lblUsuario.Text = "toolStripStatusLabel2";
            // 
            // MDIPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.DimGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(826, 774);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "MDIPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Principal";
            WindowState = FormWindowState.Maximized;
            FormClosing += MDIPrincipal_FormClosing;
            FormClosed += MDIPrincipal_FrmClosed;
            Load += MDIPrincipal_Load;
            Resize += MDIPrincipal_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mantenimientoToolStripMenuItem;
        private ToolStripMenuItem profesorToolStripMenuItem;
        private ToolStripMenuItem estudianteToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem carreraToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblUsuario;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem salirToolStripMenuItem1;
    }
}