using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace etymp
{
    public partial class MainForm : MaterialForm
    {

        private string name = "ETYMP";
        private string release = "2021/1";
        private Boolean isDebug;


        public MainForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700,
                Primary.Green600, Accent.Green700,
                TextShade.WHITE);

            releaseLabel.Text = "Release: " + release;

            this.MaximumSize = new Size(this.Width, this.Height);
            this.MinimumSize = new Size(this.Width, this.Height);
        }

        private void onMainFormLoad(object sender, EventArgs e)
        {
            this.Text = name;
            this.releaseLabel.Text = "Release: " + release;
        }

        private void clearEntries()
        {
            authorTextBox.Text = String.Empty;
            albumTextBox.Text = String.Empty;
            trackTextBox.Text = String.Empty;
            yearTextBox.Text = String.Empty;
            titleTextBox.Text = String.Empty;
            selectedPictureBox.Image = null;
            selectedPictureBox.Update();
            fileLabel.Text = "File: ";
            pictureLabel.Text = "Picture: ";
            fileBrowser.Reset();
            pictureBrowser.Reset();

        }

        private void blockLetterInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && 
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void openBrowser(OpenFileDialog browser, string filter, Label label, string labelContent, Boolean picture)
        {
            browser.Filter = filter;
            if (browser.ShowDialog() == DialogResult.OK)
            {
                label.Text = labelContent + browser.SafeFileName;
                if (picture == true)
                {
                    selectedPictureBox.Image = Image.FromFile(pictureBrowser.FileName);
                    selectedPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void openMessageBox(int type)
        {
            switch(type)
            {
                case 1:
                    MessageBox.Show("You haven't selected a file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBox.Show("Data sucessfully writed to mp3.", name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 3:
                    MessageBox.Show("File has been successfully cleared!", name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 4:
                    MessageBox.Show("Debug mode is enabled, resource will be imported automatically.", name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 5:
                    MessageBox.Show("Debug mode has been enabled!", name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void onSelectFileButtonClick(object sender, EventArgs e)
        {
                openBrowser(fileBrowser, "All Supported Audio | *.mp3", fileLabel, "File: ", false);
            
        }

        private void onSaveButtonClick(object sender, EventArgs e)
        {
            if (File.Exists(fileBrowser.InitialDirectory + fileBrowser.FileName)) 
            {
                Mp3Lib.Mp3File file = new Mp3Lib.Mp3File(fileBrowser.InitialDirectory + fileBrowser.FileName); 
                file.TagHandler.Artist = authorTextBox.Text; 
                file.TagHandler.Album = albumTextBox.Text;
                file.TagHandler.Track = trackTextBox.Text;
                file.TagHandler.Year = yearTextBox.Text;
                file.TagHandler.Title = titleTextBox.Text;
                if (isDebug == true)
                {
                    file.TagHandler.Picture = Properties.Resources.dummy;
                }
                else if (File.Exists(pictureBrowser.InitialDirectory + pictureBrowser.FileName)) 
                {
                    file.TagHandler.Picture = Image.FromFile(pictureBrowser.InitialDirectory + pictureBrowser.FileName);
                }
                file.Update();

                string fullPath = fileBrowser.FileName;
                string fileName = fileBrowser.SafeFileName; 
                string path = fullPath.Replace(fileName, ""); 


                foreach (string deletingfile in Directory.GetFiles(path, "*.bak").Where(item => item.EndsWith(".bak"))) 
                {
                    File.Delete(deletingfile); 
                }

                openMessageBox(2);
                clearEntries();
            }
            else
            {
                openMessageBox(1);
            }
        }

        private void onPictureSelectButtonClick(object sender, EventArgs e)
        {
            if (isDebug == true)
            {
                openMessageBox(4);
                pictureLabel.Text = "Picture: Default picture";
                selectedPictureBox.Image = Properties.Resources.dummy;
                selectedPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                openBrowser(pictureBrowser, "All Supported Pictures | *.jpg; *.png", pictureLabel, "Picture: ", true);
            }
        }

        private void onClearFileButtonClick(object sender, EventArgs e)
        {

            if(!File.Exists(fileBrowser.InitialDirectory + fileBrowser.FileName))
            {
                openMessageBox(1);
            }
            else
            {
                Mp3Lib.Mp3File file = new Mp3Lib.Mp3File(fileBrowser.InitialDirectory + fileBrowser.FileName);
                file.TagHandler.Artist = String.Empty;
                file.TagHandler.Album = String.Empty;
                file.TagHandler.Track = String.Empty;
                file.TagHandler.Year = String.Empty;
                file.TagHandler.Title = String.Empty;
                file.TagHandler.Picture = null;
                file.Update();
                string fullPath = fileBrowser.FileName;
                string fileName = fileBrowser.SafeFileName;
                string path = fullPath.Replace(fileName, "");


                foreach (string deletingfile in Directory.GetFiles(path, "*.bak").Where(item => item.EndsWith(".bak")))
                {
                    File.Delete(deletingfile);
                }
                openMessageBox(3);
                clearEntries();
            }
        }

        private void onLinkLabelClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://david.huljak.sk/");
        }

        private void onReleaseClick(object sender, EventArgs e)
        {
            if (isDebug == false)
            {
                isDebug = true;
                openMessageBox(5);
                tabControl.SelectedTab = this.homePage;
                authorTextBox.Text = "Debug";
                albumTextBox.Text = "DebugMode";
                trackTextBox.Text = "1";
                yearTextBox.Text = DateTime.Now.Year.ToString();
                titleTextBox.Text = "Dummy";
            }
        }

    
    }
}
