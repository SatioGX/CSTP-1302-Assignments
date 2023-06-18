namespace Ch_8_Q_10
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
            btnConvert = new Button();
            txtLetter = new TextBox();
            listBoxMorseCode = new ListBox();
            SuspendLayout();
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(31, 83);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 0;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // txtLetter
            // 
            txtLetter.Location = new Point(18, 37);
            txtLetter.Name = "txtLetter";
            txtLetter.Size = new Size(100, 23);
            txtLetter.TabIndex = 1;
            // 
            // listBoxMorseCode
            // 
            listBoxMorseCode.FormattingEnabled = true;
            listBoxMorseCode.ItemHeight = 15;
            listBoxMorseCode.Location = new Point(138, 12);
            listBoxMorseCode.Name = "listBoxMorseCode";
            listBoxMorseCode.Size = new Size(172, 139);
            listBoxMorseCode.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 179);
            Controls.Add(listBoxMorseCode);
            Controls.Add(txtLetter);
            Controls.Add(btnConvert);
            Name = "Form1";
            Text = "Morse Code Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConvert;
        private TextBox txtLetter;
        private ListBox listBoxMorseCode;
    }
}