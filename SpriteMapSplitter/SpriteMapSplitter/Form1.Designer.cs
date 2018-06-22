namespace SpriteMapSplitter
{
    partial class MainForm
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
            this.TopSection = new System.Windows.Forms.GroupBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.OutputPrefixLabel = new System.Windows.Forms.Label();
            this.OutputPrefixTextBox = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.HeightNumber = new System.Windows.Forms.NumericUpDown();
            this.SplitImageButton = new System.Windows.Forms.Button();
            this.OriginalImageGroupBox = new System.Windows.Forms.GroupBox();
            this.OriginalPictureBox = new System.Windows.Forms.PictureBox();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.WidthNumber = new System.Windows.Forms.NumericUpDown();
            this.BrowseForOutputFolder = new System.Windows.Forms.Button();
            this.OutputPathLabel = new System.Windows.Forms.Label();
            this.OutputPathTextBox = new System.Windows.Forms.TextBox();
            this.BrowseForOriginalFileButton = new System.Windows.Forms.Button();
            this.OutputFileLabel = new System.Windows.Forms.Label();
            this.OriginalFilePathTextBox = new System.Windows.Forms.TextBox();
            this.FolderBrowserDialogObject = new System.Windows.Forms.FolderBrowserDialog();
            this.OpenFileDialogObject = new System.Windows.Forms.OpenFileDialog();
            this.OutputGroupBox = new System.Windows.Forms.GroupBox();
            this.OutputPreviewGroupBox = new System.Windows.Forms.GroupBox();
            this.PreviewPictureBox = new System.Windows.Forms.PictureBox();
            this.OutputFileNamesTreeView = new System.Windows.Forms.TreeView();
            this.SplitProgressBar = new System.Windows.Forms.ProgressBar();
            this.CompletionAmountLabel = new System.Windows.Forms.Label();
            this.TopSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumber)).BeginInit();
            this.OriginalImageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumber)).BeginInit();
            this.OutputGroupBox.SuspendLayout();
            this.OutputPreviewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TopSection
            // 
            this.TopSection.Controls.Add(this.ResetButton);
            this.TopSection.Controls.Add(this.OutputPrefixLabel);
            this.TopSection.Controls.Add(this.OutputPrefixTextBox);
            this.TopSection.Controls.Add(this.HeightLabel);
            this.TopSection.Controls.Add(this.HeightNumber);
            this.TopSection.Controls.Add(this.SplitImageButton);
            this.TopSection.Controls.Add(this.OriginalImageGroupBox);
            this.TopSection.Controls.Add(this.WidthLabel);
            this.TopSection.Controls.Add(this.WidthNumber);
            this.TopSection.Controls.Add(this.BrowseForOutputFolder);
            this.TopSection.Controls.Add(this.OutputPathLabel);
            this.TopSection.Controls.Add(this.OutputPathTextBox);
            this.TopSection.Controls.Add(this.BrowseForOriginalFileButton);
            this.TopSection.Controls.Add(this.OutputFileLabel);
            this.TopSection.Controls.Add(this.OriginalFilePathTextBox);
            this.TopSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopSection.Location = new System.Drawing.Point(0, 0);
            this.TopSection.Name = "TopSection";
            this.TopSection.Size = new System.Drawing.Size(584, 175);
            this.TopSection.TabIndex = 0;
            this.TopSection.TabStop = false;
            this.TopSection.Text = "Tilemap settings";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(164, 146);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 15;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // OutputPrefixLabel
            // 
            this.OutputPrefixLabel.AutoSize = true;
            this.OutputPrefixLabel.Location = new System.Drawing.Point(12, 99);
            this.OutputPrefixLabel.Name = "OutputPrefixLabel";
            this.OutputPrefixLabel.Size = new System.Drawing.Size(71, 13);
            this.OutputPrefixLabel.TabIndex = 14;
            this.OutputPrefixLabel.Text = "Output Prefix:";
            // 
            // OutputPrefixTextBox
            // 
            this.OutputPrefixTextBox.Location = new System.Drawing.Point(85, 96);
            this.OutputPrefixTextBox.Name = "OutputPrefixTextBox";
            this.OutputPrefixTextBox.Size = new System.Drawing.Size(158, 20);
            this.OutputPrefixTextBox.TabIndex = 13;
            this.OutputPrefixTextBox.Text = "SplitImage";
            this.OutputPrefixTextBox.TextChanged += new System.EventHandler(this.OutputPrefixTextBox_TextChanged);
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(117, 124);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(41, 13);
            this.HeightLabel.TabIndex = 10;
            this.HeightLabel.Text = "Height:";
            // 
            // HeightNumber
            // 
            this.HeightNumber.Location = new System.Drawing.Point(164, 122);
            this.HeightNumber.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.HeightNumber.Name = "HeightNumber";
            this.HeightNumber.Size = new System.Drawing.Size(55, 20);
            this.HeightNumber.TabIndex = 8;
            this.HeightNumber.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // SplitImageButton
            // 
            this.SplitImageButton.Enabled = false;
            this.SplitImageButton.Location = new System.Drawing.Point(15, 146);
            this.SplitImageButton.Name = "SplitImageButton";
            this.SplitImageButton.Size = new System.Drawing.Size(143, 23);
            this.SplitImageButton.TabIndex = 12;
            this.SplitImageButton.Text = "Split Image";
            this.SplitImageButton.UseVisualStyleBackColor = true;
            this.SplitImageButton.Click += new System.EventHandler(this.SplitImageButton_Click);
            // 
            // OriginalImageGroupBox
            // 
            this.OriginalImageGroupBox.Controls.Add(this.OriginalPictureBox);
            this.OriginalImageGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.OriginalImageGroupBox.Location = new System.Drawing.Point(249, 16);
            this.OriginalImageGroupBox.Name = "OriginalImageGroupBox";
            this.OriginalImageGroupBox.Size = new System.Drawing.Size(332, 156);
            this.OriginalImageGroupBox.TabIndex = 11;
            this.OriginalImageGroupBox.TabStop = false;
            this.OriginalImageGroupBox.Text = "Original";
            // 
            // OriginalPictureBox
            // 
            this.OriginalPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OriginalPictureBox.Location = new System.Drawing.Point(3, 16);
            this.OriginalPictureBox.Name = "OriginalPictureBox";
            this.OriginalPictureBox.Size = new System.Drawing.Size(326, 137);
            this.OriginalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OriginalPictureBox.TabIndex = 0;
            this.OriginalPictureBox.TabStop = false;
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(12, 124);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(38, 13);
            this.WidthLabel.TabIndex = 9;
            this.WidthLabel.Text = "Width:";
            // 
            // WidthNumber
            // 
            this.WidthNumber.Location = new System.Drawing.Point(56, 122);
            this.WidthNumber.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.WidthNumber.Name = "WidthNumber";
            this.WidthNumber.Size = new System.Drawing.Size(55, 20);
            this.WidthNumber.TabIndex = 7;
            this.WidthNumber.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // BrowseForOutputFolder
            // 
            this.BrowseForOutputFolder.Location = new System.Drawing.Point(191, 70);
            this.BrowseForOutputFolder.Name = "BrowseForOutputFolder";
            this.BrowseForOutputFolder.Size = new System.Drawing.Size(52, 20);
            this.BrowseForOutputFolder.TabIndex = 6;
            this.BrowseForOutputFolder.Text = "Browse";
            this.BrowseForOutputFolder.UseVisualStyleBackColor = true;
            this.BrowseForOutputFolder.Click += new System.EventHandler(this.BrowseForOutputFolder_Click);
            // 
            // OutputPathLabel
            // 
            this.OutputPathLabel.AutoSize = true;
            this.OutputPathLabel.Location = new System.Drawing.Point(12, 54);
            this.OutputPathLabel.Name = "OutputPathLabel";
            this.OutputPathLabel.Size = new System.Drawing.Size(67, 13);
            this.OutputPathLabel.TabIndex = 5;
            this.OutputPathLabel.Text = "Output Path:";
            // 
            // OutputPathTextBox
            // 
            this.OutputPathTextBox.Location = new System.Drawing.Point(15, 70);
            this.OutputPathTextBox.Name = "OutputPathTextBox";
            this.OutputPathTextBox.Size = new System.Drawing.Size(170, 20);
            this.OutputPathTextBox.TabIndex = 4;
            // 
            // BrowseForOriginalFileButton
            // 
            this.BrowseForOriginalFileButton.Location = new System.Drawing.Point(191, 32);
            this.BrowseForOriginalFileButton.Name = "BrowseForOriginalFileButton";
            this.BrowseForOriginalFileButton.Size = new System.Drawing.Size(52, 20);
            this.BrowseForOriginalFileButton.TabIndex = 3;
            this.BrowseForOriginalFileButton.Text = "Browse";
            this.BrowseForOriginalFileButton.UseVisualStyleBackColor = true;
            this.BrowseForOriginalFileButton.Click += new System.EventHandler(this.BrowseForOriginalFileButton_Click);
            // 
            // OutputFileLabel
            // 
            this.OutputFileLabel.AutoSize = true;
            this.OutputFileLabel.Location = new System.Drawing.Point(12, 16);
            this.OutputFileLabel.Name = "OutputFileLabel";
            this.OutputFileLabel.Size = new System.Drawing.Size(64, 13);
            this.OutputFileLabel.TabIndex = 2;
            this.OutputFileLabel.Text = "Original File:";
            // 
            // OriginalFilePathTextBox
            // 
            this.OriginalFilePathTextBox.Location = new System.Drawing.Point(15, 32);
            this.OriginalFilePathTextBox.Name = "OriginalFilePathTextBox";
            this.OriginalFilePathTextBox.Size = new System.Drawing.Size(170, 20);
            this.OriginalFilePathTextBox.TabIndex = 1;
            // 
            // FolderBrowserDialogObject
            // 
            this.FolderBrowserDialogObject.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // OpenFileDialogObject
            // 
            this.OpenFileDialogObject.Filter = "Image file|*.png; *.jpg; *.jpeg; *.bmp";
            // 
            // OutputGroupBox
            // 
            this.OutputGroupBox.Controls.Add(this.OutputPreviewGroupBox);
            this.OutputGroupBox.Controls.Add(this.OutputFileNamesTreeView);
            this.OutputGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.OutputGroupBox.Location = new System.Drawing.Point(0, 175);
            this.OutputGroupBox.Name = "OutputGroupBox";
            this.OutputGroupBox.Size = new System.Drawing.Size(584, 186);
            this.OutputGroupBox.TabIndex = 1;
            this.OutputGroupBox.TabStop = false;
            this.OutputGroupBox.Text = "Output";
            // 
            // OutputPreviewGroupBox
            // 
            this.OutputPreviewGroupBox.Controls.Add(this.PreviewPictureBox);
            this.OutputPreviewGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.OutputPreviewGroupBox.Location = new System.Drawing.Point(249, 16);
            this.OutputPreviewGroupBox.Name = "OutputPreviewGroupBox";
            this.OutputPreviewGroupBox.Size = new System.Drawing.Size(332, 167);
            this.OutputPreviewGroupBox.TabIndex = 1;
            this.OutputPreviewGroupBox.TabStop = false;
            this.OutputPreviewGroupBox.Text = "Output Preview";
            // 
            // PreviewPictureBox
            // 
            this.PreviewPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewPictureBox.Location = new System.Drawing.Point(3, 16);
            this.PreviewPictureBox.Name = "PreviewPictureBox";
            this.PreviewPictureBox.Size = new System.Drawing.Size(326, 148);
            this.PreviewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PreviewPictureBox.TabIndex = 0;
            this.PreviewPictureBox.TabStop = false;
            // 
            // OutputFileNamesTreeView
            // 
            this.OutputFileNamesTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.OutputFileNamesTreeView.Location = new System.Drawing.Point(3, 16);
            this.OutputFileNamesTreeView.Name = "OutputFileNamesTreeView";
            this.OutputFileNamesTreeView.Size = new System.Drawing.Size(240, 167);
            this.OutputFileNamesTreeView.TabIndex = 0;
            this.OutputFileNamesTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.OutputFileNamesTreeView_NodeMouseClick);
            // 
            // SplitProgressBar
            // 
            this.SplitProgressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.SplitProgressBar.Location = new System.Drawing.Point(0, 361);
            this.SplitProgressBar.Name = "SplitProgressBar";
            this.SplitProgressBar.Size = new System.Drawing.Size(584, 23);
            this.SplitProgressBar.Step = 1;
            this.SplitProgressBar.TabIndex = 2;
            // 
            // CompletionAmountLabel
            // 
            this.CompletionAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompletionAmountLabel.AutoSize = true;
            this.CompletionAmountLabel.BackColor = System.Drawing.Color.Transparent;
            this.CompletionAmountLabel.Location = new System.Drawing.Point(246, 364);
            this.CompletionAmountLabel.Name = "CompletionAmountLabel";
            this.CompletionAmountLabel.Size = new System.Drawing.Size(24, 13);
            this.CompletionAmountLabel.TabIndex = 3;
            this.CompletionAmountLabel.Text = "0/0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 386);
            this.Controls.Add(this.CompletionAmountLabel);
            this.Controls.Add(this.SplitProgressBar);
            this.Controls.Add(this.OutputGroupBox);
            this.Controls.Add(this.TopSection);
            this.MinimumSize = new System.Drawing.Size(600, 425);
            this.Name = "MainForm";
            this.Text = "SpriteMapSplitter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TopSection.ResumeLayout(false);
            this.TopSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumber)).EndInit();
            this.OriginalImageGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumber)).EndInit();
            this.OutputGroupBox.ResumeLayout(false);
            this.OutputPreviewGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox TopSection;
        private System.Windows.Forms.Button BrowseForOutputFolder;
        private System.Windows.Forms.Label OutputPathLabel;
        private System.Windows.Forms.TextBox OutputPathTextBox;
        private System.Windows.Forms.Button BrowseForOriginalFileButton;
        private System.Windows.Forms.Label OutputFileLabel;
        private System.Windows.Forms.TextBox OriginalFilePathTextBox;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialogObject;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogObject;
        private System.Windows.Forms.Label OutputPrefixLabel;
        private System.Windows.Forms.TextBox OutputPrefixTextBox;
        private System.Windows.Forms.Button SplitImageButton;
        private System.Windows.Forms.GroupBox OriginalImageGroupBox;
        private System.Windows.Forms.PictureBox OriginalPictureBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.NumericUpDown HeightNumber;
        private System.Windows.Forms.NumericUpDown WidthNumber;
        private System.Windows.Forms.GroupBox OutputGroupBox;
        private System.Windows.Forms.GroupBox OutputPreviewGroupBox;
        private System.Windows.Forms.PictureBox PreviewPictureBox;
        private System.Windows.Forms.TreeView OutputFileNamesTreeView;
        private System.Windows.Forms.ProgressBar SplitProgressBar;
        private System.Windows.Forms.Label CompletionAmountLabel;
        private System.Windows.Forms.Button ResetButton;
    }
}

