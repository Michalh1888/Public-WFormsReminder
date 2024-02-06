namespace Upominac
{
    partial class AddTabUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTabUC));
            label3 = new Label();
            pictureBox1 = new PictureBox();
            birthDateTimePicker = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            nameTextBox = new TextBox();
            personDataTextBox = new TextBox();
            OkButton = new CustomRoundButton.RoundButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.18868F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(157, 360);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 23;
            label3.Text = "Další údaje";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(265, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // birthDateTimePicker
            // 
            birthDateTimePicker.CalendarForeColor = Color.White;
            birthDateTimePicker.CalendarMonthBackground = SystemColors.WindowFrame;
            birthDateTimePicker.CalendarTitleBackColor = SystemColors.ActiveBorder;
            birthDateTimePicker.CalendarTitleForeColor = SystemColors.WindowFrame;
            birthDateTimePicker.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point);
            birthDateTimePicker.Location = new Point(297, 316);
            birthDateTimePicker.Name = "birthDateTimePicker";
            birthDateTimePicker.Size = new Size(202, 27);
            birthDateTimePicker.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.18868F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(157, 320);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 17;
            label2.Text = "Datum narození";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.18868F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(157, 281);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 16;
            label1.Text = "Jméno";
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = SystemColors.WindowFrame;
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextBox.ForeColor = Color.White;
            nameTextBox.Location = new Point(297, 274);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(202, 27);
            nameTextBox.TabIndex = 24;
            // 
            // personDataTextBox
            // 
            personDataTextBox.BackColor = SystemColors.WindowFrame;
            personDataTextBox.BorderStyle = BorderStyle.FixedSingle;
            personDataTextBox.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point);
            personDataTextBox.ForeColor = Color.White;
            personDataTextBox.Location = new Point(157, 393);
            personDataTextBox.Multiline = true;
            personDataTextBox.Name = "personDataTextBox";
            personDataTextBox.Size = new Size(342, 191);
            personDataTextBox.TabIndex = 24;
            // 
            // OkButton
            // 
            OkButton.BackColor = Color.FromArgb(80, 80, 80);
            OkButton.BackgroundColor = Color.FromArgb(80, 80, 80);
            OkButton.Border3D = false;
            OkButton.BorderColor = SystemColors.ActiveCaptionText;
            OkButton.BorderRadius = 20;
            OkButton.BorderSize = 2;
            OkButton.FlatAppearance.BorderSize = 0;
            OkButton.FlatStyle = FlatStyle.Flat;
            OkButton.Font = new Font("Century Gothic", 10.18868F, FontStyle.Bold, GraphicsUnit.Point);
            OkButton.ForeColor = Color.White;
            OkButton.Location = new Point(281, 632);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(81, 44);
            OkButton.TabIndex = 26;
            OkButton.Text = "OK";
            OkButton.TextColor = Color.White;
            OkButton.UseVisualStyleBackColor = false;
            OkButton.Click += OkButton_Click;
            // 
            // AddTabUC
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(150, 150, 150);
            Controls.Add(OkButton);
            Controls.Add(personDataTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(birthDateTimePicker);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.White;
            Margin = new Padding(0);
            Name = "AddTabUC";
            Size = new Size(674, 764);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private PictureBox pictureBox1;
        private Button roundButton1;
        private DateTimePicker birthDateTimePicker;
        private Label label2;
        private Label label1;
        private TextBox nameTextBox;
        private TextBox personDataTextBox;
        private CustomRoundButton.RoundButton OkButton;
    }
}
