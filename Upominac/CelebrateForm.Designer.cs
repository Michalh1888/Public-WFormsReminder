namespace Upominac
{
    partial class CelebrateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CelebrateForm));
            VypisLabel = new Label();
            VypisJmenoLabel = new Label();
            OkButton = new Button();
            SuspendLayout();
            // 
            // VypisLabel
            // 
            VypisLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            VypisLabel.Location = new Point(63, 32);
            VypisLabel.Name = "VypisLabel";
            VypisLabel.Size = new Size(145, 26);
            VypisLabel.TabIndex = 0;
            VypisLabel.Text = "label1";
            VypisLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // VypisJmenoLabel
            // 
            VypisJmenoLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            VypisJmenoLabel.Location = new Point(63, 58);
            VypisJmenoLabel.Name = "VypisJmenoLabel";
            VypisJmenoLabel.Size = new Size(145, 26);
            VypisJmenoLabel.TabIndex = 0;
            VypisJmenoLabel.Text = "label2";
            VypisJmenoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OkButton
            // 
            OkButton.Location = new Point(100, 127);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(75, 23);
            OkButton.TabIndex = 1;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // CelebrateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(268, 187);
            Controls.Add(OkButton);
            Controls.Add(VypisJmenoLabel);
            Controls.Add(VypisLabel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CelebrateForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Narozeniny!!!";
            ResumeLayout(false);
        }

        #endregion

        private Label VypisLabel;
        private Label VypisJmenoLabel;
        private Button OkButton;
    }
}