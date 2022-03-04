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
        Console.Write("  ");
        for (int col = 1; col <= columnSize; col++)
        {
            Console.Write(col + " ");
        }
        Console.WriteLine();


        for (int row = 0; row < rowSize; row++)
        {
            for (int col = 0; col < columnSize; col++)
            {
                Guess guess = table[col, row];

                if (col == 0)
                {
                    Console.Write(guess.GetPosition().row.letter+ " ");
                }

                Console.Write(guess.asText() + " ");
            }
            Console.WriteLine("");
        }
    }

}