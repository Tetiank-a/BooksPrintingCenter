namespace PRINTER_CENTER
{
    partial class PaperForm
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
            this.dataGridViewPaper = new System.Windows.Forms.DataGridView();
            this.paperIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paperNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paperBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printingDataSet = new PRINTER_CENTER.PrintingDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byPaperIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bySizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paperTableAdapter = new PRINTER_CENTER.PrintingDataSetTableAdapters.PaperTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPaper
            // 
            this.dataGridViewPaper.AutoGenerateColumns = false;
            this.dataGridViewPaper.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPaper.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPaper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPaper.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paperIdDataGridViewTextBoxColumn,
            this.paperNameDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridViewPaper.DataSource = this.paperBindingSource;
            this.dataGridViewPaper.Location = new System.Drawing.Point(25, 271);
            this.dataGridViewPaper.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewPaper.MultiSelect = false;
            this.dataGridViewPaper.Name = "dataGridViewPaper";
            this.dataGridViewPaper.RowHeadersWidth = 51;
            this.dataGridViewPaper.RowTemplate.Height = 24;
            this.dataGridViewPaper.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPaper.Size = new System.Drawing.Size(819, 319);
            this.dataGridViewPaper.TabIndex = 0;
            // 
            // paperIdDataGridViewTextBoxColumn
            // 
            this.paperIdDataGridViewTextBoxColumn.DataPropertyName = "PaperId";
            this.paperIdDataGridViewTextBoxColumn.HeaderText = "PaperId";
            this.paperIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paperIdDataGridViewTextBoxColumn.Name = "paperIdDataGridViewTextBoxColumn";
            this.paperIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paperNameDataGridViewTextBoxColumn
            // 
            this.paperNameDataGridViewTextBoxColumn.DataPropertyName = "PaperName";
            this.paperNameDataGridViewTextBoxColumn.HeaderText = "PaperName";
            this.paperNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paperNameDataGridViewTextBoxColumn.Name = "paperNameDataGridViewTextBoxColumn";
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // paperBindingSource
            // 
            this.paperBindingSource.DataMember = "Paper";
            this.paperBindingSource.DataSource = this.printingDataSet;
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
            this.editToolStripMenuItem,
            this.sortToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(878, 30);
            this.menuStrip1.TabIndex = 3;
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
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byPaperIdToolStripMenuItem,
            this.bySizeToolStripMenuItem,
            this.byPriceToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.sortToolStripMenuItem.Text = "Sort";
            // 
            // byPaperIdToolStripMenuItem
            // 
            this.byPaperIdToolStripMenuItem.Name = "byPaperIdToolStripMenuItem";
            this.byPaperIdToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.byPaperIdToolStripMenuItem.Text = "By paper id";
            this.byPaperIdToolStripMenuItem.Click += new System.EventHandler(this.byPaperIdToolStripMenuItem_Click);
            // 
            // bySizeToolStripMenuItem
            // 
            this.bySizeToolStripMenuItem.Name = "bySizeToolStripMenuItem";
            this.bySizeToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.bySizeToolStripMenuItem.Text = "By size";
            this.bySizeToolStripMenuItem.Click += new System.EventHandler(this.bySizeToolStripMenuItem_Click);
            // 
            // byPriceToolStripMenuItem
            // 
            this.byPriceToolStripMenuItem.Name = "byPriceToolStripMenuItem";
            this.byPriceToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.byPriceToolStripMenuItem.Text = "By price";
            this.byPriceToolStripMenuItem.Click += new System.EventHandler(this.byPriceToolStripMenuItem_Click);
            // 
            // paperTableAdapter
            // 
            this.paperTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(141)))), ((int)(((byte)(63)))));
            this.button2.Location = new System.Drawing.Point(604, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 37);
            this.button2.TabIndex = 17;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(141)))), ((int)(((byte)(63)))));
            this.button1.Location = new System.Drawing.Point(419, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 37);
            this.button1.TabIndex = 16;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bindingNavigator3
            // 
            this.bindingNavigator3.AddNewItem = null;
            this.bindingNavigator3.BackColor = System.Drawing.Color.Tan;
            this.bindingNavigator3.CountItem = null;
            this.bindingNavigator3.DeleteItem = null;
            this.bindingNavigator3.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigator3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel4,
            this.toolStripTextBox4,
            this.toolStripSeparator1});
            this.bindingNavigator3.Location = new System.Drawing.Point(22, 123);
            this.bindingNavigator3.MoveFirstItem = null;
            this.bindingNavigator3.MoveLastItem = null;
            this.bindingNavigator3.MoveNextItem = null;
            this.bindingNavigator3.MovePreviousItem = null;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.PositionItem = null;
            this.bindingNavigator3.Size = new System.Drawing.Size(175, 27);
            this.bindingNavigator3.TabIndex = 15;
            this.bindingNavigator3.Text = "bindingNavigator3";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(54, 24);
            this.toolStripLabel4.Text = "Name";
            // 
            // toolStripTextBox4
            // 
            this.toolStripTextBox4.Name = "toolStripTextBox4";
            this.toolStripTextBox4.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox4.TextChanged += new System.EventHandler(this.toolStripTextBox4_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.Color.Tan;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.toolStripSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(22, 86);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(175, 27);
            this.bindingNavigator1.TabIndex = 14;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(54, 24);
            this.toolStripLabel1.Text = "Size";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(20, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Price from:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(20, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Price to:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 34);
            this.textBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(203, 204);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(193, 34);
            this.textBox2.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(148)))), ((int)(((byte)(139)))));
            this.button3.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(339, 598);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 48);
            this.button3.TabIndex = 24;
            this.button3.Text = "BACK <--";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MistyRose;
            this.label3.Location = new System.Drawing.Point(361, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 38);
            this.label3.TabIndex = 28;
            this.label3.Text = "PAPER";
            // 
            // PaperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(60)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(878, 656);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bindingNavigator3);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridViewPaper);
            this.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PaperForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaperForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaperForm_FormClosing);
            this.Load += new System.EventHandler(this.PaperForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPaper;
        private PrintingDataSet printingDataSet;
        private System.Windows.Forms.BindingSource paperBindingSource;
        private PrintingDataSetTableAdapters.PaperTableAdapter paperTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn paperIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paperNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingNavigator bindingNavigator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byPaperIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bySizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byPriceToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
    }
}