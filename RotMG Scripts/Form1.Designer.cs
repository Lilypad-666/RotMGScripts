namespace RotMG_Scripts {
    partial class RotMGHotkeys {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RotMGHotkeys));
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.MainTab = new System.Windows.Forms.TabPage();
            this.ProcessNameLabel = new System.Windows.Forms.Label();
            this.ProcessName = new System.Windows.Forms.TextBox();
            this.FoundPanel = new System.Windows.Forms.Panel();
            this.OptionsWarningLabel2 = new System.Windows.Forms.Label();
            this.OptionsWarningLabel1 = new System.Windows.Forms.Label();
            this.HotkeyButton0 = new System.Windows.Forms.Button();
            this.ConfigPanel = new System.Windows.Forms.Panel();
            this.ConfigButton = new System.Windows.Forms.Button();
            this.HotkeyButton1 = new System.Windows.Forms.Button();
            this.HotkeyBox1 = new System.Windows.Forms.TextBox();
            this.ConfigureLabel = new System.Windows.Forms.Label();
            this.ConfigureDesc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HotkeyBox0 = new System.Windows.Forms.TextBox();
            this.OptionsLabel = new System.Windows.Forms.Label();
            this.RotMGProcess = new System.Windows.Forms.TextBox();
            this.RotMGFound = new System.Windows.Forms.Label();
            this.RushingTab = new System.Windows.Forms.TabPage();
            this.rushingTabControl = new System.Windows.Forms.TabControl();
            this.GameInfo = new System.Windows.Forms.TabPage();
            this.windowHeightBox = new System.Windows.Forms.TextBox();
            this.windowWidthBox = new System.Windows.Forms.TextBox();
            this.windowYBox = new System.Windows.Forms.TextBox();
            this.windowXBox = new System.Windows.Forms.TextBox();
            this.windowY = new System.Windows.Forms.Label();
            this.windowWidth = new System.Windows.Forms.Label();
            this.windowHeight = new System.Windows.Forms.Label();
            this.windowX = new System.Windows.Forms.Label();
            this.WindowDim = new System.Windows.Forms.Label();
            this.ProgramInfoTab = new System.Windows.Forms.TabPage();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.WarningLabel2 = new System.Windows.Forms.Label();
            this.WarningLabel1 = new System.Windows.Forms.Label();
            this.GithubLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.ConsoleTab = new System.Windows.Forms.TabPage();
            this.mainTabControl.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.FoundPanel.SuspendLayout();
            this.ConfigPanel.SuspendLayout();
            this.RushingTab.SuspendLayout();
            this.GameInfo.SuspendLayout();
            this.ProgramInfoTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.MainTab);
            this.mainTabControl.Controls.Add(this.RushingTab);
            this.mainTabControl.Controls.Add(this.GameInfo);
            this.mainTabControl.Controls.Add(this.ConsoleTab);
            this.mainTabControl.Controls.Add(this.ProgramInfoTab);
            this.mainTabControl.Location = new System.Drawing.Point(12, 12);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(444, 426);
            this.mainTabControl.TabIndex = 0;
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.ProcessNameLabel);
            this.MainTab.Controls.Add(this.ProcessName);
            this.MainTab.Controls.Add(this.FoundPanel);
            this.MainTab.Controls.Add(this.RotMGProcess);
            this.MainTab.Controls.Add(this.RotMGFound);
            this.MainTab.Location = new System.Drawing.Point(4, 22);
            this.MainTab.Name = "MainTab";
            this.MainTab.Padding = new System.Windows.Forms.Padding(3);
            this.MainTab.Size = new System.Drawing.Size(436, 400);
            this.MainTab.TabIndex = 0;
            this.MainTab.Text = "Main";
            this.MainTab.UseVisualStyleBackColor = true;
            // 
            // ProcessNameLabel
            // 
            this.ProcessNameLabel.AutoSize = true;
            this.ProcessNameLabel.Location = new System.Drawing.Point(218, 10);
            this.ProcessNameLabel.Name = "ProcessNameLabel";
            this.ProcessNameLabel.Size = new System.Drawing.Size(79, 13);
            this.ProcessNameLabel.TabIndex = 5;
            this.ProcessNameLabel.Text = "Process Name:";
            // 
            // ProcessName
            // 
            this.ProcessName.Location = new System.Drawing.Point(307, 7);
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.Size = new System.Drawing.Size(121, 20);
            this.ProcessName.TabIndex = 4;
            this.ProcessName.Text = "flashplayer";
            // 
            // FoundPanel
            // 
            this.FoundPanel.Controls.Add(this.OptionsWarningLabel2);
            this.FoundPanel.Controls.Add(this.OptionsWarningLabel1);
            this.FoundPanel.Controls.Add(this.HotkeyButton0);
            this.FoundPanel.Controls.Add(this.ConfigPanel);
            this.FoundPanel.Controls.Add(this.HotkeyBox0);
            this.FoundPanel.Controls.Add(this.OptionsLabel);
            this.FoundPanel.Enabled = false;
            this.FoundPanel.Location = new System.Drawing.Point(-4, 32);
            this.FoundPanel.Name = "FoundPanel";
            this.FoundPanel.Size = new System.Drawing.Size(444, 372);
            this.FoundPanel.TabIndex = 3;
            // 
            // OptionsWarningLabel2
            // 
            this.OptionsWarningLabel2.AutoSize = true;
            this.OptionsWarningLabel2.ForeColor = System.Drawing.Color.Black;
            this.OptionsWarningLabel2.Location = new System.Drawing.Point(351, 26);
            this.OptionsWarningLabel2.Name = "OptionsWarningLabel2";
            this.OptionsWarningLabel2.Size = new System.Drawing.Size(78, 13);
            this.OptionsWarningLabel2.TabIndex = 20;
            this.OptionsWarningLabel2.Text = "A-Z,0-9,F1-F24";
            // 
            // OptionsWarningLabel1
            // 
            this.OptionsWarningLabel1.AutoSize = true;
            this.OptionsWarningLabel1.ForeColor = System.Drawing.Color.Black;
            this.OptionsWarningLabel1.Location = new System.Drawing.Point(363, 8);
            this.OptionsWarningLabel1.Name = "OptionsWarningLabel1";
            this.OptionsWarningLabel1.Size = new System.Drawing.Size(48, 13);
            this.OptionsWarningLabel1.TabIndex = 19;
            this.OptionsWarningLabel1.Text = "Must be:";
            // 
            // HotkeyButton0
            // 
            this.HotkeyButton0.Location = new System.Drawing.Point(242, 15);
            this.HotkeyButton0.Name = "HotkeyButton0";
            this.HotkeyButton0.Size = new System.Drawing.Size(92, 21);
            this.HotkeyButton0.TabIndex = 18;
            this.HotkeyButton0.Text = "Edit...";
            this.HotkeyButton0.UseVisualStyleBackColor = true;
            // 
            // ConfigPanel
            // 
            this.ConfigPanel.Controls.Add(this.ConfigButton);
            this.ConfigPanel.Controls.Add(this.HotkeyButton1);
            this.ConfigPanel.Controls.Add(this.HotkeyBox1);
            this.ConfigPanel.Controls.Add(this.ConfigureLabel);
            this.ConfigPanel.Controls.Add(this.ConfigureDesc);
            this.ConfigPanel.Controls.Add(this.label1);
            this.ConfigPanel.Location = new System.Drawing.Point(3, 42);
            this.ConfigPanel.Name = "ConfigPanel";
            this.ConfigPanel.Size = new System.Drawing.Size(437, 326);
            this.ConfigPanel.TabIndex = 15;
            // 
            // ConfigButton
            // 
            this.ConfigButton.Location = new System.Drawing.Point(337, 51);
            this.ConfigButton.Name = "ConfigButton";
            this.ConfigButton.Size = new System.Drawing.Size(92, 21);
            this.ConfigButton.TabIndex = 20;
            this.ConfigButton.Text = "Configure";
            this.ConfigButton.UseVisualStyleBackColor = true;
            // 
            // HotkeyButton1
            // 
            this.HotkeyButton1.Location = new System.Drawing.Point(239, 51);
            this.HotkeyButton1.Name = "HotkeyButton1";
            this.HotkeyButton1.Size = new System.Drawing.Size(92, 21);
            this.HotkeyButton1.TabIndex = 19;
            this.HotkeyButton1.Text = "Edit...";
            this.HotkeyButton1.UseVisualStyleBackColor = true;
            // 
            // HotkeyBox1
            // 
            this.HotkeyBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotkeyBox1.Location = new System.Drawing.Point(85, 52);
            this.HotkeyBox1.Name = "HotkeyBox1";
            this.HotkeyBox1.ReadOnly = true;
            this.HotkeyBox1.Size = new System.Drawing.Size(137, 20);
            this.HotkeyBox1.TabIndex = 16;
            this.HotkeyBox1.Text = "N/A";
            this.HotkeyBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConfigureLabel
            // 
            this.ConfigureLabel.AutoSize = true;
            this.ConfigureLabel.Location = new System.Drawing.Point(7, 55);
            this.ConfigureLabel.Name = "ConfigureLabel";
            this.ConfigureLabel.Size = new System.Drawing.Size(76, 13);
            this.ConfigureLabel.TabIndex = 15;
            this.ConfigureLabel.Text = "Configure Key:";
            // 
            // ConfigureDesc
            // 
            this.ConfigureDesc.AutoSize = true;
            this.ConfigureDesc.Location = new System.Drawing.Point(44, 9);
            this.ConfigureDesc.Name = "ConfigureDesc";
            this.ConfigureDesc.Size = new System.Drawing.Size(340, 13);
            this.ConfigureDesc.TabIndex = 13;
            this.ConfigureDesc.Text = "Please set your options key, go in game, and either press the configure";
            this.ConfigureDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "hotkey or the configure button below!";
            // 
            // HotkeyBox0
            // 
            this.HotkeyBox0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotkeyBox0.Location = new System.Drawing.Point(88, 16);
            this.HotkeyBox0.Name = "HotkeyBox0";
            this.HotkeyBox0.ReadOnly = true;
            this.HotkeyBox0.Size = new System.Drawing.Size(137, 20);
            this.HotkeyBox0.TabIndex = 12;
            this.HotkeyBox0.Text = "N/A";
            this.HotkeyBox0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OptionsLabel
            // 
            this.OptionsLabel.AutoSize = true;
            this.OptionsLabel.Location = new System.Drawing.Point(10, 19);
            this.OptionsLabel.Name = "OptionsLabel";
            this.OptionsLabel.Size = new System.Drawing.Size(67, 13);
            this.OptionsLabel.TabIndex = 9;
            this.OptionsLabel.Text = "Options Key:";
            // 
            // RotMGProcess
            // 
            this.RotMGProcess.Location = new System.Drawing.Point(89, 7);
            this.RotMGProcess.Name = "RotMGProcess";
            this.RotMGProcess.ReadOnly = true;
            this.RotMGProcess.Size = new System.Drawing.Size(121, 20);
            this.RotMGProcess.TabIndex = 1;
            this.RotMGProcess.Text = "Not Found...";
            // 
            // RotMGFound
            // 
            this.RotMGFound.AutoSize = true;
            this.RotMGFound.Location = new System.Drawing.Point(6, 10);
            this.RotMGFound.Name = "RotMGFound";
            this.RotMGFound.Size = new System.Drawing.Size(77, 13);
            this.RotMGFound.TabIndex = 0;
            this.RotMGFound.Text = "RotMG Found:";
            // 
            // RushingTab
            // 
            this.RushingTab.Controls.Add(this.rushingTabControl);
            this.RushingTab.Location = new System.Drawing.Point(4, 22);
            this.RushingTab.Name = "RushingTab";
            this.RushingTab.Padding = new System.Windows.Forms.Padding(3);
            this.RushingTab.Size = new System.Drawing.Size(436, 400);
            this.RushingTab.TabIndex = 1;
            this.RushingTab.Text = "Rushing";
            this.RushingTab.UseVisualStyleBackColor = true;
            // 
            // rushingTabControl
            // 
            this.rushingTabControl.Location = new System.Drawing.Point(6, 6);
            this.rushingTabControl.Name = "rushingTabControl";
            this.rushingTabControl.SelectedIndex = 0;
            this.rushingTabControl.Size = new System.Drawing.Size(427, 391);
            this.rushingTabControl.TabIndex = 0;
            // 
            // GameInfo
            // 
            this.GameInfo.Controls.Add(this.windowHeightBox);
            this.GameInfo.Controls.Add(this.windowWidthBox);
            this.GameInfo.Controls.Add(this.windowYBox);
            this.GameInfo.Controls.Add(this.windowXBox);
            this.GameInfo.Controls.Add(this.windowY);
            this.GameInfo.Controls.Add(this.windowWidth);
            this.GameInfo.Controls.Add(this.windowHeight);
            this.GameInfo.Controls.Add(this.windowX);
            this.GameInfo.Controls.Add(this.WindowDim);
            this.GameInfo.Location = new System.Drawing.Point(4, 22);
            this.GameInfo.Name = "GameInfo";
            this.GameInfo.Size = new System.Drawing.Size(436, 400);
            this.GameInfo.TabIndex = 3;
            this.GameInfo.Text = "Game Info";
            this.GameInfo.UseVisualStyleBackColor = true;
            // 
            // windowHeightBox
            // 
            this.windowHeightBox.Location = new System.Drawing.Point(267, 45);
            this.windowHeightBox.Name = "windowHeightBox";
            this.windowHeightBox.ReadOnly = true;
            this.windowHeightBox.Size = new System.Drawing.Size(38, 20);
            this.windowHeightBox.TabIndex = 17;
            this.windowHeightBox.Text = "N/A";
            this.windowHeightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // windowWidthBox
            // 
            this.windowWidthBox.Location = new System.Drawing.Point(267, 19);
            this.windowWidthBox.Name = "windowWidthBox";
            this.windowWidthBox.ReadOnly = true;
            this.windowWidthBox.Size = new System.Drawing.Size(38, 20);
            this.windowWidthBox.TabIndex = 16;
            this.windowWidthBox.Text = "N/A";
            this.windowWidthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // windowYBox
            // 
            this.windowYBox.Location = new System.Drawing.Point(146, 45);
            this.windowYBox.Name = "windowYBox";
            this.windowYBox.ReadOnly = true;
            this.windowYBox.Size = new System.Drawing.Size(38, 20);
            this.windowYBox.TabIndex = 15;
            this.windowYBox.Text = "N/A";
            this.windowYBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // windowXBox
            // 
            this.windowXBox.Location = new System.Drawing.Point(146, 19);
            this.windowXBox.Name = "windowXBox";
            this.windowXBox.ReadOnly = true;
            this.windowXBox.Size = new System.Drawing.Size(38, 20);
            this.windowXBox.TabIndex = 14;
            this.windowXBox.Text = "N/A";
            this.windowXBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // windowY
            // 
            this.windowY.AutoSize = true;
            this.windowY.Location = new System.Drawing.Point(123, 48);
            this.windowY.Name = "windowY";
            this.windowY.Size = new System.Drawing.Size(17, 13);
            this.windowY.TabIndex = 13;
            this.windowY.Text = "Y:";
            // 
            // windowWidth
            // 
            this.windowWidth.AutoSize = true;
            this.windowWidth.Location = new System.Drawing.Point(214, 22);
            this.windowWidth.Name = "windowWidth";
            this.windowWidth.Size = new System.Drawing.Size(38, 13);
            this.windowWidth.TabIndex = 12;
            this.windowWidth.Text = "Width:";
            // 
            // windowHeight
            // 
            this.windowHeight.AutoSize = true;
            this.windowHeight.Location = new System.Drawing.Point(211, 48);
            this.windowHeight.Name = "windowHeight";
            this.windowHeight.Size = new System.Drawing.Size(41, 13);
            this.windowHeight.TabIndex = 11;
            this.windowHeight.Text = "Height:";
            // 
            // windowX
            // 
            this.windowX.AutoSize = true;
            this.windowX.Location = new System.Drawing.Point(123, 25);
            this.windowX.Name = "windowX";
            this.windowX.Size = new System.Drawing.Size(17, 13);
            this.windowX.TabIndex = 10;
            this.windowX.Text = "X:";
            // 
            // WindowDim
            // 
            this.WindowDim.AutoSize = true;
            this.WindowDim.Location = new System.Drawing.Point(13, 35);
            this.WindowDim.Name = "WindowDim";
            this.WindowDim.Size = new System.Drawing.Size(104, 13);
            this.WindowDim.TabIndex = 9;
            this.WindowDim.Text = "Window Dimentions:";
            // 
            // ProgramInfoTab
            // 
            this.ProgramInfoTab.Controls.Add(this.VersionLabel);
            this.ProgramInfoTab.Controls.Add(this.WarningLabel2);
            this.ProgramInfoTab.Controls.Add(this.WarningLabel1);
            this.ProgramInfoTab.Controls.Add(this.GithubLabel);
            this.ProgramInfoTab.Controls.Add(this.AuthorLabel);
            this.ProgramInfoTab.Location = new System.Drawing.Point(4, 22);
            this.ProgramInfoTab.Name = "ProgramInfoTab";
            this.ProgramInfoTab.Size = new System.Drawing.Size(436, 400);
            this.ProgramInfoTab.TabIndex = 2;
            this.ProgramInfoTab.Text = "Program Info";
            this.ProgramInfoTab.UseVisualStyleBackColor = true;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.Location = new System.Drawing.Point(18, 108);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(64, 17);
            this.VersionLabel.TabIndex = 4;
            this.VersionLabel.Text = "Version: ";
            // 
            // WarningLabel2
            // 
            this.WarningLabel2.AutoSize = true;
            this.WarningLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningLabel2.Location = new System.Drawing.Point(77, 26);
            this.WarningLabel2.Name = "WarningLabel2";
            this.WarningLabel2.Size = new System.Drawing.Size(281, 17);
            this.WarningLabel2.TabIndex = 3;
            this.WarningLabel2.Text = "immediately change your RotMG password.";
            // 
            // WarningLabel1
            // 
            this.WarningLabel1.AutoSize = true;
            this.WarningLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningLabel1.Location = new System.Drawing.Point(18, 9);
            this.WarningLabel1.Name = "WarningLabel1";
            this.WarningLabel1.Size = new System.Drawing.Size(398, 17);
            this.WarningLabel1.TabIndex = 2;
            this.WarningLabel1.Text = " If you downloaded this anywhere other than MPGH or Github,";
            // 
            // GithubLabel
            // 
            this.GithubLabel.AutoSize = true;
            this.GithubLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GithubLabel.Location = new System.Drawing.Point(18, 134);
            this.GithubLabel.Name = "GithubLabel";
            this.GithubLabel.Size = new System.Drawing.Size(241, 17);
            this.GithubLabel.TabIndex = 1;
            this.GithubLabel.Text = "Source Code (GitHub): (LINK SOON)";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLabel.Location = new System.Drawing.Point(18, 82);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(86, 17);
            this.AuthorLabel.TabIndex = 0;
            this.AuthorLabel.Text = "Author: Lilypad-666";
            // 
            // ConsoleTab
            // 
            this.ConsoleTab.Location = new System.Drawing.Point(4, 22);
            this.ConsoleTab.Name = "ConsoleTab";
            this.ConsoleTab.Size = new System.Drawing.Size(436, 400);
            this.ConsoleTab.TabIndex = 4;
            this.ConsoleTab.Text = "Console";
            this.ConsoleTab.UseVisualStyleBackColor = true;
            // 
            // RotMGHotkeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.mainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RotMGHotkeys";
            this.Text = "RotMG Scripts ";
            this.mainTabControl.ResumeLayout(false);
            this.MainTab.ResumeLayout(false);
            this.MainTab.PerformLayout();
            this.FoundPanel.ResumeLayout(false);
            this.FoundPanel.PerformLayout();
            this.ConfigPanel.ResumeLayout(false);
            this.ConfigPanel.PerformLayout();
            this.RushingTab.ResumeLayout(false);
            this.GameInfo.ResumeLayout(false);
            this.GameInfo.PerformLayout();
            this.ProgramInfoTab.ResumeLayout(false);
            this.ProgramInfoTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage MainTab;
        private System.Windows.Forms.TabPage RushingTab;
        private System.Windows.Forms.Label RotMGFound;
        private System.Windows.Forms.TextBox RotMGProcess;
        private System.Windows.Forms.Panel FoundPanel;
        private System.Windows.Forms.TabControl rushingTabControl;
        private System.Windows.Forms.Label OptionsLabel;
        private System.Windows.Forms.TextBox HotkeyBox0;
        private System.Windows.Forms.Panel ConfigPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ConfigureDesc;
        private System.Windows.Forms.TextBox HotkeyBox1;
        private System.Windows.Forms.Label ConfigureLabel;
        private System.Windows.Forms.Button HotkeyButton0;
        private System.Windows.Forms.Button HotkeyButton1;
        private System.Windows.Forms.TabPage ProgramInfoTab;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label WarningLabel2;
        private System.Windows.Forms.Label WarningLabel1;
        private System.Windows.Forms.Label GithubLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Button ConfigButton;
        private System.Windows.Forms.Label OptionsWarningLabel2;
        private System.Windows.Forms.Label OptionsWarningLabel1;
        private System.Windows.Forms.TabPage GameInfo;
        private System.Windows.Forms.Label ProcessNameLabel;
        private System.Windows.Forms.TextBox ProcessName;
        private System.Windows.Forms.TextBox windowHeightBox;
        private System.Windows.Forms.TextBox windowWidthBox;
        private System.Windows.Forms.TextBox windowYBox;
        private System.Windows.Forms.TextBox windowXBox;
        private System.Windows.Forms.Label windowY;
        private System.Windows.Forms.Label windowWidth;
        private System.Windows.Forms.Label windowHeight;
        private System.Windows.Forms.Label windowX;
        private System.Windows.Forms.Label WindowDim;
        private System.Windows.Forms.TabPage ConsoleTab;
    }
}

