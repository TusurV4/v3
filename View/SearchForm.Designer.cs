
namespace View
{
    partial class SearchForm
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
            this.TransportNameComboBox = new System.Windows.Forms.ComboBox();
            this.TransportNameLabel = new System.Windows.Forms.Label();
            this.ExitFindButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ConsumedFuelLabel = new System.Windows.Forms.Label();
            this.ConsumedFuelTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TransportNameComboBox
            // 
            this.TransportNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransportNameComboBox.FormattingEnabled = true;
            this.TransportNameComboBox.Items.AddRange(new object[] {
            "Машина",
            "Машина-гибрид",
            "Вертолёт"});
            this.TransportNameComboBox.Location = new System.Drawing.Point(141, 6);
            this.TransportNameComboBox.Name = "TransportNameComboBox";
            this.TransportNameComboBox.Size = new System.Drawing.Size(144, 21);
            this.TransportNameComboBox.TabIndex = 44;
            this.TransportNameComboBox.SelectedIndexChanged += new System.EventHandler(this.TransportNameComboBox_SelectedIndexChanged);
            // 
            // TransportNameLabel
            // 
            this.TransportNameLabel.AutoSize = true;
            this.TransportNameLabel.Location = new System.Drawing.Point(12, 9);
            this.TransportNameLabel.Name = "TransportNameLabel";
            this.TransportNameLabel.Size = new System.Drawing.Size(61, 13);
            this.TransportNameLabel.TabIndex = 43;
            this.TransportNameLabel.Text = "Транспорт";
            // 
            // ExitFindButton
            // 
            this.ExitFindButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitFindButton.Location = new System.Drawing.Point(210, 63);
            this.ExitFindButton.Name = "ExitFindButton";
            this.ExitFindButton.Size = new System.Drawing.Size(75, 23);
            this.ExitFindButton.TabIndex = 42;
            this.ExitFindButton.Text = "Отмена";
            this.ExitFindButton.UseVisualStyleBackColor = true;
            this.ExitFindButton.Click += new System.EventHandler(this.ExitFindButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(15, 63);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 41;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ConsumedFuelLabel
            // 
            this.ConsumedFuelLabel.AutoSize = true;
            this.ConsumedFuelLabel.Location = new System.Drawing.Point(12, 37);
            this.ConsumedFuelLabel.Name = "ConsumedFuelLabel";
            this.ConsumedFuelLabel.Size = new System.Drawing.Size(87, 13);
            this.ConsumedFuelLabel.TabIndex = 39;
            this.ConsumedFuelLabel.Text = "Расход топлива";
            this.ConsumedFuelLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ConsumedFuelTextBox
            // 
            this.ConsumedFuelTextBox.Location = new System.Drawing.Point(141, 34);
            this.ConsumedFuelTextBox.MaxLength = 10;
            this.ConsumedFuelTextBox.Name = "ConsumedFuelTextBox";
            this.ConsumedFuelTextBox.Size = new System.Drawing.Size(144, 20);
            this.ConsumedFuelTextBox.TabIndex = 40;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 93);
            this.Controls.Add(this.TransportNameComboBox);
            this.Controls.Add(this.TransportNameLabel);
            this.Controls.Add(this.ExitFindButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ConsumedFuelLabel);
            this.Controls.Add(this.ConsumedFuelTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(313, 132);
            this.MinimumSize = new System.Drawing.Size(313, 132);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск инфорации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TransportNameComboBox;
        private System.Windows.Forms.Label TransportNameLabel;
        private System.Windows.Forms.Button ExitFindButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label ConsumedFuelLabel;
        private System.Windows.Forms.TextBox ConsumedFuelTextBox;
    }
}