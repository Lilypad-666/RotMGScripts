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
            this.ServerSideDebuffs = new System.Windows.Forms.GroupBox();
            this.Silence15 = new System.Windows.Forms.CheckBox();
            this.PetStasis14 = new System.Windows.Forms.CheckBox();
            this.Bleeding13 = new System.Windows.Forms.CheckBox();
            this.Stunned12 = new System.Windows.Forms.CheckBox();
            this.Weak10 = new System.Windows.Forms.CheckBox();
            this.Sick11 = new System.Windows.Forms.CheckBox();
            this.Petrified5 = new System.Windows.Forms.CheckBox();
            this.ArmorBroken4 = new System.Windows.Forms.CheckBox();
            this.Paralyzed3 = new System.Windows.Forms.CheckBox();
            this.Dazed2 = new System.Windows.Forms.CheckBox();
            this.Slowed1 = new System.Windows.Forms.CheckBox();
            this.Quiet0 = new System.Windows.Forms.CheckBox();
            this.Blind6 = new System.Windows.Forms.CheckBox();
            this.CheckedDescription = new System.Windows.Forms.Label();
            this.ClientSideDebuffs = new System.Windows.Forms.GroupBox();
            this.Darkness18 = new System.Windows.Forms.CheckBox();
            this.Confused17 = new System.Windows.Forms.CheckBox();
            this.Hallucinating16 = new System.Windows.Forms.CheckBox();
            this.Unstable8 = new System.Windows.Forms.CheckBox();
            this.Drunk7 = new System.Windows.Forms.CheckBox();
            this.RushExtra = new System.Windows.Forms.GroupBox();
            this.MobInfo19 = new System.Windows.Forms.CheckBox();
            this.HotkeyButton = new System.Windows.Forms.Button();
            this.HotkeyBox = new System.Windows.Forms.TextBox();
            this.OptionsLabel = new System.Windows.Forms.Label();
            this.ServerSideDebuffs.SuspendLayout();
            this.ClientSideDebuffs.SuspendLayout();
            this.RushExtra.SuspendLayout();
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
            // ServerSideDebuffs
            // 
            this.ServerSideDebuffs.Controls.Add(this.Silence15);
            this.ServerSideDebuffs.Controls.Add(this.PetStasis14);
            this.ServerSideDebuffs.Controls.Add(this.Bleeding13);
            this.ServerSideDebuffs.Controls.Add(this.Stunned12);
            this.ServerSideDebuffs.Controls.Add(this.Weak10);
            this.ServerSideDebuffs.Controls.Add(this.Sick11);
            this.ServerSideDebuffs.Controls.Add(this.Petrified5);
            this.ServerSideDebuffs.Controls.Add(this.ArmorBroken4);
            this.ServerSideDebuffs.Controls.Add(this.Paralyzed3);
            this.ServerSideDebuffs.Controls.Add(this.Dazed2);
            this.ServerSideDebuffs.Controls.Add(this.Slowed1);
            this.ServerSideDebuffs.Controls.Add(this.Quiet0);
            this.ServerSideDebuffs.Location = new System.Drawing.Point(3, 61);
            this.ServerSideDebuffs.Name = "ServerSideDebuffs";
            this.ServerSideDebuffs.Size = new System.Drawing.Size(255, 116);
            this.ServerSideDebuffs.TabIndex = 11;
            this.ServerSideDebuffs.TabStop = false;
            this.ServerSideDebuffs.Text = "Server Side (Will Disconnect You)";
            // 
            // Silence15
            // 
            this.Silence15.AutoSize = true;
            this.Silence15.Location = new System.Drawing.Point(181, 91);
            this.Silence15.Name = "Silence15";
            this.Silence15.Size = new System.Drawing.Size(61, 17);
            this.Silence15.TabIndex = 10;
            this.Silence15.Text = "Silence";
            this.Silence15.UseVisualStyleBackColor = true;
            // 
            // PetStasis14
            // 
            this.PetStasis14.AutoSize = true;
            this.PetStasis14.Location = new System.Drawing.Point(181, 67);
            this.PetStasis14.Name = "PetStasis14";
            this.PetStasis14.Size = new System.Drawing.Size(73, 17);
            this.PetStasis14.TabIndex = 9;
            this.PetStasis14.Text = "Pet Stasis";
            this.PetStasis14.UseVisualStyleBackColor = true;
            // 
            // Bleeding13
            // 
            this.Bleeding13.AutoSize = true;
            this.Bleeding13.Location = new System.Drawing.Point(181, 43);
            this.Bleeding13.Name = "Bleeding13";
            this.Bleeding13.Size = new System.Drawing.Size(67, 17);
            this.Bleeding13.TabIndex = 8;
            this.Bleeding13.Text = "Bleeding";
            this.Bleeding13.UseVisualStyleBackColor = true;
            // 
            // Stunned12
            // 
            this.Stunned12.AutoSize = true;
            this.Stunned12.Location = new System.Drawing.Point(181, 19);
            this.Stunned12.Name = "Stunned12";
            this.Stunned12.Size = new System.Drawing.Size(66, 17);
            this.Stunned12.TabIndex = 7;
            this.Stunned12.Text = "Stunned";
            this.Stunned12.UseVisualStyleBackColor = true;
            // 
            // Weak10
            // 
            this.Weak10.AutoSize = true;
            this.Weak10.Location = new System.Drawing.Point(84, 65);
            this.Weak10.Name = "Weak10";
            this.Weak10.Size = new System.Drawing.Size(55, 17);
            this.Weak10.TabIndex = 6;
            this.Weak10.Text = "Weak";
            this.Weak10.UseVisualStyleBackColor = true;
            // 
            // Sick11
            // 
            this.Sick11.AutoSize = true;
            this.Sick11.Location = new System.Drawing.Point(84, 89);
            this.Sick11.Name = "Sick11";
            this.Sick11.Size = new System.Drawing.Size(47, 17);
            this.Sick11.TabIndex = 6;
            this.Sick11.Text = "Sick";
            this.Sick11.UseVisualStyleBackColor = true;
            // 
            // Petrified5
            // 
            this.Petrified5.AutoSize = true;
            this.Petrified5.Checked = true;
            this.Petrified5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Petrified5.Location = new System.Drawing.Point(84, 42);
            this.Petrified5.Name = "Petrified5";
            this.Petrified5.Size = new System.Drawing.Size(64, 17);
            this.Petrified5.TabIndex = 5;
            this.Petrified5.Text = "Petrified";
            this.Petrified5.UseVisualStyleBackColor = true;
            // 
            // ArmorBroken4
            // 
            this.ArmorBroken4.AutoSize = true;
            this.ArmorBroken4.Checked = true;
            this.ArmorBroken4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ArmorBroken4.Location = new System.Drawing.Point(84, 19);
            this.ArmorBroken4.Name = "ArmorBroken4";
            this.ArmorBroken4.Size = new System.Drawing.Size(90, 17);
            this.ArmorBroken4.TabIndex = 4;
            this.ArmorBroken4.Text = "Armor Broken";
            this.ArmorBroken4.UseVisualStyleBackColor = true;
            // 
            // Paralyzed3
            // 
            this.Paralyzed3.AutoSize = true;
            this.Paralyzed3.Checked = true;
            this.Paralyzed3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Paralyzed3.Location = new System.Drawing.Point(6, 89);
            this.Paralyzed3.Name = "Paralyzed3";
            this.Paralyzed3.Size = new System.Drawing.Size(72, 17);
            this.Paralyzed3.TabIndex = 3;
            this.Paralyzed3.Text = "Paralyzed";
            this.Paralyzed3.UseVisualStyleBackColor = true;
            // 
            // Dazed2
            // 
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
            this.Slowed1.AutoSize = true;
            this.Slowed1.Checked = true;
            this.Slowed1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Slowed1.Location = new System.Drawing.Point(6, 42);
            this.Slowed1.Name = "Slowed1";
            this.Slowed1.Size = new System.Drawing.Size(61, 17);
            this.Slowed1.TabIndex = 1;
            this.Slowed1.Text = "Slowed";
            this.Slowed1.UseVisualStyleBackColor = true;
            // 
            // Quiet0
            // 
            this.Quiet0.AutoSize = true;
            this.Quiet0.Checked = true;
            this.Quiet0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Quiet0.Location = new System.Drawing.Point(6, 19);
            this.Quiet0.Name = "Quiet0";
            this.Quiet0.Size = new System.Drawing.Size(51, 17);
            this.Quiet0.TabIndex = 0;
            this.Quiet0.Text = "Quiet";
            this.Quiet0.UseVisualStyleBackColor = true;
            // 
            // Blind6
            // 
            this.Blind6.AutoSize = true;
            this.Blind6.Checked = true;
            this.Blind6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Blind6.Location = new System.Drawing.Point(6, 19);
            this.Blind6.Name = "Blind6";
            this.Blind6.Size = new System.Drawing.Size(49, 17);
            this.Blind6.TabIndex = 7;
            this.Blind6.Text = "Blind";
            this.Blind6.UseVisualStyleBackColor = true;
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
            // ClientSideDebuffs
            // 
            this.ClientSideDebuffs.Controls.Add(this.Darkness18);
            this.ClientSideDebuffs.Controls.Add(this.Confused17);
            this.ClientSideDebuffs.Controls.Add(this.Hallucinating16);
            this.ClientSideDebuffs.Controls.Add(this.Unstable8);
            this.ClientSideDebuffs.Controls.Add(this.Drunk7);
            this.ClientSideDebuffs.Controls.Add(this.Blind6);
            this.ClientSideDebuffs.Location = new System.Drawing.Point(3, 183);
            this.ClientSideDebuffs.Name = "ClientSideDebuffs";
            this.ClientSideDebuffs.Size = new System.Drawing.Size(254, 100);
            this.ClientSideDebuffs.TabIndex = 13;
            this.ClientSideDebuffs.TabStop = false;
            this.ClientSideDebuffs.Text = "Client Side (Won\'t Disconnect You)";
            // 
            // Darkness18
            // 
            this.Darkness18.AutoSize = true;
            this.Darkness18.Checked = true;
            this.Darkness18.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Darkness18.Location = new System.Drawing.Point(181, 42);
            this.Darkness18.Name = "Darkness18";
            this.Darkness18.Size = new System.Drawing.Size(71, 17);
            this.Darkness18.TabIndex = 12;
            this.Darkness18.Text = "Darkness";
            this.Darkness18.UseVisualStyleBackColor = true;
            // 
            // Confused17
            // 
            this.Confused17.AutoSize = true;
            this.Confused17.Checked = true;
            this.Confused17.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Confused17.Location = new System.Drawing.Point(181, 19);
            this.Confused17.Name = "Confused17";
            this.Confused17.Size = new System.Drawing.Size(71, 17);
            this.Confused17.TabIndex = 11;
            this.Confused17.Text = "Confused";
            this.Confused17.UseVisualStyleBackColor = true;
            // 
            // Hallucinating16
            // 
            this.Hallucinating16.AutoSize = true;
            this.Hallucinating16.Checked = true;
            this.Hallucinating16.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Hallucinating16.Location = new System.Drawing.Point(84, 42);
            this.Hallucinating16.Name = "Hallucinating16";
            this.Hallucinating16.Size = new System.Drawing.Size(87, 17);
            this.Hallucinating16.TabIndex = 10;
            this.Hallucinating16.Text = "Hallucinating";
            this.Hallucinating16.UseVisualStyleBackColor = true;
            // 
            // Unstable8
            // 
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
            this.Drunk7.AutoSize = true;
            this.Drunk7.Checked = true;
            this.Drunk7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Drunk7.Location = new System.Drawing.Point(6, 42);
            this.Drunk7.Name = "Drunk7";
            this.Drunk7.Size = new System.Drawing.Size(55, 17);
            this.Drunk7.TabIndex = 8;
            this.Drunk7.Text = "Drunk";
            this.Drunk7.UseVisualStyleBackColor = true;
            // 
            // RushExtra
            // 
            this.RushExtra.Controls.Add(this.MobInfo19);
            this.RushExtra.Location = new System.Drawing.Point(264, 61);
            this.RushExtra.Name = "RushExtra";
            this.RushExtra.Size = new System.Drawing.Size(150, 222);
            this.RushExtra.TabIndex = 14;
            this.RushExtra.TabStop = false;
            this.RushExtra.Text = "Others";
            // 
            // MobInfo19
            // 
            this.MobInfo19.AutoSize = true;
            this.MobInfo19.Location = new System.Drawing.Point(7, 19);
            this.MobInfo19.Name = "MobInfo19";
            this.MobInfo19.Size = new System.Drawing.Size(98, 17);
            this.MobInfo19.TabIndex = 0;
            this.MobInfo19.Text = "Show Mob Info";
            this.MobInfo19.UseVisualStyleBackColor = true;
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
            // RushingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HotkeyButton);
            this.Controls.Add(this.HotkeyBox);
            this.Controls.Add(this.OptionsLabel);
            this.Controls.Add(this.RushExtra);
            this.Controls.Add(this.ClientSideDebuffs);
            this.Controls.Add(this.CheckedDescription);
            this.Controls.Add(this.ServerSideDebuffs);
            this.Controls.Add(this.AddScript);
            this.Controls.Add(this.HotkeyChange);
            this.Controls.Add(this.RushingHotkeyLabel);
            this.Name = "RushingUserControl";
            this.Size = new System.Drawing.Size(417, 364);
            this.ServerSideDebuffs.ResumeLayout(false);
            this.ServerSideDebuffs.PerformLayout();
            this.ClientSideDebuffs.ResumeLayout(false);
            this.ClientSideDebuffs.PerformLayout();
            this.RushExtra.ResumeLayout(false);
            this.RushExtra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddScript;
        private System.Windows.Forms.Button HotkeyChange;
        private System.Windows.Forms.Label RushingHotkeyLabel;
        private System.Windows.Forms.GroupBox ServerSideDebuffs;
        private System.Windows.Forms.CheckBox Petrified5;
        private System.Windows.Forms.CheckBox ArmorBroken4;
        private System.Windows.Forms.CheckBox Paralyzed3;
        private System.Windows.Forms.CheckBox Dazed2;
        private System.Windows.Forms.CheckBox Slowed1;
        private System.Windows.Forms.CheckBox Quiet0;
        private System.Windows.Forms.CheckBox Weak10;
        private System.Windows.Forms.CheckBox Blind6;
        private System.Windows.Forms.Label CheckedDescription;
        private System.Windows.Forms.GroupBox ClientSideDebuffs;
        private System.Windows.Forms.CheckBox Silence15;
        private System.Windows.Forms.CheckBox PetStasis14;
        private System.Windows.Forms.CheckBox Bleeding13;
        private System.Windows.Forms.CheckBox Stunned12;
        private System.Windows.Forms.CheckBox Sick11;
        private System.Windows.Forms.CheckBox Darkness18;
        private System.Windows.Forms.CheckBox Confused17;
        private System.Windows.Forms.CheckBox Hallucinating16;
        private System.Windows.Forms.CheckBox Unstable8;
        private System.Windows.Forms.CheckBox Drunk7;
        private System.Windows.Forms.GroupBox RushExtra;
        private System.Windows.Forms.CheckBox MobInfo19;
        private System.Windows.Forms.Button HotkeyButton;
        private System.Windows.Forms.TextBox HotkeyBox;
        private System.Windows.Forms.Label OptionsLabel;
    }
}
