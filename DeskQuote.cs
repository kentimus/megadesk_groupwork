using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Roper
{
    class DeskQuote
    {
        private string customerName;
        private Desk customerDesk;
        private int rushDays;
        private int price;

        public DeskQuote(string customerName, Desk customerDesk, int rushDays)
        {
            this.customerName = customerName;
            this.customerDesk = customerDesk;
            this.rushDays = rushDays;
            this.price = setPrice();
        }

        private int setPrice()
        {
            int BasePrice = 200;
            int Area = customerDesk.getWidth() * customerDesk.getDepth();
            int SurfaceAreaPrice = getSurfaceAreaPrice(Area);
            int DrawerPrice = getDrawerPrice(customerDesk.getNumDrawers());
            int MaterialPrice = getMaterialPrice(customerDesk.getSurfaceMaterial());
            int RushPrice = getRushPrice(rushDays, Area);
       
            return BasePrice + SurfaceAreaPrice + DrawerPrice + MaterialPrice + RushPrice;
        }

        private int getSurfaceAreaPrice(int surfaceArea)
        {
            if(surfaceArea > 1000)
            {
                return surfaceArea;
            } else
            {
                return 0;
            }
        }

        private int getDrawerPrice(int numDrawers)
        {
            return numDrawers * 50;
        }

        private int getMaterialPrice(DesktopMaterial material)
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

        private int getRushPrice(int days, int surfaceArea)
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

        public int getPrice()
        {
            return price;
        }

        public string getName()
        {
            return customerName;
        }

        public int getRushDays()
        {
            return rushDays;
        }

        public int getWidth()
        {
            return customerDesk.getWidth();
        }

        public int getDepth()
        {
            return customerDesk.getDepth();
        }

        public int getNumDrawers()
        {
            return customerDesk.getNumDrawers();
        }

        public DesktopMaterial getMaterial()
        {
            return customerDesk.getSurfaceMaterial();
        }
    }
}
