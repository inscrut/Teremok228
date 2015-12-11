namespace Teremok228
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1_type = new System.Windows.Forms.ComboBox();
            this.comboBox2_items = new System.Windows.Forms.ComboBox();
            this.filters = new System.Windows.Forms.Button();
            this.button1_cansel = new System.Windows.Forms.Button();
            this.button1_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(138, 218);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(147, 212);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(457, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "SOULS:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(415, 39);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(197, 190);
            this.textBox2.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Teremok228.Properties.Resources.kirkorov;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(415, 235);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(212, 209);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Teremok228.Properties.Resources._109820381_5_nR;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 418);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1_type
            // 
            this.comboBox1_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1_type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1_type.FormattingEnabled = true;
            this.comboBox1_type.Items.AddRange(new object[] {
            "Все, кроме",
            "Только"});
            this.comboBox1_type.Location = new System.Drawing.Point(12, 12);
            this.comboBox1_type.Name = "comboBox1_type";
            this.comboBox1_type.Size = new System.Drawing.Size(121, 21);
            this.comboBox1_type.TabIndex = 8;
            this.comboBox1_type.SelectedIndexChanged += new System.EventHandler(this.comboBox1_type_SelectedIndexChanged);
            // 
            // comboBox2_items
            // 
            this.comboBox2_items.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2_items.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox2_items.FormattingEnabled = true;
            this.comboBox2_items.Location = new System.Drawing.Point(138, 12);
            this.comboBox2_items.Name = "comboBox2_items";
            this.comboBox2_items.Size = new System.Drawing.Size(121, 21);
            this.comboBox2_items.TabIndex = 9;
            this.comboBox2_items.SelectedIndexChanged += new System.EventHandler(this.comboBox2_items_SelectedIndexChanged);
            // 
            // filters
            // 
            this.filters.Location = new System.Drawing.Point(288, 12);
            this.filters.Name = "filters";
            this.filters.Size = new System.Drawing.Size(121, 48);
            this.filters.TabIndex = 10;
            this.filters.Text = "Фильтруем";
            this.filters.UseVisualStyleBackColor = true;
            this.filters.Click += new System.EventHandler(this.filters_Click);
            // 
            // button1_cansel
            // 
            this.button1_cansel.Location = new System.Drawing.Point(333, 67);
            this.button1_cansel.Name = "button1_cansel";
            this.button1_cansel.Size = new System.Drawing.Size(75, 23);
            this.button1_cansel.TabIndex = 11;
            this.button1_cansel.Text = "Отменить";
            this.button1_cansel.UseVisualStyleBackColor = true;
            this.button1_cansel.Click += new System.EventHandler(this.button1_cansel_Click);
            // 
            // button1_add
            // 
            this.button1_add.Location = new System.Drawing.Point(12, 40);
            this.button1_add.Name = "button1_add";
            this.button1_add.Size = new System.Drawing.Size(75, 23);
            this.button1_add.TabIndex = 12;
            this.button1_add.Text = "add";
            this.button1_add.UseVisualStyleBackColor = true;
            this.button1_add.Click += new System.EventHandler(this.button1_add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.button1_add);
            this.Controls.Add(this.button1_cansel);
            this.Controls.Add(this.filters);
            this.Controls.Add(this.comboBox2_items);
            this.Controls.Add(this.comboBox1_type);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "TEREMOK 228";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1_type;
        private System.Windows.Forms.ComboBox comboBox2_items;
        private System.Windows.Forms.Button filters;
        private System.Windows.Forms.Button button1_cansel;
        private System.Windows.Forms.Button button1_add;
    }
}

