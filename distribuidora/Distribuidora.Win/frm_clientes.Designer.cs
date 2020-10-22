namespace Distribuidora.Win
{
    partial class frm_clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_clientes));
            System.Windows.Forms.Label clien_idLabel;
            System.Windows.Forms.Label clien_papeLabel;
            System.Windows.Forms.Label clien_pnomLabel;
            System.Windows.Forms.Label clien_snomLabel;
            System.Windows.Forms.Label clien_telLabel;
            System.Windows.Forms.Label cliend_numidLabel;
            this.listaClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaClientesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaClientesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.clien_idTextBox = new System.Windows.Forms.TextBox();
            this.clien_papeTextBox = new System.Windows.Forms.TextBox();
            this.clien_pnomTextBox = new System.Windows.Forms.TextBox();
            this.clien_snomTextBox = new System.Windows.Forms.TextBox();
            this.clien_telTextBox = new System.Windows.Forms.TextBox();
            this.cliend_numidTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            clien_idLabel = new System.Windows.Forms.Label();
            clien_papeLabel = new System.Windows.Forms.Label();
            clien_pnomLabel = new System.Windows.Forms.Label();
            clien_snomLabel = new System.Windows.Forms.Label();
            clien_telLabel = new System.Windows.Forms.Label();
            cliend_numidLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingNavigator)).BeginInit();
            this.listaClientesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaClientesBindingSource
            // 
            this.listaClientesBindingSource.DataSource = typeof(Distribuidora.BL.Entidades.cliente);
            // 
            // listaClientesBindingNavigator
            // 
            this.listaClientesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listaClientesBindingNavigator.BindingSource = this.listaClientesBindingSource;
            this.listaClientesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaClientesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listaClientesBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listaClientesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listaClientesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listaClientesBindingNavigatorSaveItem});
            this.listaClientesBindingNavigator.Location = new System.Drawing.Point(0, 423);
            this.listaClientesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaClientesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaClientesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaClientesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaClientesBindingNavigator.Name = "listaClientesBindingNavigator";
            this.listaClientesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaClientesBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.listaClientesBindingNavigator.TabIndex = 0;
            this.listaClientesBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // listaClientesBindingNavigatorSaveItem
            // 
            this.listaClientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaClientesBindingNavigatorSaveItem.Enabled = false;
            this.listaClientesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaClientesBindingNavigatorSaveItem.Image")));
            this.listaClientesBindingNavigatorSaveItem.Name = "listaClientesBindingNavigatorSaveItem";
            this.listaClientesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.listaClientesBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // clien_idLabel
            // 
            clien_idLabel.AutoSize = true;
            clien_idLabel.Location = new System.Drawing.Point(18, 70);
            clien_idLabel.Name = "clien_idLabel";
            clien_idLabel.Size = new System.Drawing.Size(56, 17);
            clien_idLabel.TabIndex = 1;
            clien_idLabel.Text = "clien id:";
            // 
            // clien_idTextBox
            // 
            this.clien_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClientesBindingSource, "clien_id", true));
            this.clien_idTextBox.Location = new System.Drawing.Point(115, 67);
            this.clien_idTextBox.Name = "clien_idTextBox";
            this.clien_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.clien_idTextBox.TabIndex = 2;
            // 
            // clien_papeLabel
            // 
            clien_papeLabel.AutoSize = true;
            clien_papeLabel.Location = new System.Drawing.Point(18, 98);
            clien_papeLabel.Name = "clien_papeLabel";
            clien_papeLabel.Size = new System.Drawing.Size(77, 17);
            clien_papeLabel.TabIndex = 3;
            clien_papeLabel.Text = "clien pape:";
            // 
            // clien_papeTextBox
            // 
            this.clien_papeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClientesBindingSource, "clien_pape", true));
            this.clien_papeTextBox.Location = new System.Drawing.Point(115, 95);
            this.clien_papeTextBox.Name = "clien_papeTextBox";
            this.clien_papeTextBox.Size = new System.Drawing.Size(100, 22);
            this.clien_papeTextBox.TabIndex = 4;
            // 
            // clien_pnomLabel
            // 
            clien_pnomLabel.AutoSize = true;
            clien_pnomLabel.Location = new System.Drawing.Point(18, 126);
            clien_pnomLabel.Name = "clien_pnomLabel";
            clien_pnomLabel.Size = new System.Drawing.Size(80, 17);
            clien_pnomLabel.TabIndex = 5;
            clien_pnomLabel.Text = "clien pnom:";
            // 
            // clien_pnomTextBox
            // 
            this.clien_pnomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClientesBindingSource, "clien_pnom", true));
            this.clien_pnomTextBox.Location = new System.Drawing.Point(115, 123);
            this.clien_pnomTextBox.Name = "clien_pnomTextBox";
            this.clien_pnomTextBox.Size = new System.Drawing.Size(100, 22);
            this.clien_pnomTextBox.TabIndex = 6;
            // 
            // clien_snomLabel
            // 
            clien_snomLabel.AutoSize = true;
            clien_snomLabel.Location = new System.Drawing.Point(18, 154);
            clien_snomLabel.Name = "clien_snomLabel";
            clien_snomLabel.Size = new System.Drawing.Size(79, 17);
            clien_snomLabel.TabIndex = 7;
            clien_snomLabel.Text = "clien snom:";
            // 
            // clien_snomTextBox
            // 
            this.clien_snomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClientesBindingSource, "clien_snom", true));
            this.clien_snomTextBox.Location = new System.Drawing.Point(115, 151);
            this.clien_snomTextBox.Name = "clien_snomTextBox";
            this.clien_snomTextBox.Size = new System.Drawing.Size(100, 22);
            this.clien_snomTextBox.TabIndex = 8;
            // 
            // clien_telLabel
            // 
            clien_telLabel.AutoSize = true;
            clien_telLabel.Location = new System.Drawing.Point(18, 182);
            clien_telLabel.Name = "clien_telLabel";
            clien_telLabel.Size = new System.Drawing.Size(60, 17);
            clien_telLabel.TabIndex = 9;
            clien_telLabel.Text = "clien tel:";
            // 
            // clien_telTextBox
            // 
            this.clien_telTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClientesBindingSource, "clien_tel", true));
            this.clien_telTextBox.Location = new System.Drawing.Point(115, 179);
            this.clien_telTextBox.Name = "clien_telTextBox";
            this.clien_telTextBox.Size = new System.Drawing.Size(100, 22);
            this.clien_telTextBox.TabIndex = 10;
            // 
            // cliend_numidLabel
            // 
            cliend_numidLabel.AutoSize = true;
            cliend_numidLabel.Location = new System.Drawing.Point(18, 210);
            cliend_numidLabel.Name = "cliend_numidLabel";
            cliend_numidLabel.Size = new System.Drawing.Size(91, 17);
            cliend_numidLabel.TabIndex = 11;
            cliend_numidLabel.Text = "cliend numid:";
            // 
            // cliend_numidTextBox
            // 
            this.cliend_numidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClientesBindingSource, "cliend_numid", true));
            this.cliend_numidTextBox.Location = new System.Drawing.Point(115, 207);
            this.cliend_numidTextBox.Name = "cliend_numidTextBox";
            this.cliend_numidTextBox.Size = new System.Drawing.Size(100, 22);
            this.cliend_numidTextBox.TabIndex = 12;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.listaClientesBindingSource;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton7});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 47);
            this.bindingNavigator1.TabIndex = 13;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Enabled = false;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(107, 44);
            this.toolStripButton7.Text = "Guardar datos";
            this.toolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // frm_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(clien_idLabel);
            this.Controls.Add(this.clien_idTextBox);
            this.Controls.Add(clien_papeLabel);
            this.Controls.Add(this.clien_papeTextBox);
            this.Controls.Add(clien_pnomLabel);
            this.Controls.Add(this.clien_pnomTextBox);
            this.Controls.Add(clien_snomLabel);
            this.Controls.Add(this.clien_snomTextBox);
            this.Controls.Add(clien_telLabel);
            this.Controls.Add(this.clien_telTextBox);
            this.Controls.Add(cliend_numidLabel);
            this.Controls.Add(this.cliend_numidTextBox);
            this.Controls.Add(this.listaClientesBindingNavigator);
            this.Name = "frm_clientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingNavigator)).EndInit();
            this.listaClientesBindingNavigator.ResumeLayout(false);
            this.listaClientesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaClientesBindingSource;
        private System.Windows.Forms.BindingNavigator listaClientesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listaClientesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox clien_idTextBox;
        private System.Windows.Forms.TextBox clien_papeTextBox;
        private System.Windows.Forms.TextBox clien_pnomTextBox;
        private System.Windows.Forms.TextBox clien_snomTextBox;
        private System.Windows.Forms.TextBox clien_telTextBox;
        private System.Windows.Forms.TextBox cliend_numidTextBox;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
    }
}