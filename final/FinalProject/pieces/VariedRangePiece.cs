using Shogi;

public class VariedRangePiece : Piece
{
    public override List<(int, int)> GetMoves((int row, int col) initial, Space[,] board)
    {
        List<(int row, int col)> validMoves = new List<(int, int)>();
        foreach((int row, int col) square in _range)
            {
                bool unincumbered = true;
                (int row, int col) init = initial;
                while(unincumbered == true)
            {
                int nextrow = init.row + square.row;
                int nextcol = init.col + square.col;
                if(nextrow >= 0 &&
                nextrow < 8 &&
                nextcol >= 0 &&
                nextcol < 8)
                {
                    if(board[nextrow, nextcol].GetHasPiece())
                    {
                        if(board[nextrow, nextcol].GetPiece().GetColor() != board[initial.row, initial.col].GetPiece().GetColor())
                        {
                            validMoves.Add((nextrow, nextcol));
                            unincumbered = false;
                        }
                        else
                        {
                            unincumbered = false;
                        }
                    }
                    else
                    {
                        validMoves.Add((nextrow, nextcol));
                        init = (nextrow, nextcol);
                    }
                }
                else
                {
                    unincumbered = false;
                }
            }
            }
            return validMoves;
    }
}
