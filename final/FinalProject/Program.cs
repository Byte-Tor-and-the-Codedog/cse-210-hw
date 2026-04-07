namespace  Shogi
{
    

using System;

class Program
{
    static void Main(string[] args)
    {
        string game = "..\\..\\..\\default.txt";
        GameRecord game1 = new GameRecord();
        game1.ParseGameText(game);
        BoardState b1 = new BoardState();
        Console.WriteLine("Hello, welcome to the chess study tool, are you ready to study a game?");
        Console.ReadKey(true);
        Console.Clear();
        int i = 0;
        foreach(Turn turn in game1.GetGame())
            {
                if(i == 0)
                {
                    //I put the beginning position in here so it completely clears and doesn't hover above the whole time like it did during testing
                    b1.PrintBoard();
                    Console.ReadKey(true);
                    Console.Clear();
                }
                b1.MovePiece(turn);
                b1.PrintBoard();
                Console.ReadKey(true);
                Console.Clear();
                i++;
            }
        Console.WriteLine("Thanks for studying with me!");
        Console.ReadKey(true);
        Console.Clear();
    }
}
}