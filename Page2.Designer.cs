namespace Golay_Code
{
    partial class Page2
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
            this.ButtonSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxProbability = new System.Windows.Forms.TextBox();
            this.LabelEncodedData = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelReceived = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonSend
            // 
            this.ButtonSend.Location = new System.Drawing.Point(43, 332);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(143, 43);
            this.ButtonSend.TabIndex = 11;
            this.ButtonSend.Text = "Send";
            this.ButtonSend.UseVisualStyleBackColor = true;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "After encoding your data is as follows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Enter error probablity p:";
            // 
            // TextBoxProbability
            // 
            this.TextBoxProbability.Location = new System.Drawing.Point(337, 247);
            this.TextBoxProbability.Name = "TextBoxProbability";
            this.TextBoxProbability.Size = new System.Drawing.Size(100, 31);
            this.TextBoxProbability.TabIndex = 13;
            // 
            // LabelEncodedData
            // 
            this.LabelEncodedData.AutoSize = true;
            this.LabelEncodedData.Location = new System.Drawing.Point(48, 103);
            this.LabelEncodedData.Name = "LabelEncodedData";
            this.LabelEncodedData.Size = new System.Drawing.Size(0, 25);
            this.LabelEncodedData.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Vector received from the channel";
            // 
            // LabelReceived
            // 
            this.LabelReceived.AutoSize = true;
            this.LabelReceived.Location = new System.Drawing.Point(43, 460);
            this.LabelReceived.Name = "LabelReceived";
            this.LabelReceived.Size = new System.Drawing.Size(0, 25);
            this.LabelReceived.TabIndex = 16;
            // 
            // Page2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 519);
            this.Controls.Add(this.LabelReceived);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelEncodedData);
            this.Controls.Add(this.TextBoxProbability);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonSend);
            this.Controls.Add(this.label1);
            this.Name = "Page2";
            this.Text = "Gollay Code Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxProbability;
        private System.Windows.Forms.Label LabelEncodedData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelReceived;
    }
}