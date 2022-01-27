namespace task
{
    partial class Form3
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
            this.AddingDataGroupBox = new System.Windows.Forms.GroupBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.Numberlabel = new System.Windows.Forms.Label();
            this.AddingDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddingDataGroupBox
            // 
            this.AddingDataGroupBox.Controls.Add(this.AddButton);
            this.AddingDataGroupBox.Controls.Add(this.CostTextBox);
            this.AddingDataGroupBox.Controls.Add(this.NameTextBox);
            this.AddingDataGroupBox.Controls.Add(this.TypeTextBox);
            this.AddingDataGroupBox.Controls.Add(this.NumberTextBox);
            this.AddingDataGroupBox.Controls.Add(this.CostLabel);
            this.AddingDataGroupBox.Controls.Add(this.NameLabel);
            this.AddingDataGroupBox.Controls.Add(this.TypeLabel);
            this.AddingDataGroupBox.Controls.Add(this.Numberlabel);
            this.AddingDataGroupBox.Location = new System.Drawing.Point(5, 4);
            this.AddingDataGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.AddingDataGroupBox.Name = "AddingDataGroupBox";
            this.AddingDataGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.AddingDataGroupBox.Size = new System.Drawing.Size(431, 257);
            this.AddingDataGroupBox.TabIndex = 0;
            this.AddingDataGroupBox.TabStop = false;
            this.AddingDataGroupBox.Text = "groupBox1";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(166, 205);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(118, 47);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(90, 172);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(294, 22);
            this.CostTextBox.TabIndex = 7;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(90, 120);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(294, 22);
            this.NameTextBox.TabIndex = 6;
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Location = new System.Drawing.Point(90, 75);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(294, 22);
            this.TypeTextBox.TabIndex = 5;
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(90, 30);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(294, 22);
            this.NumberTextBox.TabIndex = 4;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(6, 175);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(46, 16);
            this.CostLabel.TabIndex = 3;
            this.CostLabel.Text = "Цена: ";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(6, 120);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(79, 16);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Название: ";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(6, 75);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(38, 16);
            this.TypeLabel.TabIndex = 1;
            this.TypeLabel.Text = "Тип: ";
            // 
            // Numberlabel
            // 
            this.Numberlabel.AutoSize = true;
            this.Numberlabel.Location = new System.Drawing.Point(6, 30);
            this.Numberlabel.Name = "Numberlabel";
            this.Numberlabel.Size = new System.Drawing.Size(53, 16);
            this.Numberlabel.TabIndex = 0;
            this.Numberlabel.Text = "Номер:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 268);
            this.Controls.Add(this.AddingDataGroupBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.AddingDataGroupBox.ResumeLayout(false);
            this.AddingDataGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AddingDataGroupBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label Numberlabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.Button AddButton;
    }
}