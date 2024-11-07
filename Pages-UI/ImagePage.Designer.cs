namespace Golay_Code
{
    partial class ImagePage
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
            this.HomeButton = new System.Windows.Forms.Button();
            this.PictureBoxInput = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxProbability = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PictureBoxWithEncoding = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PictureBoxWithoutEncoding = new System.Windows.Forms.PictureBox();
            this.ButtonInput = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxWithEncoding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxWithoutEncoding)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(726, 806);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(143, 43);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // PictureBoxInput
            // 
            this.PictureBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxInput.Location = new System.Drawing.Point(34, 64);
            this.PictureBoxInput.Name = "PictureBoxInput";
            this.PictureBoxInput.Size = new System.Drawing.Size(280, 280);
            this.PictureBoxInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxInput.TabIndex = 1;
            this.PictureBoxInput.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input image:";
            // 
            // ButtonSend
            // 
            this.ButtonSend.Location = new System.Drawing.Point(34, 417);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(143, 43);
            this.ButtonSend.TabIndex = 3;
            this.ButtonSend.Text = "Send";
            this.ButtonSend.UseVisualStyleBackColor = true;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter error probablity p:";
            // 
            // TextBoxProbability
            // 
            this.TextBoxProbability.Location = new System.Drawing.Point(316, 371);
            this.TextBoxProbability.Multiline = true;
            this.TextBoxProbability.Name = "TextBoxProbability";
            this.TextBoxProbability.Size = new System.Drawing.Size(134, 31);
            this.TextBoxProbability.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Received with encoding:";
            // 
            // PictureBoxWithEncoding
            // 
            this.PictureBoxWithEncoding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxWithEncoding.Location = new System.Drawing.Point(34, 569);
            this.PictureBoxWithEncoding.Name = "PictureBoxWithEncoding";
            this.PictureBoxWithEncoding.Size = new System.Drawing.Size(280, 280);
            this.PictureBoxWithEncoding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxWithEncoding.TabIndex = 6;
            this.PictureBoxWithEncoding.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(392, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Received without encoding:";
            // 
            // PictureBoxWithoutEncoding
            // 
            this.PictureBoxWithoutEncoding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxWithoutEncoding.Location = new System.Drawing.Point(397, 569);
            this.PictureBoxWithoutEncoding.Name = "PictureBoxWithoutEncoding";
            this.PictureBoxWithoutEncoding.Size = new System.Drawing.Size(280, 280);
            this.PictureBoxWithoutEncoding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxWithoutEncoding.TabIndex = 8;
            this.PictureBoxWithoutEncoding.TabStop = false;
            // 
            // ButtonInput
            // 
            this.ButtonInput.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonInput.Location = new System.Drawing.Point(122, 162);
            this.ButtonInput.Name = "ButtonInput";
            this.ButtonInput.Size = new System.Drawing.Size(100, 90);
            this.ButtonInput.TabIndex = 10;
            this.ButtonInput.Text = "Select image";
            this.ButtonInput.UseVisualStyleBackColor = true;
            this.ButtonInput.Click += new System.EventHandler(this.ButtonInput_Click);
            // 
            // ImagePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 866);
            this.Controls.Add(this.ButtonInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PictureBoxWithoutEncoding);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PictureBoxWithEncoding);
            this.Controls.Add(this.TextBoxProbability);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBoxInput);
            this.Controls.Add(this.HomeButton);
            this.Name = "ImagePage";
            this.Text = "Gollay Code Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxWithEncoding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxWithoutEncoding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.PictureBox PictureBoxInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxProbability;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PictureBoxWithEncoding;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PictureBoxWithoutEncoding;
        private System.Windows.Forms.Button ButtonInput;
    }
}