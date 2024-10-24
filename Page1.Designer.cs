namespace Golay_Code
{
    partial class Page1
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
            this.Encode = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.InputVector = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Encode
            // 
            this.Encode.Location = new System.Drawing.Point(558, 173);
            this.Encode.Name = "Encode";
            this.Encode.Size = new System.Drawing.Size(143, 43);
            this.Encode.TabIndex = 0;
            this.Encode.Text = "Encode";
            this.Encode.UseVisualStyleBackColor = true;
            this.Encode.Click += new System.EventHandler(this.Encode_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter vector of size 12:";
            // 
            // InputVector
            // 
            this.InputVector.Location = new System.Drawing.Point(324, 55);
            this.InputVector.Multiline = true;
            this.InputVector.Name = "InputVector";
            this.InputVector.Size = new System.Drawing.Size(348, 31);
            this.InputVector.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(721, 235);
            this.Controls.Add(this.InputVector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Encode);
            this.Name = "Gollay Code Simulator";
            this.Text = "Gollay Code Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Encode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InputVector;
    }
}

