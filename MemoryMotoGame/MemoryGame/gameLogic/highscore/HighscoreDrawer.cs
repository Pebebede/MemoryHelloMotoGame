class HighscoreDrawer
{

    public void DrawScore(int score)
    {
        List<string> highscoreList = new HighscoreLoader().Load();
        Console.WriteLine("Please give me your name");
        string playerName = Console.ReadLine();
        highscoreList.Add(playerName+" "+score);
       // File.WriteAllLinesAsync("highscore.txt", highscoreList);
        //TODO write disk persistance for HighScores
    }


}

