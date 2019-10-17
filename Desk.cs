using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Roper
{
    enum DesktopMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }

    class Desk
    {
        public int Width;
        public int Depth;
        public int NumDrawers;
        public DesktopMaterial SurfaceMaterial;
        private const int MINWIDTH = 24;
        private const int MAXWIDTH = 96;
        private const int MINDEPTH = 12;
        private const int MAXDEPTH = 48;

        public Desk(int inWidth, int inDepth, int inNumDrawers, string inSurfaceMaterial)
        {
            Width           = inWidth;
            Depth           = inDepth;
            NumDrawers      = inNumDrawers;

            switch (inSurfaceMaterial)
            {
                case "Oak":
                    SurfaceMaterial = DesktopMaterial.Oak;
                    break;
                case "Laminate":
                    SurfaceMaterial = DesktopMaterial.Laminate;
                    break;
                case "Pine":
                    SurfaceMaterial = DesktopMaterial.Pine;
                    break;
                case "Rosewood":
                    SurfaceMaterial = DesktopMaterial.Rosewood;
                    break;
                case "Veneer":
                    SurfaceMaterial = DesktopMaterial.Veneer;
                    break;
            }

            if(Width < MINWIDTH) { Width = MINWIDTH; }
            if(Width > MAXWIDTH) { Width = MAXWIDTH; }
            if(Depth < MINDEPTH) { Depth = MINDEPTH; }
            if(Depth > MAXDEPTH) { Depth = MAXDEPTH; }
        }

        public int getWidth()
        {
            return Width;
        }

        public int getDepth()
        {
            return Depth;
        }

        public int getNumDrawers()
        {
            return NumDrawers;
        }

        public DesktopMaterial getSurfaceMaterial()
        {
            return SurfaceMaterial;
        }
    }
}
