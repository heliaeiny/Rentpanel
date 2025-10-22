namespace Rentpanel.Forms
{
    partial class LessorForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            firstNametextBox1 = new TextBox();
            lastnametextBox2 = new TextBox();
            nationalIdtextBox3 = new TextBox();
            phoneNumbertextBox4 = new TextBox();
            userNametextBox5 = new TextBox();
            passwordTextBox = new TextBox();
            rejisterButtonLessor = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 24);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "FirstName:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 106);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "LastName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 192);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 2;
            label3.Text = "NationalId";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(480, 34);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 3;
            label4.Text = "PhoneNumber:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(491, 103);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 4;
            label5.Text = "UserName:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(496, 192);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 5;
            label6.Text = "Password:";
            // 
            // firstNametextBox1
            // 
            firstNametextBox1.Location = new Point(185, 24);
            firstNametextBox1.Name = "firstNametextBox1";
            firstNametextBox1.Size = new Size(100, 23);
            firstNametextBox1.TabIndex = 6;
            // 
            // lastnametextBox2
            // 
            lastnametextBox2.Location = new Point(185, 103);
            lastnametextBox2.Name = "lastnametextBox2";
            lastnametextBox2.Size = new Size(100, 23);
            lastnametextBox2.TabIndex = 7;
            // 
            // nationalIdtextBox3
            // 
            nationalIdtextBox3.Location = new Point(185, 184);
            nationalIdtextBox3.Name = "nationalIdtextBox3";
            nationalIdtextBox3.Size = new Size(100, 23);
            nationalIdtextBox3.TabIndex = 8;
            // 
            // phoneNumbertextBox4
            // 
            phoneNumbertextBox4.Location = new Point(614, 31);
            phoneNumbertextBox4.Name = "phoneNumbertextBox4";
            phoneNumbertextBox4.Size = new Size(100, 23);
            phoneNumbertextBox4.TabIndex = 9;
            // 
            // userNametextBox5
            // 
            userNametextBox5.Location = new Point(614, 106);
            userNametextBox5.Name = "userNametextBox5";
            userNametextBox5.Size = new Size(100, 23);
            userNametextBox5.TabIndex = 10;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(614, 184);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(100, 23);
            passwordTextBox.TabIndex = 11;
            // 
            // rejisterButtonLessor
            // 
            rejisterButtonLessor.Location = new Point(62, 256);
            rejisterButtonLessor.Name = "rejisterButtonLessor";
            rejisterButtonLessor.Size = new Size(164, 23);
            rejisterButtonLessor.TabIndex = 12;
            rejisterButtonLessor.Text = "Enter";
            rejisterButtonLessor.UseVisualStyleBackColor = true;
            rejisterButtonLessor.Click += Enterbutton1_Click;
            // 
            // LessorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rejisterButtonLessor);
            Controls.Add(passwordTextBox);
            Controls.Add(userNametextBox5);
            Controls.Add(phoneNumbertextBox4);
            Controls.Add(nationalIdtextBox3);
            Controls.Add(lastnametextBox2);
            Controls.Add(firstNametextBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LessorForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox firstNametextBox1;
        private TextBox lastnametextBox2;
        private TextBox nationalIdtextBox3;
        private TextBox phoneNumbertextBox4;
        private TextBox userNametextBox5;
        private TextBox passwordTextBox;
        private Button rejisterButtonLessor;
    }
}