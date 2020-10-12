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

    public class Desk
    {
        public const short MIN_WIDTH = 24;
        public const short MAX_WIDTH = 96;
        public const short MIN_DEPTH = 12;
        public const short MAX_DEPTH = 48;
        public const short MIN_DRAWERS = 0;
        public const short MAX_DRAWERS = 7;

        public decimal Width { get; set; }

        public decimal Depth { get; set; }

        public int  NumberOfDrawers { get; set; }

        public DeskTopMaterial SurfaceMaterial { get; set; }
    }
}
