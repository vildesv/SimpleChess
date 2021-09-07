using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChess
{
    public class Rook : Piece
    {
        public Rook() : base("TRN")
        {
        }

        public override bool Move(string fromPosition, string toPosition)
        {
            return fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1];
        }
    }
}










// TEST

/*public Rook(string symbol) : base(symbol)
       {
       }

       public override bool Move(string fromPosition, string toPosition)
       {
           throw new NotImplementedException();
       }*/
