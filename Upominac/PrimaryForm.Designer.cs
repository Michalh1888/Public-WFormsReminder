namespace Upominac
{
    partial class PrimaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimaryForm));
            osobaSaveFileDialog = new SaveFileDialog();
            TitleBarPanel = new Panel();
            MinimizeRndButton = new CustomRoundButton.RoundButton();
            MaximizeRndButton = new CustomRoundButton.RoundButton();
            CloseRndButton = new CustomRoundButton.RoundButton();
            mainBarPanel = new Panel();
            RemoveButton = new CustomRoundButton.RoundButton();
            EditButton = new CustomRoundButton.RoundButton();
            AddButton = new CustomRoundButton.RoundButton();
            HomeButton = new CustomRoundButton.RoundButton();
            topBorderPanel = new Panel();
            sideBarPanel = new Panel();
            OptionsButton = new CustomRoundButton.RoundButton();
            ExportPersonButton = new CustomRoundButton.RoundButton();
            CheckNameDateButton = new CustomRoundButton.RoundButton();
            sideBorderPanel = new Panel();
            mainAreaPanel = new Panel();
            TitleBarPanel.SuspendLayout();
            mainBarPanel.SuspendLayout();
            sideBarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // osobaSaveFileDialog
            // 
            osobaSaveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*|Word Doc (*.doc)|*.doc";
            // 
            // TitleBarPanel
            // 
            TitleBarPanel.BackColor = Color.FromArgb(85, 85, 85);
            TitleBarPanel.BackgroundImage = (Image)resources.GetObject("TitleBarPanel.BackgroundImage");
            TitleBarPanel.BackgroundImageLayout = ImageLayout.None;
            TitleBarPanel.Controls.Add(MinimizeRndButton);
            TitleBarPanel.Controls.Add(MaximizeRndButton);
            TitleBarPanel.Controls.Add(CloseRndButton);
            TitleBarPanel.Dock = DockStyle.Top;
            TitleBarPanel.Location = new Point(0, 0);
            TitleBarPanel.Margin = new Padding(0);
            TitleBarPanel.Name = "TitleBarPanel";
            TitleBarPanel.Size = new Size(780, 34);
            TitleBarPanel.TabIndex = 21;
            TitleBarPanel.MouseDown += TitleBarPanel_MouseDown;
            TitleBarPanel.MouseMove += TitleBarPanel_MouseMove;
            // 
            // MinimizeRndButton
            // 
            MinimizeRndButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MinimizeRndButton.BackColor = Color.Transparent;
            MinimizeRndButton.BackgroundColor = Color.Transparent;
            MinimizeRndButton.BackgroundImage = (Image)resources.GetObject("MinimizeRndButton.BackgroundImage");
            MinimizeRndButton.BackgroundImageLayout = ImageLayout.Center;
            MinimizeRndButton.Border3D = false;
            MinimizeRndButton.BorderColor = Color.Red;
            MinimizeRndButton.BorderRadius = 7;
            MinimizeRndButton.BorderSize = 0;
            MinimizeRndButton.FlatAppearance.BorderSize = 0;
            MinimizeRndButton.FlatStyle = FlatStyle.Flat;
            MinimizeRndButton.ForeColor = Color.White;
            MinimizeRndButton.Location = new Point(694, 1);
            MinimizeRndButton.Margin = new Padding(0);
            MinimizeRndButton.Name = "MinimizeRndButton";
            MinimizeRndButton.Size = new Size(28, 32);
            MinimizeRndButton.TabIndex = 22;
            MinimizeRndButton.TextColor = Color.White;
            MinimizeRndButton.UseVisualStyleBackColor = false;
            MinimizeRndButton.Click += MinimizeRndButton_Click;
            // 
            // MaximizeRndButton
            // 
            MaximizeRndButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MaximizeRndButton.BackColor = Color.Transparent;
            MaximizeRndButton.BackgroundColor = Color.Transparent;
            MaximizeRndButton.BackgroundImage = (Image)resources.GetObject("MaximizeRndButton.BackgroundImage");
            MaximizeRndButton.BackgroundImageLayout = ImageLayout.Center;
            MaximizeRndButton.Border3D = false;
            MaximizeRndButton.BorderColor = Color.Red;
            MaximizeRndButton.BorderRadius = 7;
            MaximizeRndButton.BorderSize = 0;
            MaximizeRndButton.FlatAppearance.BorderSize = 0;
            MaximizeRndButton.FlatStyle = FlatStyle.Flat;
            MaximizeRndButton.ForeColor = Color.White;
            MaximizeRndButton.Location = new Point(722, 1);
            MaximizeRndButton.Margin = new Padding(0);
            MaximizeRndButton.Name = "MaximizeRndButton";
            MaximizeRndButton.Size = new Size(28, 32);
            MaximizeRndButton.TabIndex = 23;
            MaximizeRndButton.TextColor = Color.White;
            MaximizeRndButton.UseVisualStyleBackColor = false;
            MaximizeRndButton.Click += MaximizeRndButton_Click;
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
            CloseRndButton.Location = new Point(750, 1);
            CloseRndButton.Margin = new Padding(0);
            CloseRndButton.Name = "CloseRndButton";
            CloseRndButton.Size = new Size(28, 32);
            CloseRndButton.TabIndex = 24;
            CloseRndButton.TextColor = Color.White;
            CloseRndButton.UseVisualStyleBackColor = false;
            CloseRndButton.Click += CloseRndButton_Click;
            // 
            // mainBarPanel
            // 
            mainBarPanel.BackColor = SystemColors.WindowFrame;
            mainBarPanel.Controls.Add(RemoveButton);
            mainBarPanel.Controls.Add(EditButton);
            mainBarPanel.Controls.Add(AddButton);
            mainBarPanel.Controls.Add(HomeButton);
            mainBarPanel.Dock = DockStyle.Top;
            mainBarPanel.Location = new Point(0, 34);
            mainBarPanel.Margin = new Padding(0);
            mainBarPanel.Name = "mainBarPanel";
            mainBarPanel.Size = new Size(780, 73);
            mainBarPanel.TabIndex = 22;
            // 
            // RemoveButton
            // 
            RemoveButton.BackColor = Color.FromArgb(80, 80, 80);
            RemoveButton.BackgroundColor = Color.FromArgb(80, 80, 80);
            RemoveButton.Border3D = false;
            RemoveButton.BorderColor = SystemColors.ActiveCaptionText;
            RemoveButton.BorderRadius = 20;
            RemoveButton.BorderSize = 2;
            RemoveButton.FlatAppearance.BorderSize = 0;
            RemoveButton.FlatStyle = FlatStyle.Flat;
            RemoveButton.Font = new Font("Century Gothic", 10.8679247F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveButton.ForeColor = Color.White;
            RemoveButton.Image = (Image)resources.GetObject("RemoveButton.Image");
            RemoveButton.Location = new Point(504, 15);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(130, 50);
            RemoveButton.TabIndex = 10;
            RemoveButton.Text = "  Odebrat";
            RemoveButton.TextColor = Color.White;
            RemoveButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            RemoveButton.UseVisualStyleBackColor = false;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.FromArgb(80, 80, 80);
            EditButton.BackgroundColor = Color.FromArgb(80, 80, 80);
            EditButton.Border3D = false;
            EditButton.BorderColor = SystemColors.ActiveCaptionText;
            EditButton.BorderRadius = 20;
            EditButton.BorderSize = 2;
            EditButton.FlatAppearance.BorderSize = 0;
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.Font = new Font("Century Gothic", 10.8679247F, FontStyle.Bold, GraphicsUnit.Point);
            EditButton.ForeColor = Color.White;
            EditButton.Image = (Image)resources.GetObject("EditButton.Image");
            EditButton.Location = new Point(368, 15);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(130, 50);
            EditButton.TabIndex = 10;
            EditButton.Text = "  Edituj";
            EditButton.TextColor = Color.White;
            EditButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.FromArgb(80, 80, 80);
            AddButton.BackgroundColor = Color.FromArgb(80, 80, 80);
            AddButton.Border3D = false;
            AddButton.BorderColor = SystemColors.ActiveCaptionText;
            AddButton.BorderRadius = 20;
            AddButton.BorderSize = 2;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Century Gothic", 10.8679247F, FontStyle.Bold, GraphicsUnit.Point);
            AddButton.ForeColor = Color.White;
            AddButton.Image = (Image)resources.GetObject("AddButton.Image");
            AddButton.Location = new Point(232, 15);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(130, 50);
            AddButton.TabIndex = 10;
            AddButton.Text = "  Přidat";
            AddButton.TextColor = Color.White;
            AddButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // HomeButton
            // 
            HomeButton.BackColor = Color.FromArgb(80, 80, 80);
            HomeButton.BackgroundColor = Color.FromArgb(80, 80, 80);
            HomeButton.Border3D = false;
            HomeButton.BorderColor = SystemColors.ActiveCaptionText;
            HomeButton.BorderRadius = 20;
            HomeButton.BorderSize = 2;
            HomeButton.FlatAppearance.BorderSize = 0;
            HomeButton.FlatStyle = FlatStyle.Flat;
            HomeButton.Font = new Font("Century Gothic", 10.8679247F, FontStyle.Bold, GraphicsUnit.Point);
            HomeButton.ForeColor = Color.White;
            HomeButton.Location = new Point(96, 15);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(130, 50);
            HomeButton.TabIndex = 10;
            HomeButton.Text = "Home";
            HomeButton.TextColor = Color.White;
            HomeButton.UseVisualStyleBackColor = false;
            HomeButton.Click += HomeButton_Click;
            // 
            // topBorderPanel
            // 
            topBorderPanel.BackColor = Color.Black;
            topBorderPanel.BackgroundImageLayout = ImageLayout.Center;
            topBorderPanel.Dock = DockStyle.Top;
            topBorderPanel.Location = new Point(0, 107);
            topBorderPanel.Margin = new Padding(0);
            topBorderPanel.Name = "topBorderPanel";
            topBorderPanel.Size = new Size(780, 2);
            topBorderPanel.TabIndex = 24;
            // 
            // sideBarPanel
            // 
            sideBarPanel.BackColor = SystemColors.WindowFrame;
            sideBarPanel.Controls.Add(OptionsButton);
            sideBarPanel.Controls.Add(ExportPersonButton);
            sideBarPanel.Controls.Add(CheckNameDateButton);
            sideBarPanel.Dock = DockStyle.Left;
            sideBarPanel.Location = new Point(0, 109);
            sideBarPanel.Margin = new Padding(0);
            sideBarPanel.Name = "sideBarPanel";
            sideBarPanel.Size = new Size(94, 775);
            sideBarPanel.TabIndex = 26;
            // 
            // OptionsButton
            // 
            OptionsButton.BackColor = Color.FromArgb(80, 80, 80);
            OptionsButton.BackgroundColor = Color.FromArgb(80, 80, 80);
            OptionsButton.Border3D = false;
            OptionsButton.BorderColor = SystemColors.ActiveCaptionText;
            OptionsButton.BorderRadius = 20;
            OptionsButton.BorderSize = 2;
            OptionsButton.FlatAppearance.BorderSize = 0;
            OptionsButton.FlatStyle = FlatStyle.Flat;
            OptionsButton.Font = new Font("Century Gothic", 8.830189F, FontStyle.Bold, GraphicsUnit.Point);
            OptionsButton.ForeColor = Color.White;
            OptionsButton.Image = (Image)resources.GetObject("OptionsButton.Image");
            OptionsButton.Location = new Point(3, 221);
            OptionsButton.Name = "OptionsButton";
            OptionsButton.Size = new Size(85, 57);
            OptionsButton.TabIndex = 10;
            OptionsButton.TextColor = Color.White;
            OptionsButton.UseVisualStyleBackColor = false;
            OptionsButton.Click += OptionsButton_Click;
            // 
            // ExportPersonButton
            // 
            ExportPersonButton.BackColor = Color.FromArgb(80, 80, 80);
            ExportPersonButton.BackgroundColor = Color.FromArgb(80, 80, 80);
            ExportPersonButton.Border3D = false;
            ExportPersonButton.BorderColor = SystemColors.ActiveCaptionText;
            ExportPersonButton.BorderRadius = 20;
            ExportPersonButton.BorderSize = 2;
            ExportPersonButton.FlatAppearance.BorderSize = 0;
            ExportPersonButton.FlatStyle = FlatStyle.Flat;
            ExportPersonButton.Font = new Font("Century Gothic", 8.830189F, FontStyle.Bold, GraphicsUnit.Point);
            ExportPersonButton.ForeColor = Color.White;
            ExportPersonButton.Location = new Point(3, 142);
            ExportPersonButton.Name = "ExportPersonButton";
            ExportPersonButton.Size = new Size(85, 57);
            ExportPersonButton.TabIndex = 10;
            ExportPersonButton.Text = "Exportuj data";
            ExportPersonButton.TextColor = Color.White;
            ExportPersonButton.UseVisualStyleBackColor = false;
            ExportPersonButton.Click += ExportPersonButton_Click;
            // 
            // CheckNameDateButton
            // 
            CheckNameDateButton.BackColor = Color.FromArgb(80, 80, 80);
            CheckNameDateButton.BackgroundColor = Color.FromArgb(80, 80, 80);
            CheckNameDateButton.Border3D = false;
            CheckNameDateButton.BorderColor = SystemColors.ActiveCaptionText;
            CheckNameDateButton.BorderRadius = 20;
            CheckNameDateButton.BorderSize = 2;
            CheckNameDateButton.FlatAppearance.BorderSize = 0;
            CheckNameDateButton.FlatStyle = FlatStyle.Flat;
            CheckNameDateButton.Font = new Font("Century Gothic", 8.830189F, FontStyle.Bold, GraphicsUnit.Point);
            CheckNameDateButton.ForeColor = Color.White;
            CheckNameDateButton.Location = new Point(3, 62);
            CheckNameDateButton.Name = "CheckNameDateButton";
            CheckNameDateButton.Size = new Size(85, 57);
            CheckNameDateButton.TabIndex = 10;
            CheckNameDateButton.Text = "Vyhledej svátek";
            CheckNameDateButton.TextColor = Color.White;
            CheckNameDateButton.UseVisualStyleBackColor = false;
            CheckNameDateButton.Click += CheckNameDateButton_Click;
            // 
            // sideBorderPanel
            // 
            sideBorderPanel.BackColor = Color.Black;
            sideBorderPanel.Dock = DockStyle.Left;
            sideBorderPanel.Location = new Point(94, 109);
            sideBorderPanel.Margin = new Padding(0);
            sideBorderPanel.Name = "sideBorderPanel";
            sideBorderPanel.Size = new Size(2, 775);
            sideBorderPanel.TabIndex = 27;
            // 
            // mainAreaPanel
            // 
            mainAreaPanel.Font = new Font("Segoe UI", 8.830189F, FontStyle.Regular, GraphicsUnit.Point);
            mainAreaPanel.Location = new Point(96, 109);
            mainAreaPanel.Margin = new Padding(5, 6, 5, 6);
            mainAreaPanel.Name = "mainAreaPanel";
            mainAreaPanel.RightToLeft = RightToLeft.No;
            mainAreaPanel.Size = new Size(674, 764);
            mainAreaPanel.TabIndex = 28;
            // 
            // PrimaryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(150, 150, 150);
            ClientSize = new Size(780, 884);
            ControlBox = false;
            Controls.Add(mainAreaPanel);
            Controls.Add(sideBorderPanel);
            Controls.Add(sideBarPanel);
            Controls.Add(topBorderPanel);
            Controls.Add(mainBarPanel);
            Controls.Add(TitleBarPanel);
            DoubleBuffered = true;
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(780, 884);
            Name = "PrimaryForm";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Výročí";
            Load += PrimaryForm_Load;
            Resize += PrimaryForm_Resize;
            TitleBarPanel.ResumeLayout(false);
            mainBarPanel.ResumeLayout(false);
            sideBarPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private SaveFileDialog osobaSaveFileDialog;
        private Panel TitleBarPanel;
        private CustomRoundButton.RoundButton MinimizeRndButton;
        private CustomRoundButton.RoundButton MaximizeRndButton;
        private CustomRoundButton.RoundButton CloseRndButton;
        private Panel mainBarPanel;
        private Panel topBorderPanel;
        private Panel sideBarPanel;
        private Panel sideBorderPanel;
        private Panel mainAreaPanel;
        private CustomRoundButton.RoundButton HomeButton;
        private CustomRoundButton.RoundButton RemoveButton;
        private CustomRoundButton.RoundButton EditButton;
        private CustomRoundButton.RoundButton AddButton;
        private CustomRoundButton.RoundButton OptionsButton;
        private CustomRoundButton.RoundButton ExportPersonButton;
        private CustomRoundButton.RoundButton CheckNameDateButton;
    }
}