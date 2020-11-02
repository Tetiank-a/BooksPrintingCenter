namespace PRINTER_CENTER
{
    partial class InkForm
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
            this.dataGridViewInk = new System.Windows.Forms.DataGridView();
            this.inkIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inkNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printingDataSet = new PRINTER_CENTER.PrintingDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inkTableAdapter = new PRINTER_CENTER.PrintingDataSetTableAdapters.InkTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewInk
            // 
            this.dataGridViewInk.AutoGenerateColumns = false;
            this.dataGridViewInk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInk.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewInk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inkIdDataGridViewTextBoxColumn,
            this.inkNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridViewInk.DataSource = this.inkBindingSource;
            this.dataGridViewInk.Location = new System.Drawing.Point(34, 80);
            this.dataGridViewInk.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewInk.Name = "dataGridViewInk";
            this.dataGridViewInk.RowHeadersWidth = 51;
            this.dataGridViewInk.RowTemplate.Height = 24;
            this.dataGridViewInk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInk.Size = new System.Drawing.Size(770, 332);
            this.dataGridViewInk.TabIndex = 0;
            // 
            // inkIdDataGridViewTextBoxColumn
            // 
            this.inkIdDataGridViewTextBoxColumn.DataPropertyName = "InkId";
            this.inkIdDataGridViewTextBoxColumn.HeaderText = "InkId";
            this.inkIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inkIdDataGridViewTextBoxColumn.Name = "inkIdDataGridViewTextBoxColumn";
            this.inkIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inkNameDataGridViewTextBoxColumn
            // 
            this.inkNameDataGridViewTextBoxColumn.DataPropertyName = "InkName";
            this.inkNameDataGridViewTextBoxColumn.HeaderText = "InkName";
            this.inkNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inkNameDataGridViewTextBoxColumn.Name = "inkNameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // inkBindingSource
            // 
            this.inkBindingSource.DataMember = "Ink";
            this.inkBindingSource.DataSource = this.printingDataSet;
            // 
            // printingDataSet
            // 
            this.printingDataSet.DataSetName = "PrintingDataSet";
            this.printingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(837, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.deleteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(136, 26);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // inkTableAdapter
            // 
            this.inkTableAdapter.ClearBeforeFill = true;
            // 
            // InkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(837, 476);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridViewInk);
            this.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "InkForm";
            this.Text = "InkForm";
            this.Load += new System.EventHandler(this.InkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInk;
        private PrintingDataSet printingDataSet;
        private System.Windows.Forms.BindingSource inkBindingSource;
        private PrintingDataSetTableAdapters.InkTableAdapter inkTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn inkIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inkNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}