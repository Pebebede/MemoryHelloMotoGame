class Position
{
    public PositionRow row { get; }
    public int column { get; }

    public Position(PositionRow row, int column)
    {
        this.row = row;
        this.column = column;
    }

    public string asText()
    {
        return row.letter + "" + column;
    }
}