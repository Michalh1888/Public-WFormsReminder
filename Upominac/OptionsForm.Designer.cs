namespace Upominac
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            RunOnStartupCheckBox = new CheckBox();
            RunOnTrayCheckBox = new CheckBox();
            SaveDataSystemFolderCheckBox = new CheckBox();
            TitleBarPanel = new Panel();
            CloseRndButton = new CustomRoundButton.RoundButton();
            roundButton1 = new CustomRoundButton.RoundButton();
            TitleBarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // RunOnStartupCheckBox
            // 
            RunOnStartupCheckBox.AutoSize = true;
            RunOnStartupCheckBox.Location = new Point(29, 45);
            RunOnStartupCheckBox.Name = "RunOnStartupCheckBox";
            RunOnStartupCheckBox.Size = new Size(123, 21);
            RunOnStartupCheckBox.TabIndex = 0;
            RunOnStartupCheckBox.Text = "Spustit po startu";
            RunOnStartupCheckBox.UseVisualStyleBackColor = true;
            RunOnStartupCheckBox.CheckedChanged += RunOnStartupCheckBox_CheckedChanged;
            // 
            // RunOnTrayCheckBox
            // 
            RunOnTrayCheckBox.AutoSize = true;
            RunOnTrayCheckBox.Location = new Point(29, 74);
            RunOnTrayCheckBox.Name = "RunOnTrayCheckBox";
            RunOnTrayCheckBox.Size = new Size(139, 21);
            RunOnTrayCheckBox.TabIndex = 2;
            RunOnTrayCheckBox.Text = "Spustit v Tray ikoně";
            RunOnTrayCheckBox.UseVisualStyleBackColor = true;
            RunOnTrayCheckBox.CheckedChanged += RunOnTrayCheckBox_CheckedChanged;
            // 
            // SaveDataSystemFolderCheckBox
            // 
            SaveDataSystemFolderCheckBox.AutoSize = true;
            SaveDataSystemFolderCheckBox.Location = new Point(29, 102);
            SaveDataSystemFolderCheckBox.Name = "SaveDataSystemFolderCheckBox";
            SaveDataSystemFolderCheckBox.Size = new Size(198, 21);
            SaveDataSystemFolderCheckBox.TabIndex = 2;
            SaveDataSystemFolderCheckBox.Text = "Ukládat data v systém. složce";
            SaveDataSystemFolderCheckBox.UseVisualStyleBackColor = true;
            SaveDataSystemFolderCheckBox.CheckedChanged += SaveDataSystemFolderCheckBox_CheckedChanged;
            // 
            // TitleBarPanel
            // 
            TitleBarPanel.BackColor = Color.FromArgb(85, 85, 85);
            TitleBarPanel.Controls.Add(CloseRndButton);
            TitleBarPanel.Dock = DockStyle.Top;
            TitleBarPanel.ForeColor = Color.White;
            TitleBarPanel.Location = new Point(0, 0);
            TitleBarPanel.Name = "TitleBarPanel";
            TitleBarPanel.Size = new Size(235, 34);
            TitleBarPanel.TabIndex = 3;
            TitleBarPanel.MouseDown += TitleBarPanel_MouseDown;
            TitleBarPanel.MouseMove += TitleBarPanel_MouseMove;
            // 
            // CloseRndButton
            // 
            CloseRndButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseRndButton.BackColor = Color.Transparent;
            CloseRndButton.BackgroundColor = Color.Transparent;
            CloseRndButton.BackgroundImage = (Image)resources.GetObject("CloseRndButton.BackgroundImage");
            CloseRndButton.BackgroundImageLayout = ImageLayout.Zoom;
            CloseRndButton.Border3D = false;
            CloseRndButton.BorderColor = Color.Red;
            CloseRndButton.BorderRadius = 7;
            CloseRndButton.BorderSize = 0;
            CloseRndButton.FlatAppearance.BorderSize = 0;
            CloseRndButton.FlatStyle = FlatStyle.Flat;
            CloseRndButton.ForeColor = Color.White;
            CloseRndButton.Location = new Point(207, 0);
            CloseRndButton.Margin = new Padding(0);
            CloseRndButton.Name = "CloseRndButton";
            CloseRndButton.Size = new Size(28, 32);
            CloseRndButton.TabIndex = 25;
            CloseRndButton.TextColor = Color.White;
            CloseRndButton.UseVisualStyleBackColor = false;
            CloseRndButton.Click += CloseRndButton_Click;
            // 
            // roundButton1
            // 
            roundButton1.BackColor = Color.FromArgb(80, 80, 80);
            roundButton1.BackgroundColor = Color.FromArgb(80, 80, 80);
            roundButton1.Border3D = false;
            roundButton1.BorderColor = SystemColors.ActiveCaptionText;
            roundButton1.BorderRadius = 20;
            roundButton1.BorderSize = 2;
            roundButton1.FlatAppearance.BorderSize = 0;
            roundButton1.FlatStyle = FlatStyle.Flat;
            roundButton1.Font = new Font("Century Gothic", 10.18868F, FontStyle.Bold, GraphicsUnit.Point);
            roundButton1.ForeColor = Color.White;
            roundButton1.Location = new Point(71, 148);
            roundButton1.Name = "roundButton1";
            roundButton1.Size = new Size(81, 44);
            roundButton1.TabIndex = 28;
            roundButton1.Text = "OK";
            roundButton1.TextColor = Color.White;
            roundButton1.UseVisualStyleBackColor = false;
            roundButton1.Click += OkButton_Click;
            // 
            // OptionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(125, 125, 125);
            ClientSize = new Size(235, 224);
            Controls.Add(roundButton1);
            Controls.Add(TitleBarPanel);
            Controls.Add(SaveDataSystemFolderCheckBox);
            Controls.Add(RunOnTrayCheckBox);
            Controls.Add(RunOnStartupCheckBox);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "OptionsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Options";
            Load += OptionsForm_Load;
            TitleBarPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox RunOnStartupCheckBox;
        private CheckBox RunOnTrayCheckBox;
        private CheckBox SaveDataSystemFolderCheckBox;
        private Panel TitleBarPanel;
        private CustomRoundButton.RoundButton CloseRndButton;
        private CustomRoundButton.RoundButton roundButton1;
    }
}