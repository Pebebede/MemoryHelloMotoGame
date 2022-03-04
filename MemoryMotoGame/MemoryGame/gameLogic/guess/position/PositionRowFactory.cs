class PositionRowFactory
{
    public static PositionRow createFrom(char letter)
    {

        int rowNumber = "abcdefg".ToCharArray().ToList()
                                .FindIndex((searched) => compareLetters(searched, letter))
                                 + 1;
        return new PositionRow(rowNumber, letter);
    }
    static bool compareLetters(char a, char b)
    {
        var matches = (a + "").ToLower() == (b + "").ToLower();
        return matches;
    }

}