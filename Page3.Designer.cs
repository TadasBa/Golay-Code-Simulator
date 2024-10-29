namespace Golay_Code
{
    partial class Page3
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
            this.TextBoxReceived = new System.Windows.Forms.TextBox();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelErrors = new System.Windows.Forms.Label();
            this.ButtonDecode = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelErrorPositions = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelDecoded = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelInput = new System.Windows.Forms.Label();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.LabelSent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vector received from the channel:";
            // 
            // TextBoxReceived
            // 
            this.TextBoxReceived.Location = new System.Drawing.Point(69, 208);
            this.TextBoxReceived.Multiline = true;
            this.TextBoxReceived.Name = "TextBoxReceived";
            this.TextBoxReceived.Size = new System.Drawing.Size(459, 31);
            this.TextBoxReceived.TabIndex = 1;
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(563, 202);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(143, 43);
            this.ButtonEdit.TabIndex = 2;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of Errors:";
            // 
            // LabelErrors
            // 
            this.LabelErrors.AutoSize = true;
            this.LabelErrors.Location = new System.Drawing.Point(269, 278);
            this.LabelErrors.Name = "LabelErrors";
            this.LabelErrors.Size = new System.Drawing.Size(0, 25);
            this.LabelErrors.TabIndex = 4;
            // 
            // ButtonDecode
            // 
            this.ButtonDecode.Location = new System.Drawing.Point(69, 382);
            this.ButtonDecode.Name = "ButtonDecode";
            this.ButtonDecode.Size = new System.Drawing.Size(143, 43);
            this.ButtonDecode.TabIndex = 5;
            this.ButtonDecode.Text = "Decode";
            this.ButtonDecode.UseVisualStyleBackColor = true;
            this.ButtonDecode.Click += new System.EventHandler(this.ButtonDecode_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Error positions:";
            // 
            // LabelErrorPositions
            // 
            this.LabelErrorPositions.AutoSize = true;
            this.LabelErrorPositions.Location = new System.Drawing.Point(269, 317);
            this.LabelErrorPositions.Name = "LabelErrorPositions";
            this.LabelErrorPositions.Size = new System.Drawing.Size(0, 25);
            this.LabelErrorPositions.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vector after decoding:";
            // 
            // LabelDecoded
            // 
            this.LabelDecoded.AutoSize = true;
            this.LabelDecoded.Location = new System.Drawing.Point(324, 463);
            this.LabelDecoded.Name = "LabelDecoded";
            this.LabelDecoded.Size = new System.Drawing.Size(0, 25);
            this.LabelDecoded.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 513);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Input vector:";
            // 
            // LabelInput
            // 
            this.LabelInput.AutoSize = true;
            this.LabelInput.Location = new System.Drawing.Point(324, 513);
            this.LabelInput.Name = "LabelInput";
            this.LabelInput.Size = new System.Drawing.Size(0, 25);
            this.LabelInput.TabIndex = 11;
            // 
            // ButtonHome
            // 
            this.ButtonHome.Location = new System.Drawing.Point(650, 570);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(143, 43);
            this.ButtonHome.TabIndex = 12;
            this.ButtonHome.Text = "Home";
            this.ButtonHome.UseVisualStyleBackColor = true;
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Vector sent to the channel:";
            // 
            // LabelSent
            // 
            this.LabelSent.AutoSize = true;
            this.LabelSent.Location = new System.Drawing.Point(64, 105);
            this.LabelSent.Name = "LabelSent";
            this.LabelSent.Size = new System.Drawing.Size(0, 25);
            this.LabelSent.TabIndex = 14;
            // 
            // Page3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 625);
            this.Controls.Add(this.LabelSent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ButtonHome);
            this.Controls.Add(this.LabelInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LabelDecoded);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelErrorPositions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonDecode);
            this.Controls.Add(this.LabelErrors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.TextBoxReceived);
            this.Controls.Add(this.label1);
            this.Name = "Page3";
            this.Text = "Page3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxReceived;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelErrors;
        private System.Windows.Forms.Button ButtonDecode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelErrorPositions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelDecoded;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabelInput;
        private System.Windows.Forms.Button ButtonHome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LabelSent;
    }
}