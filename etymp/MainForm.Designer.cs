
namespace etymp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.homePage = new System.Windows.Forms.TabPage();
            this.clearFileButton = new MaterialSkin.Controls.MaterialButton();
            this.pictureSelectButton = new MaterialSkin.Controls.MaterialButton();
            this.selectFileButton = new MaterialSkin.Controls.MaterialButton();
            this.saveButton = new MaterialSkin.Controls.MaterialButton();
            this.selectedPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureLabel = new MaterialSkin.Controls.MaterialLabel();
            this.fileLabel = new MaterialSkin.Controls.MaterialLabel();
            this.yearTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.trackTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.albumTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.authorTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.titleTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.aboutPage = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.releaseLabel = new MaterialSkin.Controls.MaterialLabel();
            this.fileBrowser = new System.Windows.Forms.OpenFileDialog();
            this.pictureBrowser = new System.Windows.Forms.OpenFileDialog();
            this.tabControl.SuspendLayout();
            this.homePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPictureBox)).BeginInit();
            this.aboutPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabControl;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(-2, 61);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTabSelector1.Size = new System.Drawing.Size(618, 42);
            this.materialTabSelector1.TabIndex = 2;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.homePage);
            this.tabControl.Controls.Add(this.aboutPage);
            this.tabControl.Depth = 0;
            this.tabControl.Location = new System.Drawing.Point(-2, 106);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(607, 299);
            this.tabControl.TabIndex = 3;
            // 
            // homePage
            // 
            this.homePage.Controls.Add(this.clearFileButton);
            this.homePage.Controls.Add(this.pictureSelectButton);
            this.homePage.Controls.Add(this.selectFileButton);
            this.homePage.Controls.Add(this.saveButton);
            this.homePage.Controls.Add(this.selectedPictureBox);
            this.homePage.Controls.Add(this.pictureLabel);
            this.homePage.Controls.Add(this.fileLabel);
            this.homePage.Controls.Add(this.yearTextBox);
            this.homePage.Controls.Add(this.trackTextBox);
            this.homePage.Controls.Add(this.albumTextBox);
            this.homePage.Controls.Add(this.authorTextBox);
            this.homePage.Controls.Add(this.titleTextBox);
            this.homePage.Location = new System.Drawing.Point(4, 22);
            this.homePage.Name = "homePage";
            this.homePage.Padding = new System.Windows.Forms.Padding(3);
            this.homePage.Size = new System.Drawing.Size(599, 273);
            this.homePage.TabIndex = 0;
            this.homePage.Text = "Home";
            this.homePage.UseVisualStyleBackColor = true;
            // 
            // clearFileButton
            // 
            this.clearFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearFileButton.Depth = 0;
            this.clearFileButton.DrawShadows = true;
            this.clearFileButton.HighEmphasis = true;
            this.clearFileButton.Icon = null;
            this.clearFileButton.Location = new System.Drawing.Point(316, 258);
            this.clearFileButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.clearFileButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearFileButton.Name = "clearFileButton";
            this.clearFileButton.Size = new System.Drawing.Size(99, 36);
            this.clearFileButton.TabIndex = 12;
            this.clearFileButton.Text = "Clear File";
            this.clearFileButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.clearFileButton.UseAccentColor = false;
            this.clearFileButton.UseVisualStyleBackColor = true;
            this.clearFileButton.Click += new System.EventHandler(this.onClearFileButtonClick);
            // 
            // pictureSelectButton
            // 
            this.pictureSelectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pictureSelectButton.Depth = 0;
            this.pictureSelectButton.DrawShadows = true;
            this.pictureSelectButton.HighEmphasis = true;
            this.pictureSelectButton.Icon = null;
            this.pictureSelectButton.Location = new System.Drawing.Point(455, 149);
            this.pictureSelectButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pictureSelectButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.pictureSelectButton.Name = "pictureSelectButton";
            this.pictureSelectButton.Size = new System.Drawing.Size(137, 36);
            this.pictureSelectButton.TabIndex = 11;
            this.pictureSelectButton.Text = "Select picture";
            this.pictureSelectButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.pictureSelectButton.UseAccentColor = false;
            this.pictureSelectButton.UseVisualStyleBackColor = true;
            this.pictureSelectButton.Click += new System.EventHandler(this.onPictureSelectButtonClick);
            // 
            // selectFileButton
            // 
            this.selectFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.selectFileButton.Depth = 0;
            this.selectFileButton.DrawShadows = true;
            this.selectFileButton.HighEmphasis = true;
            this.selectFileButton.Icon = null;
            this.selectFileButton.Location = new System.Drawing.Point(423, 258);
            this.selectFileButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.selectFileButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(106, 36);
            this.selectFileButton.TabIndex = 9;
            this.selectFileButton.Text = "Select file";
            this.selectFileButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.selectFileButton.UseAccentColor = false;
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.onSelectFileButtonClick);
            // 
            // saveButton
            // 
            this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveButton.Depth = 0;
            this.saveButton.DrawShadows = true;
            this.saveButton.HighEmphasis = true;
            this.saveButton.Icon = null;
            this.saveButton.Location = new System.Drawing.Point(537, 258);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(58, 36);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveButton.UseAccentColor = false;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.onSaveButtonClick);
            // 
            // selectedPictureBox
            // 
            this.selectedPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.selectedPictureBox.BackgroundImage = global::etymp.Properties.Resources.empty;
            this.selectedPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectedPictureBox.Location = new System.Drawing.Point(455, 6);
            this.selectedPictureBox.Name = "selectedPictureBox";
            this.selectedPictureBox.Size = new System.Drawing.Size(138, 134);
            this.selectedPictureBox.TabIndex = 7;
            this.selectedPictureBox.TabStop = false;
            // 
            // pictureLabel
            // 
            this.pictureLabel.AutoSize = true;
            this.pictureLabel.Depth = 0;
            this.pictureLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pictureLabel.Location = new System.Drawing.Point(17, 267);
            this.pictureLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.pictureLabel.Name = "pictureLabel";
            this.pictureLabel.Size = new System.Drawing.Size(54, 19);
            this.pictureLabel.TabIndex = 6;
            this.pictureLabel.Text = "Picture:";
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Depth = 0;
            this.fileLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fileLabel.Location = new System.Drawing.Point(17, 247);
            this.fileLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(30, 19);
            this.fileLabel.TabIndex = 5;
            this.fileLabel.Text = "File:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yearTextBox.Depth = 0;
            this.yearTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.yearTextBox.Hint = "Year";
            this.yearTextBox.Location = new System.Drawing.Point(20, 185);
            this.yearTextBox.MaxLength = 50;
            this.yearTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.yearTextBox.Multiline = false;
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(148, 36);
            this.yearTextBox.TabIndex = 4;
            this.yearTextBox.Text = "";
            this.yearTextBox.UseAccent = false;
            this.yearTextBox.UseTallSize = false;
            this.yearTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.blockLetterInput);
            // 
            // trackTextBox
            // 
            this.trackTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trackTextBox.Depth = 0;
            this.trackTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.trackTextBox.Hint = "Track";
            this.trackTextBox.Location = new System.Drawing.Point(20, 143);
            this.trackTextBox.MaxLength = 50;
            this.trackTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.trackTextBox.Multiline = false;
            this.trackTextBox.Name = "trackTextBox";
            this.trackTextBox.Size = new System.Drawing.Size(148, 36);
            this.trackTextBox.TabIndex = 3;
            this.trackTextBox.Text = "";
            this.trackTextBox.UseAccent = false;
            this.trackTextBox.UseTallSize = false;
            this.trackTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.blockLetterInput);
            // 
            // albumTextBox
            // 
            this.albumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.albumTextBox.Depth = 0;
            this.albumTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.albumTextBox.Hint = "Album";
            this.albumTextBox.Location = new System.Drawing.Point(20, 101);
            this.albumTextBox.MaxLength = 50;
            this.albumTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.albumTextBox.Multiline = false;
            this.albumTextBox.Name = "albumTextBox";
            this.albumTextBox.Size = new System.Drawing.Size(217, 36);
            this.albumTextBox.TabIndex = 2;
            this.albumTextBox.Text = "";
            this.albumTextBox.UseAccent = false;
            this.albumTextBox.UseTallSize = false;
            // 
            // authorTextBox
            // 
            this.authorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.authorTextBox.Depth = 0;
            this.authorTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.authorTextBox.Hint = "Author";
            this.authorTextBox.Location = new System.Drawing.Point(20, 59);
            this.authorTextBox.MaxLength = 50;
            this.authorTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.authorTextBox.Multiline = false;
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(217, 36);
            this.authorTextBox.TabIndex = 1;
            this.authorTextBox.Text = "";
            this.authorTextBox.UseAccent = false;
            this.authorTextBox.UseTallSize = false;
            // 
            // titleTextBox
            // 
            this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTextBox.Depth = 0;
            this.titleTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.titleTextBox.Hint = "Title";
            this.titleTextBox.Location = new System.Drawing.Point(20, 17);
            this.titleTextBox.MaxLength = 50;
            this.titleTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.titleTextBox.Multiline = false;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(217, 36);
            this.titleTextBox.TabIndex = 0;
            this.titleTextBox.Text = "";
            this.titleTextBox.UseAccent = false;
            this.titleTextBox.UseTallSize = false;
            // 
            // aboutPage
            // 
            this.aboutPage.Controls.Add(this.pictureBox1);
            this.aboutPage.Controls.Add(this.linkLabel1);
            this.aboutPage.Controls.Add(this.releaseLabel);
            this.aboutPage.Location = new System.Drawing.Point(4, 22);
            this.aboutPage.Name = "aboutPage";
            this.aboutPage.Padding = new System.Windows.Forms.Padding(3);
            this.aboutPage.Size = new System.Drawing.Size(599, 273);
            this.aboutPage.TabIndex = 1;
            this.aboutPage.Text = "About";
            this.aboutPage.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::etymp.Properties.Resources.about;
            this.pictureBox1.Location = new System.Drawing.Point(66, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 230);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(495, 257);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(78, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "david.huljak.sk";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.onLinkLabelClick);
            // 
            // releaseLabel
            // 
            this.releaseLabel.AutoSize = true;
            this.releaseLabel.Depth = 0;
            this.releaseLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.releaseLabel.Location = new System.Drawing.Point(24, 258);
            this.releaseLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.releaseLabel.Name = "releaseLabel";
            this.releaseLabel.Size = new System.Drawing.Size(60, 19);
            this.releaseLabel.TabIndex = 0;
            this.releaseLabel.Text = "Release:";
            this.releaseLabel.Click += new System.EventHandler(this.onReleaseClick);
            // 
            // fileBrowser
            // 
            this.fileBrowser.FileName = "fileBrowser";
            // 
            // pictureBrowser
            // 
            this.pictureBrowser.FileName = "pictureBrowser";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 410);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.materialTabSelector1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Name";
            this.Load += new System.EventHandler(this.onMainFormLoad);
            this.tabControl.ResumeLayout(false);
            this.homePage.ResumeLayout(false);
            this.homePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPictureBox)).EndInit();
            this.aboutPage.ResumeLayout(false);
            this.aboutPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage homePage;
        private MaterialSkin.Controls.MaterialLabel pictureLabel;
        private MaterialSkin.Controls.MaterialLabel fileLabel;
        private MaterialSkin.Controls.MaterialTextBox yearTextBox;
        private MaterialSkin.Controls.MaterialTextBox trackTextBox;
        private MaterialSkin.Controls.MaterialTextBox albumTextBox;
        private MaterialSkin.Controls.MaterialTextBox authorTextBox;
        private MaterialSkin.Controls.MaterialTextBox titleTextBox;
        private System.Windows.Forms.TabPage aboutPage;
        private System.Windows.Forms.PictureBox selectedPictureBox;
        private MaterialSkin.Controls.MaterialButton selectFileButton;
        private MaterialSkin.Controls.MaterialButton saveButton;
        private MaterialSkin.Controls.MaterialButton pictureSelectButton;
        private System.Windows.Forms.OpenFileDialog fileBrowser;
        private System.Windows.Forms.OpenFileDialog pictureBrowser;
        private MaterialSkin.Controls.MaterialButton clearFileButton;
        private MaterialSkin.Controls.MaterialLabel releaseLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

