using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Domain.Models
{
    public class PieceMovement
    {
        public int Forward { get; set; }
        public int Backward { get; set; }
        public int Sides { get; set; }
    }
}
