namespace SimpleGUI_Cwebp
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnConvert = new System.Windows.Forms.Button();
            this.textBoxFiles = new System.Windows.Forms.TextBox();
            this.lbOptions = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericQuality = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxResize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxWidthOrHeight = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabelOpenFiles = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuality)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvert.Location = new System.Drawing.Point(11, 268);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(620, 40);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Start Conversion";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // textBoxFiles
            // 
            this.textBoxFiles.AllowDrop = true;
            this.textBoxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFiles.Location = new System.Drawing.Point(11, 81);
            this.textBoxFiles.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFiles.Multiline = true;
            this.textBoxFiles.Name = "textBoxFiles";
            this.textBoxFiles.Size = new System.Drawing.Size(620, 119);
            this.textBoxFiles.TabIndex = 1;
            // 
            // lbOptions
            // 
            this.lbOptions.AutoSize = true;
            this.lbOptions.Location = new System.Drawing.Point(8, 32);
            this.lbOptions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOptions.Name = "lbOptions";
            this.lbOptions.Size = new System.Drawing.Size(66, 17);
            this.lbOptions.TabIndex = 2;
            this.lbOptions.Text = "Options: ...\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Files to Convert - Click link on the right to add Files";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quality:";
            // 
            // numericQuality
            // 
            this.numericQuality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericQuality.Location = new System.Drawing.Point(15, 232);
            this.numericQuality.Name = "numericQuality";
            this.numericQuality.Size = new System.Drawing.Size(70, 24);
            this.numericQuality.TabIndex = 5;
            this.numericQuality.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resize - insert a value to resize images and keep aspect ratio";
            // 
            // textBoxResize
            // 
            this.textBoxResize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResize.Location = new System.Drawing.Point(396, 236);
            this.textBoxResize.Name = "textBoxResize";
            this.textBoxResize.Size = new System.Drawing.Size(70, 24);
            this.textBoxResize.TabIndex = 7;
            this.textBoxResize.TextChanged += new System.EventHandler(this.textBoxResize_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "px";
            // 
            // comboBoxWidthOrHeight
            // 
            this.comboBoxWidthOrHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxWidthOrHeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWidthOrHeight.Enabled = false;
            this.comboBoxWidthOrHeight.FormattingEnabled = true;
            this.comboBoxWidthOrHeight.Items.AddRange(new object[] {
            "Width",
            "Height"});
            this.comboBoxWidthOrHeight.Location = new System.Drawing.Point(510, 236);
            this.comboBoxWidthOrHeight.Name = "comboBoxWidthOrHeight";
            this.comboBoxWidthOrHeight.Size = new System.Drawing.Size(121, 25);
            this.comboBoxWidthOrHeight.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(645, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // linkLabelOpenFiles
            // 
            this.linkLabelOpenFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelOpenFiles.AutoSize = true;
            this.linkLabelOpenFiles.Location = new System.Drawing.Point(556, 60);
            this.linkLabelOpenFiles.Name = "linkLabelOpenFiles";
            this.linkLabelOpenFiles.Size = new System.Drawing.Size(75, 17);
            this.linkLabelOpenFiles.TabIndex = 11;
            this.linkLabelOpenFiles.TabStop = true;
            this.linkLabelOpenFiles.Text = "Add Images";
            this.linkLabelOpenFiles.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelOpenFiles_LinkClicked);
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 318);
            this.Controls.Add(this.linkLabelOpenFiles);
            this.Controls.Add(this.comboBoxWidthOrHeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxResize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericQuality);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbOptions);
            this.Controls.Add(this.textBoxFiles);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Noto Sans", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(661, 357);
            this.Name = "FormMain";
            this.Text = "SimpleGUI for cwebp";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.numericQuality)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox textBoxFiles;
        private System.Windows.Forms.Label lbOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericQuality;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxResize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxWidthOrHeight;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabelOpenFiles;
    }
}

