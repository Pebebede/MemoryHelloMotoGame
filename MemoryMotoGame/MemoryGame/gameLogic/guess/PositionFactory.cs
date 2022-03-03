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
        list.Add(new Position('A', 1));
        list.Add(new Position('A', 2));
        list.Add(new Position('A', 3));
        list.Add(new Position('A', 4));
        list.Add(new Position('B', 1));
        list.Add(new Position('B', 2));
        list.Add(new Position('B', 3));
        list.Add(new Position('B', 4));
        list.Add(new Position('C', 1));
        list.Add(new Position('C', 2));
        list.Add(new Position('C', 3));
        list.Add(new Position('C', 4));
        list.Add(new Position('D', 1));
        list.Add(new Position('D', 2));
        list.Add(new Position('D', 3));
        list.Add(new Position('D', 4));


        return list;
    }


}

