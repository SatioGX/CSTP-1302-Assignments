namespace Ch5_Q14
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
            Open = new Button();
            listBox1 = new ListBox();
            sumNumbers = new Label();
            totalNumbers = new Label();
            SuspendLayout();
            // 
            // Open
            // 
            Open.Location = new Point(105, 175);
            Open.Name = "Open";
            Open.Size = new Size(75, 23);
            Open.TabIndex = 0;
            Open.Text = "Open";
            Open.UseVisualStyleBackColor = true;
            Open.Click += Open_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(42, 53);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // sumNumbers
            // 
            sumNumbers.AutoSize = true;
            sumNumbers.Location = new Point(185, 53);
            sumNumbers.Name = "sumNumbers";
            sumNumbers.Size = new Size(115, 15);
            sumNumbers.TabIndex = 2;
            sumNumbers.Text = "Sum of all Numbers:";
            sumNumbers.Click += sumNumbers_Click;
            // 
            // totalNumbers
            // 
            totalNumbers.AutoSize = true;
            totalNumbers.Location = new Point(185, 132);
            totalNumbers.Name = "totalNumbers";
            totalNumbers.Size = new Size(87, 15);
            totalNumbers.TabIndex = 3;
            totalNumbers.Text = "Total Numbers:";
            totalNumbers.Click += totalNumbers_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 237);
            Controls.Add(totalNumbers);
            Controls.Add(sumNumbers);
            Controls.Add(listBox1);
            Controls.Add(Open);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Open;
        private ListBox listBox1;
        private Label sumNumbers;
        private Label totalNumbers;
    }
}