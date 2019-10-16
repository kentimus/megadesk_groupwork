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

        //private static string CustomerName = AddQuotesForm.customerNameValue;
        //private static int rushDays = AddQuotesForm.rushDaysValue;
        //private static int width = AddQuotesForm.widthValue;
        //private static int depth = AddQuotesForm.depthValue;
        //private static int numDrawers = AddQuotesForm.numDrawersValue;
        //private static string surfaceMaterial = AddQuotesForm.surfaceMaterialValue;

        //private static Desk customerDesk = new Desk(width, depth, numDrawers, surfaceMaterial);
        //private static DeskQuote customerQuote = new DeskQuote(CustomerName, customerDesk, rushDays);
        private static DeskQuote customerQuote = Program.Quotes.GetLatest();
        //Program.Quotes.Add(customerQuote);

        

        


        private void BackToMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
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
