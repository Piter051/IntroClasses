namespace IntroClasses;

public class Map
{
    private Cell[][] _cells;

    public void LoadFromFile(string path)
    {
        string[] lines = File.ReadAllLines(path);
        _cells = new Cell[lines.Length][];
        for (var rowindex = 0; rowindex < lines.Length; rowindex++)
        {
            var line = lines[rowindex];
            _cells[rowindex] = new Cell[line.Length];
            Cell[] row = _cells[rowindex];
            for (var columnIndex = 0; columnIndex < line.Length; columnIndex++)
            {
                var character = line[columnIndex];
                row[columnIndex] = new Cell();
                row[columnIndex].visuals = character;
            }
        }
    }

    public void Display()
    {
        Console.SetCursorPosition(0, 0);
        foreach (var row in _cells)
        {
            foreach (var cell in row)
            {
                Console.Write(cell.visuals);
            }
            Console.WriteLine();
        }
    }
    public Cell GetCell(int x, int y)
    {
        return _cells[y][x];
    }
}    