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
            salirToolStripMenuItem1 = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lbl1 = new ToolStripStatusLabel();
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
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1101, 31);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // mantenimientoToolStripMenuItem
            // 
            mantenimientoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { profesorToolStripMenuItem, estudianteToolStripMenuItem, salirToolStripMenuItem, carreraToolStripMenuItem, salirToolStripMenuItem1 });
            mantenimientoToolStripMenuItem.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            mantenimientoToolStripMenuItem.Size = new Size(143, 25);
            mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // profesorToolStripMenuItem
            // 
            profesorToolStripMenuItem.BackgroundImage = (Image)resources.GetObject("profesorToolStripMenuItem.BackgroundImage");
            profesorToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            profesorToolStripMenuItem.Name = "profesorToolStripMenuItem";
            profesorToolStripMenuItem.Size = new Size(180, 26);
            profesorToolStripMenuItem.Text = "Profesor";
            profesorToolStripMenuItem.Click += profesorToolStripMenuItem_Click;
            // 
            // estudianteToolStripMenuItem
            // 
            estudianteToolStripMenuItem.BackgroundImage = (Image)resources.GetObject("estudianteToolStripMenuItem.BackgroundImage");
            estudianteToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            estudianteToolStripMenuItem.Name = "estudianteToolStripMenuItem";
            estudianteToolStripMenuItem.Size = new Size(180, 26);
            estudianteToolStripMenuItem.Text = "Estudiante";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.BackgroundImage = (Image)resources.GetObject("salirToolStripMenuItem.BackgroundImage");
            salirToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(180, 26);
            salirToolStripMenuItem.Text = "Curso";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // carreraToolStripMenuItem
            // 
            carreraToolStripMenuItem.BackgroundImage = (Image)resources.GetObject("carreraToolStripMenuItem.BackgroundImage");
            carreraToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            carreraToolStripMenuItem.Name = "carreraToolStripMenuItem";
            carreraToolStripMenuItem.Size = new Size(180, 26);
            carreraToolStripMenuItem.Text = "Carrera";
            carreraToolStripMenuItem.Click += carreraToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem1
            // 
            salirToolStripMenuItem1.BackgroundImage = (Image)resources.GetObject("salirToolStripMenuItem1.BackgroundImage");
            salirToolStripMenuItem1.BackgroundImageLayout = ImageLayout.None;
            salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            salirToolStripMenuItem1.Size = new Size(180, 26);
            salirToolStripMenuItem1.Text = "Salir";
            salirToolStripMenuItem1.Click += salirToolStripMenuItem1_Click;
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(98, 25);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbl1, lblUsuario });
            statusStrip1.Location = new Point(0, 990);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 21, 0);
            statusStrip1.Size = new Size(1101, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // lbl1
            // 
            lbl1.BackColor = SystemColors.ActiveCaptionText;
            lbl1.ForeColor = SystemColors.ButtonHighlight;
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(50, 17);
            lbl1.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            lblUsuario.BackColor = Color.Black;
            lblUsuario.ForeColor = SystemColors.ButtonHighlight;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(118, 17);
            lblUsuario.Text = "toolStripStatusLabel2";
            // 
            // MDIPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.DarkGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1101, 1012);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "MDIPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BIENVENIDO A INSTITUTEC";
            WindowState = FormWindowState.Maximized;
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
        private ToolStripMenuItem carreraToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lbl1;
        private ToolStripStatusLabel lblUsuario;
    }
}