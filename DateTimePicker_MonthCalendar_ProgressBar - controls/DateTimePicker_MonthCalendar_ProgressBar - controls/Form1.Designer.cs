namespace DateTimePicker_MonthCalendar_ProgressBar___controls
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
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBox1_DateTimePicker = new System.Windows.Forms.TextBox();
            this.textBox2_MonthCalendar = new System.Windows.Forms.TextBox();
            this.progressBar1_without_timer = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar2_with_Timer = new System.Windows.Forms.ProgressBar();
            this.timer1_for_ProgressBar2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(57, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(366, 23);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // textBox1_DateTimePicker
            // 
            this.textBox1_DateTimePicker.Location = new System.Drawing.Point(57, 87);
            this.textBox1_DateTimePicker.Name = "textBox1_DateTimePicker";
            this.textBox1_DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.textBox1_DateTimePicker.TabIndex = 2;
            // 
            // textBox2_MonthCalendar
            // 
            this.textBox2_MonthCalendar.Location = new System.Drawing.Point(366, 211);
            this.textBox2_MonthCalendar.Name = "textBox2_MonthCalendar";
            this.textBox2_MonthCalendar.Size = new System.Drawing.Size(227, 20);
            this.textBox2_MonthCalendar.TabIndex = 3;
            // 
            // progressBar1_without_timer
            // 
            this.progressBar1_without_timer.Location = new System.Drawing.Point(57, 161);
            this.progressBar1_without_timer.Maximum = 200;
            this.progressBar1_without_timer.Name = "progressBar1_without_timer";
            this.progressBar1_without_timer.Size = new System.Drawing.Size(100, 23);
            this.progressBar1_without_timer.TabIndex = 4;
            this.progressBar1_without_timer.Click += new System.EventHandler(this.progressBar1_without_timer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ProgressBar without Timer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ProgressBar With Timer";
            // 
            // progressBar2_with_Timer
            // 
            this.progressBar2_with_Timer.Location = new System.Drawing.Point(57, 234);
            this.progressBar2_with_Timer.Name = "progressBar2_with_Timer";
            this.progressBar2_with_Timer.Size = new System.Drawing.Size(100, 23);
            this.progressBar2_with_Timer.TabIndex = 7;
            this.progressBar2_with_Timer.Click += new System.EventHandler(this.progressBar2_with_Timer_Click);
            // 
            // timer1_for_ProgressBar2
            // 
            this.timer1_for_ProgressBar2.Interval = 1000;
            this.timer1_for_ProgressBar2.Tick += new System.EventHandler(this.timer1_for_ProgressBar2_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Click To Start Progress Bar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 321);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar2_with_Timer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1_without_timer);
            this.Controls.Add(this.textBox2_MonthCalendar);
            this.Controls.Add(this.textBox1_DateTimePicker);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBox1_DateTimePicker;
        private System.Windows.Forms.TextBox textBox2_MonthCalendar;
        private System.Windows.Forms.ProgressBar progressBar1_without_timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar2_with_Timer;
        private System.Windows.Forms.Timer timer1_for_ProgressBar2;
        private System.Windows.Forms.Button button1;
    }
}

