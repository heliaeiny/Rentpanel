namespace Rentpanel.Forms
{
    partial class newForm1
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
            userNameTextBox1 = new TextBox();
            PasswordTextBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Registerbutton1 = new Button();
            resetRejisterButton2 = new Button();
            removebutton1 = new Button();
            updatebutton2 = new Button();
            SuspendLayout();
            // 
            // userNameTextBox1
            // 
            userNameTextBox1.Location = new Point(317, 60);
            userNameTextBox1.Name = "userNameTextBox1";
            userNameTextBox1.Size = new Size(100, 23);
            userNameTextBox1.TabIndex = 0;
            // 
            // PasswordTextBox2
            // 
            PasswordTextBox2.Location = new Point(317, 114);
            PasswordTextBox2.Name = "PasswordTextBox2";
            PasswordTextBox2.Size = new Size(100, 23);
            PasswordTextBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(209, 60);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 2;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 114);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // Registerbutton1
            // 
            Registerbutton1.Location = new Point(191, 186);
            Registerbutton1.Name = "Registerbutton1";
            Registerbutton1.Size = new Size(75, 23);
            Registerbutton1.TabIndex = 4;
            Registerbutton1.Text = "Enter";
            Registerbutton1.UseVisualStyleBackColor = true;
            Registerbutton1.Click += registerbutton1_Click;
            // 
            // resetRejisterButton2
            // 
            resetRejisterButton2.Location = new Point(332, 186);
            resetRejisterButton2.Name = "resetRejisterButton2";
            resetRejisterButton2.Size = new Size(75, 23);
            resetRejisterButton2.TabIndex = 5;
            resetRejisterButton2.Text = "Reset";
            resetRejisterButton2.UseVisualStyleBackColor = true;
            resetRejisterButton2.Click += resetRejisterButton2_Click;
            // 
            // removebutton1
            // 
            removebutton1.Location = new Point(577, 186);
            removebutton1.Name = "removebutton1";
            removebutton1.Size = new Size(75, 23);
            removebutton1.TabIndex = 6;
            removebutton1.Text = "remove";
            removebutton1.UseVisualStyleBackColor = true;
            // 
            // updatebutton2
            // 
            updatebutton2.Location = new Point(447, 186);
            updatebutton2.Name = "updatebutton2";
            updatebutton2.Size = new Size(75, 23);
            updatebutton2.TabIndex = 7;
            updatebutton2.Text = "update";
            updatebutton2.UseVisualStyleBackColor = true;
            // 
            // newForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(updatebutton2);
            Controls.Add(removebutton1);
            Controls.Add(resetRejisterButton2);
            Controls.Add(Registerbutton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTextBox2);
            Controls.Add(userNameTextBox1);
            Name = "newForm1";
            Text = "newForm1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userNameTextBox1;
        private TextBox PasswordTextBox2;
        private Label label1;
        private Label label2;
        private Button Registerbutton1;
        private Button resetRejisterButton2;
        private Button removebutton1;
        private Button updatebutton2;
    }
}