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
            reserRejisterutton1 = new Button();
            LessordataGridView1 = new DataGridView();
            BirthDatedateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            updatebutton1 = new Button();
            removebutton2 = new Button();
            ((System.ComponentModel.ISupportInitialize)LessordataGridView1).BeginInit();
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
            // reserRejisterutton1
            // 
            reserRejisterutton1.Location = new Point(281, 256);
            reserRejisterutton1.Name = "reserRejisterutton1";
            reserRejisterutton1.Size = new Size(75, 23);
            reserRejisterutton1.TabIndex = 13;
            reserRejisterutton1.Text = "Reset";
            reserRejisterutton1.UseVisualStyleBackColor = true;
            reserRejisterutton1.Click += reserRejisterutton1_Click;
            // 
            // LessordataGridView1
            // 
            LessordataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LessordataGridView1.Location = new Point(131, 312);
            LessordataGridView1.Name = "LessordataGridView1";
            LessordataGridView1.Size = new Size(240, 150);
            LessordataGridView1.TabIndex = 14;
            // 
            // BirthDatedateTimePicker1
            // 
            BirthDatedateTimePicker1.Location = new Point(557, 256);
            BirthDatedateTimePicker1.Name = "BirthDatedateTimePicker1";
            BirthDatedateTimePicker1.Size = new Size(200, 23);
            BirthDatedateTimePicker1.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(496, 262);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 16;
            label7.Text = "birthdate";
            // 
            // updatebutton1
            // 
            updatebutton1.Location = new Point(569, 312);
            updatebutton1.Name = "updatebutton1";
            updatebutton1.Size = new Size(75, 23);
            updatebutton1.TabIndex = 17;
            updatebutton1.Text = "update";
            updatebutton1.UseVisualStyleBackColor = true;
            // 
            // removebutton2
            // 
            removebutton2.Location = new Point(419, 312);
            removebutton2.Name = "removebutton2";
            removebutton2.Size = new Size(75, 23);
            removebutton2.TabIndex = 18;
            removebutton2.Text = "Remove";
            removebutton2.UseVisualStyleBackColor = true;
            // 
            // LessorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(removebutton2);
            Controls.Add(updatebutton1);
            Controls.Add(label7);
            Controls.Add(BirthDatedateTimePicker1);
            Controls.Add(LessordataGridView1);
            Controls.Add(reserRejisterutton1);
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
            ((System.ComponentModel.ISupportInitialize)LessordataGridView1).EndInit();
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
        private Button reserRejisterutton1;
        private DataGridView LessordataGridView1;
        private DateTimePicker BirthDatedateTimePicker1;
        private Label label7;
        private Button updatebutton1;
        private Button removebutton2;
    }
}