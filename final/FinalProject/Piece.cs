namespace  Shogi
{
public class Piece
{
    protected string _pieceType;
    protected bool _color;
    protected List<(int row, int col)> _range;
    // It seems redundant but each piece needs to know its rank and file position in order to find its possible moves and validate if any move is valid.
    public virtual List<(int, int)> GetMoves((int row, int col) init, Space[,] board)
    {
        //check's if every theoretical move of the piece is possible
        List<(int row, int col)> validMoves = new List<(int, int)>();
        foreach((int row, int col) square in _range)
            {

                if(init.row + square.row >= 0 &&
                init.row + square.row < 8 &&
                init.col + square.col >= 0 &&
                init.col + square.col < 8)
                //If there's an opponents piece on the board you can still move to that space
                if(board[init.row + square.row, init.col + square.col].GetHasPiece() != true ||
                board[init.row + square.row, init.col + square.col].GetPiece().GetColor() != _color)
                {
                    validMoves.Add((init.row + square.row, init.col + square.col));
                }
            }
        return validMoves;
    }
    public bool GetColor()
        {
            return _color;
        }
    public string GetPieceType()
        {
            return _pieceType;
        }
    public void SetPieceType(string type)
        {
            _pieceType = type;
        }

}
}