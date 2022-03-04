class PositionFactory
{

    public List<Position> Create()
    {

        List<Position> list = new();
        Fill(list);
        return list;
    }
    private List<Position> Fill(List<Position> list)
    {
        PositionRow aRow = PositionRowFactory.createFrom('A');
        PositionRow bRow = PositionRowFactory.createFrom('B');
        PositionRow cRow = PositionRowFactory.createFrom('C');
        PositionRow dRow = PositionRowFactory.createFrom('D');

        List<PositionRow> rows = new List<PositionRow>();
        rows.Add(aRow);
        rows.Add(bRow);
        rows.Add(cRow);
        rows.Add(dRow);

        int[] columns = new int[] { 1, 2, 3, 4 };

        foreach (PositionRow row in rows)
        {
            foreach (int col in columns)
            {
                list.Add(new Position(row, col));
            }
        }


        return list;
    }


}

