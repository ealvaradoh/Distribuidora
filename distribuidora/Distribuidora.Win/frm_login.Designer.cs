namespace Distribuidora.Win
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsuario.Location = new System.Drawing.Point(42, 81);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(283, 28);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.SystemColors.Control;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.txtContraseña.Location = new System.Drawing.Point(42, 117);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '•';
            this.txtContraseña.Size = new System.Drawing.Size(283, 28);
            this.txtContraseña.TabIndex = 1;
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnConectar.FlatAppearance.BorderSize = 0;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConectar.Location = new System.Drawing.Point(42, 151);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(133, 39);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Maroon;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(192, 151);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 39);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPwd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDatabase);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 200);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conexión MySQL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Contraseña";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(135, 142);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '•';
            this.txtPwd.Size = new System.Drawing.Size(190, 24);
            this.txtPwd.TabIndex = 10;
            this.txtPwd.Text = "07adviser";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Base de datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Server";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(135, 108);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(190, 24);
            this.txtDatabase.TabIndex = 2;
            this.txtDatabase.Text = "distribuidora";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(135, 74);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(190, 24);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "root";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(135, 40);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(190, 24);
            this.txtServer.TabIndex = 0;
            this.txtServer.Text = "Localhost";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(352, 403);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(370, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(370, 450);
            this.Name = "frm_login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexión";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}