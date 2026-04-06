using Shogi;

public class Pawn : Piece
{
    public Pawn(bool color)
    {
        List<(int row, int col)> range = new  List<(int row, int col)>();
        _pieceType = "P";
        _color = color;
        if(color == true)
        {
            range.Add((1, 0));
            range.Add((1, 1));
            range.Add((1, -1));
            range.Add((2, 0));
        }
        else
        {
            range.Add((-1, 0));
            range.Add((-1, 1));
            range.Add((-1, -1));
            range.Add((-2, 0));
        }
        _range = range;
    }
}