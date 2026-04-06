using System.Data.SqlTypes;
namespace  Shogi;

public class Turn
{
    // The space class doesn't work here either, I toyed with the namespace but that did nothing
    protected (int row, int col) _initial;
    protected (int row, int col) _destination;
    public (int row, int col) GetInitial()
    {
        return _initial;
    }
    public (int row, int col) GetDestination()
    {
        return _destination;
    }

    public Turn((int row, int col) init, (int row, int col) destin)
    {
        _initial = init;
        _destination = destin;
    }
}
