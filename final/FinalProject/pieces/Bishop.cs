public class Bishop : VariedRangePiece
{
    public Bishop(bool color)
    {
        List<(int row, int col)> range = new  List<(int row, int col)>();
        _pieceType = "B";
        _color = color;
        range.Add((1, 1));
        range.Add((1, -1));
        range.Add((-1, 1));
        range.Add((-1, -1));
        _range = range;
    }
}