using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Domain.Models
{
    public abstract class ChessPiece
    {
        public bool Jump { get; }
        public PieceMovement[] AllowedMovements { get; }

    }
}
