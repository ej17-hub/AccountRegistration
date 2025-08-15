namespace AccountRegistration
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStudNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxContNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.comboBoxProgram = new System.Windows.Forms.ComboBox();
            this.TextBoxAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student No.:";
            // 
            // textBoxStudNum
            // 
            this.textBoxStudNum.Location = new System.Drawing.Point(31, 55);
            this.textBoxStudNum.Name = "textBoxStudNum";
            this.textBoxStudNum.Size = new System.Drawing.Size(161, 20);
            this.textBoxStudNum.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Program:";
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(31, 132);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(161, 20);
            this.textBoxLName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name:";
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(271, 132);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(161, 20);
            this.textBoxFName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "First Name:";
            // 
            // textBoxMName
            // 
            this.textBoxMName.Location = new System.Drawing.Point(530, 132);
            this.textBoxMName.Name = "textBoxMName";
            this.textBoxMName.Size = new System.Drawing.Size(161, 20);
            this.textBoxMName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(527, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Middle Name:";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(31, 219);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(161, 20);
            this.textBoxAge.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Age:";
            // 
            // textBoxContNum
            // 
            this.textBoxContNum.Location = new System.Drawing.Point(271, 219);
            this.textBoxContNum.Name = "textBoxContNum";
            this.textBoxContNum.Size = new System.Drawing.Size(161, 20);
            this.textBoxContNum.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Contact No.:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Address:";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(321, 428);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 17;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // comboBoxProgram
            // 
            this.comboBoxProgram.FormattingEnabled = true;
            this.comboBoxProgram.Items.AddRange(new object[] {
            "Bachelor of Science in Information Technology (BSIT)",
            "Bachelor of Computer Science (BSCS)",
            "Bachelor of Science in Information Systems (BSIS)",
            "Bachelor of Science in Computer Engineering (BSCpE)",
            "Bachelor of Science in Data Science"});
            this.comboBoxProgram.Location = new System.Drawing.Point(271, 54);
            this.comboBoxProgram.Name = "comboBoxProgram";
            this.comboBoxProgram.Size = new System.Drawing.Size(268, 21);
            this.comboBoxProgram.TabIndex = 18;
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Location = new System.Drawing.Point(31, 283);
            this.TextBoxAddress.Multiline = true;
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(699, 139);
            this.TextBoxAddress.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 463);
            this.Controls.Add(this.TextBoxAddress);
            this.Controls.Add(this.comboBoxProgram);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxContNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxMName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxStudNum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "sni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStudNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxContNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.ComboBox comboBoxProgram;
        private System.Windows.Forms.TextBox TextBoxAddress;
    }
}

