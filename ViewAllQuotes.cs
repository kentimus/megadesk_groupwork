using Newtonsoft.Json;
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
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
            
            ViewAllQuotesLoad();
        }

        private void BackToMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();
        }

        private void ViewAllQuotesLoad()
        {
            
            try
             {
                 var file = @"quotes.json";
                 using (StreamReader sr = new StreamReader(file))
                 {
                     string orders = sr.ReadToEnd();
                     List<DeskQuote> deskOrders = JsonConvert.DeserializeObject<List<DeskQuote>>(orders);
 
                     dataGridViewAllQuotes.DataSource = deskOrders.Select(desk => new
                     {
                         Width = desk.customerDesk.Width,
                         Depth = desk.customerDesk.Depth,
                         Drawers = desk.customerDesk.NumDrawers,
                         SurfaceMaterial = desk.customerDesk.SurfaceMaterial,
                         Price = desk.price,
                         CustomerName = desk.customerName,
                         RushDays = desk.rushDays,
                         OrderDate = desk.orderDate

                     }).ToList();

                 }

             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message + "Error");
             }

            


        }
    }
}
