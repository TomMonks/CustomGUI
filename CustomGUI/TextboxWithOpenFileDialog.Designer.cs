namespace CustomGUI
{
    partial class TextboxWithOpenFileDialog
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextboxWithOpenFileDialog));
            this.btOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.recentFileTextBox1 = new CustomGUI.RecentFileTextBox();
            this.SuspendLayout();
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(0, 0);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 23);
            this.btOpen.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(344, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // recentFileTextBox1
            // 
            this.recentFileTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recentFileTextBox1.Location = new System.Drawing.Point(3, 5);
            this.recentFileTextBox1.Name = "recentFileTextBox1";
            this.recentFileTextBox1.RecentFiles = ((System.Collections.Generic.List<string>)(resources.GetObject("recentFileTextBox1.RecentFiles")));
            this.recentFileTextBox1.Size = new System.Drawing.Size(336, 20);
            this.recentFileTextBox1.TabIndex = 0;
            // 
            // TextboxWithOpenFileDialog
            // 
            this.Controls.Add(this.button1);
            this.Controls.Add(this.recentFileTextBox1);
            this.Name = "TextboxWithOpenFileDialog";
            this.Size = new System.Drawing.Size(391, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private RecentFileTextBox recentFileTextBox1;
        private System.Windows.Forms.Button button1;
    }
}
