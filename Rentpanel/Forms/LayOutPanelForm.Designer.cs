namespace Rentpanel.Forms
{
    partial class LayOutPanelForm
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
            menuStrip1 = new MenuStrip();
            userToolStripMenuItem = new ToolStripMenuItem();
            managmentToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            managmentToolStripMenuItem1 = new ToolStripMenuItem();
            orderToolStripMenuItem = new ToolStripMenuItem();
            managmentToolStripMenuItem2 = new ToolStripMenuItem();
            lessorToolStripMenuItem = new ToolStripMenuItem();
            managmentToolStripMenuItem3 = new ToolStripMenuItem();
            adressToolStripMenuItem = new ToolStripMenuItem();
            managmentToolStripMenuItem4 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { userToolStripMenuItem, productToolStripMenuItem, orderToolStripMenuItem, lessorToolStripMenuItem, adressToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(811, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { managmentToolStripMenuItem });
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(42, 20);
            userToolStripMenuItem.Text = "User";
            // 
            // managmentToolStripMenuItem
            // 
            managmentToolStripMenuItem.Name = "managmentToolStripMenuItem";
            managmentToolStripMenuItem.Size = new Size(139, 22);
            managmentToolStripMenuItem.Text = "managment";
            managmentToolStripMenuItem.Click += managmentToolStripMenuItem_Click;
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { managmentToolStripMenuItem1 });
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(61, 20);
            productToolStripMenuItem.Text = "Product";
            // 
            // managmentToolStripMenuItem1
            // 
            managmentToolStripMenuItem1.Name = "managmentToolStripMenuItem1";
            managmentToolStripMenuItem1.Size = new Size(139, 22);
            managmentToolStripMenuItem1.Text = "managment";
            managmentToolStripMenuItem1.Click += managmentToolStripMenuItem1_Click;
            // 
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { managmentToolStripMenuItem2 });
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            orderToolStripMenuItem.Size = new Size(49, 20);
            orderToolStripMenuItem.Text = "Order";
            // 
            // managmentToolStripMenuItem2
            // 
            managmentToolStripMenuItem2.Name = "managmentToolStripMenuItem2";
            managmentToolStripMenuItem2.Size = new Size(139, 22);
            managmentToolStripMenuItem2.Text = "managment";
            managmentToolStripMenuItem2.Click += managmentToolStripMenuItem2_Click;
            // 
            // lessorToolStripMenuItem
            // 
            lessorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { managmentToolStripMenuItem3 });
            lessorToolStripMenuItem.Name = "lessorToolStripMenuItem";
            lessorToolStripMenuItem.Size = new Size(52, 20);
            lessorToolStripMenuItem.Text = "Lessor";
            // 
            // managmentToolStripMenuItem3
            // 
            managmentToolStripMenuItem3.Name = "managmentToolStripMenuItem3";
            managmentToolStripMenuItem3.Size = new Size(139, 22);
            managmentToolStripMenuItem3.Text = "managment";
            managmentToolStripMenuItem3.Click += managmentToolStripMenuItem3_Click;
            // 
            // adressToolStripMenuItem
            // 
            adressToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { managmentToolStripMenuItem4 });
            adressToolStripMenuItem.Name = "adressToolStripMenuItem";
            adressToolStripMenuItem.Size = new Size(54, 20);
            adressToolStripMenuItem.Text = "Adress";
            // 
            // managmentToolStripMenuItem4
            // 
            managmentToolStripMenuItem4.Name = "managmentToolStripMenuItem4";
            managmentToolStripMenuItem4.Size = new Size(139, 22);
            managmentToolStripMenuItem4.Text = "managment";
            managmentToolStripMenuItem4.Click += managmentToolStripMenuItem4_Click;
            // 
            // LayOutPanelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "LayOutPanelForm";
            Text = "agm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem managmentToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem managmentToolStripMenuItem1;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem managmentToolStripMenuItem2;
        private ToolStripMenuItem lessorToolStripMenuItem;
        private ToolStripMenuItem managmentToolStripMenuItem3;
        private ToolStripMenuItem adressToolStripMenuItem;
        private ToolStripMenuItem managmentToolStripMenuItem4;
    }
}