namespace Rentpanel.Forms
{
    partial class OrderForm
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
            ownerTextBox1 = new TextBox();
            ProductTextBox2 = new TextBox();
            CurrentPriceTextBox3 = new TextBox();
            AdressTextBox4 = new TextBox();
            CountTextBox5 = new TextBox();
            SendAtTextBox6 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            DeliveryFullNameTtextBox7 = new TextBox();
            DeliveryPhoneNumbereTxtBox8 = new TextBox();
            registerButton = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // ownerTextBox1
            // 
            ownerTextBox1.Location = new Point(132, 31);
            ownerTextBox1.Name = "ownerTextBox1";
            ownerTextBox1.Size = new Size(100, 23);
            ownerTextBox1.TabIndex = 0;
            // 
            // ProductTextBox2
            // 
            ProductTextBox2.Location = new Point(132, 112);
            ProductTextBox2.Name = "ProductTextBox2";
            ProductTextBox2.Size = new Size(100, 23);
            ProductTextBox2.TabIndex = 1;
            // 
            // CurrentPriceTextBox3
            // 
            CurrentPriceTextBox3.Location = new Point(132, 69);
            CurrentPriceTextBox3.Name = "CurrentPriceTextBox3";
            CurrentPriceTextBox3.Size = new Size(100, 23);
            CurrentPriceTextBox3.TabIndex = 2;
            // 
            // AdressTextBox4
            // 
            AdressTextBox4.Location = new Point(517, 60);
            AdressTextBox4.Name = "AdressTextBox4";
            AdressTextBox4.Size = new Size(100, 23);
            AdressTextBox4.TabIndex = 3;
            // 
            // CountTextBox5
            // 
            CountTextBox5.Location = new Point(517, 31);
            CountTextBox5.Name = "CountTextBox5";
            CountTextBox5.Size = new Size(100, 23);
            CountTextBox5.TabIndex = 4;
            // 
            // SendAtTextBox6
            // 
            SendAtTextBox6.Location = new Point(517, 112);
            SendAtTextBox6.Name = "SendAtTextBox6";
            SendAtTextBox6.Size = new Size(100, 23);
            SendAtTextBox6.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 36);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 6;
            label1.Text = "Owner";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 72);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 7;
            label2.Text = "CurrentPrice";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 120);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 8;
            label3.Text = "Product";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(458, 34);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 9;
            label4.Text = "Count";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(458, 72);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 10;
            label5.Text = "Adress";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(458, 120);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 11;
            label6.Text = "SendAt";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(-1, 177);
            label7.Name = "label7";
            label7.Size = new Size(127, 15);
            label7.TabIndex = 12;
            label7.Text = "DeliveryPhoneNumber";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(403, 169);
            label8.Name = "label8";
            label8.Size = new Size(100, 15);
            label8.TabIndex = 13;
            label8.Text = "DeliveryFullName";
            label8.Click += label8_Click;
            // 
            // DeliveryFullNameTtextBox7
            // 
            DeliveryFullNameTtextBox7.Location = new Point(517, 164);
            DeliveryFullNameTtextBox7.Name = "DeliveryFullNameTtextBox7";
            DeliveryFullNameTtextBox7.Size = new Size(100, 23);
            DeliveryFullNameTtextBox7.TabIndex = 14;
            // 
            // DeliveryPhoneNumbereTxtBox8
            // 
            DeliveryPhoneNumbereTxtBox8.Location = new Point(132, 169);
            DeliveryPhoneNumbereTxtBox8.Name = "DeliveryPhoneNumbereTxtBox8";
            DeliveryPhoneNumbereTxtBox8.Size = new Size(100, 23);
            DeliveryPhoneNumbereTxtBox8.TabIndex = 15;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(95, 241);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(75, 23);
            registerButton.TabIndex = 16;
            registerButton.Text = "Enter";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(455, 241);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 17;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(registerButton);
            Controls.Add(DeliveryPhoneNumbereTxtBox8);
            Controls.Add(DeliveryFullNameTtextBox7);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SendAtTextBox6);
            Controls.Add(CountTextBox5);
            Controls.Add(AdressTextBox4);
            Controls.Add(CurrentPriceTextBox3);
            Controls.Add(ProductTextBox2);
            Controls.Add(ownerTextBox1);
            Name = "OrderForm";
            Text = "OrderForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ownerTextBox1;
        private TextBox ProductTextBox2;
        private TextBox CurrentPriceTextBox3;
        private TextBox AdressTextBox4;
        private TextBox CountTextBox5;
        private TextBox SendAtTextBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox DeliveryFullNameTtextBox7;
        private TextBox DeliveryPhoneNumbereTxtBox8;
        private Button registerButton;
        private Button button2;
    }
}