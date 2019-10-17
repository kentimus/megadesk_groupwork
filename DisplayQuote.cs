using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Roper
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        { 
            InitializeComponent();
            ResultsTotalPrice.Text = "hello";
        }

        private static DeskQuote customerQuote;

        private void BackToMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            customerQuote = Program.Quotes.GetLatest();
           /* string[] prices = File.ReadAllLines(@"RushOrderPrices.txt");
testRushOrder.Text = "";
            foreach (string rushprice in prices)
            {
                
                // Use a tab to indent each line of the file.
                testRushOrder.Text += "\t" + rushprice + " ";
            }*/
                try
            {
                int Area = customerQuote.GetWidth() * customerQuote.GetDepth();
                int rDays = customerQuote.GetRushDays();
                OrderDateLabel.Text = customerQuote.GetDate();
                ResultsCustomerName.Text = customerQuote.GetName();
                ResultsRushDays.Text = customerQuote.GetRushDays().ToString();
                ResultsWidth.Text = customerQuote.GetWidth().ToString();
                ResultsDepth.Text = customerQuote.GetDepth().ToString();
                ResultsTotalPrice.Text = customerQuote.GetPrice().ToString();
                ResultsNumDrawers.Text = customerQuote.GetNumDrawers().ToString();
                ResultsSurfaceMaterial.Text = customerQuote.GetMaterial().ToString();
                ResultRushOrder.Text = customerQuote.GetRushOrder(rDays,Area).ToString();
                    }
            catch
            {
                ResultsCustomerName.Text = "";
                ResultsRushDays.Text = "";
                ResultsWidth.Text = "";
                ResultsDepth.Text = "";
                ResultsNumDrawers.Text = "";
                ResultsSurfaceMaterial.Text = "";
                ResultsTotalPrice.Text = "Problem calculating total price.";
            }
            
        }

        private void ResultsCustomerName_Click(object sender, EventArgs e)
        {

        }
    }
}
