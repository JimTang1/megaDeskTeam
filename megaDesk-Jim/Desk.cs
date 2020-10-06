using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace megaDesk_Jim
{

    public enum DeskTopMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer,
    }

    public enum Delivery
    {
        Rush3Days,
        Rush5Days,
        Rush7Days,
        Normal14Days,
    }
    public class Desk
    {
        public int Width { get; set; }

        public int Depth { get; set; }

        public int  NumberOfDrawers { get; set; }

        public DeskTopMaterial SurfaceMateroal { get; set; }
    }
}
