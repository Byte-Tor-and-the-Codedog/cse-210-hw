namespace  Shogi;
public class Space
{
    //I'm using the space class as a way to store the value of eacvh indivicual square so it can hold the piece value
    protected Piece _piece;
    protected bool _hasPiece;
    public bool GetHasPiece()
    {
        return _hasPiece;
    }
    public Piece GetPiece()
    {
        return _piece;
    }
    public void SetPiece(Piece piece)
    {
        _piece = piece;
    }
    public void SetHasPiece(bool hasPiece)
    {
        _hasPiece = hasPiece;
    }
    public Space()
    {
        _piece = new Piece();
        _piece.SetPieceType("_");
    }
    public Space(Piece piece)
    {
        _piece = piece;
        _hasPiece = true;
    }


}
