namespace WordRemember
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
            this.submitButton = new System.Windows.Forms.Button();
            this.unscrambleButton = new System.Windows.Forms.RadioButton();
            this.substringButton = new System.Windows.Forms.RadioButton();
            this.outputBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numeric_numLetters = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_scrambled = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_beginWord = new System.Windows.Forms.TextBox();
            this.textbox_endWord = new System.Windows.Forms.TextBox();
            this.textbox_other = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.phoneNumber_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sendText_button = new System.Windows.Forms.Button();
            this.dictionary_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_numLetters)).BeginInit();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(235, 158);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Generate Words";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // unscrambleButton
            // 
            this.unscrambleButton.AutoSize = true;
            this.unscrambleButton.Checked = true;
            this.unscrambleButton.Location = new System.Drawing.Point(22, 65);
            this.unscrambleButton.Name = "unscrambleButton";
            this.unscrambleButton.Size = new System.Drawing.Size(81, 17);
            this.unscrambleButton.TabIndex = 1;
            this.unscrambleButton.TabStop = true;
            this.unscrambleButton.Text = "Unscramble";
            this.unscrambleButton.UseVisualStyleBackColor = true;
            // 
            // substringButton
            // 
            this.substringButton.AutoSize = true;
            this.substringButton.Location = new System.Drawing.Point(22, 89);
            this.substringButton.Name = "substringButton";
            this.substringButton.Size = new System.Drawing.Size(69, 17);
            this.substringButton.TabIndex = 2;
            this.substringButton.Text = "Substring";
            this.substringButton.UseVisualStyleBackColor = true;
            this.substringButton.CheckedChanged += new System.EventHandler(this.substringButton_CheckedChanged);
            // 
            // outputBox
            // 
            this.outputBox.FormattingEnabled = true;
            this.outputBox.Location = new System.Drawing.Point(324, 28);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(150, 329);
            this.outputBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Output";
            // 
            // numeric_numLetters
            // 
            this.numeric_numLetters.Location = new System.Drawing.Point(235, 132);
            this.numeric_numLetters.Name = "numeric_numLetters";
            this.numeric_numLetters.Size = new System.Drawing.Size(38, 20);
            this.numeric_numLetters.TabIndex = 5;
            this.numeric_numLetters.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Word Length";
            // 
            // textbox_scrambled
            // 
            this.textbox_scrambled.Location = new System.Drawing.Point(235, 105);
            this.textbox_scrambled.Name = "textbox_scrambled";
            this.textbox_scrambled.Size = new System.Drawing.Size(66, 20);
            this.textbox_scrambled.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Scrambled Word";
            // 
            // textbox_beginWord
            // 
            this.textbox_beginWord.Enabled = false;
            this.textbox_beginWord.Location = new System.Drawing.Point(235, 25);
            this.textbox_beginWord.Name = "textbox_beginWord";
            this.textbox_beginWord.Size = new System.Drawing.Size(66, 20);
            this.textbox_beginWord.TabIndex = 9;
            // 
            // textbox_endWord
            // 
            this.textbox_endWord.Enabled = false;
            this.textbox_endWord.Location = new System.Drawing.Point(235, 51);
            this.textbox_endWord.Name = "textbox_endWord";
            this.textbox_endWord.Size = new System.Drawing.Size(66, 20);
            this.textbox_endWord.TabIndex = 10;
            // 
            // textbox_other
            // 
            this.textbox_other.Enabled = false;
            this.textbox_other.Location = new System.Drawing.Point(235, 77);
            this.textbox_other.Name = "textbox_other";
            this.textbox_other.Size = new System.Drawing.Size(66, 20);
            this.textbox_other.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Beginning of Word";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "End of Word";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Any Other Letters";
            // 
            // phoneNumber_textBox
            // 
            this.phoneNumber_textBox.Location = new System.Drawing.Point(137, 334);
            this.phoneNumber_textBox.Name = "phoneNumber_textBox";
            this.phoneNumber_textBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumber_textBox.TabIndex = 15;
            this.phoneNumber_textBox.Text = "12034155660";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(134, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Send Output";
            // 
            // sendText_button
            // 
            this.sendText_button.Enabled = false;
            this.sendText_button.Location = new System.Drawing.Point(243, 332);
            this.sendText_button.Name = "sendText_button";
            this.sendText_button.Size = new System.Drawing.Size(48, 23);
            this.sendText_button.TabIndex = 17;
            this.sendText_button.Text = "Send";
            this.sendText_button.UseVisualStyleBackColor = true;
            this.sendText_button.Click += new System.EventHandler(this.sendText_button_Click);
            // 
            // dictionary_textBox
            // 
            this.dictionary_textBox.Location = new System.Drawing.Point(12, 28);
            this.dictionary_textBox.Name = "dictionary_textBox";
            this.dictionary_textBox.Size = new System.Drawing.Size(100, 20);
            this.dictionary_textBox.TabIndex = 18;
            this.dictionary_textBox.Text = "ospd.txt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Dictionary";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 387);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dictionary_textBox);
            this.Controls.Add(this.sendText_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.phoneNumber_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textbox_other);
            this.Controls.Add(this.textbox_endWord);
            this.Controls.Add(this.textbox_beginWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox_scrambled);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numeric_numLetters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.substringButton);
            this.Controls.Add(this.unscrambleButton);
            this.Controls.Add(this.submitButton);
            this.Name = "Form1";
            this.Text = "Word Generator";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_numLetters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.RadioButton unscrambleButton;
        private System.Windows.Forms.RadioButton substringButton;
        private System.Windows.Forms.ListBox outputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeric_numLetters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_scrambled;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_beginWord;
        private System.Windows.Forms.TextBox textbox_endWord;
        private System.Windows.Forms.TextBox textbox_other;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phoneNumber_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button sendText_button;
        private System.Windows.Forms.TextBox dictionary_textBox;
        private System.Windows.Forms.Label label8;
    }
}