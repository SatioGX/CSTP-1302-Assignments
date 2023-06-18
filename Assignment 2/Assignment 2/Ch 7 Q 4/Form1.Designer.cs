namespace Ch_7_Q_4
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
            studentAnswers = new Button();
            correctLabel = new Label();
            incorrectLabel = new Label();
            resultLabel = new Label();
            IncorrectQuestionsBox = new ListBox();
            incorrectQuestionsLabel = new Label();
            SuspendLayout();
            // 
            // studentAnswers
            // 
            studentAnswers.Location = new Point(9, 141);
            studentAnswers.Name = "studentAnswers";
            studentAnswers.Size = new Size(110, 23);
            studentAnswers.TabIndex = 0;
            studentAnswers.Text = "Student Answers";
            studentAnswers.UseVisualStyleBackColor = true;
            studentAnswers.Click += studentAnswers_Click;
            // 
            // correctLabel
            // 
            correctLabel.AutoSize = true;
            correctLabel.Location = new Point(253, 61);
            correctLabel.Name = "correctLabel";
            correctLabel.Size = new Size(86, 15);
            correctLabel.TabIndex = 1;
            correctLabel.Text = "Total Correct: 0";
            // 
            // incorrectLabel
            // 
            incorrectLabel.AutoSize = true;
            incorrectLabel.Location = new Point(253, 90);
            incorrectLabel.Name = "incorrectLabel";
            incorrectLabel.Size = new Size(94, 15);
            incorrectLabel.TabIndex = 2;
            incorrectLabel.Text = "Total Incorrect: 0";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(133, 145);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(51, 15);
            resultLabel.TabIndex = 3;
            resultLabel.Text = "Result: 0";
            // 
            // IncorrectQuestionsBox
            // 
            IncorrectQuestionsBox.FormattingEnabled = true;
            IncorrectQuestionsBox.ItemHeight = 15;
            IncorrectQuestionsBox.Location = new Point(12, 41);
            IncorrectQuestionsBox.Name = "IncorrectQuestionsBox";
            IncorrectQuestionsBox.Size = new Size(222, 94);
            IncorrectQuestionsBox.TabIndex = 4;
            // 
            // incorrectQuestionsLabel
            // 
            incorrectQuestionsLabel.AutoSize = true;
            incorrectQuestionsLabel.Location = new Point(12, 23);
            incorrectQuestionsLabel.Name = "incorrectQuestionsLabel";
            incorrectQuestionsLabel.Size = new Size(172, 15);
            incorrectQuestionsLabel.TabIndex = 5;
            incorrectQuestionsLabel.Text = "Incorrect Questions Listed Here";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 198);
            Controls.Add(incorrectQuestionsLabel);
            Controls.Add(IncorrectQuestionsBox);
            Controls.Add(resultLabel);
            Controls.Add(incorrectLabel);
            Controls.Add(correctLabel);
            Controls.Add(studentAnswers);
            Name = "Form1";
            Text = "Multi-Choice Grader";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button studentAnswers;
        private Label correctLabel;
        private Label incorrectLabel;
        private Label resultLabel;
        private ListBox IncorrectQuestionsBox;
        private Label incorrectQuestionsLabel;
    }
}