using System.Text;

namespace Rogue;

public static class Program
{
  private const int GridWidth = 33;
  private const int GridHeight = 8;

  private static readonly Random Rnd = new();

  public static void Main()
  {
    Console.OutputEncoding = Encoding.UTF8;
    if (Console.BufferWidth == 0 && Console.BufferHeight == 0)
      throw new InternalBufferOverflowException("Buffer not initialised - please re-run the application");

    var tiles = new Tile[GridWidth,GridHeight];

    var shape = GetShape(Tiles.All);
    tiles[0, GridHeight / 2] = shape;

    for (var generation = 0; generation < 50; generation++)
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

  private static Tile GetNewTile(IReadOnlyList<Tuple<Tile, double>> validTiles)
  {
    return validTiles.Count == 0
      ? null
      : GetShape(validTiles);
  }

  private static void DrawTile(Tile[,] tiles, IReadOnlyList<Tuple<Tile, double>> validTiles, int x, int y)
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

  private static Tile GetShape(IReadOnlyList<Tuple<Tile, double>> weightedShapes)
  {
    var weights = weightedShapes.Select(t => t.Item2).ToArray();
    var max = weights.Sum();
    var value = Rnd.NextDouble() * max;

    var series = new List<Tuple<Tile, double, double>>();
    for (var i = 0; i < weightedShapes.Count; i++)
    {
      var (shape, weight) = weightedShapes[i];
      var lowerBound = i == 0 ? 0 : series[i - 1].Item3;
      var upperBound = lowerBound + weight;
      series.Add(Tuple.Create(shape, lowerBound, upperBound));
    }

    foreach (var (shape, lowerBound, upperBound) in series)
    {
      if (value >= lowerBound && value <= upperBound)
        return shape;
    }

    return null;
  }
}
