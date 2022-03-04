class TextToPositionConverter
{
    public Position GetPosition(String position)
    {
        //walidacja przed tym
        char[] chars = position.ToCharArray();
        int column = int.Parse(chars[1] + "");
        PositionRow positionRow = new PositionRow(chars[1], chars[0]);

        return new Position(positionRow, column);
    }
}

