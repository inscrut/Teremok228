namespace Teremok228
{
    partial class NewGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGen));
            this.comboBox1_type = new System.Windows.Forms.ComboBox();
            this.comboBox2_sex = new System.Windows.Forms.ComboBox();
            this.textBox3_date = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1_type
            // 
            this.comboBox1_type.FormattingEnabled = true;
            this.comboBox1_type.Items.AddRange(new object[] {
            "Gorilla",
            "Bear",
            "Dwarf"});
            this.comboBox1_type.Location = new System.Drawing.Point(13, 13);
            this.comboBox1_type.Name = "comboBox1_type";
            this.comboBox1_type.Size = new System.Drawing.Size(121, 21);
            this.comboBox1_type.TabIndex = 0;
            // 
            // comboBox2_sex
            // 
            this.comboBox2_sex.FormattingEnabled = true;
            this.comboBox2_sex.Items.AddRange(new object[] {
            "Она",
            "Он"});
            this.comboBox2_sex.Location = new System.Drawing.Point(13, 41);
            this.comboBox2_sex.Name = "comboBox2_sex";
            this.comboBox2_sex.Size = new System.Drawing.Size(121, 21);
            this.comboBox2_sex.TabIndex = 1;
            // 
            // textBox3_date
            // 
            this.textBox3_date.Location = new System.Drawing.Point(13, 68);
            this.textBox3_date.Name = "textBox3_date";
            this.textBox3_date.Size = new System.Drawing.Size(121, 20);
            this.textBox3_date.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Тип";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Пол";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Дата рождения";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 66);
            this.button1.TabIndex = 13;
            this.button1.Text = "BORN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 172);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3_date);
            this.Controls.Add(this.comboBox2_sex);
            this.Controls.Add(this.comboBox1_type);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewGen";
            this.Text = "Добавить новое существо";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1_type;
        private System.Windows.Forms.ComboBox comboBox2_sex;
        private System.Windows.Forms.TextBox textBox3_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}