﻿namespace Distribuidora.Win
{
    partial class frm_productos
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
            System.Windows.Forms.Label produ_idLabel;
            System.Windows.Forms.Label produ_nomLabel;
            System.Windows.Forms.Label produ_precLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_productos));
            this.listaProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaProductosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.produ_idTextBox = new System.Windows.Forms.TextBox();
            this.produ_nomTextBox = new System.Windows.Forms.TextBox();
            this.produ_precTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorEditItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCancelItem = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDatos = new System.Windows.Forms.Panel();
            produ_idLabel = new System.Windows.Forms.Label();
            produ_nomLabel = new System.Windows.Forms.Label();
            produ_precLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingNavigator)).BeginInit();
            this.listaProductosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // produ_idLabel
            // 
            produ_idLabel.AutoSize = true;
            produ_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            produ_idLabel.Location = new System.Drawing.Point(13, 12);
            produ_idLabel.Name = "produ_idLabel";
            produ_idLabel.Size = new System.Drawing.Size(297, 36);
            produ_idLabel.TabIndex = 1;
            produ_idLabel.Text = "N° DE PRODUCTO:";
            // 
            // produ_nomLabel
            // 
            produ_nomLabel.AutoSize = true;
            produ_nomLabel.Location = new System.Drawing.Point(16, 19);
            produ_nomLabel.Name = "produ_nomLabel";
            produ_nomLabel.Size = new System.Drawing.Size(168, 20);
            produ_nomLabel.TabIndex = 3;
            produ_nomLabel.Text = "Nombre de Producto:";
            // 
            // produ_precLabel
            // 
            produ_precLabel.AutoSize = true;
            produ_precLabel.Location = new System.Drawing.Point(16, 86);
            produ_precLabel.Name = "produ_precLabel";
            produ_precLabel.Size = new System.Drawing.Size(62, 20);
            produ_precLabel.TabIndex = 5;
            produ_precLabel.Text = "Precio:";
            // 
            // listaProductosBindingSource
            // 
            this.listaProductosBindingSource.DataSource = typeof(Distribuidora.BL.Entidades.producto);
            // 
            // listaProductosBindingNavigator
            // 
            this.listaProductosBindingNavigator.AddNewItem = null;
            this.listaProductosBindingNavigator.BindingSource = this.listaProductosBindingSource;
            this.listaProductosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaProductosBindingNavigator.DeleteItem = null;
            this.listaProductosBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listaProductosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listaProductosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem});
            this.listaProductosBindingNavigator.Location = new System.Drawing.Point(0, 379);
            this.listaProductosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaProductosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaProductosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaProductosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaProductosBindingNavigator.Name = "listaProductosBindingNavigator";
            this.listaProductosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaProductosBindingNavigator.Size = new System.Drawing.Size(669, 27);
            this.listaProductosBindingNavigator.TabIndex = 0;
            this.listaProductosBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(87, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // produ_idTextBox
            // 
            this.produ_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductosBindingSource, "produ_id", true));
            this.produ_idTextBox.Location = new System.Drawing.Point(344, 9);
            this.produ_idTextBox.Name = "produ_idTextBox";
            this.produ_idTextBox.ReadOnly = true;
            this.produ_idTextBox.Size = new System.Drawing.Size(296, 41);
            this.produ_idTextBox.TabIndex = 2;
            // 
            // produ_nomTextBox
            // 
            this.produ_nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductosBindingSource, "produ_nom", true));
            this.produ_nomTextBox.Location = new System.Drawing.Point(20, 42);
            this.produ_nomTextBox.Name = "produ_nomTextBox";
            this.produ_nomTextBox.Size = new System.Drawing.Size(483, 27);
            this.produ_nomTextBox.TabIndex = 4;
            // 
            // produ_precTextBox
            // 
            this.produ_precTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductosBindingSource, "produ_prec", true));
            this.produ_precTextBox.Location = new System.Drawing.Point(20, 109);
            this.produ_precTextBox.Name = "produ_precTextBox";
            this.produ_precTextBox.Size = new System.Drawing.Size(172, 27);
            this.produ_precTextBox.TabIndex = 6;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.listaProductosBindingSource;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSaveItem,
            this.bindingNavigatorEditItem,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorCancelItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(669, 47);
            this.bindingNavigator1.TabIndex = 7;
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
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.listaProductosBindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorEditItem
            // 
            this.bindingNavigatorEditItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorEditItem.Image")));
            this.bindingNavigatorEditItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorEditItem.Name = "bindingNavigatorEditItem";
            this.bindingNavigatorEditItem.Size = new System.Drawing.Size(52, 44);
            this.bindingNavigatorEditItem.Text = "Editar";
            this.bindingNavigatorEditItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorEditItem.Click += new System.EventHandler(this.listaProductosBindingNavigatorEdit_Click);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(57, 44);
            this.bindingNavigatorAddNewItem.Text = "Añadir";
            this.bindingNavigatorAddNewItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.listaProductosBindingNavigatorAdd_Click);
            // 
            // bindingNavigatorCancelItem
            // 
            this.bindingNavigatorCancelItem.Enabled = false;
            this.bindingNavigatorCancelItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorCancelItem.Image")));
            this.bindingNavigatorCancelItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorCancelItem.Name = "bindingNavigatorCancelItem";
            this.bindingNavigatorCancelItem.Size = new System.Drawing.Size(70, 44);
            this.bindingNavigatorCancelItem.Text = "Cancelar";
            this.bindingNavigatorCancelItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorCancelItem.Click += new System.EventHandler(this.listaProductosBindingNavigatorCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.produ_idTextBox);
            this.panel1.Controls.Add(produ_idLabel);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 67);
            this.panel1.TabIndex = 34;
            // 
            // panelDatos
            // 
            this.panelDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDatos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDatos.Controls.Add(this.produ_precTextBox);
            this.panelDatos.Controls.Add(produ_precLabel);
            this.panelDatos.Controls.Add(this.produ_nomTextBox);
            this.panelDatos.Controls.Add(produ_nomLabel);
            this.panelDatos.Enabled = false;
            this.panelDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDatos.Location = new System.Drawing.Point(21, 143);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(621, 181);
            this.panelDatos.TabIndex = 37;
            // 
            // frm_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 406);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.listaProductosBindingNavigator);
            this.Name = "frm_productos";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingNavigator)).EndInit();
            this.listaProductosBindingNavigator.ResumeLayout(false);
            this.listaProductosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaProductosBindingSource;
        private System.Windows.Forms.BindingNavigator listaProductosBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox produ_idTextBox;
        private System.Windows.Forms.TextBox produ_nomTextBox;
        private System.Windows.Forms.TextBox produ_precTextBox;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorEditItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCancelItem;
    }
}