namespace Radio_CheckBox_ListBox_ComboBox___Basic
{
    partial class Form1
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
            this.radioButton_RED = new System.Windows.Forms.RadioButton();
            this.radioButton_PURPLE = new System.Windows.Forms.RadioButton();
            this.radioButton_YELLOW = new System.Windows.Forms.RadioButton();
            this.checkBox_NUM1 = new System.Windows.Forms.CheckBox();
            this.checkBox_NUM2 = new System.Windows.Forms.CheckBox();
            this.checkBox_NUM3 = new System.Windows.Forms.CheckBox();
            this.button_SUBMIT = new System.Windows.Forms.Button();
            this.comboBox1_INPUT = new System.Windows.Forms.ComboBox();
            this.comboBox2_OUTPUT = new System.Windows.Forms.ComboBox();
            this.listBox1_OUTPUT = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // radioButton_RED
            // 
            this.radioButton_RED.AutoSize = true;
            this.radioButton_RED.Location = new System.Drawing.Point(93, 69);
            this.radioButton_RED.Name = "radioButton_RED";
            this.radioButton_RED.Size = new System.Drawing.Size(72, 17);
            this.radioButton_RED.TabIndex = 0;
            this.radioButton_RED.TabStop = true;
            this.radioButton_RED.Text = "Color Red";
            this.radioButton_RED.UseVisualStyleBackColor = true;
            this.radioButton_RED.CheckedChanged += new System.EventHandler(this.radioButton_RED_CheckedChanged);
            // 
            // radioButton_PURPLE
            // 
            this.radioButton_PURPLE.AutoSize = true;
            this.radioButton_PURPLE.Location = new System.Drawing.Point(93, 113);
            this.radioButton_PURPLE.Name = "radioButton_PURPLE";
            this.radioButton_PURPLE.Size = new System.Drawing.Size(82, 17);
            this.radioButton_PURPLE.TabIndex = 1;
            this.radioButton_PURPLE.TabStop = true;
            this.radioButton_PURPLE.Text = "Color Purple";
            this.radioButton_PURPLE.UseVisualStyleBackColor = true;
            this.radioButton_PURPLE.CheckedChanged += new System.EventHandler(this.radioButton_PURPLE_CheckedChanged);
            // 
            // radioButton_YELLOW
            // 
            this.radioButton_YELLOW.AutoSize = true;
            this.radioButton_YELLOW.Location = new System.Drawing.Point(93, 159);
            this.radioButton_YELLOW.Name = "radioButton_YELLOW";
            this.radioButton_YELLOW.Size = new System.Drawing.Size(83, 17);
            this.radioButton_YELLOW.TabIndex = 2;
            this.radioButton_YELLOW.TabStop = true;
            this.radioButton_YELLOW.Text = "Color Yellow";
            this.radioButton_YELLOW.UseVisualStyleBackColor = true;
            this.radioButton_YELLOW.CheckedChanged += new System.EventHandler(this.radioButton_YELLOW_CheckedChanged);
            // 
            // checkBox_NUM1
            // 
            this.checkBox_NUM1.AutoSize = true;
            this.checkBox_NUM1.Location = new System.Drawing.Point(284, 69);
            this.checkBox_NUM1.Name = "checkBox_NUM1";
            this.checkBox_NUM1.Size = new System.Drawing.Size(72, 17);
            this.checkBox_NUM1.TabIndex = 3;
            this.checkBox_NUM1.Text = "Number 1";
            this.checkBox_NUM1.UseVisualStyleBackColor = true;
            // 
            // checkBox_NUM2
            // 
            this.checkBox_NUM2.AutoSize = true;
            this.checkBox_NUM2.Location = new System.Drawing.Point(284, 113);
            this.checkBox_NUM2.Name = "checkBox_NUM2";
            this.checkBox_NUM2.Size = new System.Drawing.Size(72, 17);
            this.checkBox_NUM2.TabIndex = 4;
            this.checkBox_NUM2.Text = "Number 2";
            this.checkBox_NUM2.UseVisualStyleBackColor = true;
            // 
            // checkBox_NUM3
            // 
            this.checkBox_NUM3.AutoSize = true;
            this.checkBox_NUM3.Location = new System.Drawing.Point(284, 159);
            this.checkBox_NUM3.Name = "checkBox_NUM3";
            this.checkBox_NUM3.Size = new System.Drawing.Size(72, 17);
            this.checkBox_NUM3.TabIndex = 5;
            this.checkBox_NUM3.Text = "Number 3";
            this.checkBox_NUM3.UseVisualStyleBackColor = true;
            // 
            // button_SUBMIT
            // 
            this.button_SUBMIT.Location = new System.Drawing.Point(158, 207);
            this.button_SUBMIT.Name = "button_SUBMIT";
            this.button_SUBMIT.Size = new System.Drawing.Size(156, 57);
            this.button_SUBMIT.TabIndex = 6;
            this.button_SUBMIT.Text = "Submit";
            this.button_SUBMIT.UseVisualStyleBackColor = true;
            this.button_SUBMIT.Click += new System.EventHandler(this.button_SUBMIT_Click);
            // 
            // comboBox1_INPUT
            // 
            this.comboBox1_INPUT.FormattingEnabled = true;
            this.comboBox1_INPUT.Items.AddRange(new object[] {
            "Numbers",
            "Letters"});
            this.comboBox1_INPUT.Location = new System.Drawing.Point(438, 69);
            this.comboBox1_INPUT.Name = "comboBox1_INPUT";
            this.comboBox1_INPUT.Size = new System.Drawing.Size(121, 21);
            this.comboBox1_INPUT.TabIndex = 7;
            this.comboBox1_INPUT.SelectedIndexChanged += new System.EventHandler(this.comboBox1_INPUT_SelectedIndexChanged);
            // 
            // comboBox2_OUTPUT
            // 
            this.comboBox2_OUTPUT.FormattingEnabled = true;
            this.comboBox2_OUTPUT.Location = new System.Drawing.Point(438, 113);
            this.comboBox2_OUTPUT.Name = "comboBox2_OUTPUT";
            this.comboBox2_OUTPUT.Size = new System.Drawing.Size(121, 21);
            this.comboBox2_OUTPUT.TabIndex = 8;
            // 
            // listBox1_OUTPUT
            // 
            this.listBox1_OUTPUT.FormattingEnabled = true;
            this.listBox1_OUTPUT.Location = new System.Drawing.Point(439, 159);
            this.listBox1_OUTPUT.Name = "listBox1_OUTPUT";
            this.listBox1_OUTPUT.Size = new System.Drawing.Size(120, 95);
            this.listBox1_OUTPUT.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 349);
            this.Controls.Add(this.listBox1_OUTPUT);
            this.Controls.Add(this.comboBox2_OUTPUT);
            this.Controls.Add(this.comboBox1_INPUT);
            this.Controls.Add(this.button_SUBMIT);
            this.Controls.Add(this.checkBox_NUM3);
            this.Controls.Add(this.checkBox_NUM2);
            this.Controls.Add(this.checkBox_NUM1);
            this.Controls.Add(this.radioButton_YELLOW);
            this.Controls.Add(this.radioButton_PURPLE);
            this.Controls.Add(this.radioButton_RED);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_RED;
        private System.Windows.Forms.RadioButton radioButton_PURPLE;
        private System.Windows.Forms.RadioButton radioButton_YELLOW;
        private System.Windows.Forms.CheckBox checkBox_NUM1;
        private System.Windows.Forms.CheckBox checkBox_NUM2;
        private System.Windows.Forms.CheckBox checkBox_NUM3;
        private System.Windows.Forms.Button button_SUBMIT;
        private System.Windows.Forms.ComboBox comboBox1_INPUT;
        private System.Windows.Forms.ComboBox comboBox2_OUTPUT;
        private System.Windows.Forms.ListBox listBox1_OUTPUT;
    }
}

