using System;

internal class Program
{
    private static void Main(string[] args)
    {
        ScoreCheck(250, "Maria");
        ScoreCheck(315, "Michael");
        ScoreCheck(350, "Admin Lucas");
        Console.Read();

    }
    static int highScore = 300;
    static string highScorePlayer = "Admin Lucas";
    public static void ScoreCheck (int score, string playerName)
    {
        if(score > highScore)
        {
            highScore = score;
            highScorePlayer = playerName;
            Console.WriteLine($"New highscore is {score}\nNew highscore holder is {playerName}");
        }
        else
        {
            Console.WriteLine($"The old highscore of {highScore} could not be broken and is still held by {highScorePlayer}");
        }
        
    }



    //Teacher solution: Same as mine
}