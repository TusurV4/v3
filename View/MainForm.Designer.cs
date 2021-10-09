
namespace View
{
    partial class MainForm
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransportDataGridView = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.AddToolStripMenuItem,
            this.SearchToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(734, 24);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.LoadToolStripMenuItem.Text = "Загрузить";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.AddToolStripMenuItem.Text = "Добавить";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // SearchToolStripMenuItem
            // 
            this.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            this.SearchToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.SearchToolStripMenuItem.Text = "Найти";
            this.SearchToolStripMenuItem.Click += new System.EventHandler(this.SearctToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DelToolStripMenuItem_Click);
            // 
            // TransportDataGridView
            // 
            this.TransportDataGridView.AllowUserToAddRows = false;
            this.TransportDataGridView.AllowUserToDeleteRows = false;
            this.TransportDataGridView.AllowUserToResizeColumns = false;
            this.TransportDataGridView.AllowUserToResizeRows = false;
            this.TransportDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransportDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TransportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1});
            this.TransportDataGridView.Location = new System.Drawing.Point(12, 27);
            this.TransportDataGridView.MultiSelect = false;
            this.TransportDataGridView.Name = "TransportDataGridView";
            this.TransportDataGridView.ReadOnly = true;
            this.TransportDataGridView.RowHeadersVisible = false;
            this.TransportDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TransportDataGridView.Size = new System.Drawing.Size(710, 206);
            this.TransportDataGridView.TabIndex = 3;
            // 
            // Column0
            // 
            this.Column0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column0.DataPropertyName = "TransportName";
            this.Column0.HeaderText = "Название транспортного средства";
            this.Column0.MaxInputLength = 20;
            this.Column0.Name = "Column0";
            this.Column0.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "ConsumedFuel";
            this.Column1.HeaderText = "Количество затраченного топлива";
            this.Column1.MaxInputLength = 20;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 245);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.TransportDataGridView);
            this.MinimumSize = new System.Drawing.Size(750, 284);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Количество затраченного топлива транспортными средствами";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransportDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.DataGridView TransportDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

