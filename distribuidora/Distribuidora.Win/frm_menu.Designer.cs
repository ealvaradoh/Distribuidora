namespace Distribuidora.Win
{
    partial class frm_menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsServer = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsDatabase = new System.Windows.Forms.ToolStripLabel();
            this.tsUsuario = new System.Windows.Forms.ToolStripLabel();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1132, 28);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlDeUsuariosToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // controlDeUsuariosToolStripMenuItem
            // 
            this.controlDeUsuariosToolStripMenuItem.Name = "controlDeUsuariosToolStripMenuItem";
            this.controlDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.controlDeUsuariosToolStripMenuItem.Text = "Control de Usuarios";
            this.controlDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.controlDeUsuariosToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsServer,
            this.toolStripButton1,
            this.tsDatabase,
            this.tsUsuario});
            this.toolStrip1.Location = new System.Drawing.Point(0, 670);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1132, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsServer
            // 
            this.tsServer.BackColor = System.Drawing.SystemColors.Menu;
            this.tsServer.Name = "tsServer";
            this.tsServer.Size = new System.Drawing.Size(71, 22);
            this.tsServer.Text = "Servidor: ";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsDatabase
            // 
            this.tsDatabase.BackColor = System.Drawing.SystemColors.Menu;
            this.tsDatabase.Name = "tsDatabase";
            this.tsDatabase.Size = new System.Drawing.Size(105, 22);
            this.tsDatabase.Text = "Base de datos:";
            // 
            // tsUsuario
            // 
            this.tsUsuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsUsuario.BackColor = System.Drawing.SystemColors.Menu;
            this.tsUsuario.Name = "tsUsuario";
            this.tsUsuario.Size = new System.Drawing.Size(137, 22);
            this.tsUsuario.Text = "Usuario de sistema:";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 695);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_menu";
            this.Text = "Menú";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripButton1;
        private System.Windows.Forms.ToolStripLabel tsServer;
        private System.Windows.Forms.ToolStripLabel tsDatabase;
        private System.Windows.Forms.ToolStripLabel tsUsuario;
        private System.Windows.Forms.ToolStripMenuItem controlDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
    }
}

