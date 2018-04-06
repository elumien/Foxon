namespace Loxon
{
    partial class MagicFox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MagicFox));
            this.InputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.MagicButton = new System.Windows.Forms.Button();
            this.OutputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.RainbowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputRichTextBox
            // 
            this.InputRichTextBox.Location = new System.Drawing.Point(21, 18);
            this.InputRichTextBox.Name = "InputRichTextBox";
            this.InputRichTextBox.Size = new System.Drawing.Size(184, 386);
            this.InputRichTextBox.TabIndex = 0;
            this.InputRichTextBox.Text = "${var1}\n${var2}\n${var3}";
            // 
            // MagicButton
            // 
            this.MagicButton.BackColor = System.Drawing.Color.Indigo;
            this.MagicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MagicButton.ForeColor = System.Drawing.Color.Yellow;
            this.MagicButton.Location = new System.Drawing.Point(225, 179);
            this.MagicButton.Name = "MagicButton";
            this.MagicButton.Size = new System.Drawing.Size(75, 23);
            this.MagicButton.TabIndex = 1;
            this.MagicButton.Text = "Magic";
            this.MagicButton.UseVisualStyleBackColor = false;
            this.MagicButton.Click += new System.EventHandler(this.MagicButton_Click);
            // 
            // OutputRichTextBox
            // 
            this.OutputRichTextBox.Location = new System.Drawing.Point(320, 119);
            this.OutputRichTextBox.Name = "OutputRichTextBox";
            this.OutputRichTextBox.Size = new System.Drawing.Size(368, 184);
            this.OutputRichTextBox.TabIndex = 2;
            this.OutputRichTextBox.Text = "";
            // 
            // RainbowButton
            // 
            this.RainbowButton.BackColor = System.Drawing.Color.Indigo;
            this.RainbowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RainbowButton.ForeColor = System.Drawing.Color.Yellow;
            this.RainbowButton.Location = new System.Drawing.Point(225, 214);
            this.RainbowButton.Name = "RainbowButton";
            this.RainbowButton.Size = new System.Drawing.Size(75, 23);
            this.RainbowButton.TabIndex = 3;
            this.RainbowButton.Text = "Rainbow";
            this.RainbowButton.UseVisualStyleBackColor = false;
            this.RainbowButton.Click += new System.EventHandler(this.RainbowButton_Click);
            // 
            // MagicFox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(709, 423);
            this.Controls.Add(this.RainbowButton);
            this.Controls.Add(this.OutputRichTextBox);
            this.Controls.Add(this.MagicButton);
            this.Controls.Add(this.InputRichTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(725, 461);
            this.MinimumSize = new System.Drawing.Size(725, 461);
            this.Name = "MagicFox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MagicFox";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox InputRichTextBox;
        private System.Windows.Forms.Button MagicButton;
        private System.Windows.Forms.RichTextBox OutputRichTextBox;
        private System.Windows.Forms.Button RainbowButton;
    }
}

