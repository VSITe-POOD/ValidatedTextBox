namespace TestWindowsFormsApp
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.letterOnlyTextBox1 = new MyEditControls.LetterOnlyTextBox();
            this.numericTextBox1 = new MyEditControls.NumericTextBox();
            this.validatedTextBox = new MyEditControls.ValidatedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonLettersOnly = new System.Windows.Forms.RadioButton();
            this.radioButtonDigitsOnly = new System.Windows.Forms.RadioButton();
            this.radioButtonAnyChar = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 0;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(12, 54);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(174, 20);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // letterOnlyTextBox1
            // 
            this.letterOnlyTextBox1.Location = new System.Drawing.Point(13, 142);
            this.letterOnlyTextBox1.Name = "letterOnlyTextBox1";
            this.letterOnlyTextBox1.Size = new System.Drawing.Size(173, 20);
            this.letterOnlyTextBox1.TabIndex = 3;
            // 
            // numericTextBox1
            // 
            this.numericTextBox1.Location = new System.Drawing.Point(13, 95);
            this.numericTextBox1.Name = "numericTextBox1";
            this.numericTextBox1.Size = new System.Drawing.Size(173, 20);
            this.numericTextBox1.TabIndex = 2;
            // 
            // validatedTextBox
            // 
            this.validatedTextBox.Location = new System.Drawing.Point(6, 19);
            this.validatedTextBox.Name = "validatedTextBox";
            this.validatedTextBox.Size = new System.Drawing.Size(188, 20);
            this.validatedTextBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonLettersOnly);
            this.groupBox1.Controls.Add(this.radioButtonDigitsOnly);
            this.groupBox1.Controls.Add(this.radioButtonAnyChar);
            this.groupBox1.Controls.Add(this.validatedTextBox);
            this.groupBox1.Location = new System.Drawing.Point(192, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 137);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButtonLettersOnly
            // 
            this.radioButtonLettersOnly.AutoSize = true;
            this.radioButtonLettersOnly.Location = new System.Drawing.Point(6, 91);
            this.radioButtonLettersOnly.Name = "radioButtonLettersOnly";
            this.radioButtonLettersOnly.Size = new System.Drawing.Size(75, 17);
            this.radioButtonLettersOnly.TabIndex = 8;
            this.radioButtonLettersOnly.Text = "letters only";
            this.radioButtonLettersOnly.UseVisualStyleBackColor = true;
            this.radioButtonLettersOnly.CheckedChanged += new System.EventHandler(this.radioButtonLettersOnly_CheckedChanged);
            // 
            // radioButtonDigitsOnly
            // 
            this.radioButtonDigitsOnly.AutoSize = true;
            this.radioButtonDigitsOnly.Location = new System.Drawing.Point(6, 68);
            this.radioButtonDigitsOnly.Name = "radioButtonDigitsOnly";
            this.radioButtonDigitsOnly.Size = new System.Drawing.Size(71, 17);
            this.radioButtonDigitsOnly.TabIndex = 7;
            this.radioButtonDigitsOnly.Text = "digits only";
            this.radioButtonDigitsOnly.UseVisualStyleBackColor = true;
            this.radioButtonDigitsOnly.CheckedChanged += new System.EventHandler(this.radioButtonDigitsOnly_CheckedChanged);
            // 
            // radioButtonAnyChar
            // 
            this.radioButtonAnyChar.AutoSize = true;
            this.radioButtonAnyChar.Checked = true;
            this.radioButtonAnyChar.Location = new System.Drawing.Point(6, 45);
            this.radioButtonAnyChar.Name = "radioButtonAnyChar";
            this.radioButtonAnyChar.Size = new System.Drawing.Size(66, 17);
            this.radioButtonAnyChar.TabIndex = 6;
            this.radioButtonAnyChar.TabStop = true;
            this.radioButtonAnyChar.Text = "any char";
            this.radioButtonAnyChar.UseVisualStyleBackColor = true;
            this.radioButtonAnyChar.CheckedChanged += new System.EventHandler(this.radioButtonAnyChar_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 335);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.letterOnlyTextBox1);
            this.Controls.Add(this.numericTextBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private MyEditControls.NumericTextBox numericTextBox1;
        private MyEditControls.LetterOnlyTextBox letterOnlyTextBox1;
        private MyEditControls.ValidatedTextBox validatedTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonLettersOnly;
        private System.Windows.Forms.RadioButton radioButtonDigitsOnly;
        private System.Windows.Forms.RadioButton radioButtonAnyChar;
    }
}

