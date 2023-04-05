
namespace Practice13_Zadanie3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonPrice = new System.Windows.Forms.RadioButton();
            this.radioButtonAccuracy = new System.Windows.Forms.RadioButton();
            this.radioButtonType = new System.Windows.Forms.RadioButton();
            this.radioButtonManufacturer = new System.Windows.Forms.RadioButton();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonNewDevice = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxAccuracy = new System.Windows.Forms.TextBox();
            this.textBoxManufacturer = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(889, 551);
            this.splitContainer1.SplitterDistance = 599;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 551);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(599, 551);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 26);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.buttonBack);
            this.panel2.Controls.Add(this.button_Search);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.buttonNewDevice);
            this.panel2.Controls.Add(this.textBoxPrice);
            this.panel2.Controls.Add(this.textBoxAccuracy);
            this.panel2.Controls.Add(this.textBoxManufacturer);
            this.panel2.Controls.Add(this.textBoxType);
            this.panel2.Controls.Add(this.textBoxName);
            this.panel2.Controls.Add(this.textBoxKey);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 551);
            this.panel2.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(16, 525);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(258, 23);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "Вернуть значения";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Visible = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(16, 500);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(258, 23);
            this.button_Search.TabIndex = 10;
            this.button_Search.Text = "Искать";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Visible = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 470);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 23);
            this.textBox1.TabIndex = 9;
            this.textBox1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonPrice);
            this.groupBox1.Controls.Add(this.radioButtonAccuracy);
            this.groupBox1.Controls.Add(this.radioButtonType);
            this.groupBox1.Controls.Add(this.radioButtonManufacturer);
            this.groupBox1.Controls.Add(this.radioButtonName);
            this.groupBox1.Location = new System.Drawing.Point(16, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // radioButtonPrice
            // 
            this.radioButtonPrice.AutoSize = true;
            this.radioButtonPrice.Location = new System.Drawing.Point(7, 75);
            this.radioButtonPrice.Name = "radioButtonPrice";
            this.radioButtonPrice.Size = new System.Drawing.Size(117, 19);
            this.radioButtonPrice.TabIndex = 4;
            this.radioButtonPrice.TabStop = true;
            this.radioButtonPrice.Text = "по стоимости(<)";
            this.radioButtonPrice.UseVisualStyleBackColor = true;
            // 
            // radioButtonAccuracy
            // 
            this.radioButtonAccuracy.AutoSize = true;
            this.radioButtonAccuracy.Location = new System.Drawing.Point(142, 47);
            this.radioButtonAccuracy.Name = "radioButtonAccuracy";
            this.radioButtonAccuracy.Size = new System.Drawing.Size(109, 19);
            this.radioButtonAccuracy.TabIndex = 3;
            this.radioButtonAccuracy.TabStop = true;
            this.radioButtonAccuracy.Text = "по точности(<)";
            this.radioButtonAccuracy.UseVisualStyleBackColor = true;
            // 
            // radioButtonType
            // 
            this.radioButtonType.AutoSize = true;
            this.radioButtonType.Location = new System.Drawing.Point(143, 22);
            this.radioButtonType.Name = "radioButtonType";
            this.radioButtonType.Size = new System.Drawing.Size(67, 19);
            this.radioButtonType.TabIndex = 2;
            this.radioButtonType.TabStop = true;
            this.radioButtonType.Text = "по типу";
            this.radioButtonType.UseVisualStyleBackColor = true;
            // 
            // radioButtonManufacturer
            // 
            this.radioButtonManufacturer.AutoSize = true;
            this.radioButtonManufacturer.Location = new System.Drawing.Point(7, 49);
            this.radioButtonManufacturer.Name = "radioButtonManufacturer";
            this.radioButtonManufacturer.Size = new System.Drawing.Size(129, 19);
            this.radioButtonManufacturer.TabIndex = 1;
            this.radioButtonManufacturer.TabStop = true;
            this.radioButtonManufacturer.Text = "по производителю";
            this.radioButtonManufacturer.UseVisualStyleBackColor = true;
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Location = new System.Drawing.Point(7, 23);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(98, 19);
            this.radioButtonName.TabIndex = 0;
            this.radioButtonName.TabStop = true;
            this.radioButtonName.Text = "По названию";
            this.radioButtonName.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonNewDevice
            // 
            this.buttonNewDevice.Location = new System.Drawing.Point(16, 285);
            this.buttonNewDevice.Name = "buttonNewDevice";
            this.buttonNewDevice.Size = new System.Drawing.Size(168, 23);
            this.buttonNewDevice.TabIndex = 6;
            this.buttonNewDevice.Text = "Создать прибор";
            this.buttonNewDevice.UseVisualStyleBackColor = true;
            this.buttonNewDevice.Click += new System.EventHandler(this.buttonNewDevice_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxPrice.Location = new System.Drawing.Point(16, 246);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(168, 23);
            this.textBoxPrice.TabIndex = 5;
            this.textBoxPrice.Text = "Введите стоимость прибора";
            // 
            // textBoxAccuracy
            // 
            this.textBoxAccuracy.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxAccuracy.Location = new System.Drawing.Point(16, 202);
            this.textBoxAccuracy.Name = "textBoxAccuracy";
            this.textBoxAccuracy.Size = new System.Drawing.Size(168, 23);
            this.textBoxAccuracy.TabIndex = 4;
            this.textBoxAccuracy.Text = "Введите точность прибора";
            // 
            // textBoxManufacturer
            // 
            this.textBoxManufacturer.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxManufacturer.Location = new System.Drawing.Point(16, 155);
            this.textBoxManufacturer.Name = "textBoxManufacturer";
            this.textBoxManufacturer.Size = new System.Drawing.Size(168, 23);
            this.textBoxManufacturer.TabIndex = 3;
            this.textBoxManufacturer.Text = "Введите производителя";
            // 
            // textBoxType
            // 
            this.textBoxType.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxType.Location = new System.Drawing.Point(16, 107);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(168, 23);
            this.textBoxType.TabIndex = 2;
            this.textBoxType.Text = "Введите тип прибора";
            // 
            // textBoxName
            // 
            this.textBoxName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxName.Location = new System.Drawing.Point(16, 59);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(168, 23);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Text = "Введите название прибора";
            // 
            // textBoxKey
            // 
            this.textBoxKey.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxKey.Location = new System.Drawing.Point(16, 13);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(168, 23);
            this.textBoxKey.TabIndex = 0;
            this.textBoxKey.Text = "Введите ключ";
            this.textBoxKey.TextChanged += new System.EventHandler(this.textBoxKey_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 551);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button buttonNewDevice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxAccuracy;
        private System.Windows.Forms.TextBox textBoxManufacturer;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonPrice;
        private System.Windows.Forms.RadioButton radioButtonAccuracy;
        private System.Windows.Forms.RadioButton radioButtonType;
        private System.Windows.Forms.RadioButton radioButtonManufacturer;
        private System.Windows.Forms.RadioButton radioButtonName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button buttonBack;
    }
}

