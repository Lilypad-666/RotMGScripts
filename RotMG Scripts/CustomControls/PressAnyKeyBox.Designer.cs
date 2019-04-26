namespace RotMG_Scripts {
    partial class PressAnyKeyBox {
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
            this.HotkeyAnyKeyLabel = new System.Windows.Forms.Label();
            this.HotkeyPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EditingHotkeyLabel = new System.Windows.Forms.Label();
            this.OptionsWarningLabel = new System.Windows.Forms.Label();
            this.HotkeyTitleBar = new System.Windows.Forms.Panel();
            this.HotkeyExitButton = new RotMG_Scripts.TitleBarButton();
            this.HotkeyLabel = new System.Windows.Forms.Label();
            this.MinimizeButton = new RotMG_Scripts.TitleBarButton();
            this.ExitButton = new RotMG_Scripts.TitleBarButton();
            this.HotkeyPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.HotkeyTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // HotkeyAnyKeyLabel
            // 
            this.HotkeyAnyKeyLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HotkeyAnyKeyLabel.AutoSize = true;
            this.HotkeyAnyKeyLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotkeyAnyKeyLabel.ForeColor = System.Drawing.Color.White;
            this.HotkeyAnyKeyLabel.Location = new System.Drawing.Point(41, 84);
            this.HotkeyAnyKeyLabel.Name = "HotkeyAnyKeyLabel";
            this.HotkeyAnyKeyLabel.Size = new System.Drawing.Size(98, 17);
            this.HotkeyAnyKeyLabel.TabIndex = 0;
            this.HotkeyAnyKeyLabel.Text = "Press Any Key...";
            // 
            // HotkeyPanel
            // 
            this.HotkeyPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HotkeyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HotkeyPanel.Controls.Add(this.tableLayoutPanel1);
            this.HotkeyPanel.Location = new System.Drawing.Point(10, 30);
            this.HotkeyPanel.Name = "HotkeyPanel";
            this.HotkeyPanel.Size = new System.Drawing.Size(180, 110);
            this.HotkeyPanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.EditingHotkeyLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.HotkeyAnyKeyLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.OptionsWarningLabel, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(180, 110);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // EditingHotkeyLabel
            // 
            this.EditingHotkeyLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditingHotkeyLabel.AutoSize = true;
            this.EditingHotkeyLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditingHotkeyLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditingHotkeyLabel.ForeColor = System.Drawing.Color.White;
            this.EditingHotkeyLabel.Location = new System.Drawing.Point(49, 1);
            this.EditingHotkeyLabel.Name = "EditingHotkeyLabel";
            this.EditingHotkeyLabel.Size = new System.Drawing.Size(81, 17);
            this.EditingHotkeyLabel.TabIndex = 1;
            this.EditingHotkeyLabel.Text = "--Key Here--";
            // 
            // OptionsWarningLabel
            // 
            this.OptionsWarningLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OptionsWarningLabel.AutoSize = true;
            this.OptionsWarningLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsWarningLabel.ForeColor = System.Drawing.Color.White;
            this.OptionsWarningLabel.Location = new System.Drawing.Point(90, 21);
            this.OptionsWarningLabel.Name = "OptionsWarningLabel";
            this.OptionsWarningLabel.Size = new System.Drawing.Size(0, 17);
            this.OptionsWarningLabel.TabIndex = 2;
            // 
            // HotkeyTitleBar
            // 
            this.HotkeyTitleBar.BackColor = System.Drawing.Color.Transparent;
            this.HotkeyTitleBar.Controls.Add(this.HotkeyExitButton);
            this.HotkeyTitleBar.Controls.Add(this.HotkeyLabel);
            this.HotkeyTitleBar.Controls.Add(this.MinimizeButton);
            this.HotkeyTitleBar.Controls.Add(this.ExitButton);
            this.HotkeyTitleBar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotkeyTitleBar.Location = new System.Drawing.Point(0, 0);
            this.HotkeyTitleBar.Name = "HotkeyTitleBar";
            this.HotkeyTitleBar.Size = new System.Drawing.Size(200, 30);
            this.HotkeyTitleBar.TabIndex = 28;
            // 
            // HotkeyExitButton
            // 
            this.HotkeyExitButton.BackColor = System.Drawing.Color.Red;
            this.HotkeyExitButton.FlatAppearance.BorderSize = 0;
            this.HotkeyExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HotkeyExitButton.Font = new System.Drawing.Font("Marlett", 12F);
            this.HotkeyExitButton.ForeColor = System.Drawing.Color.White;
            this.HotkeyExitButton.Location = new System.Drawing.Point(145, 0);
            this.HotkeyExitButton.Name = "HotkeyExitButton";
            this.HotkeyExitButton.Size = new System.Drawing.Size(55, 30);
            this.HotkeyExitButton.TabIndex = 30;
            this.HotkeyExitButton.Text = "r";
            this.HotkeyExitButton.UseVisualStyleBackColor = false;
            // 
            // HotkeyLabel
            // 
            this.HotkeyLabel.AutoSize = true;
            this.HotkeyLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotkeyLabel.ForeColor = System.Drawing.Color.White;
            this.HotkeyLabel.Location = new System.Drawing.Point(34, 6);
            this.HotkeyLabel.Name = "HotkeyLabel";
            this.HotkeyLabel.Size = new System.Drawing.Size(74, 17);
            this.HotkeyLabel.TabIndex = 29;
            this.HotkeyLabel.Text = "Edit Hotkey";
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
            // PressAnyKeyBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(200, 150);
            this.Controls.Add(this.HotkeyTitleBar);
            this.Controls.Add(this.HotkeyPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PressAnyKeyBox";
            this.HotkeyPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.HotkeyTitleBar.ResumeLayout(false);
            this.HotkeyTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HotkeyAnyKeyLabel;
        private System.Windows.Forms.Panel HotkeyPanel;
        public System.Windows.Forms.Panel HotkeyTitleBar;
        public System.Windows.Forms.Label HotkeyLabel;
        public TitleBarButton MinimizeButton;
        public TitleBarButton ExitButton;
        public TitleBarButton HotkeyExitButton;
        private System.Windows.Forms.Label EditingHotkeyLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label OptionsWarningLabel;
    }
}
