namespace Lyler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ResultBox = new TextBox();
            label1 = new Label();
            TitleInput = new TextBox();
            ArtistInput = new TextBox();
            panel1 = new Panel();
            neButton = new Button();
            prButton = new Button();
            LogText = new TextBox();
            LyricButton = new Button();
            PlayButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ResultBox
            // 
            ResultBox.BackColor = SystemColors.ButtonHighlight;
            ResultBox.Font = new Font("바탕", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            ResultBox.Location = new Point(16, 83);
            ResultBox.Multiline = true;
            ResultBox.Name = "ResultBox";
            ResultBox.ReadOnly = true;
            ResultBox.ScrollBars = ScrollBars.Vertical;
            ResultBox.Size = new Size(455, 351);
            ResultBox.TabIndex = 0;
            ResultBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("바탕", 36F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(185, 48);
            label1.Name = "label1";
            label1.Size = new Size(147, 48);
            label1.TabIndex = 1;
            label1.Text = "Lyler";
            label1.Click += label1_Click;
            // 
            // TitleInput
            // 
            TitleInput.Font = new Font("바탕", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            TitleInput.Location = new Point(126, 116);
            TitleInput.Multiline = true;
            TitleInput.Name = "TitleInput";
            TitleInput.PlaceholderText = "제목을 입력하세요";
            TitleInput.Size = new Size(256, 23);
            TitleInput.TabIndex = 3;
            TitleInput.TextAlign = HorizontalAlignment.Center;
            TitleInput.TextChanged += TitleInput_TextChanged;
            // 
            // ArtistInput
            // 
            ArtistInput.Font = new Font("바탕", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            ArtistInput.Location = new Point(139, 145);
            ArtistInput.Multiline = true;
            ArtistInput.Name = "ArtistInput";
            ArtistInput.PlaceholderText = "아티스트를 입력하세요";
            ArtistInput.Size = new Size(225, 23);
            ArtistInput.TabIndex = 4;
            ArtistInput.TextAlign = HorizontalAlignment.Center;
            ArtistInput.TextChanged += ArtistInput_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(neButton);
            panel1.Controls.Add(prButton);
            panel1.Controls.Add(LogText);
            panel1.Controls.Add(LyricButton);
            panel1.Controls.Add(PlayButton);
            panel1.Controls.Add(ResultBox);
            panel1.Location = new Point(12, 180);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 437);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // neButton
            // 
            neButton.BackColor = Color.Snow;
            neButton.Font = new Font("바탕", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            neButton.Location = new Point(440, 48);
            neButton.Name = "neButton";
            neButton.Size = new Size(32, 29);
            neButton.TabIndex = 5;
            neButton.TabStop = false;
            neButton.Text = ">";
            neButton.UseVisualStyleBackColor = false;
            neButton.Click += neButton_Click;
            // 
            // prButton
            // 
            prButton.BackColor = Color.Snow;
            prButton.Font = new Font("바탕", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            prButton.Location = new Point(16, 48);
            prButton.Name = "prButton";
            prButton.Size = new Size(32, 29);
            prButton.TabIndex = 4;
            prButton.TabStop = false;
            prButton.Text = "<";
            prButton.UseVisualStyleBackColor = false;
            prButton.Click += prButton_Click;
            // 
            // LogText
            // 
            LogText.BackColor = SystemColors.ButtonHighlight;
            LogText.Font = new Font("바탕", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            LogText.Location = new Point(75, 48);
            LogText.Multiline = true;
            LogText.Name = "LogText";
            LogText.ReadOnly = true;
            LogText.Size = new Size(343, 29);
            LogText.TabIndex = 3;
            LogText.TextAlign = HorizontalAlignment.Center;
            // 
            // LyricButton
            // 
            LyricButton.BackColor = SystemColors.ActiveCaption;
            LyricButton.Font = new Font("바탕", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            LyricButton.Location = new Point(3, 3);
            LyricButton.Name = "LyricButton";
            LyricButton.Size = new Size(228, 39);
            LyricButton.TabIndex = 2;
            LyricButton.TabStop = false;
            LyricButton.Text = "#^@ 가사 가져오기 $#@";
            LyricButton.UseVisualStyleBackColor = false;
            LyricButton.Click += LyricButton_Click;
            // 
            // PlayButton
            // 
            PlayButton.BackColor = Color.LightGreen;
            PlayButton.Font = new Font("바탕", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            PlayButton.ForeColor = SystemColors.ControlText;
            PlayButton.Location = new Point(237, 3);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(245, 39);
            PlayButton.TabIndex = 1;
            PlayButton.TabStop = false;
            PlayButton.Text = "#^@ 음악 재생 $#@";
            PlayButton.UseVisualStyleBackColor = false;
            PlayButton.Click += PlayButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(509, 629);
            Controls.Add(panel1);
            Controls.Add(ArtistInput);
            Controls.Add(TitleInput);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ResultBox;
        private Label label1;
        private TextBox TitleInput;
        private TextBox ArtistInput;
        private Panel panel1;
        private Button PlayButton;
        private Button LyricButton;
        private TextBox LogText;
        private Button neButton;
        private Button prButton;
    }
}
