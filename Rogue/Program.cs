using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;

namespace Rogue
{
  /// <remarks>
  /// To build and run in bash:
  ///   xbuild Rogue.csproj; if [[ $PIPESTATUS -eq 0 ]]; then mono --debug bin/Debug/Rogue.exe; fi
  /// </remarks>
  public static class Program
  {
    private const int GridWidth = 33;
    private const int GridHeight = 8;

    private static readonly Random Rnd = new Random();

    public static void Main()
    {
      Console.OutputEncoding = Encoding.UTF8;
      if (Console.BufferWidth == 0 && Console.BufferHeight == 0)
        throw new InternalBufferOverflowException("Buffer not initialised - please re-run the application");

      var tiles = new Tile[GridWidth,GridHeight];

      var shape = Tiles.All[Rnd.Next(0, Tiles.All.Length)];
      tiles[GridWidth / 2, GridHeight / 2] = shape;

      for (var generation = 0; generation < 10; generation++)
      {
        var tilesToProcess = (Tile[,])tiles.Clone();
        for (var x = 0; x < GridWidth; x++)
        {
          for (var y = 0; y < GridHeight; y++)
          {
            var tile = tilesToProcess[x, y];
            if (tile == null)
              continue;

            DrawTile(tiles, tile.North, x, y - 1);
            DrawTile(tiles, tile.South, x, y + 1);
            DrawTile(tiles, tile.East, x + 1, y);
            DrawTile(tiles, tile.West, x - 1, y);
          }
        }
      }
    }

    private static Tile GetNewTile(IReadOnlyList<Tile> validTiles)
    {
      return validTiles.Count == 0
        ? null
        : validTiles[Rnd.Next(0, validTiles.Count)];
    }

    private static void DrawTile(Tile[,] tiles, IReadOnlyList<Tile> validTiles, int x, int y)
    {
      var tile = GetNewTile(validTiles);
      if (tile == null)
        return;

      if (x < tiles.GetLowerBound(0) || x >= tiles.GetUpperBound(0) ||
          y < tiles.GetLowerBound(1) || y >= tiles.GetUpperBound(1) ||
          tiles[x, y] != null)
        return;

      tile.Draw(x*Tile.Width, y*Tile.Height);
      tiles[x, y] = tile;
    }
  }
}