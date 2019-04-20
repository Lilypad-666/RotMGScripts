namespace RotMG_Scripts {
    partial class MainForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DebuggingTab = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ConsoleTab = new System.Windows.Forms.TabPage();
            this.ConsolePanel = new System.Windows.Forms.Panel();
            this.ConsoleSend = new System.Windows.Forms.Button();
            this.ConsoleInput = new System.Windows.Forms.TextBox();
            this.ConsoleText = new System.Windows.Forms.TextBox();
            this.ProgramInfoTab = new System.Windows.Forms.TabPage();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.WarningLabel2 = new System.Windows.Forms.Label();
            this.WarningLabel1 = new System.Windows.Forms.Label();
            this.GithubLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.RushingTab = new System.Windows.Forms.TabPage();
            this.rushingTabControl = new System.Windows.Forms.TabControl();
            this.MainTab = new System.Windows.Forms.TabPage();
            this.ProcessNameLabel = new System.Windows.Forms.Label();
            this.ProcessName = new System.Windows.Forms.TextBox();
            this.RotMGProcess = new System.Windows.Forms.TextBox();
            this.OptionsPanel = new System.Windows.Forms.Panel();
            this.OptionsWarningLabel2 = new System.Windows.Forms.Label();
            this.OptionsWarningLabel1 = new System.Windows.Forms.Label();
            this.HotkeyButton0 = new System.Windows.Forms.Button();
            this.HotkeyBox0 = new System.Windows.Forms.TextBox();
            this.OptionsLabel = new System.Windows.Forms.Label();
            this.RotMGFound = new System.Windows.Forms.Label();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.GameInfoTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WindowYBox = new System.Windows.Forms.TextBox();
            this.WindowWidthBox = new System.Windows.Forms.TextBox();
            this.WindowHeightBox = new System.Windows.Forms.TextBox();
            this.WindowXBox = new System.Windows.Forms.TextBox();
            this.WindowHeightLabel = new System.Windows.Forms.Label();
            this.WindowWidthLabel = new System.Windows.Forms.Label();
            this.WindowYLabel = new System.Windows.Forms.Label();
            this.WindowXLabel = new System.Windows.Forms.Label();
            this.WindowInfoLabel = new System.Windows.Forms.Label();
            this.GitHubLink = new System.Windows.Forms.LinkLabel();
            this.DebuggingTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ConsoleTab.SuspendLayout();
            this.ConsolePanel.SuspendLayout();
            this.ProgramInfoTab.SuspendLayout();
            this.RushingTab.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.OptionsPanel.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.GameInfoTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DebuggingTab
            // 
            this.DebuggingTab.Controls.Add(this.tabControl1);
            this.DebuggingTab.Location = new System.Drawing.Point(4, 22);
            this.DebuggingTab.Name = "DebuggingTab";
            this.DebuggingTab.Size = new System.Drawing.Size(436, 400);
            this.DebuggingTab.TabIndex = 5;
            this.DebuggingTab.Text = "Debugging";
            this.DebuggingTab.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ConsoleTab);
            this.tabControl1.Controls.Add(this.ProgramInfoTab);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(432, 396);
            this.tabControl1.TabIndex = 0;
            // 
            // ConsoleTab
            // 
            this.ConsoleTab.Controls.Add(this.ConsolePanel);
            this.ConsoleTab.Location = new System.Drawing.Point(4, 22);
            this.ConsoleTab.Name = "ConsoleTab";
            this.ConsoleTab.Size = new System.Drawing.Size(424, 370);
            this.ConsoleTab.TabIndex = 2;
            this.ConsoleTab.Text = "Console";
            this.ConsoleTab.UseVisualStyleBackColor = true;
            // 
            // ConsolePanel
            // 
            this.ConsolePanel.BackColor = System.Drawing.Color.Black;
            this.ConsolePanel.Controls.Add(this.ConsoleSend);
            this.ConsolePanel.Controls.Add(this.ConsoleInput);
            this.ConsolePanel.Controls.Add(this.ConsoleText);
            this.ConsolePanel.Location = new System.Drawing.Point(3, 3);
            this.ConsolePanel.Name = "ConsolePanel";
            this.ConsolePanel.Size = new System.Drawing.Size(418, 364);
            this.ConsolePanel.TabIndex = 1;
            // 
            // ConsoleSend
            // 
            this.ConsoleSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ConsoleSend.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ConsoleSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsoleSend.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleSend.ForeColor = System.Drawing.Color.Lime;
            this.ConsoleSend.Location = new System.Drawing.Point(350, 340);
            this.ConsoleSend.Name = "ConsoleSend";
            this.ConsoleSend.Size = new System.Drawing.Size(65, 21);
            this.ConsoleSend.TabIndex = 2;
            this.ConsoleSend.TabStop = false;
            this.ConsoleSend.Text = "Send";
            this.ConsoleSend.UseVisualStyleBackColor = false;
            this.ConsoleSend.Click += new System.EventHandler(this.ConsoleSendClick);
            // 
            // ConsoleInput
            // 
            this.ConsoleInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ConsoleInput.Font = new System.Drawing.Font("Arial", 10.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleInput.ForeColor = System.Drawing.Color.Lime;
            this.ConsoleInput.Location = new System.Drawing.Point(3, 339);
            this.ConsoleInput.Name = "ConsoleInput";
            this.ConsoleInput.Size = new System.Drawing.Size(346, 23);
            this.ConsoleInput.TabIndex = 1;
            // 
            // ConsoleText
            // 
            this.ConsoleText.BackColor = System.Drawing.Color.Black;
            this.ConsoleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsoleText.Font = new System.Drawing.Font("Arial", 10.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleText.ForeColor = System.Drawing.Color.Lime;
            this.ConsoleText.Location = new System.Drawing.Point(3, 3);
            this.ConsoleText.Multiline = true;
            this.ConsoleText.Name = "ConsoleText";
            this.ConsoleText.ReadOnly = true;
            this.ConsoleText.Size = new System.Drawing.Size(412, 330);
            this.ConsoleText.TabIndex = 0;
            // 
            // ProgramInfoTab
            // 
            this.ProgramInfoTab.Controls.Add(this.GitHubLink);
            this.ProgramInfoTab.Controls.Add(this.VersionLabel);
            this.ProgramInfoTab.Controls.Add(this.WarningLabel2);
            this.ProgramInfoTab.Controls.Add(this.WarningLabel1);
            this.ProgramInfoTab.Controls.Add(this.GithubLabel);
            this.ProgramInfoTab.Controls.Add(this.AuthorLabel);
            this.ProgramInfoTab.Location = new System.Drawing.Point(4, 22);
            this.ProgramInfoTab.Name = "ProgramInfoTab";
            this.ProgramInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProgramInfoTab.Size = new System.Drawing.Size(424, 370);
            this.ProgramInfoTab.TabIndex = 1;
            this.ProgramInfoTab.Text = "Program Info";
            this.ProgramInfoTab.UseVisualStyleBackColor = true;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.Location = new System.Drawing.Point(20, 102);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(64, 17);
            this.VersionLabel.TabIndex = 9;
            this.VersionLabel.Text = "Version: ";
            // 
            // WarningLabel2
            // 
            this.WarningLabel2.AutoSize = true;
            this.WarningLabel2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningLabel2.Location = new System.Drawing.Point(68, 26);
            this.WarningLabel2.Name = "WarningLabel2";
            this.WarningLabel2.Size = new System.Drawing.Size(291, 17);
            this.WarningLabel2.TabIndex = 8;
            this.WarningLabel2.Text = "immediately change your RotMG password.";
            // 
            // WarningLabel1
            // 
            this.WarningLabel1.AutoSize = true;
            this.WarningLabel1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningLabel1.Location = new System.Drawing.Point(9, 9);
            this.WarningLabel1.Name = "WarningLabel1";
            this.WarningLabel1.Size = new System.Drawing.Size(404, 17);
            this.WarningLabel1.TabIndex = 7;
            this.WarningLabel1.Text = " If you downloaded this anywhere other than MPGH or Github,";
            // 
            // GithubLabel
            // 
            this.GithubLabel.AutoSize = true;
            this.GithubLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GithubLabel.Location = new System.Drawing.Point(20, 128);
            this.GithubLabel.Name = "GithubLabel";
            this.GithubLabel.Size = new System.Drawing.Size(98, 17);
            this.GithubLabel.TabIndex = 6;
            this.GithubLabel.Text = "Source Code:";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLabel.Location = new System.Drawing.Point(20, 76);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(88, 17);
            this.AuthorLabel.TabIndex = 5;
            this.AuthorLabel.Text = "Author: Lilypad-666";
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
            // MainTab
            // 
            this.MainTab.Controls.Add(this.ProcessNameLabel);
            this.MainTab.Controls.Add(this.ProcessName);
            this.MainTab.Controls.Add(this.RotMGProcess);
            this.MainTab.Controls.Add(this.OptionsPanel);
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
            // RotMGProcess
            // 
            this.RotMGProcess.Location = new System.Drawing.Point(89, 7);
            this.RotMGProcess.Name = "RotMGProcess";
            this.RotMGProcess.ReadOnly = true;
            this.RotMGProcess.Size = new System.Drawing.Size(121, 20);
            this.RotMGProcess.TabIndex = 1;
            this.RotMGProcess.Text = "Not Found...";
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.Controls.Add(this.OptionsWarningLabel2);
            this.OptionsPanel.Controls.Add(this.OptionsWarningLabel1);
            this.OptionsPanel.Controls.Add(this.HotkeyButton0);
            this.OptionsPanel.Controls.Add(this.HotkeyBox0);
            this.OptionsPanel.Controls.Add(this.OptionsLabel);
            this.OptionsPanel.Enabled = false;
            this.OptionsPanel.Location = new System.Drawing.Point(-4, 32);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(444, 372);
            this.OptionsPanel.TabIndex = 3;
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
            // RotMGFound
            // 
            this.RotMGFound.AutoSize = true;
            this.RotMGFound.Location = new System.Drawing.Point(6, 10);
            this.RotMGFound.Name = "RotMGFound";
            this.RotMGFound.Size = new System.Drawing.Size(77, 13);
            this.RotMGFound.TabIndex = 0;
            this.RotMGFound.Text = "RotMG Found:";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.MainTab);
            this.mainTabControl.Controls.Add(this.RushingTab);
            this.mainTabControl.Controls.Add(this.GameInfoTab);
            this.mainTabControl.Controls.Add(this.DebuggingTab);
            this.mainTabControl.Location = new System.Drawing.Point(12, 12);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(444, 426);
            this.mainTabControl.TabIndex = 0;
            // 
            // GameInfoTab
            // 
            this.GameInfoTab.Controls.Add(this.panel1);
            this.GameInfoTab.Location = new System.Drawing.Point(4, 22);
            this.GameInfoTab.Name = "GameInfoTab";
            this.GameInfoTab.Size = new System.Drawing.Size(436, 400);
            this.GameInfoTab.TabIndex = 6;
            this.GameInfoTab.Text = "Game Info";
            this.GameInfoTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.WindowYBox);
            this.panel1.Controls.Add(this.WindowWidthBox);
            this.panel1.Controls.Add(this.WindowHeightBox);
            this.panel1.Controls.Add(this.WindowXBox);
            this.panel1.Controls.Add(this.WindowHeightLabel);
            this.panel1.Controls.Add(this.WindowWidthLabel);
            this.panel1.Controls.Add(this.WindowYLabel);
            this.panel1.Controls.Add(this.WindowXLabel);
            this.panel1.Controls.Add(this.WindowInfoLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 400);
            this.panel1.TabIndex = 0;
            // 
            // WindowYBox
            // 
            this.WindowYBox.Location = new System.Drawing.Point(143, 32);
            this.WindowYBox.Name = "WindowYBox";
            this.WindowYBox.ReadOnly = true;
            this.WindowYBox.Size = new System.Drawing.Size(40, 20);
            this.WindowYBox.TabIndex = 8;
            this.WindowYBox.Text = "N/A";
            this.WindowYBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WindowWidthBox
            // 
            this.WindowWidthBox.Location = new System.Drawing.Point(244, 6);
            this.WindowWidthBox.Name = "WindowWidthBox";
            this.WindowWidthBox.ReadOnly = true;
            this.WindowWidthBox.Size = new System.Drawing.Size(40, 20);
            this.WindowWidthBox.TabIndex = 7;
            this.WindowWidthBox.Text = "N/A";
            this.WindowWidthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WindowHeightBox
            // 
            this.WindowHeightBox.Location = new System.Drawing.Point(244, 32);
            this.WindowHeightBox.Name = "WindowHeightBox";
            this.WindowHeightBox.ReadOnly = true;
            this.WindowHeightBox.Size = new System.Drawing.Size(40, 20);
            this.WindowHeightBox.TabIndex = 6;
            this.WindowHeightBox.Text = "N/A";
            this.WindowHeightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WindowXBox
            // 
            this.WindowXBox.Location = new System.Drawing.Point(143, 6);
            this.WindowXBox.Name = "WindowXBox";
            this.WindowXBox.ReadOnly = true;
            this.WindowXBox.Size = new System.Drawing.Size(40, 20);
            this.WindowXBox.TabIndex = 5;
            this.WindowXBox.Text = "N/A";
            this.WindowXBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WindowHeightLabel
            // 
            this.WindowHeightLabel.AutoSize = true;
            this.WindowHeightLabel.Location = new System.Drawing.Point(197, 35);
            this.WindowHeightLabel.Name = "WindowHeightLabel";
            this.WindowHeightLabel.Size = new System.Drawing.Size(41, 13);
            this.WindowHeightLabel.TabIndex = 4;
            this.WindowHeightLabel.Text = "Height:";
            // 
            // WindowWidthLabel
            // 
            this.WindowWidthLabel.AutoSize = true;
            this.WindowWidthLabel.Location = new System.Drawing.Point(200, 9);
            this.WindowWidthLabel.Name = "WindowWidthLabel";
            this.WindowWidthLabel.Size = new System.Drawing.Size(38, 13);
            this.WindowWidthLabel.TabIndex = 3;
            this.WindowWidthLabel.Text = "Width:";
            // 
            // WindowYLabel
            // 
            this.WindowYLabel.AutoSize = true;
            this.WindowYLabel.Location = new System.Drawing.Point(120, 35);
            this.WindowYLabel.Name = "WindowYLabel";
            this.WindowYLabel.Size = new System.Drawing.Size(17, 13);
            this.WindowYLabel.TabIndex = 2;
            this.WindowYLabel.Text = "Y:";
            // 
            // WindowXLabel
            // 
            this.WindowXLabel.AutoSize = true;
            this.WindowXLabel.Location = new System.Drawing.Point(120, 9);
            this.WindowXLabel.Name = "WindowXLabel";
            this.WindowXLabel.Size = new System.Drawing.Size(17, 13);
            this.WindowXLabel.TabIndex = 1;
            this.WindowXLabel.Text = "X:";
            // 
            // WindowInfoLabel
            // 
            this.WindowInfoLabel.AutoSize = true;
            this.WindowInfoLabel.Location = new System.Drawing.Point(13, 22);
            this.WindowInfoLabel.Name = "WindowInfoLabel";
            this.WindowInfoLabel.Size = new System.Drawing.Size(101, 13);
            this.WindowInfoLabel.TabIndex = 0;
            this.WindowInfoLabel.Text = "Game Window Info:";
            // 
            // GitHubLink
            // 
            this.GitHubLink.AutoSize = true;
            this.GitHubLink.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GitHubLink.Location = new System.Drawing.Point(124, 128);
            this.GitHubLink.Name = "GitHubLink";
            this.GitHubLink.Size = new System.Drawing.Size(52, 17);
            this.GitHubLink.TabIndex = 10;
            this.GitHubLink.TabStop = true;
            this.GitHubLink.Tag = "";
            this.GitHubLink.Text = "GitHub";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.mainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "RotMG Scripts ";
            this.DebuggingTab.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ConsoleTab.ResumeLayout(false);
            this.ConsolePanel.ResumeLayout(false);
            this.ConsolePanel.PerformLayout();
            this.ProgramInfoTab.ResumeLayout(false);
            this.ProgramInfoTab.PerformLayout();
            this.RushingTab.ResumeLayout(false);
            this.MainTab.ResumeLayout(false);
            this.MainTab.PerformLayout();
            this.OptionsPanel.ResumeLayout(false);
            this.OptionsPanel.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.GameInfoTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabPage DebuggingTab;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage ConsoleTab;
        public System.Windows.Forms.Panel ConsolePanel;
        public System.Windows.Forms.TextBox ConsoleText;
        public System.Windows.Forms.TabPage ProgramInfoTab;
        public System.Windows.Forms.Label VersionLabel;
        public System.Windows.Forms.Label WarningLabel2;
        public System.Windows.Forms.Label WarningLabel1;
        public System.Windows.Forms.Label GithubLabel;
        public System.Windows.Forms.Label AuthorLabel;
        public System.Windows.Forms.TabPage RushingTab;
        public System.Windows.Forms.TabControl rushingTabControl;
        public System.Windows.Forms.TabPage MainTab;
        public System.Windows.Forms.Label ProcessNameLabel;
        public System.Windows.Forms.TextBox ProcessName;
        public System.Windows.Forms.TextBox RotMGProcess;
        public System.Windows.Forms.Panel OptionsPanel;
        public System.Windows.Forms.Label OptionsWarningLabel2;
        public System.Windows.Forms.Label OptionsWarningLabel1;
        public System.Windows.Forms.Button HotkeyButton0;
        public System.Windows.Forms.TextBox HotkeyBox0;
        public System.Windows.Forms.Label OptionsLabel;
        public System.Windows.Forms.Label RotMGFound;
        public System.Windows.Forms.TabControl mainTabControl;
        public System.Windows.Forms.TabPage GameInfoTab;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox WindowYBox;
        public System.Windows.Forms.TextBox WindowWidthBox;
        public System.Windows.Forms.TextBox WindowHeightBox;
        public System.Windows.Forms.TextBox WindowXBox;
        public System.Windows.Forms.Label WindowHeightLabel;
        public System.Windows.Forms.Label WindowWidthLabel;
        public System.Windows.Forms.Label WindowYLabel;
        public System.Windows.Forms.Label WindowXLabel;
        public System.Windows.Forms.Label WindowInfoLabel;
        public System.Windows.Forms.TextBox ConsoleInput;
        public System.Windows.Forms.Button ConsoleSend;
        public System.Windows.Forms.LinkLabel GitHubLink;
    }
}

