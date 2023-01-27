using System.ComponentModel.DataAnnotations;

namespace NavalWar.DAL.Models
{
    public class Player
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Navigation property for foreign key
        /// </summary>
        public List<int> Sessions { get; set; }

        private static int _boardSize = 9;

        private string[,] _personalBoard = new string[_boardSize, _boardSize];
        private string[,] _shotsBoard = new string[_boardSize, _boardSize];


        public Player()
        {
            _personalBoard = Create2DBoard(_personalBoard);
            _shotsBoard = Create2DBoard(_shotsBoard);
        }

        private string[,] Create2DBoard(string[,] board)
        {
            //string[,] board = new string[_boardSize,_boardSize];
            for (int row = 0; row < _boardSize; row++)
            {
                for (int col = 0; col < _boardSize; col++)
                {
                    board[row, col] = " ";
                }
            }
            return board;

        }

        public string[,] GetPersonalBoard
        {
            get { return _personalBoard; }
        }
        public string[,] GetShotsBoard
        {
            get { return _shotsBoard; }
        }
    }
}