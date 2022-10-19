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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonAnyCharacter = new System.Windows.Forms.RadioButton();
            this.radioButtonDigitsOnly = new System.Windows.Forms.RadioButton();
            this.radioButtonLettersOnly = new System.Windows.Forms.RadioButton();
            this.validatedTextBox = new MyEditControls.ValidatedTextBox();
            this.lettersOnlyTextBox1 = new MyEditControls.LettersOnlyTextBox();
            this.numericTextBox1 = new MyEditControls.NumericTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 0;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(12, 50);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(152, 20);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonLettersOnly);
            this.groupBox1.Controls.Add(this.radioButtonDigitsOnly);
            this.groupBox1.Controls.Add(this.radioButtonAnyCharacter);
            this.groupBox1.Controls.Add(this.validatedTextBox);
            this.groupBox1.Location = new System.Drawing.Point(196, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 138);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButtonAnyCharacter
            // 
            this.radioButtonAnyCharacter.AutoSize = true;
            this.radioButtonAnyCharacter.Checked = true;
            this.radioButtonAnyCharacter.Location = new System.Drawing.Point(16, 58);
            this.radioButtonAnyCharacter.Name = "radioButtonAnyCharacter";
            this.radioButtonAnyCharacter.Size = new System.Drawing.Size(91, 17);
            this.radioButtonAnyCharacter.TabIndex = 5;
            this.radioButtonAnyCharacter.TabStop = true;
            this.radioButtonAnyCharacter.Text = "&Any character";
            this.radioButtonAnyCharacter.UseVisualStyleBackColor = true;
            this.radioButtonAnyCharacter.CheckedChanged += new System.EventHandler(this.radioButtonAnyCharacter_CheckedChanged);
            // 
            // radioButtonDigitsOnly
            // 
            this.radioButtonDigitsOnly.AutoSize = true;
            this.radioButtonDigitsOnly.Location = new System.Drawing.Point(16, 80);
            this.radioButtonDigitsOnly.Name = "radioButtonDigitsOnly";
            this.radioButtonDigitsOnly.Size = new System.Drawing.Size(73, 17);
            this.radioButtonDigitsOnly.TabIndex = 6;
            this.radioButtonDigitsOnly.Text = "&Digits only";
            this.radioButtonDigitsOnly.UseVisualStyleBackColor = true;
            this.radioButtonDigitsOnly.CheckedChanged += new System.EventHandler(this.radioButtonDigitsOnly_CheckedChanged);
            // 
            // radioButtonLettersOnly
            // 
            this.radioButtonLettersOnly.AutoSize = true;
            this.radioButtonLettersOnly.Location = new System.Drawing.Point(16, 103);
            this.radioButtonLettersOnly.Name = "radioButtonLettersOnly";
            this.radioButtonLettersOnly.Size = new System.Drawing.Size(74, 17);
            this.radioButtonLettersOnly.TabIndex = 7;
            this.radioButtonLettersOnly.Text = "&Letter only";
            this.radioButtonLettersOnly.UseVisualStyleBackColor = true;
            this.radioButtonLettersOnly.CheckedChanged += new System.EventHandler(this.radioButtonLettersOnly_CheckedChanged);
            // 
            // validatedTextBox
            // 
            this.validatedTextBox.Location = new System.Drawing.Point(16, 19);
            this.validatedTextBox.Name = "validatedTextBox";
            this.validatedTextBox.Size = new System.Drawing.Size(210, 20);
            this.validatedTextBox.TabIndex = 4;
            // 
            // lettersOnlyTextBox1
            // 
            this.lettersOnlyTextBox1.Location = new System.Drawing.Point(12, 126);
            this.lettersOnlyTextBox1.Name = "lettersOnlyTextBox1";
            this.lettersOnlyTextBox1.Size = new System.Drawing.Size(152, 20);
            this.lettersOnlyTextBox1.TabIndex = 3;
            // 
            // numericTextBox1
            // 
            this.numericTextBox1.Location = new System.Drawing.Point(12, 88);
            this.numericTextBox1.Name = "numericTextBox1";
            this.numericTextBox1.Size = new System.Drawing.Size(152, 20);
            this.numericTextBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lettersOnlyTextBox1);
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
        private MyEditControls.LettersOnlyTextBox lettersOnlyTextBox1;
        private MyEditControls.ValidatedTextBox validatedTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonLettersOnly;
        private System.Windows.Forms.RadioButton radioButtonDigitsOnly;
        private System.Windows.Forms.RadioButton radioButtonAnyCharacter;
    }
}

