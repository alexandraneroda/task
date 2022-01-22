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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TableDevaces = new System.Windows.Forms.DataGridView();
            this.TableProperties = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableDevaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Location = new System.Drawing.Point(12, 304);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // buttonDelet
            // 
            this.buttonDelet.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDelet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelet.Location = new System.Drawing.Point(93, 304);
            this.buttonDelet.Name = "buttonDelet";
            this.buttonDelet.Size = new System.Drawing.Size(75, 23);
            this.buttonDelet.TabIndex = 1;
            this.buttonDelet.Text = "Удалить\r\n";
            this.buttonDelet.UseVisualStyleBackColor = false;
            // 
            // buttonAdd1
            // 
            this.buttonAdd1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAdd1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd1.Location = new System.Drawing.Point(479, 304);
            this.buttonAdd1.Name = "buttonAdd1";
            this.buttonAdd1.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd1.TabIndex = 2;
            this.buttonAdd1.Text = "Добавить\r\n";
            this.buttonAdd1.UseVisualStyleBackColor = false;
            // 
            // buttonAdd2
            // 
            this.buttonAdd2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAdd2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd2.Location = new System.Drawing.Point(560, 304);
            this.buttonAdd2.Name = "buttonAdd2";
            this.buttonAdd2.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd2.TabIndex = 3;
            this.buttonAdd2.Text = "Удалить";
            this.buttonAdd2.UseVisualStyleBackColor = false;
            // 
            // buttonInExel
            // 
            this.buttonInExel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonInExel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInExel.Location = new System.Drawing.Point(12, 333);
            this.buttonInExel.Name = "buttonInExel";
            this.buttonInExel.Size = new System.Drawing.Size(125, 23);
            this.buttonInExel.TabIndex = 4;
            this.buttonInExel.Text = "Выгрузить в EXEL";
            this.buttonInExel.UseVisualStyleBackColor = false;
            // 
            // buttonInXml
            // 
            this.buttonInXml.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonInXml.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInXml.Location = new System.Drawing.Point(143, 333);
            this.buttonInXml.Name = "buttonInXml";
            this.buttonInXml.Size = new System.Drawing.Size(114, 23);
            this.buttonInXml.TabIndex = 5;
            this.buttonInXml.Text = "Выгрузить в XML";
            this.buttonInXml.UseVisualStyleBackColor = false;
            // 
            // buttonInJson
            // 
            this.buttonInJson.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonInJson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInJson.Location = new System.Drawing.Point(263, 333);
            this.buttonInJson.Name = "buttonInJson";
            this.buttonInJson.Size = new System.Drawing.Size(122, 23);
            this.buttonInJson.TabIndex = 6;
            this.buttonInJson.Text = "Выгрузить в JSON";
            this.buttonInJson.UseVisualStyleBackColor = false;
            // 
            // buttonOnJson
            // 
            this.buttonOnJson.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonOnJson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOnJson.Location = new System.Drawing.Point(263, 362);
            this.buttonOnJson.Name = "buttonOnJson";
            this.buttonOnJson.Size = new System.Drawing.Size(122, 23);
            this.buttonOnJson.TabIndex = 7;
            this.buttonOnJson.Text = "Загрузить из JSON";
            this.buttonOnJson.UseVisualStyleBackColor = false;
            // 
            // buttonInLua
            // 
            this.buttonInLua.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonInLua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInLua.Location = new System.Drawing.Point(391, 333);
            this.buttonInLua.Name = "buttonInLua";
            this.buttonInLua.Size = new System.Drawing.Size(117, 23);
            this.buttonInLua.TabIndex = 8;
            this.buttonInLua.Text = "Выгрузить в LUA";
            this.buttonInLua.UseVisualStyleBackColor = false;
            // 
            // buttonOnLua
            // 
            this.buttonOnLua.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonOnLua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOnLua.Location = new System.Drawing.Point(391, 362);
            this.buttonOnLua.Name = "buttonOnLua";
            this.buttonOnLua.Size = new System.Drawing.Size(117, 23);
            this.buttonOnLua.TabIndex = 9;
            this.buttonOnLua.Text = "Загрузить из LUA";
            this.buttonOnLua.UseVisualStyleBackColor = false;
            // 
            // buttonSort
            // 
            this.buttonSort.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSort.Location = new System.Drawing.Point(182, 23);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(75, 23);
            this.buttonSort.TabIndex = 10;
            this.buttonSort.Text = "Сортировка";
            this.buttonSort.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.TableProperties);
            this.panel2.Location = new System.Drawing.Point(448, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 239);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Устройства";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Свойства";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.TableDevaces);
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 239);
            this.panel1.TabIndex = 11;
            // 
            // TableDevaces
            // 
            this.TableDevaces.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.TableDevaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableDevaces.Location = new System.Drawing.Point(3, 3);
            this.TableDevaces.Name = "TableDevaces";
            this.TableDevaces.Size = new System.Drawing.Size(370, 64);
            this.TableDevaces.TabIndex = 0;
            // 
            // TableProperties
            // 
            this.TableProperties.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.TableProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableProperties.Location = new System.Drawing.Point(4, 4);
            this.TableProperties.Name = "TableProperties";
            this.TableProperties.Size = new System.Drawing.Size(373, 63);
            this.TableProperties.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableDevaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableProperties)).EndInit();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView TableProperties;
        private System.Windows.Forms.DataGridView TableDevaces;
    }
}

