using System.ComponentModel;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace  Shogi
{
public class BoardState
{
    protected Space[,] _board;

    public Space[,] GetBoard()
        {
            return _board;
        }
    public void MovePiece(Turn turn)
        {
            (int row, int col) init = (turn.GetInitial().row, turn.GetInitial().col);
            List<(int, int)> moves = _board[init.row, init.col].GetPiece().GetMoves(init, _board);
            Piece piece = _board[init.row, init.col].GetPiece();

            if(moves.Contains(turn.GetDestination()))
            {
                _board[turn.GetDestination().row, turn.GetDestination().col].SetPiece(piece);
                _board[turn.GetDestination().row, turn.GetDestination().col].SetHasPiece(true);
                _board[init.row, init.col].SetPiece(null);
                _board[init.row, init.col].SetHasPiece(false);
            }
            else
            {
                Console.Write("error: invalid move");
                foreach((int row, int col) i in moves)
                {
                    Console.Write($"({i.row}, {i.col})");
                }
                Console.Write("\n");
            }
        }
    public void PrintBoard()
        {
            Console.WriteLine(" _ _ _ _ _ _ _ _");
            for(int x = 7;  x >=0; x--)
            {
                Console.Write("|");
                for(int y = 0; y < 8; y++)
                {
                    if(_board[x, y].GetHasPiece())
                    {
                        Console.Write($"{_board[x, y].GetPiece().GetPieceType()}|");
                    }
                    else
                    {
                        Console.Write("_|");
                    }
                }
                Console.Write("\n");
            }
        }
    //constructs the basic default setup of a chess game. I could add a custom constructor to play games like fischer random but I didn't need to to do that for this project.
    public BoardState()
        {
            _board = new Space[8, 8];
            _board[0, 0] = new Space(new Rook(true));
            _board[0, 1] = new Space(new Knight(true));
            _board[0, 2] = new Space(new Bishop(true));
            _board[0, 3] = new Space(new Queen(true));
            _board[0, 4] = new Space(new King(true));
            _board[0, 5] = new Space(new Bishop(true));
            _board[0, 6] = new Space(new Knight(true));
            _board[0, 7] = new Space(new Rook(true));

            for(int i = 0; i < 8; i++)
            {
                _board[1, i] = new Space(new Pawn(true));
            }

            for(int y = 2; y < 6; y++)
            {
                for(int x = 0; x < 8; x++)
                {
                    _board[y, x] = new Space();
                }
            }

            for(int i = 0; i < 8; i++)
            {
                _board[6, i] = new Space(new Pawn(false));
            }

            _board[7, 0] = new Space(new Rook(false));
            _board[7, 1] = new Space(new Knight(false));
            _board[7, 2] = new Space(new Bishop(false));
            _board[7, 3] = new Space(new Queen(false));
            _board[7, 4] = new Space(new King(false));
            _board[7, 5] = new Space(new Bishop(false));
            _board[7, 6] = new Space(new Knight(false));
            _board[7, 7] = new Space(new Rook(false));
}
}
}