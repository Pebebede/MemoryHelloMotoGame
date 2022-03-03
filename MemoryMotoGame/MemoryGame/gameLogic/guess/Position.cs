class Position
{
    char row;
    int column;

    public Position(char row, int column)
    {
        this.row = row;
        this.column = column;
    }

    public string asText()
    {
        return row + "" + column;
    }
}