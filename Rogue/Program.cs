using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Rogue
{
  /// <remarks>
  /// To build and run in bash:
  ///   xbuild Rogue.csproj; if [[ $PIPESTATUS -eq 0 ]]; then mono --debug bin/Debug/Rogue.exe; fi
  ///
  /// ToDo: Conway's Game of Life
  /// </remarks>
  public static class Program
  {
    private const int GridWidth = 33;
    private const int GridHeight = 8;

    public static void Main()
    {
      Console.OutputEncoding = Encoding.UTF8;
      if (Console.BufferWidth == 0 && Console.BufferHeight == 0)
        throw new InternalBufferOverflowException("Buffer not initialised - please re-run the application");

      var rnd = new Random();
      var tiles = new Tile[GridWidth,GridHeight];

      for (var x = 0; x < GridWidth; x++)
      {
        for (var y = 0; y < GridHeight; y++)
        {
          var north = Tuple.Create(x, y - 1);
          var west = Tuple.Create(x - 1, y);

          var northTile = north.Item2 < 0 ? Tiles.NullTile : tiles[north.Item1, north.Item2];
          var westTile = west.Item1 < 0 ? Tiles.NullTile : tiles[west.Item1, west.Item2];
          var validTiles = northTile.South.Intersect(westTile.East).ToArray();

          var shape = validTiles.Length == 0
            ? Tiles.Full
            : validTiles[rnd.Next(0, validTiles.Length)];
          tiles[x,y] = shape;
          shape.Draw(x*Tile.Width, y*Tile.Height);
        }
      }
    }
  }
}