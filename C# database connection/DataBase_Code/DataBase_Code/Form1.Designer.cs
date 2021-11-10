namespace DataBase_Code
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
            this.IDlabel1 = new System.Windows.Forms.Label();
            this.Namelabel2 = new System.Windows.Forms.Label();
            this.Addresslabel3 = new System.Windows.Forms.Label();
            this.Numberlabel4 = new System.Windows.Forms.Label();
            this.IdTextbox = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.AddressTextbox = new System.Windows.Forms.TextBox();
            this.NumberTextbox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.TabledataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TabledataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // IDlabel1
            // 
            this.IDlabel1.AutoSize = true;
            this.IDlabel1.Location = new System.Drawing.Point(87, 58);
            this.IDlabel1.Name = "IDlabel1";
            this.IDlabel1.Size = new System.Drawing.Size(16, 13);
            this.IDlabel1.TabIndex = 0;
            this.IDlabel1.Text = "Id";
            // 
            // Namelabel2
            // 
            this.Namelabel2.AutoSize = true;
            this.Namelabel2.Location = new System.Drawing.Point(87, 89);
            this.Namelabel2.Name = "Namelabel2";
            this.Namelabel2.Size = new System.Drawing.Size(35, 13);
            this.Namelabel2.TabIndex = 1;
            this.Namelabel2.Text = "Name";
            // 
            // Addresslabel3
            // 
            this.Addresslabel3.AutoSize = true;
            this.Addresslabel3.Location = new System.Drawing.Point(87, 123);
            this.Addresslabel3.Name = "Addresslabel3";
            this.Addresslabel3.Size = new System.Drawing.Size(45, 13);
            this.Addresslabel3.TabIndex = 2;
            this.Addresslabel3.Text = "Address";
            // 
            // Numberlabel4
            // 
            this.Numberlabel4.AutoSize = true;
            this.Numberlabel4.Location = new System.Drawing.Point(90, 154);
            this.Numberlabel4.Name = "Numberlabel4";
            this.Numberlabel4.Size = new System.Drawing.Size(44, 13);
            this.Numberlabel4.TabIndex = 3;
            this.Numberlabel4.Text = "Number";
            // 
            // IdTextbox
            // 
            this.IdTextbox.Location = new System.Drawing.Point(158, 58);
            this.IdTextbox.Name = "IdTextbox";
            this.IdTextbox.Size = new System.Drawing.Size(100, 20);
            this.IdTextbox.TabIndex = 4;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(158, 89);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(100, 20);
            this.NameTextbox.TabIndex = 5;
            // 
            // AddressTextbox
            // 
            this.AddressTextbox.Location = new System.Drawing.Point(158, 123);
            this.AddressTextbox.Name = "AddressTextbox";
            this.AddressTextbox.Size = new System.Drawing.Size(100, 20);
            this.AddressTextbox.TabIndex = 6;
            // 
            // NumberTextbox
            // 
            this.NumberTextbox.Location = new System.Drawing.Point(158, 154);
            this.NumberTextbox.Name = "NumberTextbox";
            this.NumberTextbox.Size = new System.Drawing.Size(100, 20);
            this.NumberTextbox.TabIndex = 7;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(75, 214);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(297, 214);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 9;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(183, 214);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(432, 214);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(75, 23);
            this.ViewButton.TabIndex = 11;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(246, 274);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // TabledataGridView
            // 
            this.TabledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabledataGridView.Location = new System.Drawing.Point(359, 24);
            this.TabledataGridView.Name = "TabledataGridView";
            this.TabledataGridView.Size = new System.Drawing.Size(240, 150);
            this.TabledataGridView.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 344);
            this.Controls.Add(this.TabledataGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.NumberTextbox);
            this.Controls.Add(this.AddressTextbox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.IdTextbox);
            this.Controls.Add(this.Numberlabel4);
            this.Controls.Add(this.Addresslabel3);
            this.Controls.Add(this.Namelabel2);
            this.Controls.Add(this.IDlabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TabledataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDlabel1;
        private System.Windows.Forms.Label Namelabel2;
        private System.Windows.Forms.Label Addresslabel3;
        private System.Windows.Forms.Label Numberlabel4;
        private System.Windows.Forms.TextBox IdTextbox;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox AddressTextbox;
        private System.Windows.Forms.TextBox NumberTextbox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView TabledataGridView;
    }
}

