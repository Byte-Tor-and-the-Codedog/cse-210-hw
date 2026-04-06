using Shogi;

public class King : Piece
{
    public King(bool color)
    {
        List<(int row, int col)> range = new  List<(int row, int col)>();
        _pieceType = "K";
        _color = color;
        range.Add((1, -1));
        range.Add((-1, 1));
        range.Add((1, 1));
        range.Add((1, -1));
        range.Add((-1, -1));
        _range = range;
    }
}