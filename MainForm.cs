using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Shell;

namespace IconChanger
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void chooseIconButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Icon Files (*.ico)|*.ico|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string newIconPath = openFileDialog.FileName;
                Icon newIcon = new Icon(newIconPath);
                iconPreview.Image = newIcon.ToBitmap();
            }
        }

        private void setIconButton_Click(object sender, EventArgs e)
        {
            string targetFile = filePathTextBox.Text;
            string newIconPath = // Your code here to get the path to the new icon
            Icon newIcon = new Icon(newIconPath);
            ShellFile shellFile = ShellFile.FromFilePath(targetFile);
           private string GetNewIconPath()
{
    return (iconPreview.Image != null) ? ((Bitmap)iconPreview.Image).ToString() : null;
}

private void setIconButton_Click(object sender, EventArgs e)
{
    string targetFile = filePathTextBox.Text;
    string newIconPath = GetNewIconPath();

    if (string.IsNullOrEmpty(targetFile) || string.IsNullOrEmpty(newIconPath))
    {
        MessageBox.Show("Please select both a target file and an icon.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
    }

    Icon newIcon = new Icon(newIconPath);
    ShellFile shellFile = ShellFile.FromFilePath(targetFile);
    shellFile.Properties.System.Thumbnail.SetThumbnail(newIcon.ToBitmap());
    MessageBox.Show("Icon set successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
}

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void chooseIconButton_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Icon Files (*.ico)|*.ico|All Files (*.*)|*.*";

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            string newIconPath = openFileDialog.FileName;
            Icon newIcon = new Icon(newIconPath);
            iconPreview.Image = newIcon.ToBitmap();
        }
    }

    private string GetNewIconPath()
    {
        return (iconPreview.Image != null) ? ((Bitmap)iconPreview.Image).ToString() : null;
    }

    private void setIconButton_Click(object sender,
