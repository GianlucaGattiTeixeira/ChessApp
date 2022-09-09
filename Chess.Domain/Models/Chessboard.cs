using Chess.Domain.Exceptions;

namespace Chess.Domain.Models
{
    public class Chessboard
    {
        public ChessPiece[,,] Board { get; set; }

        public int[] ResolveBoarPosition(string position)
        {
            if (position.Length != 2)
                throw new InvalidPositionException();

            string[] individualPositions = position.Split();

            int xPosition = this.ResolveLetterPosition(individualPositions[0][0]);

            int yPosition;
            if (!int.TryParse(individualPositions[1], out yPosition))
                throw new InvalidPositionException();

            if (yPosition < 0 || yPosition > 8 || xPosition < 0 || xPosition > 8)
                throw new InvalidPositionException();


            return new int[] { xPosition, yPosition };
        }

        private int ResolveLetterPosition(char letter)
        {
            return char.ToUpper(letter) - 64;
        }
    }



}
