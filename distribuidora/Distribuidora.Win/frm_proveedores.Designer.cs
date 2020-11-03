namespace Distribuidora.Win
{
    partial class frm_proveedores
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label prov_direLabel;
            System.Windows.Forms.Label prov_mailLabel;
            System.Windows.Forms.Label prov_nomLabel;
            System.Windows.Forms.Label prov_paisLabel;
            System.Windows.Forms.Label prov_rtnLabel;
            System.Windows.Forms.Label prov_telLabel;
            System.Windows.Forms.Label produ_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_proveedores));
            this.listaProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaProveedoresBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDelete = new System.Windows.Forms.ToolStripButton();
            this.prov_direTextBox = new System.Windows.Forms.TextBox();
            this.prov_idTextBox = new System.Windows.Forms.TextBox();
            this.prov_mailTextBox = new System.Windows.Forms.TextBox();
            this.prov_nomTextBox = new System.Windows.Forms.TextBox();
            this.prov_paisTextBox = new System.Windows.Forms.TextBox();
            this.prov_rtnTextBox = new System.Windows.Forms.TextBox();
            this.prov_telTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorEditItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCancelNewItem = new System.Windows.Forms.ToolStripButton();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            prov_direLabel = new System.Windows.Forms.Label();
            prov_mailLabel = new System.Windows.Forms.Label();
            prov_nomLabel = new System.Windows.Forms.Label();
            prov_paisLabel = new System.Windows.Forms.Label();
            prov_rtnLabel = new System.Windows.Forms.Label();
            prov_telLabel = new System.Windows.Forms.Label();
            produ_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaProveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProveedoresBindingNavigator)).BeginInit();
            this.listaProveedoresBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.panelDatos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prov_direLabel
            // 
            prov_direLabel.AutoSize = true;
            prov_direLabel.Location = new System.Drawing.Point(27, 149);
            prov_direLabel.Name = "prov_direLabel";
            prov_direLabel.Size = new System.Drawing.Size(86, 20);
            prov_direLabel.TabIndex = 1;
            prov_direLabel.Text = "Dirección:";
            // 
            // prov_mailLabel
            // 
            prov_mailLabel.AutoSize = true;
            prov_mailLabel.Location = new System.Drawing.Point(490, 259);
            prov_mailLabel.Name = "prov_mailLabel";
            prov_mailLabel.Size = new System.Drawing.Size(70, 20);
            prov_mailLabel.TabIndex = 5;
            prov_mailLabel.Text = "E-MAIL:";
            // 
            // prov_nomLabel
            // 
            prov_nomLabel.AutoSize = true;
            prov_nomLabel.Location = new System.Drawing.Point(27, 76);
            prov_nomLabel.Name = "prov_nomLabel";
            prov_nomLabel.Size = new System.Drawing.Size(73, 20);
            prov_nomLabel.TabIndex = 7;
            prov_nomLabel.Text = "Nombre:";
            // 
            // prov_paisLabel
            // 
            prov_paisLabel.AutoSize = true;
            prov_paisLabel.Location = new System.Drawing.Point(490, 149);
            prov_paisLabel.Name = "prov_paisLabel";
            prov_paisLabel.Size = new System.Drawing.Size(47, 20);
            prov_paisLabel.TabIndex = 9;
            prov_paisLabel.Text = "País:";
            // 
            // prov_rtnLabel
            // 
            prov_rtnLabel.AutoSize = true;
            prov_rtnLabel.Location = new System.Drawing.Point(27, 11);
            prov_rtnLabel.Name = "prov_rtnLabel";
            prov_rtnLabel.Size = new System.Drawing.Size(112, 20);
            prov_rtnLabel.TabIndex = 11;
            prov_rtnLabel.Text = "Número RTN:";
            // 
            // prov_telLabel
            // 
            prov_telLabel.AutoSize = true;
            prov_telLabel.Location = new System.Drawing.Point(490, 204);
            prov_telLabel.Name = "prov_telLabel";
            prov_telLabel.Size = new System.Drawing.Size(78, 20);
            prov_telLabel.TabIndex = 13;
            prov_telLabel.Text = "Teléfono:";
            // 
            // produ_idLabel
            // 
            produ_idLabel.AutoSize = true;
            produ_idLabel.Location = new System.Drawing.Point(13, 12);
            produ_idLabel.Name = "produ_idLabel";
            produ_idLabel.Size = new System.Drawing.Size(304, 36);
            produ_idLabel.TabIndex = 1;
            produ_idLabel.Text = "N° DE PROVEEDOR:";
            // 
            // listaProveedoresBindingSource
            // 
            this.listaProveedoresBindingSource.DataSource = typeof(Distribuidora.BL.Entidades.proveedor);
            // 
            // listaProveedoresBindingNavigator
            // 
            this.listaProveedoresBindingNavigator.AddNewItem = null;
            this.listaProveedoresBindingNavigator.BindingSource = this.listaProveedoresBindingSource;
            this.listaProveedoresBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaProveedoresBindingNavigator.DeleteItem = null;
            this.listaProveedoresBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listaProveedoresBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listaProveedoresBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDelete});
            this.listaProveedoresBindingNavigator.Location = new System.Drawing.Point(0, 570);
            this.listaProveedoresBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaProveedoresBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaProveedoresBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaProveedoresBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaProveedoresBindingNavigator.Name = "listaProveedoresBindingNavigator";
            this.listaProveedoresBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaProveedoresBindingNavigator.Size = new System.Drawing.Size(874, 27);
            this.listaProveedoresBindingNavigator.TabIndex = 0;
            this.listaProveedoresBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorDelete
            // 
            this.bindingNavigatorDelete.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDelete.Image")));
            this.bindingNavigatorDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorDelete.Name = "bindingNavigatorDelete";
            this.bindingNavigatorDelete.Size = new System.Drawing.Size(87, 24);
            this.bindingNavigatorDelete.Text = "Eliminar";
            this.bindingNavigatorDelete.Click += new System.EventHandler(this.bindingNavigatorDelete_Click);
            // 
            // prov_direTextBox
            // 
            this.prov_direTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProveedoresBindingSource, "prov_dire", true));
            this.prov_direTextBox.Location = new System.Drawing.Point(27, 172);
            this.prov_direTextBox.Multiline = true;
            this.prov_direTextBox.Name = "prov_direTextBox";
            this.prov_direTextBox.Size = new System.Drawing.Size(430, 137);
            this.prov_direTextBox.TabIndex = 2;
            // 
            // prov_idTextBox
            // 
            this.prov_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProveedoresBindingSource, "prov_id", true));
            this.prov_idTextBox.Enabled = false;
            this.prov_idTextBox.Location = new System.Drawing.Point(339, 12);
            this.prov_idTextBox.Name = "prov_idTextBox";
            this.prov_idTextBox.Size = new System.Drawing.Size(352, 41);
            this.prov_idTextBox.TabIndex = 4;
            // 
            // prov_mailTextBox
            // 
            this.prov_mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProveedoresBindingSource, "prov_mail", true));
            this.prov_mailTextBox.Location = new System.Drawing.Point(490, 282);
            this.prov_mailTextBox.Name = "prov_mailTextBox";
            this.prov_mailTextBox.Size = new System.Drawing.Size(320, 27);
            this.prov_mailTextBox.TabIndex = 6;
            // 
            // prov_nomTextBox
            // 
            this.prov_nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProveedoresBindingSource, "prov_nom", true));
            this.prov_nomTextBox.Location = new System.Drawing.Point(27, 99);
            this.prov_nomTextBox.Name = "prov_nomTextBox";
            this.prov_nomTextBox.Size = new System.Drawing.Size(785, 27);
            this.prov_nomTextBox.TabIndex = 8;
            // 
            // prov_paisTextBox
            // 
            this.prov_paisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProveedoresBindingSource, "prov_pais", true));
            this.prov_paisTextBox.Location = new System.Drawing.Point(491, 172);
            this.prov_paisTextBox.Name = "prov_paisTextBox";
            this.prov_paisTextBox.Size = new System.Drawing.Size(320, 27);
            this.prov_paisTextBox.TabIndex = 10;
            // 
            // prov_rtnTextBox
            // 
            this.prov_rtnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProveedoresBindingSource, "prov_rtn", true));
            this.prov_rtnTextBox.Location = new System.Drawing.Point(27, 35);
            this.prov_rtnTextBox.Name = "prov_rtnTextBox";
            this.prov_rtnTextBox.Size = new System.Drawing.Size(433, 27);
            this.prov_rtnTextBox.TabIndex = 12;
            // 
            // prov_telTextBox
            // 
            this.prov_telTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProveedoresBindingSource, "prov_tel", true));
            this.prov_telTextBox.Location = new System.Drawing.Point(491, 227);
            this.prov_telTextBox.Name = "prov_telTextBox";
            this.prov_telTextBox.Size = new System.Drawing.Size(321, 27);
            this.prov_telTextBox.TabIndex = 14;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.listaProveedoresBindingSource;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSaveItem,
            this.bindingNavigatorEditItem,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorCancelNewItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(874, 47);
            this.bindingNavigator1.TabIndex = 15;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSaveItem
            // 
            this.bindingNavigatorSaveItem.Enabled = false;
            this.bindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSaveItem.Image")));
            this.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            this.bindingNavigatorSaveItem.Size = new System.Drawing.Size(107, 44);
            this.bindingNavigatorSaveItem.Text = "Guardar datos";
            this.bindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.bindingNavigatorSave_Click);
            // 
            // bindingNavigatorEditItem
            // 
            this.bindingNavigatorEditItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorEditItem.Image")));
            this.bindingNavigatorEditItem.Name = "bindingNavigatorEditItem";
            this.bindingNavigatorEditItem.Size = new System.Drawing.Size(52, 44);
            this.bindingNavigatorEditItem.Text = "Editar";
            this.bindingNavigatorEditItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorEditItem.ToolTipText = "Editar";
            this.bindingNavigatorEditItem.Click += new System.EventHandler(this.bindingNavigatorEdit_Click);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(57, 44);
            this.bindingNavigatorAddNewItem.Text = "Añadir";
            this.bindingNavigatorAddNewItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAdd_Click);
            // 
            // bindingNavigatorCancelNewItem
            // 
            this.bindingNavigatorCancelNewItem.Enabled = false;
            this.bindingNavigatorCancelNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorCancelNewItem.Image")));
            this.bindingNavigatorCancelNewItem.Name = "bindingNavigatorCancelNewItem";
            this.bindingNavigatorCancelNewItem.Size = new System.Drawing.Size(70, 44);
            this.bindingNavigatorCancelNewItem.Text = "Cancelar";
            this.bindingNavigatorCancelNewItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorCancelNewItem.Click += new System.EventHandler(this.bindingNavigatorCancel_Click);
            // 
            // panelDatos
            // 
            this.panelDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDatos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDatos.Controls.Add(this.prov_direTextBox);
            this.panelDatos.Controls.Add(this.prov_telTextBox);
            this.panelDatos.Controls.Add(prov_direLabel);
            this.panelDatos.Controls.Add(prov_telLabel);
            this.panelDatos.Controls.Add(this.prov_rtnTextBox);
            this.panelDatos.Controls.Add(prov_rtnLabel);
            this.panelDatos.Controls.Add(this.prov_paisTextBox);
            this.panelDatos.Controls.Add(prov_mailLabel);
            this.panelDatos.Controls.Add(prov_paisLabel);
            this.panelDatos.Controls.Add(this.prov_mailTextBox);
            this.panelDatos.Controls.Add(this.prov_nomTextBox);
            this.panelDatos.Controls.Add(prov_nomLabel);
            this.panelDatos.Enabled = false;
            this.panelDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDatos.Location = new System.Drawing.Point(21, 154);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(829, 370);
            this.panelDatos.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.prov_idTextBox);
            this.panel1.Controls.Add(produ_idLabel);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 67);
            this.panel1.TabIndex = 39;
            // 
            // frm_proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.listaProveedoresBindingNavigator);
            this.Name = "frm_proveedores";
            this.Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.listaProveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProveedoresBindingNavigator)).EndInit();
            this.listaProveedoresBindingNavigator.ResumeLayout(false);
            this.listaProveedoresBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaProveedoresBindingSource;
        private System.Windows.Forms.BindingNavigator listaProveedoresBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox prov_direTextBox;
        private System.Windows.Forms.TextBox prov_idTextBox;
        private System.Windows.Forms.TextBox prov_mailTextBox;
        private System.Windows.Forms.TextBox prov_nomTextBox;
        private System.Windows.Forms.TextBox prov_paisTextBox;
        private System.Windows.Forms.TextBox prov_rtnTextBox;
        private System.Windows.Forms.TextBox prov_telTextBox;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorEditItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCancelNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDelete;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Panel panel1;
    }
}