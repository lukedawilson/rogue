namespace Rogue;

public class Tile
{
  public const int Width = 8;
  public const int Height = 8;

  public Tile(string description)
  {
    Layout = new int[Width,Height];
    West = Array.Empty<Tuple<Tile, double>>();
    East = Array.Empty<Tuple<Tile, double>>();
    North = Array.Empty<Tuple<Tile, double>>();
    South = Array.Empty<Tuple<Tile, double>>();

    _description = description;
  }

  public int[,] Layout { get; set; }

  public Tuple<Tile, double>[] West { get; set; }
  public Tuple<Tile, double>[] East { get; set; }
  public Tuple<Tile, double>[] North { get; set; }
  public Tuple<Tile, double>[] South { get; set; }

  private readonly string _description;

  public void Draw(int x, int y)
  {
    Console.SetCursorPosition(x, y);

    var i = 0;
    foreach (var p in Layout)
    {
      Console.Write(p == 1 ? '\u2592' : ' '); // http://www.utf8-chartable.de/unicode-utf8-table.pl?start=9600&number=128
      i++;

      if (i != Width)
        continue;

      Console.CursorTop++;
      Console.CursorLeft-=Width;
      i = 0;
    }
  }

  public override string ToString()
  {
    return _description;
  }

  public override int GetHashCode()
  {
    return _description.GetHashCode();
  }
}
