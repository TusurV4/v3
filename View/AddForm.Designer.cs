
namespace View
{
    partial class AddForm
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
            this.AddTextBox3 = new System.Windows.Forms.TextBox();
            this.AddItemLabel3 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.RandomValueButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddTextBox2 = new System.Windows.Forms.TextBox();
            this.AddTextBox1 = new System.Windows.Forms.TextBox();
            this.TransportNameComboBox = new System.Windows.Forms.ComboBox();
            this.AddItemLabel2 = new System.Windows.Forms.Label();
            this.TransportNameLabel = new System.Windows.Forms.Label();
            this.AddItemLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddTextBox3
            // 
            this.AddTextBox3.Location = new System.Drawing.Point(200, 86);
            this.AddTextBox3.MaxLength = 10;
            this.AddTextBox3.Name = "AddTextBox3";
            this.AddTextBox3.Size = new System.Drawing.Size(116, 20);
            this.AddTextBox3.TabIndex = 59;
            // 
            // AddItemLabel3
            // 
            this.AddItemLabel3.AutoSize = true;
            this.AddItemLabel3.Location = new System.Drawing.Point(12, 89);
            this.AddItemLabel3.Name = "AddItemLabel3";
            this.AddItemLabel3.Size = new System.Drawing.Size(78, 13);
            this.AddItemLabel3.TabIndex = 58;
            this.AddItemLabel3.Text = "AddItemLabel3";
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(221, 121);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(95, 37);
            this.ExitButton.TabIndex = 55;
            this.ExitButton.Text = "Отмена";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RandomValueButton
            // 
            this.RandomValueButton.Location = new System.Drawing.Point(116, 121);
            this.RandomValueButton.Name = "RandomValueButton";
            this.RandomValueButton.Size = new System.Drawing.Size(96, 37);
            this.RandomValueButton.TabIndex = 56;
            this.RandomValueButton.Text = "Случайное значение";
            this.RandomValueButton.UseVisualStyleBackColor = true;
            this.RandomValueButton.Click += new System.EventHandler(this.RandomValueButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(15, 121);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(95, 37);
            this.AddButton.TabIndex = 57;
            this.AddButton.Text = "Ok";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddTextBox2
            // 
            this.AddTextBox2.Location = new System.Drawing.Point(200, 60);
            this.AddTextBox2.MaxLength = 10;
            this.AddTextBox2.Name = "AddTextBox2";
            this.AddTextBox2.Size = new System.Drawing.Size(116, 20);
            this.AddTextBox2.TabIndex = 54;
            // 
            // AddTextBox1
            // 
            this.AddTextBox1.Location = new System.Drawing.Point(200, 36);
            this.AddTextBox1.MaxLength = 10;
            this.AddTextBox1.Name = "AddTextBox1";
            this.AddTextBox1.Size = new System.Drawing.Size(116, 20);
            this.AddTextBox1.TabIndex = 53;
            // 
            // TransportNameComboBox
            // 
            this.TransportNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransportNameComboBox.FormattingEnabled = true;
            this.TransportNameComboBox.Items.AddRange(new object[] {
            "Машина",
            "Машина-гибрид",
            "Вертолёт"});
            this.TransportNameComboBox.Location = new System.Drawing.Point(200, 6);
            this.TransportNameComboBox.Name = "TransportNameComboBox";
            this.TransportNameComboBox.Size = new System.Drawing.Size(116, 21);
            this.TransportNameComboBox.TabIndex = 52;
            this.TransportNameComboBox.SelectedIndexChanged += new System.EventHandler(this.TransportNameComboBox_SelectedIndexChanged);
            // 
            // AddItemLabel2
            // 
            this.AddItemLabel2.AutoSize = true;
            this.AddItemLabel2.Location = new System.Drawing.Point(12, 63);
            this.AddItemLabel2.Name = "AddItemLabel2";
            this.AddItemLabel2.Size = new System.Drawing.Size(78, 13);
            this.AddItemLabel2.TabIndex = 49;
            this.AddItemLabel2.Text = "AddItemLabel2";
            // 
            // TransportNameLabel
            // 
            this.TransportNameLabel.AutoSize = true;
            this.TransportNameLabel.Location = new System.Drawing.Point(12, 9);
            this.TransportNameLabel.Name = "TransportNameLabel";
            this.TransportNameLabel.Size = new System.Drawing.Size(61, 13);
            this.TransportNameLabel.TabIndex = 50;
            this.TransportNameLabel.Text = "Транспорт";
            // 
            // AddItemLabel1
            // 
            this.AddItemLabel1.AutoSize = true;
            this.AddItemLabel1.Location = new System.Drawing.Point(12, 39);
            this.AddItemLabel1.Name = "AddItemLabel1";
            this.AddItemLabel1.Size = new System.Drawing.Size(78, 13);
            this.AddItemLabel1.TabIndex = 51;
            this.AddItemLabel1.Text = "AddItemLabel1";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 164);
            this.Controls.Add(this.AddTextBox3);
            this.Controls.Add(this.AddItemLabel3);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RandomValueButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AddTextBox2);
            this.Controls.Add(this.AddTextBox1);
            this.Controls.Add(this.TransportNameComboBox);
            this.Controls.Add(this.AddItemLabel2);
            this.Controls.Add(this.TransportNameLabel);
            this.Controls.Add(this.AddItemLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(338, 203);
            this.MinimumSize = new System.Drawing.Size(338, 203);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление информации";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddTextBox3;
        private System.Windows.Forms.Label AddItemLabel3;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button RandomValueButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox AddTextBox2;
        private System.Windows.Forms.TextBox AddTextBox1;
        private System.Windows.Forms.ComboBox TransportNameComboBox;
        private System.Windows.Forms.Label AddItemLabel2;
        private System.Windows.Forms.Label TransportNameLabel;
        private System.Windows.Forms.Label AddItemLabel1;
    }
}