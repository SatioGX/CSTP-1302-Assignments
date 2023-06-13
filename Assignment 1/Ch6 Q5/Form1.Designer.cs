namespace Ch6_Q5
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
            oildAndLubeBox = new GroupBox();
            lubeJob = new CheckBox();
            oilChange = new CheckBox();
            flushBox = new GroupBox();
            transmissionFlush = new CheckBox();
            radiatorFlush = new CheckBox();
            miscBox = new GroupBox();
            tireRotation = new CheckBox();
            replaceMuffler = new CheckBox();
            inspection = new CheckBox();
            partsAndLaborBox = new GroupBox();
            laborTextBox = new TextBox();
            partsTextBox = new TextBox();
            laborLabel = new Label();
            partsLabel = new Label();
            calculateButton = new Button();
            groupBox5 = new GroupBox();
            totalFeesTextBox = new TextBox();
            taxTextBox = new TextBox();
            totalFeesLabel = new Label();
            taxLabel = new Label();
            partsSummaryTextBox = new TextBox();
            serviceAndLaborTextBox = new TextBox();
            partsSummaryLabel = new Label();
            serviceAndLaborLabel = new Label();
            clearButton = new Button();
            exitButton = new Button();
            oildAndLubeBox.SuspendLayout();
            flushBox.SuspendLayout();
            miscBox.SuspendLayout();
            partsAndLaborBox.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // oildAndLubeBox
            // 
            oildAndLubeBox.Controls.Add(lubeJob);
            oildAndLubeBox.Controls.Add(oilChange);
            oildAndLubeBox.Location = new Point(12, 12);
            oildAndLubeBox.Name = "oildAndLubeBox";
            oildAndLubeBox.Size = new Size(169, 80);
            oildAndLubeBox.TabIndex = 0;
            oildAndLubeBox.TabStop = false;
            oildAndLubeBox.Text = "Oil and Lube";
            // 
            // lubeJob
            // 
            lubeJob.AutoSize = true;
            lubeJob.Location = new Point(6, 47);
            lubeJob.Name = "lubeJob";
            lubeJob.Size = new Size(116, 19);
            lubeJob.TabIndex = 1;
            lubeJob.Text = "Lube job ($18.00)";
            lubeJob.UseVisualStyleBackColor = true;
            // 
            // oilChange
            // 
            oilChange.AutoSize = true;
            oilChange.Location = new Point(6, 22);
            oilChange.Name = "oilChange";
            oilChange.Size = new Size(129, 19);
            oilChange.TabIndex = 0;
            oilChange.Text = "Oil Change ($26.00)";
            oilChange.UseVisualStyleBackColor = true;
            // 
            // flushBox
            // 
            flushBox.Controls.Add(transmissionFlush);
            flushBox.Controls.Add(radiatorFlush);
            flushBox.Location = new Point(205, 12);
            flushBox.Name = "flushBox";
            flushBox.Size = new Size(180, 80);
            flushBox.TabIndex = 1;
            flushBox.TabStop = false;
            flushBox.Text = "Flush";
            // 
            // transmissionFlush
            // 
            transmissionFlush.AutoSize = true;
            transmissionFlush.Location = new Point(6, 47);
            transmissionFlush.Name = "transmissionFlush";
            transmissionFlush.Size = new Size(169, 19);
            transmissionFlush.TabIndex = 1;
            transmissionFlush.Text = "Transmission Flush ($80.00)";
            transmissionFlush.UseVisualStyleBackColor = true;
            // 
            // radiatorFlush
            // 
            radiatorFlush.AutoSize = true;
            radiatorFlush.Location = new Point(6, 22);
            radiatorFlush.Name = "radiatorFlush";
            radiatorFlush.Size = new Size(145, 19);
            radiatorFlush.TabIndex = 0;
            radiatorFlush.Text = "Radiator Flush ($30.00)";
            radiatorFlush.UseVisualStyleBackColor = true;
            // 
            // miscBox
            // 
            miscBox.Controls.Add(tireRotation);
            miscBox.Controls.Add(replaceMuffler);
            miscBox.Controls.Add(inspection);
            miscBox.Location = new Point(12, 98);
            miscBox.Name = "miscBox";
            miscBox.Size = new Size(169, 100);
            miscBox.TabIndex = 2;
            miscBox.TabStop = false;
            miscBox.Text = "Misc";
            // 
            // tireRotation
            // 
            tireRotation.AutoSize = true;
            tireRotation.Location = new Point(6, 75);
            tireRotation.Name = "tireRotation";
            tireRotation.Size = new Size(137, 19);
            tireRotation.TabIndex = 2;
            tireRotation.Text = "Tire Rotation ($20.00)";
            tireRotation.UseVisualStyleBackColor = true;
            // 
            // replaceMuffler
            // 
            replaceMuffler.AutoSize = true;
            replaceMuffler.Location = new Point(6, 50);
            replaceMuffler.Name = "replaceMuffler";
            replaceMuffler.Size = new Size(159, 19);
            replaceMuffler.TabIndex = 1;
            replaceMuffler.Text = "Replace Muffler ($100.00)";
            replaceMuffler.UseVisualStyleBackColor = true;
            // 
            // inspection
            // 
            inspection.AutoSize = true;
            inspection.Location = new Point(6, 25);
            inspection.Name = "inspection";
            inspection.Size = new Size(125, 19);
            inspection.TabIndex = 0;
            inspection.Text = "Inspection ($15.00)";
            inspection.UseVisualStyleBackColor = true;
            // 
            // partsAndLaborBox
            // 
            partsAndLaborBox.Controls.Add(laborTextBox);
            partsAndLaborBox.Controls.Add(partsTextBox);
            partsAndLaborBox.Controls.Add(laborLabel);
            partsAndLaborBox.Controls.Add(partsLabel);
            partsAndLaborBox.Location = new Point(205, 98);
            partsAndLaborBox.Name = "partsAndLaborBox";
            partsAndLaborBox.Size = new Size(180, 100);
            partsAndLaborBox.TabIndex = 5;
            partsAndLaborBox.TabStop = false;
            partsAndLaborBox.Text = "Parts and Labor";
            // 
            // laborTextBox
            // 
            laborTextBox.Location = new Point(81, 60);
            laborTextBox.Name = "laborTextBox";
            laborTextBox.Size = new Size(53, 23);
            laborTextBox.TabIndex = 3;
            // 
            // partsTextBox
            // 
            partsTextBox.Location = new Point(81, 25);
            partsTextBox.Name = "partsTextBox";
            partsTextBox.Size = new Size(53, 23);
            partsTextBox.TabIndex = 2;
            // 
            // laborLabel
            // 
            laborLabel.AutoSize = true;
            laborLabel.Location = new Point(21, 63);
            laborLabel.Name = "laborLabel";
            laborLabel.Size = new Size(54, 15);
            laborLabel.TabIndex = 1;
            laborLabel.Text = "Labor ($)";
            // 
            // partsLabel
            // 
            partsLabel.AutoSize = true;
            partsLabel.Location = new Point(21, 29);
            partsLabel.Name = "partsLabel";
            partsLabel.Size = new Size(33, 15);
            partsLabel.TabIndex = 0;
            partsLabel.Text = "Parts";
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(76, 370);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 23);
            calculateButton.TabIndex = 9;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(totalFeesTextBox);
            groupBox5.Controls.Add(taxTextBox);
            groupBox5.Controls.Add(totalFeesLabel);
            groupBox5.Controls.Add(taxLabel);
            groupBox5.Controls.Add(partsSummaryTextBox);
            groupBox5.Controls.Add(serviceAndLaborTextBox);
            groupBox5.Controls.Add(partsSummaryLabel);
            groupBox5.Controls.Add(serviceAndLaborLabel);
            groupBox5.Location = new Point(12, 204);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(373, 160);
            groupBox5.TabIndex = 8;
            groupBox5.TabStop = false;
            groupBox5.Text = "Summary";
            // 
            // totalFeesTextBox
            // 
            totalFeesTextBox.Location = new Point(134, 126);
            totalFeesTextBox.Name = "totalFeesTextBox";
            totalFeesTextBox.Size = new Size(106, 23);
            totalFeesTextBox.TabIndex = 7;
            // 
            // taxTextBox
            // 
            taxTextBox.Location = new Point(134, 91);
            taxTextBox.Name = "taxTextBox";
            taxTextBox.Size = new Size(106, 23);
            taxTextBox.TabIndex = 6;
            // 
            // totalFeesLabel
            // 
            totalFeesLabel.AutoSize = true;
            totalFeesLabel.Location = new Point(64, 126);
            totalFeesLabel.Name = "totalFeesLabel";
            totalFeesLabel.Size = new Size(58, 15);
            totalFeesLabel.TabIndex = 5;
            totalFeesLabel.Text = "Total Fees";
            // 
            // taxLabel
            // 
            taxLabel.AutoSize = true;
            taxLabel.Location = new Point(42, 99);
            taxLabel.Name = "taxLabel";
            taxLabel.Size = new Size(80, 15);
            taxLabel.TabIndex = 4;
            taxLabel.Text = "Tax (On Parts)";
            // 
            // partsSummaryTextBox
            // 
            partsSummaryTextBox.Location = new Point(134, 55);
            partsSummaryTextBox.Name = "partsSummaryTextBox";
            partsSummaryTextBox.Size = new Size(106, 23);
            partsSummaryTextBox.TabIndex = 3;
            // 
            // serviceAndLaborTextBox
            // 
            serviceAndLaborTextBox.Location = new Point(134, 20);
            serviceAndLaborTextBox.Name = "serviceAndLaborTextBox";
            serviceAndLaborTextBox.Size = new Size(106, 23);
            serviceAndLaborTextBox.TabIndex = 2;
            // 
            // partsSummaryLabel
            // 
            partsSummaryLabel.AutoSize = true;
            partsSummaryLabel.Location = new Point(89, 63);
            partsSummaryLabel.Name = "partsSummaryLabel";
            partsSummaryLabel.Size = new Size(33, 15);
            partsSummaryLabel.TabIndex = 1;
            partsSummaryLabel.Text = "Parts";
            // 
            // serviceAndLaborLabel
            // 
            serviceAndLaborLabel.AutoSize = true;
            serviceAndLaborLabel.Location = new Point(22, 24);
            serviceAndLaborLabel.Name = "serviceAndLaborLabel";
            serviceAndLaborLabel.Size = new Size(100, 15);
            serviceAndLaborLabel.TabIndex = 0;
            serviceAndLaborLabel.Text = "Service and Labor";
            // 
            // clearButton
            // 
            clearButton.Location = new Point(157, 370);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 10;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(238, 370);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 12;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 404);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(calculateButton);
            Controls.Add(groupBox5);
            Controls.Add(partsAndLaborBox);
            Controls.Add(miscBox);
            Controls.Add(flushBox);
            Controls.Add(oildAndLubeBox);
            Name = "Form1";
            Text = "Automotive";
            oildAndLubeBox.ResumeLayout(false);
            oildAndLubeBox.PerformLayout();
            flushBox.ResumeLayout(false);
            flushBox.PerformLayout();
            miscBox.ResumeLayout(false);
            miscBox.PerformLayout();
            partsAndLaborBox.ResumeLayout(false);
            partsAndLaborBox.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox oildAndLubeBox;
        private CheckBox lubeJob;
        private CheckBox oilChange;
        private GroupBox flushBox;
        private CheckBox transmissionFlush;
        private CheckBox radiatorFlush;
        private GroupBox miscBox;
        private CheckBox tireRotation;
        private CheckBox replaceMuffler;
        private CheckBox inspection;
        private GroupBox partsAndLaborBox;
        private TextBox laborTextBox;
        private TextBox partsTextBox;
        private Label laborLabel;
        private Label partsLabel;
        private Button calculateButton;
        private GroupBox groupBox5;
        private TextBox partsSummaryTextBox;
        private TextBox serviceAndLaborTextBox;
        private Label partsSummaryLabel;
        private Label serviceAndLaborLabel;
        private Button clearButton;
        private TextBox totalFeesTextBox;
        private TextBox taxTextBox;
        private Label totalFeesLabel;
        private Label taxLabel;
        private Button exitButton;
    }
}