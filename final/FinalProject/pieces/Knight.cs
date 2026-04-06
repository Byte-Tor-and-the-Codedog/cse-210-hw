using Shogi;

public class Knight : Piece
{
    public Knight(bool color)
    {
        List<(int row, int col)> range = new  List<(int row, int col)>();
        _pieceType = "N";
        _color = color;
        range.Add((2, 1));
        range.Add((2, -1));
        range.Add((-2, 1));
        range.Add((-2, -1));
        range.Add((-1, 2));
        range.Add((1, 2));
        range.Add((1, -2));
        range.Add((-1, -2));
        _range = range;
    }
}