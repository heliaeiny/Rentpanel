using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rentpanel.Forms
{
    public partial class LayOutPanelForm : Form
    {
        public LayOutPanelForm()
        {
            InitializeComponent();
        }

        private void managmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OwnerForm ownerform = new OwnerForm();
            ownerform.ShowDialog();
        }

        private void managmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
        }

        private void managmentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.ShowDialog();
        }

        private void managmentToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            LessorForm lessorForm = new LessorForm();
            lessorForm.ShowDialog();
        }

        private void managmentToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            AdressForm adressForm = new AdressForm();
            adressForm.ShowDialog();
        }

        private void LayOutPanelForm_Load(object sender, EventArgs e)
        {

        }
    }
}
