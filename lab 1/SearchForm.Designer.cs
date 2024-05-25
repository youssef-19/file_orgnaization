namespace lab_1
{
    partial class SearchForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SearchIDtextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.displayFNtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FileSizeLabel = new System.Windows.Forms.Label();
            this.NumOfRecLabel = new System.Windows.Forms.Label();
            this.FileLabel = new System.Windows.Forms.Label();
            this.RecLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SearchIDtextBox
            // 
            this.SearchIDtextBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchIDtextBox.Location = new System.Drawing.Point(161, 87);
            this.SearchIDtextBox.Name = "SearchIDtextBox";
            this.SearchIDtextBox.Size = new System.Drawing.Size(394, 35);
            this.SearchIDtextBox.TabIndex = 1;
            this.SearchIDtextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(653, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // displayFNtextBox
            // 
            this.displayFNtextBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.displayFNtextBox.Location = new System.Drawing.Point(285, 35);
            this.displayFNtextBox.Name = "displayFNtextBox";
            this.displayFNtextBox.Size = new System.Drawing.Size(270, 38);
            this.displayFNtextBox.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "File Name";
            // 
            // FileSizeLabel
            // 
            this.FileSizeLabel.AutoSize = true;
            this.FileSizeLabel.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileSizeLabel.Location = new System.Drawing.Point(464, 133);
            this.FileSizeLabel.Name = "FileSizeLabel";
            this.FileSizeLabel.Size = new System.Drawing.Size(0, 25);
            this.FileSizeLabel.TabIndex = 27;
            // 
            // NumOfRecLabel
            // 
            this.NumOfRecLabel.AutoSize = true;
            this.NumOfRecLabel.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfRecLabel.Location = new System.Drawing.Point(276, 133);
            this.NumOfRecLabel.Name = "NumOfRecLabel";
            this.NumOfRecLabel.Size = new System.Drawing.Size(0, 25);
            this.NumOfRecLabel.TabIndex = 26;
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileLabel.Location = new System.Drawing.Point(345, 133);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(84, 25);
            this.FileLabel.TabIndex = 25;
            this.FileLabel.Text = "File Size";
            // 
            // RecLabel
            // 
            this.RecLabel.AutoSize = true;
            this.RecLabel.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecLabel.Location = new System.Drawing.Point(156, 133);
            this.RecLabel.Name = "RecLabel";
            this.RecLabel.Size = new System.Drawing.Size(112, 25);
            this.RecLabel.TabIndex = 24;
            this.RecLabel.Text = "# Recordes";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(653, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 38);
            this.button2.TabIndex = 28;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(861, 208);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FileSizeLabel);
            this.Controls.Add(this.NumOfRecLabel);
            this.Controls.Add(this.FileLabel);
            this.Controls.Add(this.RecLabel);
            this.Controls.Add(this.displayFNtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchIDtextBox);
            this.Controls.Add(this.label1);
            this.Name = "SearchForm";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchIDtextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox displayFNtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FileSizeLabel;
        private System.Windows.Forms.Label NumOfRecLabel;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.Label RecLabel;
        private System.Windows.Forms.Button button2;
    }
}