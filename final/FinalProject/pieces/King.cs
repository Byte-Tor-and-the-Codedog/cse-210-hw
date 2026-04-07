using Shogi;

public class King : Piece
{
    public King(bool color)
    {
        List<(int row, int col)> range = new  List<(int row, int col)>();
        _pieceType = "K";
        _color = color;
        range.Add((1, 1)); //upright
        range.Add((1, -1)); //upleft
        range.Add((-1, 1)); //downright
        range.Add((-1, -1));//downleft
        range.Add((1, 0)); //up
        range.Add((-1, 0)); //down
        range.Add((0, 1)); //right
        range.Add((0, -1)); //left
        _range = range;
    }
}