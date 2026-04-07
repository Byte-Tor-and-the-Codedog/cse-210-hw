using Shogi;

public class VariedRangePiece : Piece
{
    //This is the ploymorphic function for the rook, bishop and queen who do not have a variable range that depends on more factors than others.
    public override List<(int, int)> GetMoves((int row, int col) initial, Space[,] board)
    {
        //this goes down the line of each possible direction until they run into a piece or the end of the board.
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
                        //If there's an opponents piece on the board you can still move to that space
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
