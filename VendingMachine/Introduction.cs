using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine
{
    public partial class Introduction : Form
    {
        public Introduction()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Activates the vending machine
        /// </summary>
        /// <param name="sender">Not Used</param>
        /// <param name="e">Not Used</param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 vendingMachine = new Form1();
            vendingMachine.ShowDialog();
            this.Close();
        }
    }
}
