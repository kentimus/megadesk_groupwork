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
    public partial class AddQuotesForm : Form
    {
        public AddQuotesForm()
        {
            InitializeComponent();
            CreateQuoteButton.Enabled = false;
        }

        public static string customerNameValue;
        public static int rushDaysValue;
        public static int widthValue;
        public static int depthValue;
        public static int numDrawersValue;
        public static string surfaceMaterialValue;

        private void BackToMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();
        }

        public int getDrawerCount()
        {
            return (int)NumDrawers.Value;
        }
        

        private void CheckForm()
        {
            bool formOkay = true;
            if(CustomerName.Text != "")
            {
                CustomerNameHelperText.BackColor = Color.FromArgb(240, 240, 240);
                CustomerNameHelperText.ForeColor = Color.Green;
            } else
            {
                formOkay = false;
                CustomerNameHelperText.BackColor = Color.Red;
                CustomerNameHelperText.ForeColor = Color.White;
            }

            if(RushDays.Text != "")
            {
                RushDaysHelperText.BackColor = Color.FromArgb(240, 240, 240);
                RushDaysHelperText.ForeColor = Color.Green;
            } else
            {
                formOkay = false;
                RushDaysHelperText.BackColor = Color.Red;
                RushDaysHelperText.ForeColor = Color.White;
            }

            if (Width.Value >= 24 && Width.Value <= 96)
            {
                WidthHelperText.BackColor = Color.FromArgb(240, 240, 240);
                WidthHelperText.ForeColor = Color.Green;
            }
            else
            {
                formOkay = false;
                WidthHelperText.BackColor = Color.Red;
                WidthHelperText.ForeColor = Color.White;
            }

            if(Depth.Value >= 12 && Depth.Value <= 48)
            {
                DepthHelperText.BackColor = Color.FromArgb(240, 240, 240);
                DepthHelperText.ForeColor = Color.Green;
            } else
            {
                formOkay = false;
                DepthHelperText.BackColor = Color.Red;
                DepthHelperText.ForeColor = Color.White;
            }

            if(NumDrawers.Value >= 0 && NumDrawers.Value <= 7)
            {
                DrawersHelperText.BackColor = Color.FromArgb(240, 240, 240);
                DrawersHelperText.ForeColor = Color.Green;
            } else
            {
                formOkay = false;
                DrawersHelperText.BackColor = Color.Red;
                DrawersHelperText.ForeColor = Color.White;
            }

            if (SurfaceMaterial.Text != "")
            {
                SurfaceHelperText.BackColor = Color.FromArgb(240, 240, 240);
                SurfaceHelperText.ForeColor = Color.Green;
            } else
            {
                formOkay = false;
                SurfaceHelperText.BackColor = Color.Red;
                SurfaceHelperText.ForeColor = Color.White;
            }



            if (formOkay == true)
            {
                CreateQuoteButton.Enabled = true;
            } else
            {
                CreateQuoteButton.Enabled = false;
            }
        }

        private void Width_ValueChanged(object sender, EventArgs e)
        {
            CheckForm();
        }

        private void Depth_ValueChanged(object sender, EventArgs e)
        {
            CheckForm();
        }

        private void NumDrawers_ValueChanged(object sender, EventArgs e)
        {
            CheckForm();
        }

        private void SurfaceMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckForm();
        }

        private void CreateQuoteButton_Click(object sender, EventArgs e)
        {
            DeskQuote customerQuote = null;

            customerNameValue = CustomerName.Text;
            rushDaysValue = Convert.ToInt32(RushDays.Text);
            widthValue = (int) Width.Value;
            depthValue = (int) Depth.Value;
            numDrawersValue = (int) NumDrawers.Value;
            surfaceMaterialValue = SurfaceMaterial.Text;
            //rushCostValue = ;

            Desk customerDesk = new Desk(widthValue, depthValue, numDrawersValue, surfaceMaterialValue);
            customerQuote = new DeskQuote(customerNameValue, customerDesk, rushDaysValue);
            Program.Quotes.Add(customerQuote);



            //  Saving JSON to text file
            var json = "";
            try
            {
                json = JsonConvert.SerializeObject(customerQuote);

                string fileName = @"quotes.json";

                if (!File.Exists(fileName))
                {
                    using (StreamWriter x = File.CreateText(fileName))
                    {

                    }
                }
                using (StreamWriter x = File.AppendText(fileName))
                {
                    x.WriteLine(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error writing to file.");
            }



            //private static Desk customerDesk = new Desk(widthValue, depthValue, numDrawersValue, surfaceMaterialValue);
            //private static DeskQuote customerQuote = new DeskQuote(customerNameValue, customerDesk, rushDaysValue);


            DisplayQuote viewDisplayQuote = new DisplayQuote();

            viewDisplayQuote.Tag = this.Tag;
            viewDisplayQuote.Show();
            Hide();
        }

        

        private void CustomerName_TextChanged(object sender, EventArgs e)
        {
            CheckForm();
        }

        private void RushDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckForm();
        }

        private void AddQuotesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
