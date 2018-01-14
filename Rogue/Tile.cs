using System;

namespace Rogue
{
  public class Tile
  {
    public const int Width = 8;
    public const int Height = 8;

    public Tile(string description)
    {
      Layout = new int[Width,Height];
      West = new Tile[0];
      East = new Tile[0];
      North = new Tile[0];
      South = new Tile[0];

      _description = description;
    }

    public int[,] Layout { get; set; }

    public Tile[] West { get; set; }
    public Tile[] East { get; set; }
    public Tile[] North { get; set; }
    public Tile[] South { get; set; }

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
}