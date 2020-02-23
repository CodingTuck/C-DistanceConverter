namespace Distance_Converter
{
    partial class Form1
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
            this.fromGroupBox = new System.Windows.Forms.GroupBox();
            this.fromListBox = new System.Windows.Forms.ListBox();
            this.toGroupBox = new System.Windows.Forms.GroupBox();
            this.toListBox = new System.Windows.Forms.ListBox();
            this.distanceConvertLabel = new System.Windows.Forms.Label();
            this.convertedDistanceLabel = new System.Windows.Forms.Label();
            this.convertedDistanceOutput = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.distanceConvertInput = new System.Windows.Forms.TextBox();
            this.fromGroupBox.SuspendLayout();
            this.toGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fromGroupBox
            // 
            this.fromGroupBox.Controls.Add(this.fromListBox);
            this.fromGroupBox.Location = new System.Drawing.Point(12, 76);
            this.fromGroupBox.Name = "fromGroupBox";
            this.fromGroupBox.Size = new System.Drawing.Size(161, 119);
            this.fromGroupBox.TabIndex = 0;
            this.fromGroupBox.TabStop = false;
            this.fromGroupBox.Text = "From";
            // 
            // fromListBox
            // 
            this.fromListBox.FormattingEnabled = true;
            this.fromListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.fromListBox.Location = new System.Drawing.Point(20, 19);
            this.fromListBox.Name = "fromListBox";
            this.fromListBox.Size = new System.Drawing.Size(120, 56);
            this.fromListBox.TabIndex = 3;
            // 
            // toGroupBox
            // 
            this.toGroupBox.Controls.Add(this.toListBox);
            this.toGroupBox.Location = new System.Drawing.Point(200, 76);
            this.toGroupBox.Name = "toGroupBox";
            this.toGroupBox.Size = new System.Drawing.Size(161, 119);
            this.toGroupBox.TabIndex = 1;
            this.toGroupBox.TabStop = false;
            this.toGroupBox.Text = "To";
            // 
            // toListBox
            // 
            this.toListBox.FormattingEnabled = true;
            this.toListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.toListBox.Location = new System.Drawing.Point(28, 19);
            this.toListBox.Name = "toListBox";
            this.toListBox.Size = new System.Drawing.Size(120, 56);
            this.toListBox.TabIndex = 2;
            // 
            // distanceConvertLabel
            // 
            this.distanceConvertLabel.AutoSize = true;
            this.distanceConvertLabel.Location = new System.Drawing.Point(35, 39);
            this.distanceConvertLabel.Name = "distanceConvertLabel";
            this.distanceConvertLabel.Size = new System.Drawing.Size(138, 13);
            this.distanceConvertLabel.TabIndex = 2;
            this.distanceConvertLabel.Text = "Enter a distance to convert:";
            // 
            // convertedDistanceLabel
            // 
            this.convertedDistanceLabel.AutoSize = true;
            this.convertedDistanceLabel.Location = new System.Drawing.Point(69, 215);
            this.convertedDistanceLabel.Name = "convertedDistanceLabel";
            this.convertedDistanceLabel.Size = new System.Drawing.Size(104, 13);
            this.convertedDistanceLabel.TabIndex = 3;
            this.convertedDistanceLabel.Text = "Converted Distance:";
            // 
            // convertedDistanceOutput
            // 
            this.convertedDistanceOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.convertedDistanceOutput.Location = new System.Drawing.Point(200, 215);
            this.convertedDistanceOutput.Name = "convertedDistanceOutput";
            this.convertedDistanceOutput.Size = new System.Drawing.Size(109, 26);
            this.convertedDistanceOutput.TabIndex = 4;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(98, 257);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 5;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(200, 257);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // distanceConvertInput
            // 
            this.distanceConvertInput.Location = new System.Drawing.Point(200, 36);
            this.distanceConvertInput.Name = "distanceConvertInput";
            this.distanceConvertInput.Size = new System.Drawing.Size(100, 20);
            this.distanceConvertInput.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 292);
            this.Controls.Add(this.distanceConvertInput);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.convertedDistanceOutput);
            this.Controls.Add(this.convertedDistanceLabel);
            this.Controls.Add(this.distanceConvertLabel);
            this.Controls.Add(this.toGroupBox);
            this.Controls.Add(this.fromGroupBox);
            this.Name = "Form1";
            this.Text = "Distance Converter";
            this.fromGroupBox.ResumeLayout(false);
            this.toGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox fromGroupBox;
        private System.Windows.Forms.ListBox fromListBox;
        private System.Windows.Forms.GroupBox toGroupBox;
        private System.Windows.Forms.ListBox toListBox;
        private System.Windows.Forms.Label distanceConvertLabel;
        private System.Windows.Forms.Label convertedDistanceLabel;
        private System.Windows.Forms.Label convertedDistanceOutput;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox distanceConvertInput;
    }
}

