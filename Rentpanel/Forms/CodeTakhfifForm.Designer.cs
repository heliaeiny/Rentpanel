namespace Rentpanel.Forms
{
    partial class CodeTakhfifForm
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
            ff = new Label();
            CodeTakhfiftextBox1 = new TextBox();
            label1 = new Label();
            CodeTakhfifTypecomboBox1 = new ComboBox();
            label3 = new Label();
            CodeTakhfifdataGridView1 = new DataGridView();
            EnterClickButton = new Button();
            ResetCLickbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)CodeTakhfifdataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ff
            // 
            ff.AutoSize = true;
            ff.Location = new Point(580, 23);
            ff.Name = "ff";
            ff.Size = new Size(58, 15);
            ff.TabIndex = 0;
            ff.Text = "کد تخفیف:";
            // 
            // CodeTakhfiftextBox1
            // 
            CodeTakhfiftextBox1.Location = new Point(382, 23);
            CodeTakhfiftextBox1.Name = "CodeTakhfiftextBox1";
            CodeTakhfiftextBox1.Size = new Size(100, 23);
            CodeTakhfiftextBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(584, 77);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "نوع تخفیف";
            // 
            // CodeTakhfifTypecomboBox1
            // 
            CodeTakhfifTypecomboBox1.FormattingEnabled = true;
            CodeTakhfifTypecomboBox1.Items.AddRange(new object[] { "1)درصدی", "2)ثابت" });
            CodeTakhfifTypecomboBox1.Location = new Point(307, 74);
            CodeTakhfifTypecomboBox1.Name = "CodeTakhfifTypecomboBox1";
            CodeTakhfifTypecomboBox1.Size = new Size(175, 23);
            CodeTakhfifTypecomboBox1.TabIndex = 3;
            CodeTakhfifTypecomboBox1.SelectedIndexChanged += CodeTakhfifTypecomboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 206);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 6;
            // 
            // CodeTakhfifdataGridView1
            // 
            CodeTakhfifdataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CodeTakhfifdataGridView1.Location = new Point(39, 288);
            CodeTakhfifdataGridView1.Name = "CodeTakhfifdataGridView1";
            CodeTakhfifdataGridView1.Size = new Size(651, 150);
            CodeTakhfifdataGridView1.TabIndex = 11;
            CodeTakhfifdataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // EnterClickButton
            // 
            EnterClickButton.Location = new Point(92, 206);
            EnterClickButton.Name = "EnterClickButton";
            EnterClickButton.Size = new Size(230, 56);
            EnterClickButton.TabIndex = 12;
            EnterClickButton.Text = "Enter";
            EnterClickButton.UseVisualStyleBackColor = true;
            EnterClickButton.Click += EnterClickButton_Click;
            // 
            // ResetCLickbutton
            // 
            ResetCLickbutton.Location = new Point(356, 206);
            ResetCLickbutton.Name = "ResetCLickbutton";
            ResetCLickbutton.Size = new Size(252, 56);
            ResetCLickbutton.TabIndex = 13;
            ResetCLickbutton.Text = "Reset";
            ResetCLickbutton.UseVisualStyleBackColor = true;
            ResetCLickbutton.Click += ResetCLickbutton_Click;
            // 
            // CodeTakhfifForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 450);
            Controls.Add(ResetCLickbutton);
            Controls.Add(EnterClickButton);
            Controls.Add(CodeTakhfifdataGridView1);
            Controls.Add(label3);
            Controls.Add(CodeTakhfifTypecomboBox1);
            Controls.Add(label1);
            Controls.Add(CodeTakhfiftextBox1);
            Controls.Add(ff);
            Name = "CodeTakhfifForm";
            Load += CodeTakhfifForm_Load;
            ((System.ComponentModel.ISupportInitialize)CodeTakhfifdataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ff;
        private TextBox CodeTakhfiftextBox1;
        private Label label1;
        private ComboBox CodeTakhfifTypecomboBox1;
        private Label label3;
        private DataGridView CodeTakhfifdataGridView1;
        private Button EnterClickButton;
        private Button ResetCLickbutton;
    }
}