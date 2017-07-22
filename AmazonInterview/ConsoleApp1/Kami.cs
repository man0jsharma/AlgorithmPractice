using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmzMain
{
    internal class Cell
    {
        internal char Character { get; set; }
        internal int Row { get; set; }

        internal int Col { get; set; }
        internal List<Cell> Adjacencies { get; set; }
    }
    internal class Kami
    {

    }
}
