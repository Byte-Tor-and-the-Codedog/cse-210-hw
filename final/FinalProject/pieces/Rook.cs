public class Rook : VariedRangePiece
{
    public Rook(bool color)
    {
        List<(int row, int col)> range = new  List<(int row, int col)>();
        _pieceType = "R";
        _color = color;
        range.Add((1, 0));
        range.Add((-1, 0));
        range.Add((0, 1));
        range.Add((0, -1));
        _range = range;
    }
}