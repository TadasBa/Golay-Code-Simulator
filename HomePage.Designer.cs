namespace Golay_Code
{
    partial class HomePage
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxInputType = new System.Windows.Forms.ComboBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(47, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(818, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Golay Code C23 - Error Correction Simulation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Input Type:";
            // 
            // ComboBoxInputType
            // 
            this.ComboBoxInputType.DisplayMember = "none";
            this.ComboBoxInputType.FormattingEnabled = true;
            this.ComboBoxInputType.Items.AddRange(new object[] {
            "Vector",
            "Text",
            "Image"});
            this.ComboBoxInputType.Location = new System.Drawing.Point(470, 345);
            this.ComboBoxInputType.Name = "ComboBoxInputType";
            this.ComboBoxInputType.Size = new System.Drawing.Size(153, 33);
            this.ComboBoxInputType.TabIndex = 8;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(790, 451);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(143, 43);
            this.NextButton.TabIndex = 10;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(494, 100);
            this.label3.TabIndex = 11;
            this.label3.Text = "Welcome to the Golay Code Simulator!\r\n\r\nThis program simulates data transmission " +
    "\r\nencoded with Golay Code through a noisy channel\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(974, 519);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxInputType);
            this.Controls.Add(this.label2);
            this.Name = "WelcomePage";
            this.Text = "Gollay Code Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxInputType;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label label3;
    }
}