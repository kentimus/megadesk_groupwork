using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Roper
{
    class DeskQuote
    {
        public string customerName;
        public Desk customerDesk;
        public int rushDays;
        public int price;

        public DeskQuote(string customerName, Desk customerDesk, int rushDays)
        {
            this.customerName = customerName;
            this.customerDesk = customerDesk;
            this.rushDays = rushDays;
            this.price = SetPrice();
        }

        private int SetPrice()
        {
            int BasePrice = 200;
            int Area = customerDesk.getWidth() * customerDesk.getDepth();
            int SurfaceAreaPrice = GetSurfaceAreaPrice(Area);
            int DrawerPrice = GetDrawerPrice(customerDesk.getNumDrawers());
            int MaterialPrice = GetMaterialPrice(customerDesk.getSurfaceMaterial());
            int RushPrice = GetRushOrder(rushDays, Area);
       
            return BasePrice + SurfaceAreaPrice + DrawerPrice + MaterialPrice + RushPrice;
        }

        private int GetSurfaceAreaPrice(int surfaceArea)
        {
            if(surfaceArea > 1000)
            {
                return surfaceArea;
            } else
            {
                return 0;
            }
        }

        private int GetDrawerPrice(int numDrawers)
        {
            return numDrawers * 50;
        }

        private int GetMaterialPrice(DesktopMaterial material)
        {
            switch (material)
            {
                case DesktopMaterial.Oak:
                    return 200;
                case DesktopMaterial.Laminate:
                    return 100;
                case DesktopMaterial.Pine:
                    return 50;
                case DesktopMaterial.Rosewood:
                    return 300;
                case DesktopMaterial.Veneer:
                    return 125;
                default:
                    return 50;
            }
        }

        public static int[,] GetPrices()
        {
            string[] lines = File.ReadAllLines(@"rushOrderPrices.txt");

            int[,] rushPrice = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    rushPrice[i, j] = Int32.Parse(lines[(i * 3) + j]);
                }
            }
            return rushPrice;
        }
        public int GetRushOrder(int days, int surfaceArea)
        {
            int costRush = 0;

            switch (days)
            {
                case 3:
                    if (surfaceArea < 1000) { costRush = GetPrices()[0, 0]; }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000) { costRush = GetPrices()[0, 1]; }
                    else { costRush = GetPrices()[0, 2]; }
                    break;
                case 5:
                    if (surfaceArea < 1000) { costRush = GetPrices()[1, 0]; }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000) { costRush = GetPrices()[1, 1]; }
                    else { costRush = GetPrices()[1, 2]; }
                    break;
                case 7:
                    if (surfaceArea < 1000) { costRush = GetPrices()[2, 0]; }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000) { costRush = GetPrices()[2, 1]; }
                    else { costRush = GetPrices()[2, 2]; }
                    break;
                default:
                    costRush = 0;
                    break;
            }

            return costRush;

        }

        /*private int getRushPrice(int days, int surfaceArea)
        {
            switch (days){
                case 3:
                    if (surfaceArea < 1000) { return 60; }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000) { return 70; }
                    else { return 80; } // surfaceArea > 2000
                case 5:
                    if (surfaceArea < 1000) { return 40; }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000) { return 50; }
                    else { return 60; }
                case 7:
                    if (surfaceArea < 1000) { return 30; }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000) { return 35; }
                    else { return 40; }
                default:
                    return 0;
            }
        }
        */
        public int GetPrice()
        {
            return price;
        }


        public string GetName()
        {
            return customerName;
        }

        public int GetRushDays()
        {
            return rushDays;
        }

        public int GetWidth()
        {
            return customerDesk.getWidth();
        }

        public int GetDepth()
        {
            return customerDesk.getDepth();
        }

        public int GetNumDrawers()
        {
            return customerDesk.getNumDrawers();
        }

        public DesktopMaterial GetMaterial()
        {
            return customerDesk.getSurfaceMaterial();
        }
    }
}
