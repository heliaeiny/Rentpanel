namespace Rentpanel.Forms
{
    partial class ProductForm
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
            Enterrejisterbutton1 = new Button();
            ProductdataGridView1 = new DataGridView();
            rsetRejisterButton1 = new Button();
            descriptiontextBox1 = new TextBox();
            codetextBox3 = new TextBox();
            nametextBox6 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            yesSellableradioButton1 = new RadioButton();
            notsellableradioButton2 = new RadioButton();
            label3 = new Label();
            pricetextBox1 = new TextBox();
            updatebutton1 = new Button();
            removebutton2 = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductdataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Enterrejisterbutton1
            // 
            Enterrejisterbutton1.Location = new Point(28, 259);
            Enterrejisterbutton1.Name = "Enterrejisterbutton1";
            Enterrejisterbutton1.Size = new Size(75, 23);
            Enterrejisterbutton1.TabIndex = 0;
            Enterrejisterbutton1.Text = "Enter";
            Enterrejisterbutton1.UseVisualStyleBackColor = true;
            Enterrejisterbutton1.Click += button1_Click;
            // 
            // ProductdataGridView1
            // 
            ProductdataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductdataGridView1.Location = new Point(30, 288);
            ProductdataGridView1.Name = "ProductdataGridView1";
            ProductdataGridView1.Size = new Size(389, 150);
            ProductdataGridView1.TabIndex = 1;
            // 
            // rsetRejisterButton1
            // 
            rsetRejisterButton1.Location = new Point(127, 259);
            rsetRejisterButton1.Name = "rsetRejisterButton1";
            rsetRejisterButton1.Size = new Size(75, 23);
            rsetRejisterButton1.TabIndex = 2;
            rsetRejisterButton1.Text = "Reset";
            rsetRejisterButton1.UseVisualStyleBackColor = true;
            rsetRejisterButton1.Click += rsetRejisterButton1_Click;
            // 
            // descriptiontextBox1
            // 
            descriptiontextBox1.Location = new Point(102, 19);
            descriptiontextBox1.Name = "descriptiontextBox1";
            descriptiontextBox1.Size = new Size(100, 23);
            descriptiontextBox1.TabIndex = 3;
            // 
            // codetextBox3
            // 
            codetextBox3.Location = new Point(102, 73);
            codetextBox3.Name = "codetextBox3";
            codetextBox3.Size = new Size(100, 23);
            codetextBox3.TabIndex = 5;
            // 
            // nametextBox6
            // 
            nametextBox6.Location = new Point(102, 188);
            nametextBox6.Name = "nametextBox6";
            nametextBox6.Size = new Size(100, 23);
            nametextBox6.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 19);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 9;
            label1.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 73);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 10;
            label2.Text = "Code";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 193);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 12;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(269, 98);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 13;
            label5.Text = "IsSellAble";
            // 
            // yesSellableradioButton1
            // 
            yesSellableradioButton1.AutoSize = true;
            yesSellableradioButton1.Location = new Point(332, 89);
            yesSellableradioButton1.Name = "yesSellableradioButton1";
            yesSellableradioButton1.Size = new Size(87, 19);
            yesSellableradioButton1.TabIndex = 14;
            yesSellableradioButton1.TabStop = true;
            yesSellableradioButton1.Text = "NotSellAble";
            yesSellableradioButton1.UseVisualStyleBackColor = true;
            // 
            // notsellableradioButton2
            // 
            notsellableradioButton2.AutoSize = true;
            notsellableradioButton2.Location = new Point(332, 114);
            notsellableradioButton2.Name = "notsellableradioButton2";
            notsellableradioButton2.Size = new Size(67, 19);
            notsellableradioButton2.TabIndex = 15;
            notsellableradioButton2.TabStop = true;
            notsellableradioButton2.Text = "SellAble";
            notsellableradioButton2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 133);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 16;
            label3.Text = "Price";
            // 
            // pricetextBox1
            // 
            pricetextBox1.Location = new Point(102, 130);
            pricetextBox1.Name = "pricetextBox1";
            pricetextBox1.Size = new Size(100, 23);
            pricetextBox1.TabIndex = 17;
            // 
            // updatebutton1
            // 
            updatebutton1.Location = new Point(231, 259);
            updatebutton1.Name = "updatebutton1";
            updatebutton1.Size = new Size(75, 23);
            updatebutton1.TabIndex = 18;
            updatebutton1.Text = "update";
            updatebutton1.UseVisualStyleBackColor = true;
            // 
            // removebutton2
            // 
            removebutton2.Location = new Point(335, 259);
            removebutton2.Name = "removebutton2";
            removebutton2.Size = new Size(75, 23);
            removebutton2.TabIndex = 19;
            removebutton2.Text = "Remove";
            removebutton2.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 450);
            Controls.Add(removebutton2);
            Controls.Add(updatebutton1);
            Controls.Add(pricetextBox1);
            Controls.Add(label3);
            Controls.Add(notsellableradioButton2);
            Controls.Add(yesSellableradioButton1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nametextBox6);
            Controls.Add(codetextBox3);
            Controls.Add(descriptiontextBox1);
            Controls.Add(rsetRejisterButton1);
            Controls.Add(ProductdataGridView1);
            Controls.Add(Enterrejisterbutton1);
            Name = "ProductForm";
            Text = "ProductForm";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)ProductdataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Enterrejisterbutton1;
        private DataGridView ProductdataGridView1;
        private Button rsetRejisterButton1;
        private TextBox descriptiontextBox1;
        private TextBox codetextBox3;
        private TextBox nametextBox6;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private RadioButton yesSellableradioButton1;
        private RadioButton notsellableradioButton2;
        private Label label3;
        private TextBox pricetextBox1;
        private Button updatebutton1;
        private Button removebutton2;
    }
}