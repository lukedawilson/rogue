namespace Rogue
{
  public static class Tiles
  {
    public static readonly Tile HorizontalCorridor = new Tile
    {
      Layout = new int[Tile.Width,Tile.Height]
      {
        {1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1},
        {0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0},
        {1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1},
      },
    };

    public static readonly Tile VerticalCorridor = new Tile
    {
      Layout = new int[Tile.Width,Tile.Height]
      {
        {1, 1, 1, 0, 0, 1, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
      },
    };

    public static readonly Tile Crossroads = new Tile
    {
      Layout = new int[Tile.Width,Tile.Height]
      {
        {1, 1, 1, 0, 0, 1, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
        {0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0},
        {1, 1, 1, 0, 0, 1, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
      },
    };

    public static readonly Tile HorizontalNorthT = new Tile
    {
      Layout = new int[Tile.Width,Tile.Height]
      {
        {1, 1, 1, 0, 0, 1, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
        {0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0},
        {1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1},
      },
    };

    public static readonly Tile HorizontalSouthT = new Tile
    {
      Layout = new int[Tile.Width,Tile.Height]
      {
        {1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1},
        {0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0},
        {1, 1, 1, 0, 0, 1, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
      },
    };

    public static readonly Tile VerticalWestT = new Tile
    {
      Layout = new int[Tile.Width,Tile.Height]
      {
        {1, 1, 1, 0, 0, 1, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
        {0, 0, 0, 0, 0, 1, 1, 1},
        {0, 0, 0, 0, 0, 1, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
      },
    };

    public static readonly Tile VerticalEastT = new Tile
    {
      Layout = new int[Tile.Width,Tile.Height]
      {
        {1, 1, 1, 0, 0, 1, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
        {1, 1, 1, 0, 0, 0, 0, 0},
        {1, 1, 1, 0, 0, 0, 0, 0},
        {1, 1, 1, 0, 0, 1, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
      },
    };

    public static readonly Tile[] All = new Tile[] // ToDo: weighting
    {
      HorizontalCorridor,
      VerticalCorridor,
      Crossroads,
      HorizontalNorthT,
      HorizontalSouthT,
      VerticalWestT,
      VerticalEastT
    };

    public static readonly Tile Full = new Tile
    {
      Layout = new int[Tile.Width,Tile.Height]
      {
        {1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1},
      },
      East = All,
      West = All,
      North = All,
      South = All,
    };

    public static readonly Tile NullTile = new Tile
    {
      East = All,
      West = All,
      North = All,
      South = All,
    };

    static Tiles()
    {
      var toNorthWall = new[] { HorizontalCorridor, HorizontalNorthT };
      var toSouthWall = new[] { HorizontalCorridor, HorizontalSouthT };
      var toEastOpening = new[] { HorizontalCorridor, Crossroads, HorizontalNorthT, HorizontalSouthT, VerticalWestT };
      var toWestOpening = new[] { HorizontalCorridor, Crossroads, HorizontalNorthT, HorizontalSouthT, VerticalEastT };
      var toNorthOpening = new[] { VerticalCorridor, Crossroads, HorizontalSouthT, VerticalWestT, VerticalEastT };
      var toSouthOpening = new[] { VerticalCorridor, Crossroads, HorizontalNorthT, VerticalWestT, VerticalEastT };
      var toEastWall = new[] { VerticalCorridor, VerticalEastT };
      var toWestWall = new[] { VerticalCorridor, VerticalWestT };

      HorizontalCorridor.North = toNorthWall;
      HorizontalCorridor.South = toSouthWall;
      HorizontalCorridor.East = toEastOpening;
      HorizontalCorridor.West = toWestOpening;

      VerticalCorridor.North = toNorthOpening;
      VerticalCorridor.South = toSouthOpening;
      VerticalCorridor.East = toEastWall;
      VerticalCorridor.West = toWestWall;

      Crossroads.North = toNorthOpening;
      Crossroads.South = toSouthOpening;
      Crossroads.East = toEastOpening;
      Crossroads.West = toWestOpening;

      HorizontalNorthT.North = toNorthOpening;
      HorizontalNorthT.South = toSouthWall;
      HorizontalNorthT.East = toEastOpening;
      HorizontalNorthT.West = toWestOpening;

      HorizontalSouthT.North = toNorthWall;
      HorizontalSouthT.South = toSouthOpening;
      HorizontalSouthT.East = toEastOpening;
      HorizontalSouthT.West = toWestOpening;

      VerticalWestT.North = toNorthOpening;
      VerticalWestT.South = toSouthOpening;
      VerticalWestT.East = toEastWall;
      VerticalWestT.West = toWestOpening;

      VerticalEastT.North = toNorthOpening;
      VerticalEastT.South = toSouthOpening;
      VerticalEastT.East = toEastOpening;
      VerticalEastT.West = toWestWall;
    }
  }
}