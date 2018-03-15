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
    public partial class Form1 : Form
    {

        /// <summary>
        /// Represents one drink
        /// </summary>
        struct Drink
        {
            public string name;
            public double price;

            public Drink(double price, string name)
            {
                this.price = price;
                this.name = name;
            }
        }

        private List<Drink> drinkOptions = new List<Drink>();
        private Label[] inventoryLabels;
        private int[] drinkInventory = new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5 };

        private double totalAmountSpent = 0;

        public Form1()
        {
            InitializeComponent();
            CreateDrinks();
            inventoryLabels = new Label[] { label1, label2, label3, label4, label5, label6, label7, label8, label9 };
        }

        /// <summary>
        /// Fills drinkOptions with the struct 'Drink' objects
        /// </summary>
        private void CreateDrinks()
        {
            drinkOptions.Add(new Drink(1.00, "Coke"));
            drinkOptions.Add(new Drink(1.05, "Pepsi"));
            drinkOptions.Add(new Drink(1.75, "Sprite"));
            drinkOptions.Add(new Drink(0.95, "fanta"));
            drinkOptions.Add(new Drink(1.25, "7 Up"));
            drinkOptions.Add(new Drink(2.00, "Mountain Dew"));
            drinkOptions.Add(new Drink(1.50, "Diet Coke"));
            drinkOptions.Add(new Drink(1.55, "Diet Pepsi"));
            drinkOptions.Add(new Drink(0.75, "Dasani"));
        }

        /// <summary>
        /// Exits the form upon clicking
        /// </summary>
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Resets the inventory counters to 5, the total
        /// amount of money spent to 0, and resets the 
        /// inventory labels to 5 and clears the comboBox
        /// </summary>
        private void Reset_Click(object sender, EventArgs e)
        {
            drinkInventory = new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            totalAmountSpent = 0;
            TotalLabel.Text = "Total: $" + totalAmountSpent;
            comboBox1.Items.Clear();
            comboBox1.DropDownHeight = 106;
            foreach (Label label in inventoryLabels)
                label.Text = "5";

        }

        /// <summary>
        /// When a drink is purchased we check if there is
        /// any remaining inventory, if so, we subtract 1
        /// and add the price to the total running amount
        /// and update the total label and comboBox for 
        /// drinks purchased.
        /// </summary>
        /// <param name="index">Index of the drink being purchased</param>
        private void ItemPurchased(int index)
        {
            if (drinkInventory[index] <= 0)
                return;
            drinkInventory[index]--;
            totalAmountSpent += drinkOptions[index].price;
            comboBox1.Items.Add(drinkOptions[index].name);
            TotalLabel.Text = "Total: $" + totalAmountSpent.ToString("F");
        }

        /// <summary>
        /// Handles purchasing a coke
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            ItemPurchased(0);
            label1.Text = "" + (drinkInventory[0]);
        }

        /// <summary>
        /// Handles purchasing a pepsi
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            ItemPurchased(1);
            label2.Text = "" + (drinkInventory[1]);
        }

        /// <summary>
        /// Handles purchasing a Sprite
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            ItemPurchased(2);
            label3.Text = "" + (drinkInventory[2]);
        }

        /// <summary>
        /// Handles purchasing a Fanta
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            ItemPurchased(3);
            label4.Text = "" + (drinkInventory[3]);
        }

        /// <summary>
        /// Handles purchasing a 7UP
        /// </summary>
        private void button5_Click(object sender, EventArgs e)
        {
            ItemPurchased(4);
            label5.Text = "" + (drinkInventory[4]);
        }

        /// <summary>
        /// Handles purchasing a Mountain Dew
        /// </summary>
        private void button6_Click(object sender, EventArgs e)
        {
            ItemPurchased(5);
            label6.Text = "" + (drinkInventory[5]);
        }

        /// <summary>
        /// Handles purchasing a diet coke
        /// </summary>
        private void button7_Click(object sender, EventArgs e)
        {
            ItemPurchased(6);
            label7.Text = "" + (drinkInventory[6]);
        }

        /// <summary>
        /// Handles purchasing a diet pepsi
        /// </summary>
        private void button8_Click(object sender, EventArgs e)
        {
            ItemPurchased(7);
            label8.Text = "" + (drinkInventory[7]);
        }

        /// <summary>
        /// Handles purchasing a Dasani
        /// </summary>
        private void button9_Click(object sender, EventArgs e)
        {
            ItemPurchased(8);
            label9.Text = "" + (drinkInventory[8]);
        }
    }
}
