namespace Upominac
{
    partial class NameDayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NameDayForm));
            nameTextBox = new TextBox();
            label1 = new Label();
            roundButton1 = new CustomRoundButton.RoundButton();
            CloseRndButton = new CustomRoundButton.RoundButton();
            TitleBarPanel = new Panel();
            TitleBarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = SystemColors.WindowFrame;
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextBox.ForeColor = Color.White;
            nameTextBox.Location = new Point(80, 84);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(129, 27);
            nameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.18868F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(95, 50);
            label1.Name = "label1";
            label1.Size = new Size(101, 18);
            label1.TabIndex = 1;
            label1.Text = "Zadej jméno";
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
            roundButton1.Location = new Point(98, 136);
            roundButton1.Name = "roundButton1";
            roundButton1.Size = new Size(81, 44);
            roundButton1.TabIndex = 27;
            roundButton1.Text = "OK";
            roundButton1.TextColor = Color.White;
            roundButton1.UseVisualStyleBackColor = false;
            roundButton1.Click += OkButton_Click;
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
            CloseRndButton.Location = new Point(256, 0);
            CloseRndButton.Margin = new Padding(0);
            CloseRndButton.Name = "CloseRndButton";
            CloseRndButton.Size = new Size(28, 32);
            CloseRndButton.TabIndex = 28;
            CloseRndButton.TextColor = Color.White;
            CloseRndButton.UseVisualStyleBackColor = false;
            CloseRndButton.Click += CloseRndButton_Click;
            // 
            // TitleBarPanel
            // 
            TitleBarPanel.BackColor = Color.FromArgb(85, 85, 85);
            TitleBarPanel.Controls.Add(CloseRndButton);
            TitleBarPanel.Dock = DockStyle.Top;
            TitleBarPanel.Location = new Point(0, 0);
            TitleBarPanel.Name = "TitleBarPanel";
            TitleBarPanel.Size = new Size(286, 32);
            TitleBarPanel.TabIndex = 29;
            TitleBarPanel.MouseDown += TitleBarPanel_MouseDown;
            TitleBarPanel.MouseMove += TitleBarPanel_MouseMove;
            // 
            // NameDayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(125, 125, 125);
            ClientSize = new Size(286, 201);
            Controls.Add(TitleBarPanel);
            Controls.Add(roundButton1);
            Controls.Add(label1);
            Controls.Add(nameTextBox);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "NameDayForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vyhledej svátek osoby";
            Load += NameDayForm_Load;
            KeyUp += NameDayForm_KeyUp;
            TitleBarPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private Label label1;
        private CustomRoundButton.RoundButton roundButton1;
        private CustomRoundButton.RoundButton CloseRndButton;
        private Panel TitleBarPanel;
    }
}