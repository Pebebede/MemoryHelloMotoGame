class PositionRow
{
    public int value { get; }
    public int letter { get; }
    public PositionRow(int rowNumber, char letter)
    {
        this.value = rowNumber;
        this.letter = letter;
    }


}