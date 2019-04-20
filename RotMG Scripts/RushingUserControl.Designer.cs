namespace RotMG_Scripts {
    partial class RushingUserControl {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.AddScript = new System.Windows.Forms.Button();
            this.HotkeyChange = new System.Windows.Forms.Button();
            this.RushingHotkeyLabel = new System.Windows.Forms.Label();
            this.CheckedDescription = new System.Windows.Forms.Label();
            this.HotkeyButton = new System.Windows.Forms.Button();
            this.HotkeyBox = new System.Windows.Forms.TextBox();
            this.OptionsLabel = new System.Windows.Forms.Label();
            this.GameInfoOther = new System.Windows.Forms.GroupBox();
            this.MobInfo18 = new System.Windows.Forms.CheckBox();
            this.GameInfoClient = new System.Windows.Forms.GroupBox();
            this.Darkness17 = new System.Windows.Forms.CheckBox();
            this.Confused16 = new System.Windows.Forms.CheckBox();
            this.Hallucinating15 = new System.Windows.Forms.CheckBox();
            this.Unstable8 = new System.Windows.Forms.CheckBox();
            this.Drunk7 = new System.Windows.Forms.CheckBox();
            this.Blind6 = new System.Windows.Forms.CheckBox();
            this.GameInfoServer = new System.Windows.Forms.GroupBox();
            this.Silence14 = new System.Windows.Forms.CheckBox();
            this.PetStasis13 = new System.Windows.Forms.CheckBox();
            this.Bleeding12 = new System.Windows.Forms.CheckBox();
            this.Stunned11 = new System.Windows.Forms.CheckBox();
            this.Weak9 = new System.Windows.Forms.CheckBox();
            this.Sick10 = new System.Windows.Forms.CheckBox();
            this.Petrified5 = new System.Windows.Forms.CheckBox();
            this.ArmorBroken4 = new System.Windows.Forms.CheckBox();
            this.Paralyzed3 = new System.Windows.Forms.CheckBox();
            this.Dazed2 = new System.Windows.Forms.CheckBox();
            this.Slowed1 = new System.Windows.Forms.CheckBox();
            this.Quiet0 = new System.Windows.Forms.CheckBox();
            this.GameInfoOther.SuspendLayout();
            this.GameInfoClient.SuspendLayout();
            this.GameInfoServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddScript
            // 
            this.AddScript.Location = new System.Drawing.Point(309, 337);
            this.AddScript.Name = "AddScript";
            this.AddScript.Size = new System.Drawing.Size(105, 24);
            this.AddScript.TabIndex = 7;
            this.AddScript.Text = "Add New Script";
            this.AddScript.UseVisualStyleBackColor = true;
            // 
            // HotkeyChange
            // 
            this.HotkeyChange.Location = new System.Drawing.Point(72, -96);
            this.HotkeyChange.Name = "HotkeyChange";
            this.HotkeyChange.Size = new System.Drawing.Size(102, 20);
            this.HotkeyChange.TabIndex = 6;
            this.HotkeyChange.Text = "Press Any Key...";
            this.HotkeyChange.UseVisualStyleBackColor = true;
            // 
            // RushingHotkeyLabel
            // 
            this.RushingHotkeyLabel.AutoSize = true;
            this.RushingHotkeyLabel.Location = new System.Drawing.Point(-121, -92);
            this.RushingHotkeyLabel.Name = "RushingHotkeyLabel";
            this.RushingHotkeyLabel.Size = new System.Drawing.Size(44, 13);
            this.RushingHotkeyLabel.TabIndex = 4;
            this.RushingHotkeyLabel.Text = "Hotkey:";
            // 
            // CheckedDescription
            // 
            this.CheckedDescription.AutoSize = true;
            this.CheckedDescription.Location = new System.Drawing.Point(47, 40);
            this.CheckedDescription.Name = "CheckedDescription";
            this.CheckedDescription.Size = new System.Drawing.Size(150, 13);
            this.CheckedDescription.TabIndex = 12;
            this.CheckedDescription.Text = "Checked = Disable the Debuff";
            // 
            // HotkeyButton
            // 
            this.HotkeyButton.Location = new System.Drawing.Point(218, 8);
            this.HotkeyButton.Name = "HotkeyButton";
            this.HotkeyButton.Size = new System.Drawing.Size(92, 21);
            this.HotkeyButton.TabIndex = 21;
            this.HotkeyButton.Text = "Edit...";
            this.HotkeyButton.UseVisualStyleBackColor = true;
            // 
            // HotkeyBox
            // 
            this.HotkeyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotkeyBox.Location = new System.Drawing.Point(64, 9);
            this.HotkeyBox.Name = "HotkeyBox";
            this.HotkeyBox.ReadOnly = true;
            this.HotkeyBox.Size = new System.Drawing.Size(137, 20);
            this.HotkeyBox.TabIndex = 20;
            this.HotkeyBox.Text = "N/A";
            this.HotkeyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OptionsLabel
            // 
            this.OptionsLabel.AutoSize = true;
            this.OptionsLabel.Location = new System.Drawing.Point(9, 12);
            this.OptionsLabel.Name = "OptionsLabel";
            this.OptionsLabel.Size = new System.Drawing.Size(44, 13);
            this.OptionsLabel.TabIndex = 19;
            this.OptionsLabel.Text = "Hotkey:";
            // 
            // GameInfoOther
            // 
            this.GameInfoOther.Controls.Add(this.MobInfo18);
            this.GameInfoOther.Location = new System.Drawing.Point(264, 71);
            this.GameInfoOther.Name = "GameInfoOther";
            this.GameInfoOther.Size = new System.Drawing.Size(150, 222);
            this.GameInfoOther.TabIndex = 24;
            this.GameInfoOther.TabStop = false;
            this.GameInfoOther.Text = "Other Settings";
            // 
            // MobInfo18
            // 
            this.MobInfo18.AutoCheck = false;
            this.MobInfo18.AutoSize = true;
            this.MobInfo18.Location = new System.Drawing.Point(7, 19);
            this.MobInfo18.Name = "MobInfo18";
            this.MobInfo18.Size = new System.Drawing.Size(98, 17);
            this.MobInfo18.TabIndex = 0;
            this.MobInfo18.Text = "Show Mob Info";
            this.MobInfo18.UseVisualStyleBackColor = true;
            // 
            // GameInfoClient
            // 
            this.GameInfoClient.Controls.Add(this.Darkness17);
            this.GameInfoClient.Controls.Add(this.Confused16);
            this.GameInfoClient.Controls.Add(this.Hallucinating15);
            this.GameInfoClient.Controls.Add(this.Unstable8);
            this.GameInfoClient.Controls.Add(this.Drunk7);
            this.GameInfoClient.Controls.Add(this.Blind6);
            this.GameInfoClient.Location = new System.Drawing.Point(3, 193);
            this.GameInfoClient.Name = "GameInfoClient";
            this.GameInfoClient.Size = new System.Drawing.Size(254, 100);
            this.GameInfoClient.TabIndex = 23;
            this.GameInfoClient.TabStop = false;
            this.GameInfoClient.Text = "Client Side Debuffs";
            // 
            // Darkness17
            // 
            this.Darkness17.AutoCheck = false;
            this.Darkness17.AutoSize = true;
            this.Darkness17.Location = new System.Drawing.Point(181, 42);
            this.Darkness17.Name = "Darkness17";
            this.Darkness17.Size = new System.Drawing.Size(71, 17);
            this.Darkness17.TabIndex = 12;
            this.Darkness17.Text = "Darkness";
            this.Darkness17.UseVisualStyleBackColor = true;
            // 
            // Confused16
            // 
            this.Confused16.AutoCheck = false;
            this.Confused16.AutoSize = true;
            this.Confused16.Location = new System.Drawing.Point(181, 19);
            this.Confused16.Name = "Confused16";
            this.Confused16.Size = new System.Drawing.Size(71, 17);
            this.Confused16.TabIndex = 11;
            this.Confused16.Text = "Confused";
            this.Confused16.UseVisualStyleBackColor = true;
            // 
            // Hallucinating15
            // 
            this.Hallucinating15.AutoCheck = false;
            this.Hallucinating15.AutoSize = true;
            this.Hallucinating15.Location = new System.Drawing.Point(84, 42);
            this.Hallucinating15.Name = "Hallucinating15";
            this.Hallucinating15.Size = new System.Drawing.Size(87, 17);
            this.Hallucinating15.TabIndex = 10;
            this.Hallucinating15.Text = "Hallucinating";
            this.Hallucinating15.UseVisualStyleBackColor = true;
            // 
            // Unstable8
            // 
            this.Unstable8.AutoCheck = false;
            this.Unstable8.AutoSize = true;
            this.Unstable8.Location = new System.Drawing.Point(84, 19);
            this.Unstable8.Name = "Unstable8";
            this.Unstable8.Size = new System.Drawing.Size(68, 17);
            this.Unstable8.TabIndex = 9;
            this.Unstable8.Text = "Unstable";
            this.Unstable8.UseVisualStyleBackColor = true;
            // 
            // Drunk7
            // 
            this.Drunk7.AutoCheck = false;
            this.Drunk7.AutoSize = true;
            this.Drunk7.Location = new System.Drawing.Point(6, 42);
            this.Drunk7.Name = "Drunk7";
            this.Drunk7.Size = new System.Drawing.Size(55, 17);
            this.Drunk7.TabIndex = 8;
            this.Drunk7.Text = "Drunk";
            this.Drunk7.UseVisualStyleBackColor = true;
            // 
            // Blind6
            // 
            this.Blind6.AutoCheck = false;
            this.Blind6.AutoSize = true;
            this.Blind6.Location = new System.Drawing.Point(6, 19);
            this.Blind6.Name = "Blind6";
            this.Blind6.Size = new System.Drawing.Size(49, 17);
            this.Blind6.TabIndex = 7;
            this.Blind6.Text = "Blind";
            this.Blind6.UseVisualStyleBackColor = true;
            // 
            // GameInfoServer
            // 
            this.GameInfoServer.Controls.Add(this.Silence14);
            this.GameInfoServer.Controls.Add(this.PetStasis13);
            this.GameInfoServer.Controls.Add(this.Bleeding12);
            this.GameInfoServer.Controls.Add(this.Stunned11);
            this.GameInfoServer.Controls.Add(this.Weak9);
            this.GameInfoServer.Controls.Add(this.Sick10);
            this.GameInfoServer.Controls.Add(this.Petrified5);
            this.GameInfoServer.Controls.Add(this.ArmorBroken4);
            this.GameInfoServer.Controls.Add(this.Paralyzed3);
            this.GameInfoServer.Controls.Add(this.Dazed2);
            this.GameInfoServer.Controls.Add(this.Slowed1);
            this.GameInfoServer.Controls.Add(this.Quiet0);
            this.GameInfoServer.Location = new System.Drawing.Point(3, 71);
            this.GameInfoServer.Name = "GameInfoServer";
            this.GameInfoServer.Size = new System.Drawing.Size(255, 116);
            this.GameInfoServer.TabIndex = 22;
            this.GameInfoServer.TabStop = false;
            this.GameInfoServer.Text = "Server Side Debuffs";
            // 
            // Silence14
            // 
            this.Silence14.AutoCheck = false;
            this.Silence14.AutoSize = true;
            this.Silence14.Location = new System.Drawing.Point(181, 91);
            this.Silence14.Name = "Silence14";
            this.Silence14.Size = new System.Drawing.Size(61, 17);
            this.Silence14.TabIndex = 10;
            this.Silence14.Text = "Silence";
            this.Silence14.UseVisualStyleBackColor = true;
            // 
            // PetStasis13
            // 
            this.PetStasis13.AutoCheck = false;
            this.PetStasis13.AutoSize = true;
            this.PetStasis13.Location = new System.Drawing.Point(181, 67);
            this.PetStasis13.Name = "PetStasis13";
            this.PetStasis13.Size = new System.Drawing.Size(73, 17);
            this.PetStasis13.TabIndex = 9;
            this.PetStasis13.Text = "Pet Stasis";
            this.PetStasis13.UseVisualStyleBackColor = true;
            // 
            // Bleeding12
            // 
            this.Bleeding12.AutoCheck = false;
            this.Bleeding12.AutoSize = true;
            this.Bleeding12.Location = new System.Drawing.Point(181, 43);
            this.Bleeding12.Name = "Bleeding12";
            this.Bleeding12.Size = new System.Drawing.Size(67, 17);
            this.Bleeding12.TabIndex = 8;
            this.Bleeding12.Text = "Bleeding";
            this.Bleeding12.UseVisualStyleBackColor = true;
            // 
            // Stunned11
            // 
            this.Stunned11.AutoCheck = false;
            this.Stunned11.AutoSize = true;
            this.Stunned11.Location = new System.Drawing.Point(181, 19);
            this.Stunned11.Name = "Stunned11";
            this.Stunned11.Size = new System.Drawing.Size(66, 17);
            this.Stunned11.TabIndex = 7;
            this.Stunned11.Text = "Stunned";
            this.Stunned11.UseVisualStyleBackColor = true;
            // 
            // Weak9
            // 
            this.Weak9.AutoCheck = false;
            this.Weak9.AutoSize = true;
            this.Weak9.Location = new System.Drawing.Point(84, 65);
            this.Weak9.Name = "Weak9";
            this.Weak9.Size = new System.Drawing.Size(55, 17);
            this.Weak9.TabIndex = 6;
            this.Weak9.Text = "Weak";
            this.Weak9.UseVisualStyleBackColor = true;
            // 
            // Sick10
            // 
            this.Sick10.AutoCheck = false;
            this.Sick10.AutoSize = true;
            this.Sick10.Location = new System.Drawing.Point(84, 89);
            this.Sick10.Name = "Sick10";
            this.Sick10.Size = new System.Drawing.Size(47, 17);
            this.Sick10.TabIndex = 6;
            this.Sick10.Text = "Sick";
            this.Sick10.UseVisualStyleBackColor = true;
            // 
            // Petrified5
            // 
            this.Petrified5.AutoCheck = false;
            this.Petrified5.AutoSize = true;
            this.Petrified5.Location = new System.Drawing.Point(84, 42);
            this.Petrified5.Name = "Petrified5";
            this.Petrified5.Size = new System.Drawing.Size(64, 17);
            this.Petrified5.TabIndex = 5;
            this.Petrified5.Text = "Petrified";
            this.Petrified5.UseVisualStyleBackColor = true;
            // 
            // ArmorBroken4
            // 
            this.ArmorBroken4.AutoCheck = false;
            this.ArmorBroken4.AutoSize = true;
            this.ArmorBroken4.Location = new System.Drawing.Point(84, 19);
            this.ArmorBroken4.Name = "ArmorBroken4";
            this.ArmorBroken4.Size = new System.Drawing.Size(90, 17);
            this.ArmorBroken4.TabIndex = 4;
            this.ArmorBroken4.Text = "Armor Broken";
            this.ArmorBroken4.UseVisualStyleBackColor = true;
            // 
            // Paralyzed3
            // 
            this.Paralyzed3.AutoCheck = false;
            this.Paralyzed3.AutoSize = true;
            this.Paralyzed3.Location = new System.Drawing.Point(6, 89);
            this.Paralyzed3.Name = "Paralyzed3";
            this.Paralyzed3.Size = new System.Drawing.Size(72, 17);
            this.Paralyzed3.TabIndex = 3;
            this.Paralyzed3.Text = "Paralyzed";
            this.Paralyzed3.UseVisualStyleBackColor = true;
            // 
            // Dazed2
            // 
            this.Dazed2.AutoCheck = false;
            this.Dazed2.AutoSize = true;
            this.Dazed2.Location = new System.Drawing.Point(6, 65);
            this.Dazed2.Name = "Dazed2";
            this.Dazed2.Size = new System.Drawing.Size(57, 17);
            this.Dazed2.TabIndex = 2;
            this.Dazed2.Text = "Dazed";
            this.Dazed2.UseVisualStyleBackColor = true;
            // 
            // Slowed1
            // 
            this.Slowed1.AutoCheck = false;
            this.Slowed1.AutoSize = true;
            this.Slowed1.Location = new System.Drawing.Point(6, 42);
            this.Slowed1.Name = "Slowed1";
            this.Slowed1.Size = new System.Drawing.Size(61, 17);
            this.Slowed1.TabIndex = 1;
            this.Slowed1.Text = "Slowed";
            this.Slowed1.UseVisualStyleBackColor = true;
            // 
            // Quiet0
            // 
            this.Quiet0.AutoCheck = false;
            this.Quiet0.AutoSize = true;
            this.Quiet0.Location = new System.Drawing.Point(6, 19);
            this.Quiet0.Name = "Quiet0";
            this.Quiet0.Size = new System.Drawing.Size(51, 17);
            this.Quiet0.TabIndex = 0;
            this.Quiet0.Text = "Quiet";
            this.Quiet0.UseVisualStyleBackColor = true;
            // 
            // RushingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GameInfoOther);
            this.Controls.Add(this.GameInfoClient);
            this.Controls.Add(this.GameInfoServer);
            this.Controls.Add(this.HotkeyButton);
            this.Controls.Add(this.HotkeyBox);
            this.Controls.Add(this.OptionsLabel);
            this.Controls.Add(this.CheckedDescription);
            this.Controls.Add(this.AddScript);
            this.Controls.Add(this.HotkeyChange);
            this.Controls.Add(this.RushingHotkeyLabel);
            this.Name = "RushingUserControl";
            this.Size = new System.Drawing.Size(417, 364);
            this.GameInfoOther.ResumeLayout(false);
            this.GameInfoOther.PerformLayout();
            this.GameInfoClient.ResumeLayout(false);
            this.GameInfoClient.PerformLayout();
            this.GameInfoServer.ResumeLayout(false);
            this.GameInfoServer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button AddScript;
        public System.Windows.Forms.Button HotkeyChange;
        public System.Windows.Forms.Label RushingHotkeyLabel;
        public System.Windows.Forms.Label CheckedDescription;
        public System.Windows.Forms.Button HotkeyButton;
        public System.Windows.Forms.TextBox HotkeyBox;
        public System.Windows.Forms.Label OptionsLabel;
        public System.Windows.Forms.GroupBox GameInfoOther;
        public System.Windows.Forms.CheckBox MobInfo18;
        public System.Windows.Forms.GroupBox GameInfoClient;
        public System.Windows.Forms.CheckBox Darkness17;
        public System.Windows.Forms.CheckBox Confused16;
        public System.Windows.Forms.CheckBox Hallucinating15;
        public System.Windows.Forms.CheckBox Unstable8;
        public System.Windows.Forms.CheckBox Drunk7;
        public System.Windows.Forms.CheckBox Blind6;
        public System.Windows.Forms.GroupBox GameInfoServer;
        public System.Windows.Forms.CheckBox Silence14;
        public System.Windows.Forms.CheckBox PetStasis13;
        public System.Windows.Forms.CheckBox Bleeding12;
        public System.Windows.Forms.CheckBox Stunned11;
        public System.Windows.Forms.CheckBox Weak9;
        public System.Windows.Forms.CheckBox Sick10;
        public System.Windows.Forms.CheckBox Petrified5;
        public System.Windows.Forms.CheckBox ArmorBroken4;
        public System.Windows.Forms.CheckBox Paralyzed3;
        public System.Windows.Forms.CheckBox Dazed2;
        public System.Windows.Forms.CheckBox Slowed1;
        public System.Windows.Forms.CheckBox Quiet0;
    }
}
