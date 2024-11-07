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
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxWithEncoding = new System.Windows.Forms.TextBox();
            this.TextBoxWithoutEncoding = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxProbability = new System.Windows.Forms.TextBox();
            this.ButtonHome = new System.Windows.Forms.Button();
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
            // TextBoxInput
            // 
            this.TextBoxInput.Location = new System.Drawing.Point(28, 65);
            this.TextBoxInput.Multiline = true;
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.Size = new System.Drawing.Size(600, 100);
            this.TextBoxInput.TabIndex = 1;
            // 
            // ButtonSend
            // 
            this.ButtonSend.Location = new System.Drawing.Point(28, 254);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(143, 43);
            this.ButtonSend.TabIndex = 2;
            this.ButtonSend.Text = "Send";
            this.ButtonSend.UseVisualStyleBackColor = true;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Received text with encoding:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Received text without encoding:";
            // 
            // TextBoxWithEncoding
            // 
            this.TextBoxWithEncoding.Location = new System.Drawing.Point(28, 402);
            this.TextBoxWithEncoding.Multiline = true;
            this.TextBoxWithEncoding.Name = "TextBoxWithEncoding";
            this.TextBoxWithEncoding.ReadOnly = true;
            this.TextBoxWithEncoding.Size = new System.Drawing.Size(600, 100);
            this.TextBoxWithEncoding.TabIndex = 7;
            // 
            // TextBoxWithoutEncoding
            // 
            this.TextBoxWithoutEncoding.Location = new System.Drawing.Point(28, 562);
            this.TextBoxWithoutEncoding.Multiline = true;
            this.TextBoxWithoutEncoding.Name = "TextBoxWithoutEncoding";
            this.TextBoxWithoutEncoding.ReadOnly = true;
            this.TextBoxWithoutEncoding.Size = new System.Drawing.Size(600, 100);
            this.TextBoxWithoutEncoding.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter error probablity p:";
            // 
            // TextBoxProbability
            // 
            this.TextBoxProbability.Location = new System.Drawing.Point(312, 197);
            this.TextBoxProbability.Multiline = true;
            this.TextBoxProbability.Name = "TextBoxProbability";
            this.TextBoxProbability.Size = new System.Drawing.Size(148, 31);
            this.TextBoxProbability.TabIndex = 10;
            // 
            // ButtonHome
            // 
            this.ButtonHome.Location = new System.Drawing.Point(667, 702);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(143, 43);
            this.ButtonHome.TabIndex = 11;
            this.ButtonHome.Text = "Home";
            this.ButtonHome.UseVisualStyleBackColor = true;
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // TextPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 757);
            this.Controls.Add(this.ButtonHome);
            this.Controls.Add(this.TextBoxProbability);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxWithoutEncoding);
            this.Controls.Add(this.TextBoxWithEncoding);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonSend);
            this.Controls.Add(this.TextBoxInput);
            this.Controls.Add(this.label1);
            this.Name = "TextPage";
            this.Text = "Gollay Code Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxInput;
        private System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxWithEncoding;
        private System.Windows.Forms.TextBox TextBoxWithoutEncoding;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxProbability;
        private System.Windows.Forms.Button ButtonHome;
    }
}