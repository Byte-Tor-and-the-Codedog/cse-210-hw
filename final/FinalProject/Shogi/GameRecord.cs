using Shogi;

public class GameRecord
{
    private List<Turn> _game;
    public List<Turn> GetGame()
    {
        return _game;
    }
    public void ParseGameText(string game)
    {
        List<Turn> turns = new List<Turn>();
        foreach(string line in File.ReadLines(game))
        {
            string[] turn = line.Split("|");
            string[] init = turn[0].Split(",");
            string[] destin = turn[1].Split(",");
            turns.Add(new Turn((int.Parse(init[0]), int.Parse(init[1])), (int.Parse(destin[0]), int.Parse(destin[1]))));
            _game = turns;
        }
    }
}