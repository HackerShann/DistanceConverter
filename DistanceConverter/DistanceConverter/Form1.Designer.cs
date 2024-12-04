namespace DistanceConverter
{
    partial class DistanceConverter
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
            this.From = new System.Windows.Forms.GroupBox();
            this.ListBox_From = new System.Windows.Forms.ListBox();
            this.To = new System.Windows.Forms.GroupBox();
            this.ListBox_To = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.convert_enter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.convert_answer = new System.Windows.Forms.Label();
            this.Convert = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.From.SuspendLayout();
            this.To.SuspendLayout();
            this.SuspendLayout();
            // 
            // From
            // 
            this.From.Controls.Add(this.ListBox_From);
            this.From.Location = new System.Drawing.Point(83, 212);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(402, 284);
            this.From.TabIndex = 0;
            this.From.TabStop = false;
            this.From.Text = "From";
            this.From.Enter += new System.EventHandler(this.From_Enter);
            // 
            // ListBox_From
            // 
            this.ListBox_From.FormattingEnabled = true;
            this.ListBox_From.ItemHeight = 25;
            this.ListBox_From.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.ListBox_From.Location = new System.Drawing.Point(62, 87);
            this.ListBox_From.Name = "ListBox_From";
            this.ListBox_From.Size = new System.Drawing.Size(268, 129);
            this.ListBox_From.TabIndex = 0;
            // 
            // To
            // 
            this.To.Controls.Add(this.ListBox_To);
            this.To.Location = new System.Drawing.Point(611, 212);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(402, 284);
            this.To.TabIndex = 1;
            this.To.TabStop = false;
            this.To.Text = "To";
            // 
            // ListBox_To
            // 
            this.ListBox_To.FormattingEnabled = true;
            this.ListBox_To.ItemHeight = 25;
            this.ListBox_To.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.ListBox_To.Location = new System.Drawing.Point(68, 87);
            this.ListBox_To.Name = "ListBox_To";
            this.ListBox_To.Size = new System.Drawing.Size(271, 129);
            this.ListBox_To.TabIndex = 0;
            this.ListBox_To.SelectedIndexChanged += new System.EventHandler(this.ListBox_To_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter a distance to convert:";
            // 
            // convert_enter
            // 
            this.convert_enter.Location = new System.Drawing.Point(586, 101);
            this.convert_enter.Name = "convert_enter";
            this.convert_enter.Size = new System.Drawing.Size(281, 31);
            this.convert_enter.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 606);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter a distance to convert:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // convert_answer
            // 
            this.convert_answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.convert_answer.Location = new System.Drawing.Point(586, 585);
            this.convert_answer.Name = "convert_answer";
            this.convert_answer.Size = new System.Drawing.Size(237, 46);
            this.convert_answer.TabIndex = 5;
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(248, 697);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(203, 92);
            this.Convert.TabIndex = 6;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(586, 697);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(203, 92);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // DistanceConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 878);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.convert_answer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.convert_enter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.To);
            this.Controls.Add(this.From);
            this.Name = "DistanceConverter";
            this.Text = " Distance Converter";
            this.From.ResumeLayout(false);
            this.To.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox From;
        private System.Windows.Forms.GroupBox To;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox convert_enter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label convert_answer;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ListBox ListBox_From;
        private System.Windows.Forms.ListBox ListBox_To;
    }
}

