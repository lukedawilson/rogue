namespace Rogue
{
  public static class Tiles
  {
    private static readonly Tile HorizontalCorridor = new Tile("HorizontalCorridor")
    {
      Layout = new[,]
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

    private static readonly Tile VerticalCorridor = new Tile("VerticalCorridor")
    {
      Layout = new[,]
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

    private static readonly Tile Crossroads = new Tile("Crossroads")
    {
      Layout = new[,]
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

    private static readonly Tile HorizontalNorthT = new Tile("HorizontalNorthT")
    {
      Layout = new[,]
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

    private static readonly Tile HorizontalSouthT = new Tile("HorizontalSouthT")
    {
      Layout = new[,]
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

    private static readonly Tile VerticalWestT = new Tile("VerticalWestT")
    {
      Layout = new[,]
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

    private static readonly Tile VerticalEastT = new Tile("VerticalEastT")
    {
      Layout = new[,]
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

    public static readonly Tile[] All = { // ToDo: weighting
      HorizontalCorridor,
      VerticalCorridor,
      Crossroads,
      HorizontalNorthT,
      HorizontalSouthT,
      VerticalWestT,
      VerticalEastT
    };

    public static readonly Tile Full = new Tile("Full")
    {
      Layout = new[,]
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

    public static readonly Tile NullTile = new Tile("NullTile")
    {
      East = All,
      West = All,
      North = All,
      South = All,
    };

    static Tiles()
    {
      var toNorthWall = new Tile[0];
      var toSouthWall = new Tile[0];
      var toEastOpening = new[] { HorizontalCorridor, Crossroads, HorizontalNorthT, HorizontalSouthT, VerticalWestT };
      var toWestOpening = new[] { HorizontalCorridor, Crossroads, HorizontalNorthT, HorizontalSouthT, VerticalEastT };
      var toNorthOpening = new[] { VerticalCorridor, Crossroads, HorizontalSouthT, VerticalWestT, VerticalEastT };
      var toSouthOpening = new[] { VerticalCorridor, Crossroads, HorizontalNorthT, VerticalWestT, VerticalEastT };
      var toEastWall = new Tile[0];
      var toWestWall = new Tile[0];

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