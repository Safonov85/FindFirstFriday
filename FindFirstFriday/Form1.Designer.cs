namespace FindFirstFriday
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
            this.FindFirstFrLabel = new System.Windows.Forms.Label();
            this.RegularFindListBox = new System.Windows.Forms.ListBox();
            this.LINQlistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // FindFirstFrLabel
            // 
            this.FindFirstFrLabel.AutoSize = true;
            this.FindFirstFrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindFirstFrLabel.Location = new System.Drawing.Point(109, 43);
            this.FindFirstFrLabel.Name = "FindFirstFrLabel";
            this.FindFirstFrLabel.Size = new System.Drawing.Size(438, 37);
            this.FindFirstFrLabel.TabIndex = 0;
            this.FindFirstFrLabel.Text = "Find First Friday of the month";
            // 
            // RegularFindListBox
            // 
            this.RegularFindListBox.FormattingEnabled = true;
            this.RegularFindListBox.ItemHeight = 20;
            this.RegularFindListBox.Location = new System.Drawing.Point(56, 168);
            this.RegularFindListBox.Name = "RegularFindListBox";
            this.RegularFindListBox.Size = new System.Drawing.Size(181, 304);
            this.RegularFindListBox.TabIndex = 1;
            // 
            // LINQlistBox
            // 
            this.LINQlistBox.FormattingEnabled = true;
            this.LINQlistBox.ItemHeight = 20;
            this.LINQlistBox.Location = new System.Drawing.Point(401, 168);
            this.LINQlistBox.Name = "LINQlistBox";
            this.LINQlistBox.Size = new System.Drawing.Size(181, 304);
            this.LINQlistBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 674);
            this.Controls.Add(this.LINQlistBox);
            this.Controls.Add(this.RegularFindListBox);
            this.Controls.Add(this.FindFirstFrLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FindFirstFrLabel;
        private System.Windows.Forms.ListBox RegularFindListBox;
        private System.Windows.Forms.ListBox LINQlistBox;
    }
}

