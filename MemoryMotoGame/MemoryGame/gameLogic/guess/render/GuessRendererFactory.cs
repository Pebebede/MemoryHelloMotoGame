class GuessRendererFactory
{
    public GuessRenderer Create(List<Guess> guesses)
    {
        int numberOfGuesses = guesses.Count;
        int columnSize = 4;
        int rowSize = numberOfGuesses / columnSize;
        Guess[,] table = new Guess[columnSize + 1, rowSize + 1];

        foreach (Guess g in guesses)
        {
            int row = g.GetPosition().row.value - 1;
            int col = g.GetPosition().column - 1;
        }
        foreach (Guess guess in guesses)
        {
            Position position = guess.GetPosition();
            int row = position.row.value - 1;
            int column = position.column - 1;
            table[column, row] = guess;
        }
        return new GuessRenderer(table, columnSize, rowSize);
    }



}

