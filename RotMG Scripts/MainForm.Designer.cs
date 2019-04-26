using System.Drawing;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TitleBarPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MinimizeButton = new RotMG_Scripts.TitleBarButton();
            this.ExitButton = new RotMG_Scripts.TitleBarButton();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.UpdateDelayLabel = new System.Windows.Forms.Label();
            this.SeachDelayLabel = new System.Windows.Forms.Label();
            this.MainTabControl = new RotMG_Scripts.CustomTabControl();
            this.MainTab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MainPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.OptionsLabel = new System.Windows.Forms.Label();
            this.HotkeyBox0 = new System.Windows.Forms.TextBox();
            this.HotkeyButton0 = new RotMG_Scripts.CustomButton();
            this.AspectRatioGroup = new RotMG_Scripts.CustomGroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AspectFourThree = new System.Windows.Forms.CheckBox();
            this.AspectSixteenNine = new System.Windows.Forms.CheckBox();
            this.AspectNone = new System.Windows.Forms.CheckBox();
            this.AspectOneOne = new System.Windows.Forms.CheckBox();
            this.MainPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ProcessName = new System.Windows.Forms.TextBox();
            this.ProcessNameLabel = new System.Windows.Forms.Label();
            this.RotMGProcess = new System.Windows.Forms.TextBox();
            this.RotMGFound = new System.Windows.Forms.Label();
            this.UpdateDelayInput = new System.Windows.Forms.NumericUpDown();
            this.SearchDelayInput = new System.Windows.Forms.NumericUpDown();
            this.RushingTab = new System.Windows.Forms.TabPage();
            this.RushingTabControl = new RotMG_Scripts.CustomTabControl();
            this.GameInfoTab = new System.Windows.Forms.TabPage();
            this.GameInfoPanel = new System.Windows.Forms.Panel();
            this.GameInfoPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.WindowWidthLabel = new System.Windows.Forms.Label();
            this.WindowHeightBox = new System.Windows.Forms.TextBox();
            this.WindowXBox = new System.Windows.Forms.TextBox();
            this.WindowXLabel = new System.Windows.Forms.Label();
            this.WindowWidthBox = new System.Windows.Forms.TextBox();
            this.WindowYLabel = new System.Windows.Forms.Label();
            this.WindowHeightLabel = new System.Windows.Forms.Label();
            this.WindowYBox = new System.Windows.Forms.TextBox();
            this.WindowInfoLabel = new System.Windows.Forms.Label();
            this.DebuggingTab = new System.Windows.Forms.TabPage();
            this.DebugTabControl = new RotMG_Scripts.CustomTabControl();
            this.ConsoleTab = new System.Windows.Forms.TabPage();
            this.ConsolePanel = new System.Windows.Forms.Panel();
            this.RichConsoleText = new System.Windows.Forms.RichTextBox();
            this.ConsoleSendButton = new RotMG_Scripts.CustomButton();
            this.ConsoleInput = new System.Windows.Forms.TextBox();
            this.ProgramInfoTab = new System.Windows.Forms.TabPage();
            this.DebuggingInfoPanel = new System.Windows.Forms.Panel();
            this.DebuggingInfoPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.lilypadLabel = new System.Windows.Forms.Label();
            this.GitHubLink = new System.Windows.Forms.LinkLabel();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.VersionNumberLabel = new System.Windows.Forms.Label();
            this.DebuggingInfoPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TitleBarPanel.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.MainPanel2.SuspendLayout();
            this.AspectRatioGroup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.MainPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateDelayInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchDelayInput)).BeginInit();
            this.RushingTab.SuspendLayout();
            this.GameInfoTab.SuspendLayout();
            this.GameInfoPanel.SuspendLayout();
            this.GameInfoPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.DebuggingTab.SuspendLayout();
            this.DebugTabControl.SuspendLayout();
            this.ConsoleTab.SuspendLayout();
            this.ConsolePanel.SuspendLayout();
            this.ProgramInfoTab.SuspendLayout();
            this.DebuggingInfoPanel.SuspendLayout();
            this.DebuggingInfoPanel2.SuspendLayout();
            this.DebuggingInfoPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBarPanel
            // 
            this.TitleBarPanel.BackColor = System.Drawing.Color.Transparent;
            this.TitleBarPanel.Controls.Add(this.TitleLabel);
            this.TitleBarPanel.Controls.Add(this.MinimizeButton);
            this.TitleBarPanel.Controls.Add(this.ExitButton);
            this.TitleBarPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TitleBarPanel.Name = "TitleBarPanel";
            this.TitleBarPanel.Size = new System.Drawing.Size(550, 30);
            this.TitleBarPanel.TabIndex = 27;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(34, 6);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(96, 17);
            this.TitleLabel.TabIndex = 29;
            this.TitleLabel.Text = "RotMG Scripts ";
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.Gray;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold);
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(440, -2);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(55, 32);
            this.MinimizeButton.TabIndex = 28;
            this.MinimizeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MinimizeButton.UseCompatibleTextRendering = true;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Marlett", 12F);
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(495, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(55, 30);
            this.ExitButton.TabIndex = 27;
            this.ExitButton.UseVisualStyleBackColor = false;
            // 
            // UpdateDelayLabel
            // 
            this.UpdateDelayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateDelayLabel.AutoSize = true;
            this.UpdateDelayLabel.BackColor = System.Drawing.Color.Transparent;
            this.UpdateDelayLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDelayLabel.ForeColor = System.Drawing.Color.White;
            this.UpdateDelayLabel.Location = new System.Drawing.Point(304, 141);
            this.UpdateDelayLabel.Name = "UpdateDelayLabel";
            this.UpdateDelayLabel.Size = new System.Drawing.Size(119, 17);
            this.UpdateDelayLabel.TabIndex = 23;
            this.UpdateDelayLabel.Text = "Update Delay (ms):";
            this.ToolTip.SetToolTip(this.UpdateDelayLabel, "Delay is milliseconds to update the game data when the game is found.");
            // 
            // SeachDelayLabel
            // 
            this.SeachDelayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SeachDelayLabel.AutoSize = true;
            this.SeachDelayLabel.BackColor = System.Drawing.Color.Transparent;
            this.SeachDelayLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeachDelayLabel.ForeColor = System.Drawing.Color.White;
            this.SeachDelayLabel.Location = new System.Drawing.Point(98, 141);
            this.SeachDelayLabel.Name = "SeachDelayLabel";
            this.SeachDelayLabel.Size = new System.Drawing.Size(115, 17);
            this.SeachDelayLabel.TabIndex = 21;
            this.SeachDelayLabel.Text = "Search Delay (ms):";
            this.ToolTip.SetToolTip(this.SeachDelayLabel, "Delay in milliseconds to re-search for the program when it is not found.");
            // 
            // MainTabControl
            // 
            this.MainTabControl.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(105)))), ((int)(((byte)(199)))));
            this.MainTabControl.AllowDrop = true;
            this.MainTabControl.BackTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(105)))), ((int)(((byte)(199)))));
            this.MainTabControl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MainTabControl.Controls.Add(this.MainTab);
            this.MainTabControl.Controls.Add(this.RushingTab);
            this.MainTabControl.Controls.Add(this.GameInfoTab);
            this.MainTabControl.Controls.Add(this.DebuggingTab);
            this.MainTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.MainTabControl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTabControl.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainTabControl.HorizontalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(105)))), ((int)(((byte)(199)))));
            this.MainTabControl.ItemSize = new System.Drawing.Size(240, 28);
            this.MainTabControl.Location = new System.Drawing.Point(10, 30);
            this.MainTabControl.Multiline = true;
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.Padding = new System.Drawing.Point(10, 0);
            this.MainTabControl.RightToLeftLayout = true;
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(530, 540);
            this.MainTabControl.TabIndex = 1;
            this.MainTabControl.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // MainTab
            // 
            this.MainTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(105)))), ((int)(((byte)(199)))));
            this.MainTab.Controls.Add(this.panel2);
            this.MainTab.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainTab.Location = new System.Drawing.Point(4, 32);
            this.MainTab.Name = "MainTab";
            this.MainTab.Padding = new System.Windows.Forms.Padding(3);
            this.MainTab.Size = new System.Drawing.Size(522, 504);
            this.MainTab.TabIndex = 0;
            this.MainTab.Text = "Main";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.MainPanel2);
            this.panel2.Controls.Add(this.MainPanel1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 508);
            this.panel2.TabIndex = 27;
            // 
            // MainPanel2
            // 
            this.MainPanel2.ColumnCount = 1;
            this.MainPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainPanel2.Controls.Add(this.OptionsLabel, 0, 1);
            this.MainPanel2.Controls.Add(this.HotkeyBox0, 0, 2);
            this.MainPanel2.Controls.Add(this.HotkeyButton0, 0, 3);
            this.MainPanel2.Controls.Add(this.AspectRatioGroup, 0, 5);
            this.MainPanel2.Location = new System.Drawing.Point(0, 230);
            this.MainPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel2.Name = "MainPanel2";
            this.MainPanel2.RowCount = 6;
            this.MainPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.MainPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.MainPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.MainPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MainPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.MainPanel2.Size = new System.Drawing.Size(522, 274);
            this.MainPanel2.TabIndex = 28;
            // 
            // OptionsLabel
            // 
            this.OptionsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OptionsLabel.AutoSize = true;
            this.OptionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.OptionsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsLabel.ForeColor = System.Drawing.Color.White;
            this.OptionsLabel.Location = new System.Drawing.Point(220, 39);
            this.OptionsLabel.Name = "OptionsLabel";
            this.OptionsLabel.Size = new System.Drawing.Size(82, 17);
            this.OptionsLabel.TabIndex = 9;
            this.OptionsLabel.Text = "Options Key:";
            // 
            // HotkeyBox0
            // 
            this.HotkeyBox0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HotkeyBox0.BackColor = System.Drawing.Color.Gray;
            this.HotkeyBox0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HotkeyBox0.Cursor = System.Windows.Forms.Cursors.Default;
            this.HotkeyBox0.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotkeyBox0.Location = new System.Drawing.Point(192, 65);
            this.HotkeyBox0.Name = "HotkeyBox0";
            this.HotkeyBox0.ReadOnly = true;
            this.HotkeyBox0.Size = new System.Drawing.Size(137, 25);
            this.HotkeyBox0.TabIndex = 12;
            this.HotkeyBox0.Text = "N/A";
            this.HotkeyBox0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HotkeyButton0
            // 
            this.HotkeyButton0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HotkeyButton0.BackColor = System.Drawing.Color.White;
            this.HotkeyButton0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HotkeyButton0.FlatAppearance.BorderSize = 0;
            this.HotkeyButton0.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotkeyButton0.Location = new System.Drawing.Point(211, 104);
            this.HotkeyButton0.Margin = new System.Windows.Forms.Padding(0);
            this.HotkeyButton0.Name = "HotkeyButton0";
            this.HotkeyButton0.Size = new System.Drawing.Size(100, 27);
            this.HotkeyButton0.TabIndex = 18;
            this.HotkeyButton0.Text = "Edit...";
            this.HotkeyButton0.UseVisualStyleBackColor = false;
            // 
            // AspectRatioGroup
            // 
            this.AspectRatioGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AspectRatioGroup.BackColor = System.Drawing.Color.Transparent;
            this.AspectRatioGroup.Controls.Add(this.tableLayoutPanel1);
            this.AspectRatioGroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AspectRatioGroup.ForeColor = System.Drawing.Color.White;
            this.AspectRatioGroup.Location = new System.Drawing.Point(169, 174);
            this.AspectRatioGroup.Name = "AspectRatioGroup";
            this.AspectRatioGroup.Size = new System.Drawing.Size(184, 88);
            this.AspectRatioGroup.TabIndex = 26;
            this.AspectRatioGroup.TabStop = false;
            this.AspectRatioGroup.Text = "Lock Game To Aspect Ratio";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.90909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.90909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.Controls.Add(this.AspectFourThree, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.AspectSixteenNine, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.AspectNone, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.AspectOneOne, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(178, 70);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // AspectFourThree
            // 
            this.AspectFourThree.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AspectFourThree.AutoSize = true;
            this.AspectFourThree.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AspectFourThree.ForeColor = System.Drawing.Color.White;
            this.AspectFourThree.Location = new System.Drawing.Point(19, 7);
            this.AspectFourThree.Name = "AspectFourThree";
            this.AspectFourThree.Size = new System.Drawing.Size(44, 21);
            this.AspectFourThree.TabIndex = 0;
            this.AspectFourThree.Text = "4:3";
            this.AspectFourThree.UseVisualStyleBackColor = true;
            // 
            // AspectSixteenNine
            // 
            this.AspectSixteenNine.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AspectSixteenNine.AutoSize = true;
            this.AspectSixteenNine.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AspectSixteenNine.ForeColor = System.Drawing.Color.White;
            this.AspectSixteenNine.Location = new System.Drawing.Point(19, 42);
            this.AspectSixteenNine.Name = "AspectSixteenNine";
            this.AspectSixteenNine.Size = new System.Drawing.Size(51, 21);
            this.AspectSixteenNine.TabIndex = 1;
            this.AspectSixteenNine.Text = "16:9";
            this.AspectSixteenNine.UseVisualStyleBackColor = true;
            // 
            // AspectNone
            // 
            this.AspectNone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AspectNone.AutoSize = true;
            this.AspectNone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AspectNone.ForeColor = System.Drawing.Color.White;
            this.AspectNone.Location = new System.Drawing.Point(91, 42);
            this.AspectNone.Name = "AspectNone";
            this.AspectNone.Size = new System.Drawing.Size(59, 21);
            this.AspectNone.TabIndex = 3;
            this.AspectNone.Text = "None";
            this.AspectNone.UseVisualStyleBackColor = true;
            // 
            // AspectOneOne
            // 
            this.AspectOneOne.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AspectOneOne.AutoSize = true;
            this.AspectOneOne.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AspectOneOne.ForeColor = System.Drawing.Color.White;
            this.AspectOneOne.Location = new System.Drawing.Point(91, 7);
            this.AspectOneOne.Name = "AspectOneOne";
            this.AspectOneOne.Size = new System.Drawing.Size(44, 21);
            this.AspectOneOne.TabIndex = 2;
            this.AspectOneOne.Text = "1:1";
            this.AspectOneOne.UseVisualStyleBackColor = true;
            // 
            // MainPanel1
            // 
            this.MainPanel1.ColumnCount = 4;
            this.MainPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MainPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MainPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainPanel1.Controls.Add(this.ProcessName, 2, 2);
            this.MainPanel1.Controls.Add(this.ProcessNameLabel, 2, 1);
            this.MainPanel1.Controls.Add(this.RotMGProcess, 1, 2);
            this.MainPanel1.Controls.Add(this.RotMGFound, 1, 1);
            this.MainPanel1.Controls.Add(this.UpdateDelayInput, 2, 5);
            this.MainPanel1.Controls.Add(this.UpdateDelayLabel, 2, 4);
            this.MainPanel1.Controls.Add(this.SeachDelayLabel, 1, 4);
            this.MainPanel1.Controls.Add(this.SearchDelayInput, 1, 5);
            this.MainPanel1.Location = new System.Drawing.Point(0, 8);
            this.MainPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel1.Name = "MainPanel1";
            this.MainPanel1.RowCount = 7;
            this.MainPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.MainPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.MainPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.MainPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainPanel1.Size = new System.Drawing.Size(522, 221);
            this.MainPanel1.TabIndex = 27;
            // 
            // ProcessName
            // 
            this.ProcessName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProcessName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessName.Location = new System.Drawing.Point(289, 87);
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.Size = new System.Drawing.Size(150, 25);
            this.ProcessName.TabIndex = 4;
            this.ProcessName.Text = "flashplayer";
            this.ProcessName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProcessNameLabel
            // 
            this.ProcessNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProcessNameLabel.AutoSize = true;
            this.ProcessNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProcessNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessNameLabel.ForeColor = System.Drawing.Color.White;
            this.ProcessNameLabel.Location = new System.Drawing.Point(316, 61);
            this.ProcessNameLabel.Name = "ProcessNameLabel";
            this.ProcessNameLabel.Size = new System.Drawing.Size(95, 17);
            this.ProcessNameLabel.TabIndex = 5;
            this.ProcessNameLabel.Text = "Process Name:";
            // 
            // RotMGProcess
            // 
            this.RotMGProcess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RotMGProcess.BackColor = System.Drawing.Color.Gray;
            this.RotMGProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RotMGProcess.Cursor = System.Windows.Forms.Cursors.Default;
            this.RotMGProcess.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RotMGProcess.Location = new System.Drawing.Point(81, 87);
            this.RotMGProcess.Name = "RotMGProcess";
            this.RotMGProcess.ReadOnly = true;
            this.RotMGProcess.Size = new System.Drawing.Size(150, 25);
            this.RotMGProcess.TabIndex = 1;
            this.RotMGProcess.Text = "Not Found...";
            this.RotMGProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RotMGFound
            // 
            this.RotMGFound.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RotMGFound.AutoSize = true;
            this.RotMGFound.BackColor = System.Drawing.Color.Transparent;
            this.RotMGFound.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RotMGFound.ForeColor = System.Drawing.Color.White;
            this.RotMGFound.Location = new System.Drawing.Point(110, 61);
            this.RotMGFound.Name = "RotMGFound";
            this.RotMGFound.Size = new System.Drawing.Size(92, 17);
            this.RotMGFound.TabIndex = 0;
            this.RotMGFound.Text = "RotMG Found:";
            // 
            // UpdateDelayInput
            // 
            this.UpdateDelayInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateDelayInput.BackColor = System.Drawing.SystemColors.Control;
            this.UpdateDelayInput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDelayInput.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.UpdateDelayInput.Location = new System.Drawing.Point(289, 167);
            this.UpdateDelayInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.UpdateDelayInput.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.UpdateDelayInput.Name = "UpdateDelayInput";
            this.UpdateDelayInput.Size = new System.Drawing.Size(150, 25);
            this.UpdateDelayInput.TabIndex = 24;
            this.UpdateDelayInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpdateDelayInput.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // SearchDelayInput
            // 
            this.SearchDelayInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchDelayInput.BackColor = System.Drawing.SystemColors.Control;
            this.SearchDelayInput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchDelayInput.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.SearchDelayInput.Location = new System.Drawing.Point(81, 167);
            this.SearchDelayInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SearchDelayInput.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.SearchDelayInput.Name = "SearchDelayInput";
            this.SearchDelayInput.Size = new System.Drawing.Size(150, 25);
            this.SearchDelayInput.TabIndex = 22;
            this.SearchDelayInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchDelayInput.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // RushingTab
            // 
            this.RushingTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(105)))), ((int)(((byte)(199)))));
            this.RushingTab.Controls.Add(this.RushingTabControl);
            this.RushingTab.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushingTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RushingTab.Location = new System.Drawing.Point(4, 32);
            this.RushingTab.Name = "RushingTab";
            this.RushingTab.Padding = new System.Windows.Forms.Padding(3);
            this.RushingTab.Size = new System.Drawing.Size(522, 504);
            this.RushingTab.TabIndex = 1;
            this.RushingTab.Text = "Rushing";
            // 
            // RushingTabControl
            // 
            this.RushingTabControl.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.RushingTabControl.AllowDrop = true;
            this.RushingTabControl.BackTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.RushingTabControl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RushingTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.RushingTabControl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushingTabControl.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.RushingTabControl.HorizontalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.RushingTabControl.ItemSize = new System.Drawing.Size(240, 28);
            this.RushingTabControl.Location = new System.Drawing.Point(2, 2);
            this.RushingTabControl.Multiline = true;
            this.RushingTabControl.Name = "RushingTabControl";
            this.RushingTabControl.Padding = new System.Drawing.Point(10, 0);
            this.RushingTabControl.RightToLeftLayout = true;
            this.RushingTabControl.SelectedIndex = 0;
            this.RushingTabControl.Size = new System.Drawing.Size(519, 501);
            this.RushingTabControl.TabIndex = 3;
            this.RushingTabControl.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // GameInfoTab
            // 
            this.GameInfoTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(105)))), ((int)(((byte)(199)))));
            this.GameInfoTab.Controls.Add(this.GameInfoPanel);
            this.GameInfoTab.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameInfoTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GameInfoTab.Location = new System.Drawing.Point(4, 32);
            this.GameInfoTab.Name = "GameInfoTab";
            this.GameInfoTab.Size = new System.Drawing.Size(522, 504);
            this.GameInfoTab.TabIndex = 6;
            this.GameInfoTab.Text = "Game Info";
            // 
            // GameInfoPanel
            // 
            this.GameInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.GameInfoPanel.Controls.Add(this.GameInfoPanel1);
            this.GameInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.GameInfoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.GameInfoPanel.Name = "GameInfoPanel";
            this.GameInfoPanel.Size = new System.Drawing.Size(522, 504);
            this.GameInfoPanel.TabIndex = 27;
            // 
            // GameInfoPanel1
            // 
            this.GameInfoPanel1.ColumnCount = 4;
            this.GameInfoPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.GameInfoPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.GameInfoPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.GameInfoPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.GameInfoPanel1.Controls.Add(this.tableLayoutPanel4, 2, 0);
            this.GameInfoPanel1.Controls.Add(this.WindowInfoLabel, 1, 0);
            this.GameInfoPanel1.Location = new System.Drawing.Point(0, 8);
            this.GameInfoPanel1.Name = "GameInfoPanel1";
            this.GameInfoPanel1.RowCount = 1;
            this.GameInfoPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GameInfoPanel1.Size = new System.Drawing.Size(522, 64);
            this.GameInfoPanel1.TabIndex = 27;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.Controls.Add(this.WindowWidthLabel, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.WindowHeightBox, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.WindowXBox, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.WindowXLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.WindowWidthBox, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.WindowYLabel, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.WindowHeightLabel, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.WindowYBox, 1, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(230, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(209, 58);
            this.tableLayoutPanel4.TabIndex = 28;
            // 
            // WindowWidthLabel
            // 
            this.WindowWidthLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.WindowWidthLabel.AutoSize = true;
            this.WindowWidthLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowWidthLabel.ForeColor = System.Drawing.Color.White;
            this.WindowWidthLabel.Location = new System.Drawing.Point(111, 6);
            this.WindowWidthLabel.Name = "WindowWidthLabel";
            this.WindowWidthLabel.Size = new System.Drawing.Size(45, 17);
            this.WindowWidthLabel.TabIndex = 3;
            this.WindowWidthLabel.Text = "Width:";
            // 
            // WindowHeightBox
            // 
            this.WindowHeightBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WindowHeightBox.BackColor = System.Drawing.Color.Gray;
            this.WindowHeightBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WindowHeightBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.WindowHeightBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowHeightBox.Location = new System.Drawing.Point(164, 32);
            this.WindowHeightBox.Name = "WindowHeightBox";
            this.WindowHeightBox.ReadOnly = true;
            this.WindowHeightBox.Size = new System.Drawing.Size(40, 25);
            this.WindowHeightBox.TabIndex = 6;
            this.WindowHeightBox.Text = "N/A";
            this.WindowHeightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WindowXBox
            // 
            this.WindowXBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WindowXBox.BackColor = System.Drawing.Color.Gray;
            this.WindowXBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WindowXBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.WindowXBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowXBox.Location = new System.Drawing.Point(35, 3);
            this.WindowXBox.Name = "WindowXBox";
            this.WindowXBox.ReadOnly = true;
            this.WindowXBox.Size = new System.Drawing.Size(40, 25);
            this.WindowXBox.TabIndex = 5;
            this.WindowXBox.Text = "N/A";
            this.WindowXBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WindowXLabel
            // 
            this.WindowXLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.WindowXLabel.AutoSize = true;
            this.WindowXLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowXLabel.ForeColor = System.Drawing.Color.White;
            this.WindowXLabel.Location = new System.Drawing.Point(8, 6);
            this.WindowXLabel.Name = "WindowXLabel";
            this.WindowXLabel.Size = new System.Drawing.Size(19, 17);
            this.WindowXLabel.TabIndex = 1;
            this.WindowXLabel.Text = "X:";
            // 
            // WindowWidthBox
            // 
            this.WindowWidthBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WindowWidthBox.BackColor = System.Drawing.Color.Gray;
            this.WindowWidthBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WindowWidthBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.WindowWidthBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowWidthBox.Location = new System.Drawing.Point(164, 3);
            this.WindowWidthBox.Name = "WindowWidthBox";
            this.WindowWidthBox.ReadOnly = true;
            this.WindowWidthBox.Size = new System.Drawing.Size(40, 25);
            this.WindowWidthBox.TabIndex = 7;
            this.WindowWidthBox.Text = "N/A";
            this.WindowWidthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WindowYLabel
            // 
            this.WindowYLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.WindowYLabel.AutoSize = true;
            this.WindowYLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowYLabel.ForeColor = System.Drawing.Color.White;
            this.WindowYLabel.Location = new System.Drawing.Point(9, 35);
            this.WindowYLabel.Name = "WindowYLabel";
            this.WindowYLabel.Size = new System.Drawing.Size(18, 17);
            this.WindowYLabel.TabIndex = 2;
            this.WindowYLabel.Text = "Y:";
            // 
            // WindowHeightLabel
            // 
            this.WindowHeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.WindowHeightLabel.AutoSize = true;
            this.WindowHeightLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowHeightLabel.ForeColor = System.Drawing.Color.White;
            this.WindowHeightLabel.Location = new System.Drawing.Point(107, 35);
            this.WindowHeightLabel.Name = "WindowHeightLabel";
            this.WindowHeightLabel.Size = new System.Drawing.Size(49, 17);
            this.WindowHeightLabel.TabIndex = 4;
            this.WindowHeightLabel.Text = "Height:";
            // 
            // WindowYBox
            // 
            this.WindowYBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WindowYBox.BackColor = System.Drawing.Color.Gray;
            this.WindowYBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WindowYBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.WindowYBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowYBox.Location = new System.Drawing.Point(35, 32);
            this.WindowYBox.Name = "WindowYBox";
            this.WindowYBox.ReadOnly = true;
            this.WindowYBox.Size = new System.Drawing.Size(40, 25);
            this.WindowYBox.TabIndex = 8;
            this.WindowYBox.Text = "N/A";
            this.WindowYBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WindowInfoLabel
            // 
            this.WindowInfoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WindowInfoLabel.AutoSize = true;
            this.WindowInfoLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowInfoLabel.ForeColor = System.Drawing.Color.White;
            this.WindowInfoLabel.Location = new System.Drawing.Point(69, 23);
            this.WindowInfoLabel.Name = "WindowInfoLabel";
            this.WindowInfoLabel.Size = new System.Drawing.Size(122, 17);
            this.WindowInfoLabel.TabIndex = 0;
            this.WindowInfoLabel.Text = "Game Window Info:";
            // 
            // DebuggingTab
            // 
            this.DebuggingTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(105)))), ((int)(((byte)(199)))));
            this.DebuggingTab.Controls.Add(this.DebugTabControl);
            this.DebuggingTab.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebuggingTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DebuggingTab.Location = new System.Drawing.Point(4, 32);
            this.DebuggingTab.Name = "DebuggingTab";
            this.DebuggingTab.Size = new System.Drawing.Size(522, 504);
            this.DebuggingTab.TabIndex = 5;
            this.DebuggingTab.Text = "Debugging";
            // 
            // DebugTabControl
            // 
            this.DebugTabControl.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.DebugTabControl.AllowDrop = true;
            this.DebugTabControl.BackTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.DebugTabControl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DebugTabControl.Controls.Add(this.ConsoleTab);
            this.DebugTabControl.Controls.Add(this.ProgramInfoTab);
            this.DebugTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.DebugTabControl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebugTabControl.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DebugTabControl.HorizontalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.DebugTabControl.ItemSize = new System.Drawing.Size(240, 28);
            this.DebugTabControl.Location = new System.Drawing.Point(0, 1);
            this.DebugTabControl.Multiline = true;
            this.DebugTabControl.Name = "DebugTabControl";
            this.DebugTabControl.Padding = new System.Drawing.Point(10, 0);
            this.DebugTabControl.RightToLeftLayout = true;
            this.DebugTabControl.SelectedIndex = 0;
            this.DebugTabControl.Size = new System.Drawing.Size(519, 501);
            this.DebugTabControl.TabIndex = 2;
            this.DebugTabControl.TextColor = System.Drawing.Color.White;
            // 
            // ConsoleTab
            // 
            this.ConsoleTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.ConsoleTab.Controls.Add(this.ConsolePanel);
            this.ConsoleTab.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConsoleTab.Location = new System.Drawing.Point(4, 32);
            this.ConsoleTab.Name = "ConsoleTab";
            this.ConsoleTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConsoleTab.Size = new System.Drawing.Size(511, 465);
            this.ConsoleTab.TabIndex = 0;
            this.ConsoleTab.Text = "Console";
            // 
            // ConsolePanel
            // 
            this.ConsolePanel.BackColor = System.Drawing.Color.Black;
            this.ConsolePanel.Controls.Add(this.RichConsoleText);
            this.ConsolePanel.Controls.Add(this.ConsoleSendButton);
            this.ConsolePanel.Controls.Add(this.ConsoleInput);
            this.ConsolePanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsolePanel.Location = new System.Drawing.Point(0, 0);
            this.ConsolePanel.Name = "ConsolePanel";
            this.ConsolePanel.Size = new System.Drawing.Size(518, 465);
            this.ConsolePanel.TabIndex = 27;
            // 
            // RichConsoleText
            // 
            this.RichConsoleText.BackColor = System.Drawing.Color.Black;
            this.RichConsoleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichConsoleText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichConsoleText.ForeColor = System.Drawing.Color.Lime;
            this.RichConsoleText.Location = new System.Drawing.Point(0, 2);
            this.RichConsoleText.Name = "RichConsoleText";
            this.RichConsoleText.ReadOnly = true;
            this.RichConsoleText.Size = new System.Drawing.Size(511, 429);
            this.RichConsoleText.TabIndex = 3;
            this.RichConsoleText.Text = "";
            // 
            // ConsoleSendButton
            // 
            this.ConsoleSendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ConsoleSendButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ConsoleSendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsoleSendButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleSendButton.ForeColor = System.Drawing.Color.Aqua;
            this.ConsoleSendButton.Location = new System.Drawing.Point(431, 437);
            this.ConsoleSendButton.Name = "ConsoleSendButton";
            this.ConsoleSendButton.Size = new System.Drawing.Size(77, 25);
            this.ConsoleSendButton.TabIndex = 2;
            this.ConsoleSendButton.TabStop = false;
            this.ConsoleSendButton.Text = "Send";
            this.ConsoleSendButton.UseVisualStyleBackColor = false;
            // 
            // ConsoleInput
            // 
            this.ConsoleInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ConsoleInput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleInput.ForeColor = System.Drawing.Color.Aqua;
            this.ConsoleInput.Location = new System.Drawing.Point(3, 437);
            this.ConsoleInput.Name = "ConsoleInput";
            this.ConsoleInput.Size = new System.Drawing.Size(424, 25);
            this.ConsoleInput.TabIndex = 1;
            // 
            // ProgramInfoTab
            // 
            this.ProgramInfoTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.ProgramInfoTab.Controls.Add(this.DebuggingInfoPanel);
            this.ProgramInfoTab.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramInfoTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ProgramInfoTab.Location = new System.Drawing.Point(4, 32);
            this.ProgramInfoTab.Name = "ProgramInfoTab";
            this.ProgramInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProgramInfoTab.Size = new System.Drawing.Size(511, 465);
            this.ProgramInfoTab.TabIndex = 1;
            this.ProgramInfoTab.Text = "Info";
            // 
            // DebuggingInfoPanel
            // 
            this.DebuggingInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.DebuggingInfoPanel.Controls.Add(this.DebuggingInfoPanel2);
            this.DebuggingInfoPanel.Controls.Add(this.DebuggingInfoPanel1);
            this.DebuggingInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.DebuggingInfoPanel.Name = "DebuggingInfoPanel";
            this.DebuggingInfoPanel.Size = new System.Drawing.Size(511, 465);
            this.DebuggingInfoPanel.TabIndex = 17;
            // 
            // DebuggingInfoPanel2
            // 
            this.DebuggingInfoPanel2.ColumnCount = 3;
            this.DebuggingInfoPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.DebuggingInfoPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.DebuggingInfoPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DebuggingInfoPanel2.Controls.Add(this.label5, 0, 0);
            this.DebuggingInfoPanel2.Controls.Add(this.lilypadLabel, 2, 0);
            this.DebuggingInfoPanel2.Controls.Add(this.GitHubLink, 2, 2);
            this.DebuggingInfoPanel2.Controls.Add(this.VersionLabel, 0, 1);
            this.DebuggingInfoPanel2.Controls.Add(this.label4, 0, 2);
            this.DebuggingInfoPanel2.Controls.Add(this.VersionNumberLabel, 2, 1);
            this.DebuggingInfoPanel2.Location = new System.Drawing.Point(19, 137);
            this.DebuggingInfoPanel2.Name = "DebuggingInfoPanel2";
            this.DebuggingInfoPanel2.RowCount = 3;
            this.DebuggingInfoPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.DebuggingInfoPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.DebuggingInfoPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.DebuggingInfoPanel2.Size = new System.Drawing.Size(471, 75);
            this.DebuggingInfoPanel2.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(46, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Author:";
            // 
            // lilypadLabel
            // 
            this.lilypadLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lilypadLabel.AutoSize = true;
            this.lilypadLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lilypadLabel.ForeColor = System.Drawing.Color.White;
            this.lilypadLabel.Location = new System.Drawing.Point(138, 2);
            this.lilypadLabel.Name = "lilypadLabel";
            this.lilypadLabel.Size = new System.Drawing.Size(44, 21);
            this.lilypadLabel.TabIndex = 12;
            this.lilypadLabel.Text = "Lilypad-666";
            // 
            // GitHubLink
            // 
            this.GitHubLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.GitHubLink.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GitHubLink.AutoSize = true;
            this.GitHubLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GitHubLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.GitHubLink.Location = new System.Drawing.Point(138, 52);
            this.GitHubLink.Name = "GitHubLink";
            this.GitHubLink.Size = new System.Drawing.Size(59, 21);
            this.GitHubLink.TabIndex = 16;
            this.GitHubLink.TabStop = true;
            this.GitHubLink.Tag = "";
            this.GitHubLink.Text = "GitHub";
            this.GitHubLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            // 
            // VersionLabel
            // 
            this.VersionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.ForeColor = System.Drawing.Color.White;
            this.VersionLabel.Location = new System.Drawing.Point(38, 27);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(69, 21);
            this.VersionLabel.TabIndex = 15;
            this.VersionLabel.Text = "Version: ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Source Code:";
            // 
            // VersionNumberLabel
            // 
            this.VersionNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VersionNumberLabel.AutoSize = true;
            this.VersionNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionNumberLabel.ForeColor = System.Drawing.Color.White;
            this.VersionNumberLabel.Location = new System.Drawing.Point(138, 27);
            this.VersionNumberLabel.Name = "VersionNumberLabel";
            this.VersionNumberLabel.Size = new System.Drawing.Size(0, 21);
            this.VersionNumberLabel.TabIndex = 16;
            // 
            // DebuggingInfoPanel1
            // 
            this.DebuggingInfoPanel1.ColumnCount = 1;
            this.DebuggingInfoPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DebuggingInfoPanel1.Controls.Add(this.label3, 0, 0);
            this.DebuggingInfoPanel1.Controls.Add(this.label2, 0, 1);
            this.DebuggingInfoPanel1.Location = new System.Drawing.Point(2, 21);
            this.DebuggingInfoPanel1.Name = "DebuggingInfoPanel1";
            this.DebuggingInfoPanel1.RowCount = 2;
            this.DebuggingInfoPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.DebuggingInfoPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.DebuggingInfoPanel1.Size = new System.Drawing.Size(508, 50);
            this.DebuggingInfoPanel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(442, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = " If you downloaded this anywhere other than MPGH or Github,";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(97, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "immediately change your RotMG password.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(550, 580);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.TitleBarPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "RotMG Scripts ";
            this.TitleBarPanel.ResumeLayout(false);
            this.TitleBarPanel.PerformLayout();
            this.MainTabControl.ResumeLayout(false);
            this.MainTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.MainPanel2.ResumeLayout(false);
            this.MainPanel2.PerformLayout();
            this.AspectRatioGroup.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.MainPanel1.ResumeLayout(false);
            this.MainPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateDelayInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchDelayInput)).EndInit();
            this.RushingTab.ResumeLayout(false);
            this.GameInfoTab.ResumeLayout(false);
            this.GameInfoPanel.ResumeLayout(false);
            this.GameInfoPanel1.ResumeLayout(false);
            this.GameInfoPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.DebuggingTab.ResumeLayout(false);
            this.DebugTabControl.ResumeLayout(false);
            this.ConsoleTab.ResumeLayout(false);
            this.ConsolePanel.ResumeLayout(false);
            this.ConsolePanel.PerformLayout();
            this.ProgramInfoTab.ResumeLayout(false);
            this.DebuggingInfoPanel.ResumeLayout(false);
            this.DebuggingInfoPanel2.ResumeLayout(false);
            this.DebuggingInfoPanel2.PerformLayout();
            this.DebuggingInfoPanel1.ResumeLayout(false);
            this.DebuggingInfoPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabPage DebuggingTab;
        public System.Windows.Forms.TabPage RushingTab;
        public System.Windows.Forms.Label ProcessNameLabel;
        public System.Windows.Forms.TextBox ProcessName;
        public System.Windows.Forms.TextBox RotMGProcess;
        public CustomButton HotkeyButton0;
        public System.Windows.Forms.TextBox HotkeyBox0;
        public System.Windows.Forms.Label OptionsLabel;
        public System.Windows.Forms.Label RotMGFound;
        public System.Windows.Forms.TabPage GameInfoTab;
        public System.Windows.Forms.NumericUpDown SearchDelayInput;
        public System.Windows.Forms.Label SeachDelayLabel;
        public System.Windows.Forms.NumericUpDown UpdateDelayInput;
        public System.Windows.Forms.Label UpdateDelayLabel;
        public CustomGroupBox AspectRatioGroup;
        public System.Windows.Forms.CheckBox AspectNone;
        public System.Windows.Forms.CheckBox AspectOneOne;
        public System.Windows.Forms.CheckBox AspectSixteenNine;
        public System.Windows.Forms.CheckBox AspectFourThree;
        public CustomTabControl MainTabControl;
        public System.Windows.Forms.Panel TitleBarPanel;
        public System.Windows.Forms.TabPage MainTab;
        public TitleBarButton ExitButton;
        public TitleBarButton MinimizeButton;
        public System.Windows.Forms.Label TitleLabel;
        public CustomTabControl DebugTabControl;
        public System.Windows.Forms.TabPage ConsoleTab;
        public System.Windows.Forms.TabPage ProgramInfoTab;
        public System.Windows.Forms.Panel ConsolePanel;
        public System.Windows.Forms.RichTextBox RichConsoleText;
        public RotMG_Scripts.CustomButton ConsoleSendButton;
        public System.Windows.Forms.TextBox ConsoleInput;
        public System.Windows.Forms.LinkLabel GitHubLink;
        public System.Windows.Forms.Label VersionLabel;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public CustomTabControl RushingTabControl;
        private System.Windows.Forms.Panel DebuggingInfoPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel MainPanel1;
        private System.Windows.Forms.TableLayoutPanel MainPanel2;
        private System.Windows.Forms.TableLayoutPanel DebuggingInfoPanel2;
        private System.Windows.Forms.TableLayoutPanel DebuggingInfoPanel1;
        private System.Windows.Forms.Label lilypadLabel;
        private System.Windows.Forms.Label VersionNumberLabel;
        private System.Windows.Forms.Panel GameInfoPanel;
        private System.Windows.Forms.TableLayoutPanel GameInfoPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        public System.Windows.Forms.Label WindowWidthLabel;
        public System.Windows.Forms.TextBox WindowHeightBox;
        public System.Windows.Forms.TextBox WindowXBox;
        public System.Windows.Forms.Label WindowXLabel;
        public System.Windows.Forms.TextBox WindowWidthBox;
        public System.Windows.Forms.Label WindowYLabel;
        public System.Windows.Forms.Label WindowHeightLabel;
        public System.Windows.Forms.TextBox WindowYBox;
        public System.Windows.Forms.Label WindowInfoLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}