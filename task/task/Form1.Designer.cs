namespace task
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelet = new System.Windows.Forms.Button();
            this.buttonAdd1 = new System.Windows.Forms.Button();
            this.buttonAdd2 = new System.Windows.Forms.Button();
            this.buttonInExel = new System.Windows.Forms.Button();
            this.buttonInXml = new System.Windows.Forms.Button();
            this.buttonInJson = new System.Windows.Forms.Button();
            this.buttonOnJson = new System.Windows.Forms.Button();
            this.buttonInLua = new System.Windows.Forms.Button();
            this.buttonOnLua = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DevicesDataGridView = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProDevicesDataGredView = new System.Windows.Forms.DataGridView();
            this.NumberProperties = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Properties = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meaning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DevicesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProDevicesDataGredView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Location = new System.Drawing.Point(16, 374);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelet
            // 
            this.buttonDelet.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDelet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelet.Location = new System.Drawing.Point(124, 374);
            this.buttonDelet.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelet.Name = "buttonDelet";
            this.buttonDelet.Size = new System.Drawing.Size(100, 28);
            this.buttonDelet.TabIndex = 1;
            this.buttonDelet.Text = "Удалить\r\n";
            this.buttonDelet.UseVisualStyleBackColor = false;
            this.buttonDelet.Click += new System.EventHandler(this.buttonDelet_Click);
            // 
            // buttonAdd1
            // 
            this.buttonAdd1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAdd1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd1.Location = new System.Drawing.Point(647, 374);
            this.buttonAdd1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd1.Name = "buttonAdd1";
            this.buttonAdd1.Size = new System.Drawing.Size(100, 28);
            this.buttonAdd1.TabIndex = 2;
            this.buttonAdd1.Text = "Добавить\r\n";
            this.buttonAdd1.UseVisualStyleBackColor = false;
            this.buttonAdd1.Click += new System.EventHandler(this.buttonAdd1_Click);
            // 
            // buttonAdd2
            // 
            this.buttonAdd2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAdd2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd2.Location = new System.Drawing.Point(774, 374);
            this.buttonAdd2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd2.Name = "buttonAdd2";
            this.buttonAdd2.Size = new System.Drawing.Size(100, 28);
            this.buttonAdd2.TabIndex = 3;
            this.buttonAdd2.Text = "Удалить";
            this.buttonAdd2.UseVisualStyleBackColor = false;
            this.buttonAdd2.Click += new System.EventHandler(this.buttonAdd2_Click);
            // 
            // buttonInExel
            // 
            this.buttonInExel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonInExel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInExel.Location = new System.Drawing.Point(16, 410);
            this.buttonInExel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInExel.Name = "buttonInExel";
            this.buttonInExel.Size = new System.Drawing.Size(167, 28);
            this.buttonInExel.TabIndex = 4;
            this.buttonInExel.Text = "Выгрузить в EXEL";
            this.buttonInExel.UseVisualStyleBackColor = false;
            // 
            // buttonInXml
            // 
            this.buttonInXml.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonInXml.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInXml.Location = new System.Drawing.Point(191, 410);
            this.buttonInXml.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInXml.Name = "buttonInXml";
            this.buttonInXml.Size = new System.Drawing.Size(152, 28);
            this.buttonInXml.TabIndex = 5;
            this.buttonInXml.Text = "Выгрузить в XML";
            this.buttonInXml.UseVisualStyleBackColor = false;
            // 
            // buttonInJson
            // 
            this.buttonInJson.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonInJson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInJson.Location = new System.Drawing.Point(351, 410);
            this.buttonInJson.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInJson.Name = "buttonInJson";
            this.buttonInJson.Size = new System.Drawing.Size(163, 28);
            this.buttonInJson.TabIndex = 6;
            this.buttonInJson.Text = "Выгрузить в JSON";
            this.buttonInJson.UseVisualStyleBackColor = false;
            // 
            // buttonOnJson
            // 
            this.buttonOnJson.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonOnJson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOnJson.Location = new System.Drawing.Point(351, 446);
            this.buttonOnJson.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOnJson.Name = "buttonOnJson";
            this.buttonOnJson.Size = new System.Drawing.Size(163, 28);
            this.buttonOnJson.TabIndex = 7;
            this.buttonOnJson.Text = "Загрузить из JSON";
            this.buttonOnJson.UseVisualStyleBackColor = false;
            // 
            // buttonInLua
            // 
            this.buttonInLua.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonInLua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInLua.Location = new System.Drawing.Point(521, 410);
            this.buttonInLua.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInLua.Name = "buttonInLua";
            this.buttonInLua.Size = new System.Drawing.Size(156, 28);
            this.buttonInLua.TabIndex = 8;
            this.buttonInLua.Text = "Выгрузить в LUA";
            this.buttonInLua.UseVisualStyleBackColor = false;
            // 
            // buttonOnLua
            // 
            this.buttonOnLua.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonOnLua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOnLua.Location = new System.Drawing.Point(521, 446);
            this.buttonOnLua.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOnLua.Name = "buttonOnLua";
            this.buttonOnLua.Size = new System.Drawing.Size(156, 28);
            this.buttonOnLua.TabIndex = 9;
            this.buttonOnLua.Text = "Загрузить из LUA";
            this.buttonOnLua.UseVisualStyleBackColor = false;
            // 
            // buttonSort
            // 
            this.buttonSort.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSort.Location = new System.Drawing.Point(243, 28);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(100, 28);
            this.buttonSort.TabIndex = 10;
            this.buttonSort.Text = "Сортировка";
            this.buttonSort.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Устройства";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Свойства";
            // 
            // DevicesDataGridView
            // 
            this.DevicesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DevicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DevicesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Type,
            this.NameOne,
            this.Cost});
            this.DevicesDataGridView.Location = new System.Drawing.Point(16, 71);
            this.DevicesDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.DevicesDataGridView.Name = "DevicesDataGridView";
            this.DevicesDataGridView.RowHeadersWidth = 51;
            this.DevicesDataGridView.Size = new System.Drawing.Size(608, 295);
            this.DevicesDataGridView.TabIndex = 15;
            // 
            // Number
            // 
            this.Number.HeaderText = "№";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            // 
            // Type
            // 
            this.Type.HeaderText = "Тип";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            // 
            // NameOne
            // 
            this.NameOne.HeaderText = "Название";
            this.NameOne.MinimumWidth = 6;
            this.NameOne.Name = "NameOne";
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Цена";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            // 
            // ProDevicesDataGredView
            // 
            this.ProDevicesDataGredView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProDevicesDataGredView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProDevicesDataGredView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberProperties,
            this.Properties,
            this.Meaning});
            this.ProDevicesDataGredView.Location = new System.Drawing.Point(647, 71);
            this.ProDevicesDataGredView.Margin = new System.Windows.Forms.Padding(4);
            this.ProDevicesDataGredView.Name = "ProDevicesDataGredView";
            this.ProDevicesDataGredView.RowHeadersWidth = 51;
            this.ProDevicesDataGredView.Size = new System.Drawing.Size(513, 295);
            this.ProDevicesDataGredView.TabIndex = 16;
            // 
            // NumberProperties
            // 
            this.NumberProperties.HeaderText = "№";
            this.NumberProperties.MinimumWidth = 6;
            this.NumberProperties.Name = "NumberProperties";
            // 
            // Properties
            // 
            this.Properties.HeaderText = "Свойство";
            this.Properties.MinimumWidth = 6;
            this.Properties.Name = "Properties";
            // 
            // Meaning
            // 
            this.Meaning.HeaderText = "Значение";
            this.Meaning.MinimumWidth = 6;
            this.Meaning.Name = "Meaning";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1173, 517);
            this.Controls.Add(this.ProDevicesDataGredView);
            this.Controls.Add(this.DevicesDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonOnLua);
            this.Controls.Add(this.buttonInLua);
            this.Controls.Add(this.buttonOnJson);
            this.Controls.Add(this.buttonInJson);
            this.Controls.Add(this.buttonInXml);
            this.Controls.Add(this.buttonInExel);
            this.Controls.Add(this.buttonAdd2);
            this.Controls.Add(this.buttonAdd1);
            this.Controls.Add(this.buttonDelet);
            this.Controls.Add(this.buttonAdd);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DevicesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProDevicesDataGredView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelet;
        private System.Windows.Forms.Button buttonAdd1;
        private System.Windows.Forms.Button buttonAdd2;
        private System.Windows.Forms.Button buttonInExel;
        private System.Windows.Forms.Button buttonInXml;
        private System.Windows.Forms.Button buttonInJson;
        private System.Windows.Forms.Button buttonOnJson;
        private System.Windows.Forms.Button buttonInLua;
        private System.Windows.Forms.Button buttonOnLua;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberProperties;
        private System.Windows.Forms.DataGridViewTextBoxColumn Properties;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meaning;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        public System.Windows.Forms.DataGridView DevicesDataGridView;
        public System.Windows.Forms.DataGridView ProDevicesDataGredView;
    }
}

