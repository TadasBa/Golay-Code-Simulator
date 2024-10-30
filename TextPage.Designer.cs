namespace Golay_Code
{
    partial class TextPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxTextInput = new System.Windows.Forms.TextBox();
            this.ButtonSendTextInput = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxWithEncoding = new System.Windows.Forms.TextBox();
            this.TextBoxWithoutEncoding = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Text:";
            // 
            // TextBoxTextInput
            // 
            this.TextBoxTextInput.Location = new System.Drawing.Point(28, 65);
            this.TextBoxTextInput.Multiline = true;
            this.TextBoxTextInput.Name = "TextBoxTextInput";
            this.TextBoxTextInput.Size = new System.Drawing.Size(800, 125);
            this.TextBoxTextInput.TabIndex = 1;
            // 
            // ButtonSendTextInput
            // 
            this.ButtonSendTextInput.Location = new System.Drawing.Point(28, 221);
            this.ButtonSendTextInput.Name = "ButtonSendTextInput";
            this.ButtonSendTextInput.Size = new System.Drawing.Size(143, 43);
            this.ButtonSendTextInput.TabIndex = 2;
            this.ButtonSendTextInput.Text = "Send";
            this.ButtonSendTextInput.UseVisualStyleBackColor = true;
            this.ButtonSendTextInput.Click += new System.EventHandler(this.ButtonSendTextInput_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Received text with encoding:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 519);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Received text without encoding:";
            // 
            // TextBoxWithEncoding
            // 
            this.TextBoxWithEncoding.Location = new System.Drawing.Point(28, 362);
            this.TextBoxWithEncoding.Multiline = true;
            this.TextBoxWithEncoding.Name = "TextBoxWithEncoding";
            this.TextBoxWithEncoding.ReadOnly = true;
            this.TextBoxWithEncoding.Size = new System.Drawing.Size(800, 125);
            this.TextBoxWithEncoding.TabIndex = 7;
            // 
            // TextBoxWithoutEncoding
            // 
            this.TextBoxWithoutEncoding.Location = new System.Drawing.Point(28, 556);
            this.TextBoxWithoutEncoding.Multiline = true;
            this.TextBoxWithoutEncoding.Name = "TextBoxWithoutEncoding";
            this.TextBoxWithoutEncoding.ReadOnly = true;
            this.TextBoxWithoutEncoding.Size = new System.Drawing.Size(800, 125);
            this.TextBoxWithoutEncoding.TabIndex = 8;
            // 
            // PageHandlingTextInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 704);
            this.Controls.Add(this.TextBoxWithoutEncoding);
            this.Controls.Add(this.TextBoxWithEncoding);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonSendTextInput);
            this.Controls.Add(this.TextBoxTextInput);
            this.Controls.Add(this.label1);
            this.Name = "PageHandlingTextInput";
            this.Text = "Gollay Code Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxTextInput;
        private System.Windows.Forms.Button ButtonSendTextInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxWithEncoding;
        private System.Windows.Forms.TextBox TextBoxWithoutEncoding;
    }
}