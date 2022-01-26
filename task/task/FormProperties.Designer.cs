namespace task
{
    partial class FormProperties
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBoxMean = new System.Windows.Forms.TextBox();
            this.TextBoxPro = new System.Windows.Forms.TextBox();
            this.TextBoxN = new System.Windows.Forms.TextBox();
            this.labelMean = new System.Windows.Forms.Label();
            this.labelPropertie = new System.Windows.Forms.Label();
            this.labelNumberProperties = new System.Windows.Forms.Label();
            this.AddPrButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddPrButton);
            this.groupBox1.Controls.Add(this.TextBoxMean);
            this.groupBox1.Controls.Add(this.TextBoxPro);
            this.groupBox1.Controls.Add(this.TextBoxN);
            this.groupBox1.Controls.Add(this.labelMean);
            this.groupBox1.Controls.Add(this.labelPropertie);
            this.groupBox1.Controls.Add(this.labelNumberProperties);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // TextBoxMean
            // 
            this.TextBoxMean.Location = new System.Drawing.Point(109, 144);
            this.TextBoxMean.Name = "TextBoxMean";
            this.TextBoxMean.Size = new System.Drawing.Size(243, 22);
            this.TextBoxMean.TabIndex = 5;
            // 
            // TextBoxPro
            // 
            this.TextBoxPro.Location = new System.Drawing.Point(109, 90);
            this.TextBoxPro.Name = "TextBoxPro";
            this.TextBoxPro.Size = new System.Drawing.Size(243, 22);
            this.TextBoxPro.TabIndex = 4;
            // 
            // TextBoxN
            // 
            this.TextBoxN.Location = new System.Drawing.Point(109, 25);
            this.TextBoxN.Name = "TextBoxN";
            this.TextBoxN.Size = new System.Drawing.Size(243, 22);
            this.TextBoxN.TabIndex = 3;
            // 
            // labelMean
            // 
            this.labelMean.AutoSize = true;
            this.labelMean.Location = new System.Drawing.Point(18, 150);
            this.labelMean.Name = "labelMean";
            this.labelMean.Size = new System.Drawing.Size(75, 16);
            this.labelMean.TabIndex = 2;
            this.labelMean.Text = "Значение:";
            // 
            // labelPropertie
            // 
            this.labelPropertie.AutoSize = true;
            this.labelPropertie.Location = new System.Drawing.Point(18, 96);
            this.labelPropertie.Name = "labelPropertie";
            this.labelPropertie.Size = new System.Drawing.Size(73, 16);
            this.labelPropertie.TabIndex = 1;
            this.labelPropertie.Text = "Свойство:";
            // 
            // labelNumberProperties
            // 
            this.labelNumberProperties.AutoSize = true;
            this.labelNumberProperties.Location = new System.Drawing.Point(18, 28);
            this.labelNumberProperties.Name = "labelNumberProperties";
            this.labelNumberProperties.Size = new System.Drawing.Size(53, 16);
            this.labelNumberProperties.TabIndex = 0;
            this.labelNumberProperties.Text = "Номер:";
            // 
            // AddPrButton
            // 
            this.AddPrButton.Location = new System.Drawing.Point(161, 180);
            this.AddPrButton.Name = "AddPrButton";
            this.AddPrButton.Size = new System.Drawing.Size(114, 23);
            this.AddPrButton.TabIndex = 6;
            this.AddPrButton.Text = "Добавить";
            this.AddPrButton.UseVisualStyleBackColor = true;
            this.AddPrButton.Click += new System.EventHandler(this.AddPrButton_Click);
            // 
            // FormProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 229);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormProperties";
            this.Text = "FormProperties";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelMean;
        private System.Windows.Forms.Label labelPropertie;
        private System.Windows.Forms.Label labelNumberProperties;
        private System.Windows.Forms.TextBox TextBoxMean;
        private System.Windows.Forms.TextBox TextBoxPro;
        private System.Windows.Forms.TextBox TextBoxN;
        private System.Windows.Forms.Button AddPrButton;
    }
}