namespace TestGUIComponents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.recentFileTextBox1 = new CustomGUI.RecentFileTextBox();
            this.extendedTabControl1 = new CustomGUI.ExtendedTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.extendedTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // recentFileTextBox1
            // 
            this.recentFileTextBox1.Location = new System.Drawing.Point(12, 379);
            this.recentFileTextBox1.Name = "recentFileTextBox1";
            this.recentFileTextBox1.RecentFiles = ((System.Collections.Generic.List<string>)(resources.GetObject("recentFileTextBox1.RecentFiles")));
            this.recentFileTextBox1.Size = new System.Drawing.Size(475, 20);
            this.recentFileTextBox1.TabIndex = 1;
            // 
            // extendedTabControl1
            // 
            this.extendedTabControl1.Controls.Add(this.tabPage1);
            this.extendedTabControl1.Controls.Add(this.tabPage2);
            this.extendedTabControl1.Location = new System.Drawing.Point(12, 12);
            this.extendedTabControl1.Name = "extendedTabControl1";
            this.extendedTabControl1.SelectedIndex = 0;
            this.extendedTabControl1.Size = new System.Drawing.Size(479, 361);
            this.extendedTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(471, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(471, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 424);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.recentFileTextBox1);
            this.Controls.Add(this.extendedTabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.extendedTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomGUI.ExtendedTabControl extendedTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private CustomGUI.RecentFileTextBox recentFileTextBox1;
        private System.Windows.Forms.Button button1;
    }
}

