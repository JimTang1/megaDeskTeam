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
        public const short MIN_WIDTH = 24;
        public const short MAX_WIDTH = 96;
        public const short MIN_DEPTH = 12;
        public const short MAX_DEPTH = 48;
        public const short MIN_DRAWERS = 0;
        public const short MAX_DRAWERS = 7;

        public int Width { get; set; }

        public int Depth { get; set; }

        public int  NumberOfDrawers { get; set; }

        public DeskTopMaterial SurfaceMateroal { get; set; }
    }
}
