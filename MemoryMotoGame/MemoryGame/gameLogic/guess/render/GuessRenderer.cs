class GuessRenderer
{
    private Guess[,] table;
    private int columnSize;
    private int rowSize;

    public GuessRenderer(Guess[,] table, int columnSize, int rowSize)
    {
        this.table = table;
        this.columnSize = columnSize;
        this.rowSize = rowSize;
    }

    public void Draw()
    {
        for (int row = 0; row < rowSize; row++)
        {
            for (int col = 0; col < columnSize; col++)
            {
                Guess guess = table[col, row];
                Console.Write(guess.asText() + " ");
            }
            Console.WriteLine("");
        }
    }

}