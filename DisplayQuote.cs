using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            try
            {
                ResultsCustomerName.Text = customerQuote.getName();
                ResultsRushDays.Text = customerQuote.getRushDays().ToString();
                ResultsWidth.Text = customerQuote.getWidth().ToString();
                ResultsDepth.Text = customerQuote.getDepth().ToString();
                ResultsTotalPrice.Text = customerQuote.getPrice().ToString();
                ResultsNumDrawers.Text = customerQuote.getNumDrawers().ToString();
                ResultsSurfaceMaterial.Text = customerQuote.getMaterial().ToString();
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
