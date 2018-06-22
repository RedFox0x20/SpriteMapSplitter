using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpriteMapSplitter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        string 
            OriginalFilePath = "",
            OutputFilePath = "",
            OutputPrefix    = "";

        Image OriginalImage;

        private void BrowseForOriginalFileButton_Click(object sender, EventArgs e)
        {
            DialogResult R = OpenFileDialogObject.ShowDialog();
            if (R == DialogResult.OK)
            {
                OriginalFilePath = OpenFileDialogObject.FileName;
                OriginalFilePathTextBox.Text = OriginalFilePath;
                Thread T = new Thread(LoadOriginal);
                T.IsBackground = true;
                T.Start();
            }
        }

        private void OutputPrefixTextBox_TextChanged(object sender, EventArgs e)
        {
            OutputPrefix = OutputPrefixTextBox.Text;
        }

        List<string> ImagePaths = new List<string>();

        private void OutputFileNamesTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            PreviewPictureBox.Image = Image.FromFile(e.Node.Text);
        }

        Thread SplitThread;
        private void SplitImageButton_Click(object sender, EventArgs e)
        {
            OutputFilePath = OutputPathTextBox.Text;
            SplitThread = new Thread(SplitImage);
            SplitThread.IsBackground = true;
            SplitThread.Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OutputPathTextBox.Text = $@"C:\Users\{Environment.UserName}\Pictures";
            OutputPrefix = OutputPrefixTextBox.Text;
        }

        private void SplitImage()
        {
            try
            {
                int W = Convert.ToInt32(WidthNumber.Value);
                int H = Convert.ToInt32(HeightNumber.Value);
                int NumWidth = Convert.ToInt32(OriginalImage.Width / W);
                int NumHeight = Convert.ToInt32(OriginalImage.Height / H);
                Rectangle ImageArea = new Rectangle { Width = W, Height = H };
                int i = 0;
                SplitProgressBar.Invoke((MethodInvoker)delegate () { SplitProgressBar.Maximum = NumWidth * NumHeight; });
                for (int X = 0; X < NumWidth; X++)
                {
                    for (int Y = 0; Y < NumHeight; Y++)
                    {
                        if (X * W + W > OriginalImage.Width || Y * H + H > OriginalImage.Height) { continue; }
                        ImageArea.X = X * W;
                        ImageArea.Y = Y * H;
                        Bitmap NewImage = new Bitmap(W, H);
                        Graphics g = Graphics.FromImage(NewImage);
                        g.DrawImage(OriginalImage, -ImageArea.X, -ImageArea.Y);
                        string FOUT = OutputFilePath + "\\" + OutputPrefix + "_" + i + ".png";
                        Bitmap SaveImage = new Bitmap(NewImage);
                        SaveImage.Save(FOUT);
                        ImagePaths.Add(FOUT);
                        i++;

                        SplitProgressBar.Invoke((MethodInvoker)delegate () { SplitProgressBar.PerformStep(); });
                        OutputFileNamesTreeView.Invoke((MethodInvoker)delegate () { OutputFileNamesTreeView.Nodes.Add(FOUT); });
                        CompletionAmountLabel.Invoke((MethodInvoker)delegate () { CompletionAmountLabel.Text = $"{i}/{NumWidth * NumHeight}"; });

                        SaveImage.Dispose();
                        g.Dispose();
                        NewImage.Dispose();
                    }
                }
                PreviewPictureBox.Invoke((MethodInvoker)delegate () { PreviewPictureBox.Image = Image.FromFile(ImagePaths[0]); });
                DialogResult R = MessageBox.Show("Image split complete!", "Success!", MessageBoxButtons.OK);
            }
            catch { }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SplitThread != null) { SplitThread.Abort(); }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            SplitProgressBar.Value = 0;
            CompletionAmountLabel.Text = "0/0";
            OriginalImage.Dispose();
            OriginalPictureBox.Image = null;
            OriginalFilePath = "";
            OriginalFilePathTextBox.Text = "";
            PreviewPictureBox.Image = null;
            OutputFilePath = "";
            OutputFileNamesTreeView.Nodes.Clear();
            OutputPathTextBox.Text = $@"C:\Users\{Environment.UserName}\Pictures";
            OutputPrefix = OutputPrefixTextBox.Text;
            SplitImageButton.Enabled = false;
        }

        private void BrowseForOutputFolder_Click(object sender, EventArgs e)
        {
            DialogResult R = FolderBrowserDialogObject.ShowDialog();
            if (R == DialogResult.OK)
            {
                OutputFilePath = FolderBrowserDialogObject.SelectedPath;
                OutputPathTextBox.Text = OutputFilePath;
            }
        }

        private void LoadOriginal()
        {
            OriginalImage = Image.FromFile(OriginalFilePath);
            OriginalPictureBox.Invoke((MethodInvoker)delegate () { OriginalPictureBox.Image = OriginalImage; });
            SplitImageButton.Invoke((MethodInvoker)delegate () { SplitImageButton.Enabled = true; });
        }
    }
}
