namespace Upominac
{
    partial class HomeTabUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeTabUC));
            personDetailTextBox = new TextBox();
            PersonDetailCheckBox = new CheckBox();
            label5 = new Label();
            nameDayLabel = new Label();
            label3 = new Label();
            confettiPictureBox = new PictureBox();
            todayBirthdayLabel = new Label();
            birthMonthCalendar = new MonthCalendar();
            ageLabel = new Label();
            label7 = new Label();
            dateBirthLabel = new Label();
            nextBirthLabel = new Label();
            label4 = new Label();
            todayDateLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            PersonsListBox = new ListBox();
            borderPanel2 = new Panel();
            borderPanel4 = new Panel();
            panel3 = new Panel();
            borderPanel1 = new Panel();
            borderPanel3 = new Panel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)confettiPictureBox).BeginInit();
            borderPanel4.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // personDetailTextBox
            // 
            personDetailTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            personDetailTextBox.BackColor = SystemColors.WindowFrame;
            personDetailTextBox.BorderStyle = BorderStyle.FixedSingle;
            personDetailTextBox.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point);
            personDetailTextBox.ForeColor = Color.White;
            personDetailTextBox.Location = new Point(34, 609);
            personDetailTextBox.Multiline = true;
            personDetailTextBox.Name = "personDetailTextBox";
            personDetailTextBox.ReadOnly = true;
            personDetailTextBox.Size = new Size(41, 39);
            personDetailTextBox.TabIndex = 37;
            personDetailTextBox.Visible = false;
            // 
            // PersonDetailCheckBox
            // 
            PersonDetailCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PersonDetailCheckBox.AutoSize = true;
            PersonDetailCheckBox.Location = new Point(306, 414);
            PersonDetailCheckBox.Name = "PersonDetailCheckBox";
            PersonDetailCheckBox.Size = new Size(15, 14);
            PersonDetailCheckBox.TabIndex = 36;
            PersonDetailCheckBox.TextAlign = ContentAlignment.TopCenter;
            PersonDetailCheckBox.UseVisualStyleBackColor = true;
            PersonDetailCheckBox.CheckedChanged += PersonDetailCheckBox_CheckedChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.18868F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(288, 381);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 35;
            label5.Text = "detail";
            // 
            // nameDayLabel
            // 
            nameDayLabel.AutoSize = true;
            nameDayLabel.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point);
            nameDayLabel.Location = new Point(185, 64);
            nameDayLabel.Name = "nameDayLabel";
            nameDayLabel.Size = new Size(50, 20);
            nameDayLabel.TabIndex = 34;
            nameDayLabel.Text = "label5";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.18868F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 64);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 33;
            label3.Text = "Svátek má";
            // 
            // confettiPictureBox
            // 
            confettiPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            confettiPictureBox.Image = (Image)resources.GetObject("confettiPictureBox.Image");
            confettiPictureBox.Location = new Point(596, 633);
            confettiPictureBox.Name = "confettiPictureBox";
            confettiPictureBox.Size = new Size(56, 48);
            confettiPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            confettiPictureBox.TabIndex = 32;
            confettiPictureBox.TabStop = false;
            confettiPictureBox.Visible = false;
            // 
            // todayBirthdayLabel
            // 
            todayBirthdayLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            todayBirthdayLabel.Font = new Font("Segoe UI Semibold", 10.18868F, FontStyle.Bold, GraphicsUnit.Point);
            todayBirthdayLabel.Location = new Point(283, 645);
            todayBirthdayLabel.Name = "todayBirthdayLabel";
            todayBirthdayLabel.RightToLeft = RightToLeft.No;
            todayBirthdayLabel.Size = new Size(296, 48);
            todayBirthdayLabel.TabIndex = 31;
            todayBirthdayLabel.Text = "label3";
            // 
            // birthMonthCalendar
            // 
            birthMonthCalendar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            birthMonthCalendar.BackColor = SystemColors.WindowFrame;
            birthMonthCalendar.Enabled = false;
            birthMonthCalendar.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point);
            birthMonthCalendar.ForeColor = Color.White;
            birthMonthCalendar.Location = new Point(378, 321);
            birthMonthCalendar.Margin = new Padding(0);
            birthMonthCalendar.MaxSelectionCount = 1;
            birthMonthCalendar.Name = "birthMonthCalendar";
            birthMonthCalendar.ShowToday = false;
            birthMonthCalendar.TabIndex = 30;
            birthMonthCalendar.TitleBackColor = SystemColors.ActiveBorder;
            birthMonthCalendar.TitleForeColor = Color.Transparent;
            // 
            // ageLabel
            // 
            ageLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ageLabel.AutoSize = true;
            ageLabel.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point);
            ageLabel.Location = new Point(125, 49);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(50, 20);
            ageLabel.TabIndex = 28;
            ageLabel.Text = "label8";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.18868F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(8, 49);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 27;
            label7.Text = "Věk";
            // 
            // dateBirthLabel
            // 
            dateBirthLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateBirthLabel.AutoSize = true;
            dateBirthLabel.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point);
            dateBirthLabel.Location = new Point(125, 18);
            dateBirthLabel.Name = "dateBirthLabel";
            dateBirthLabel.Size = new Size(50, 20);
            dateBirthLabel.TabIndex = 25;
            dateBirthLabel.Text = "label1";
            // 
            // nextBirthLabel
            // 
            nextBirthLabel.AutoSize = true;
            nextBirthLabel.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point);
            nextBirthLabel.Location = new Point(185, 97);
            nextBirthLabel.Name = "nextBirthLabel";
            nextBirthLabel.Size = new Size(50, 20);
            nextBirthLabel.TabIndex = 24;
            nextBirthLabel.Text = "label1";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.18868F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(8, 18);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 23;
            label4.Text = "Narozen/a:";
            // 
            // todayDateLabel
            // 
            todayDateLabel.AutoSize = true;
            todayDateLabel.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point);
            todayDateLabel.Location = new Point(185, 30);
            todayDateLabel.Name = "todayDateLabel";
            todayDateLabel.Size = new Size(50, 20);
            todayDateLabel.TabIndex = 22;
            todayDateLabel.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.18868F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 97);
            label2.Name = "label2";
            label2.Size = new Size(152, 20);
            label2.TabIndex = 26;
            label2.Text = "Nejbližší narozeniny:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.18868F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 30);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 21;
            label1.Text = "Dnes je";
            // 
            // PersonsListBox
            // 
            PersonsListBox.Anchor = AnchorStyles.None;
            PersonsListBox.BackColor = SystemColors.WindowFrame;
            PersonsListBox.BorderStyle = BorderStyle.FixedSingle;
            PersonsListBox.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point);
            PersonsListBox.ForeColor = Color.White;
            PersonsListBox.FormattingEnabled = true;
            PersonsListBox.ItemHeight = 20;
            PersonsListBox.Location = new Point(34, 184);
            PersonsListBox.Name = "PersonsListBox";
            PersonsListBox.RightToLeft = RightToLeft.No;
            PersonsListBox.Size = new Size(236, 382);
            PersonsListBox.Sorted = true;
            PersonsListBox.TabIndex = 38;
            PersonsListBox.SelectedIndexChanged += PersonsListBox_SelectedIndexChanged;
            // 
            // borderPanel2
            // 
            borderPanel2.Location = new Point(362, 491);
            borderPanel2.Name = "borderPanel2";
            borderPanel2.Size = new Size(214, 35);
            borderPanel2.TabIndex = 39;
            // 
            // borderPanel4
            // 
            borderPanel4.Controls.Add(panel3);
            borderPanel4.Location = new Point(378, 321);
            borderPanel4.Name = "borderPanel4";
            borderPanel4.Size = new Size(171, 15);
            borderPanel4.TabIndex = 39;
            // 
            // panel3
            // 
            panel3.Location = new Point(167, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(31, 182);
            panel3.TabIndex = 40;
            // 
            // borderPanel1
            // 
            borderPanel1.Location = new Point(362, 321);
            borderPanel1.Name = "borderPanel1";
            borderPanel1.Size = new Size(17, 182);
            borderPanel1.TabIndex = 40;
            // 
            // borderPanel3
            // 
            borderPanel3.Location = new Point(545, 321);
            borderPanel3.Name = "borderPanel3";
            borderPanel3.Size = new Size(31, 182);
            borderPanel3.TabIndex = 40;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(todayDateLabel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(nameDayLabel);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nextBirthLabel);
            groupBox1.Location = new Point(34, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(618, 137);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(dateBirthLabel);
            groupBox2.Controls.Add(ageLabel);
            groupBox2.Location = new Point(354, 176);
            groupBox2.Margin = new Padding(0);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(0);
            groupBox2.Size = new Size(298, 81);
            groupBox2.TabIndex = 42;
            groupBox2.TabStop = false;
            // 
            // HomeTabUC
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(150, 150, 150);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(borderPanel3);
            Controls.Add(borderPanel1);
            Controls.Add(borderPanel4);
            Controls.Add(borderPanel2);
            Controls.Add(PersonsListBox);
            Controls.Add(personDetailTextBox);
            Controls.Add(PersonDetailCheckBox);
            Controls.Add(label5);
            Controls.Add(confettiPictureBox);
            Controls.Add(todayBirthdayLabel);
            Controls.Add(birthMonthCalendar);
            ForeColor = Color.White;
            Margin = new Padding(0);
            Name = "HomeTabUC";
            Size = new Size(674, 764);
            ((System.ComponentModel.ISupportInitialize)confettiPictureBox).EndInit();
            borderPanel4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox personDetailTextBox;
        private CheckBox PersonDetailCheckBox;
        private Label label5;
        private Label nameDayLabel;
        private Label label3;
        private PictureBox confettiPictureBox;
        private Label todayBirthdayLabel;
        private MonthCalendar birthMonthCalendar;
        private Label ageLabel;
        private Label label7;
        private Label dateBirthLabel;
        private Label nextBirthLabel;
        private Label label4;
        private Label todayDateLabel;
        private Label label2;
        private Label label1;
        public ListBox PersonsListBox;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel borderPanel2;
        private Panel borderPanel4;
        private Panel borderPanel1;
        private Panel borderPanel3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
