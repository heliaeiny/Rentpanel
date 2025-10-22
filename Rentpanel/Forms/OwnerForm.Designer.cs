namespace Rentpanel.Forms
{
    partial class OwnerForm
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
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            phoneNumberTextBox = new TextBox();
            nationalCodeTextBox = new TextBox();
            passwordtextBox5 = new TextBox();
            userNametextBox6 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            registerButton = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            birthdatedateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            button1 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(142, 39);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(100, 23);
            firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(509, 39);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(100, 23);
            lastNameTextBox.TabIndex = 1;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(142, 92);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(100, 23);
            phoneNumberTextBox.TabIndex = 2;
            // 
            // nationalCodeTextBox
            // 
            nationalCodeTextBox.Location = new Point(509, 92);
            nationalCodeTextBox.Name = "nationalCodeTextBox";
            nationalCodeTextBox.Size = new Size(100, 23);
            nationalCodeTextBox.TabIndex = 3;
            // 
            // passwordtextBox5
            // 
            passwordtextBox5.Location = new Point(142, 150);
            passwordtextBox5.Name = "passwordtextBox5";
            passwordtextBox5.Size = new Size(100, 23);
            passwordtextBox5.TabIndex = 4;
            // 
            // userNametextBox6
            // 
            userNametextBox6.Location = new Point(509, 147);
            userNametextBox6.Name = "userNametextBox6";
            userNametextBox6.Size = new Size(100, 23);
            userNametextBox6.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 47);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 6;
            label1.Text = "FirstName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(432, 47);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 7;
            label2.Text = "LastName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 95);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 8;
            label3.Text = "PhoneNumber";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(412, 95);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 9;
            label4.Text = "NationalCode";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 160);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 10;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(430, 160);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 11;
            label6.Text = "UserName";
            // 
            // registerButton
            // 
            registerButton.Location = new Point(60, 203);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(157, 23);
            registerButton.TabIndex = 12;
            registerButton.Text = "Enter";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(236, 203);
            button2.Name = "button2";
            button2.Size = new Size(144, 23);
            button2.TabIndex = 13;
            button2.Text = "reset";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(236, 305);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 14;
            // 
            // birthdatedateTimePicker1
            // 
            birthdatedateTimePicker1.Location = new Point(70, 256);
            birthdatedateTimePicker1.Name = "birthdatedateTimePicker1";
            birthdatedateTimePicker1.Size = new Size(200, 23);
            birthdatedateTimePicker1.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 264);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 16;
            label7.Text = "birthdate";
            // 
            // button1
            // 
            button1.Location = new Point(571, 203);
            button1.Name = "button1";
            button1.Size = new Size(134, 23);
            button1.TabIndex = 18;
            button1.Text = "remove";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(412, 203);
            button3.Name = "button3";
            button3.Size = new Size(132, 23);
            button3.TabIndex = 19;
            button3.Text = "update";
            button3.UseVisualStyleBackColor = true;
            // 
            // OwnerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 494);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(birthdatedateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(registerButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(userNametextBox6);
            Controls.Add(passwordtextBox5);
            Controls.Add(nationalCodeTextBox);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Name = "OwnerForm";
            Text = "OwnerForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox phoneNumberTextBox;
        private TextBox nationalCodeTextBox;
        private TextBox passwordtextBox5;
        private TextBox userNametextBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button registerButton;
        private Button button2;
        private DataGridView dataGridView1;
        private DateTimePicker birthdatedateTimePicker1;
        private Label label7;
        private Button button1;
        private Button button3;
    }
}