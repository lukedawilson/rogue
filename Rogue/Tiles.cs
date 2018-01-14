using System;

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
        {1, 1, 0, 0, 0, 0, 1, 1},
        {0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 1, 1, 1, 1, 0, 0},
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
        {1, 1, 0, 0, 1, 1, 1, 1},
        {1, 1, 0, 0, 1, 1, 1, 1},
        {1, 1, 0, 0, 1, 1, 1, 1},
        {1, 1, 0, 0, 1, 1, 1, 1},
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
        {1, 1, 0, 0, 0, 0, 1, 1},
        {0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0},
        {1, 1, 0, 0, 0, 0, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
      },
    };

    private static readonly Tile HorizontalNorthTJunction = new Tile("HorizontalNorthT")
    {
      Layout = new[,]
      {
        {1, 1, 1, 0, 0, 1, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
        {1, 1, 0, 0, 1, 1, 1, 1},
        {0, 1, 0, 0, 1, 1, 1, 0},
        {0, 0, 0, 0, 0, 0, 0, 0},
        {1, 0, 0, 0, 0, 0, 0, 1},
        {1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1},
      },
    };

    private static readonly Tile HorizontalSouthTJunction = new Tile("HorizontalSouthT")
    {
      Layout = new[,]
      {
        {1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
        {1, 0, 0, 0, 0, 0, 0, 1},
        {0, 0, 0, 0, 0, 0, 0, 0},
        {0, 1, 1, 1, 0, 0, 1, 0},
        {1, 1, 1, 1, 0, 0, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
      },
    };

    private static readonly Tile VerticalWestTJunction = new Tile("VerticalWestT")
    {
      Layout = new[,]
      {
        {1, 1, 1, 0, 0, 1, 1, 1},
        {1, 1, 1, 1, 0, 0, 1, 1},
        {1, 1, 0, 0, 0, 0, 1, 1},
        {0, 0, 0, 0, 0, 0, 1, 1},
        {0, 0, 1, 1, 0, 0, 1, 1},
        {1, 1, 1, 1, 0, 0, 1, 1},
        {1, 1, 1, 1, 0, 0, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
      },
    };

    private static readonly Tile VerticalEastTJunction = new Tile("VerticalEastT")
    {
      Layout = new[,]
      {
        {1, 1, 1, 0, 0, 1, 1, 1},
        {1, 1, 0, 0, 1, 1, 1, 1},
        {1, 1, 0, 0, 1, 1, 1, 1},
        {1, 1, 0, 0, 1, 1, 0, 0},
        {1, 1, 0, 0, 0, 0, 0, 0},
        {1, 1, 0, 0, 0, 0, 1, 1},
        {1, 1, 0, 0, 1, 1, 1, 1},
        {1, 1, 1, 0, 0, 1, 1, 1},
      },
    };

    // TODO: do we need to specify weights separately for each collection?
    // Or should they be properties of the `Tile` objects?
    // If the former, then remove these constants and specify individually.
    // If the latter, then remove these constants and refactor.
    private const double WeightCorridor = 5.0;
    private const double WeightTJunction = 1.0;
    private const double WeightCrossroads = 0.1;

    private const double WeightHorizontalCorridor = WeightCorridor;
    private const double WeightVerticalCorridor = WeightCorridor;
    private const double WeightHorizontalNorthTJunction = WeightTJunction;
    private const double WeightHorizontalSouthTJunction = WeightTJunction;
    private const double WeightVerticalWestTJunction = WeightTJunction;
    private const double WeightVerticalEastTJunction = WeightTJunction;

    public static readonly Tuple<Tile, double>[] All = {
      Tuple.Create(HorizontalCorridor, WeightHorizontalCorridor),
      Tuple.Create(VerticalCorridor, WeightVerticalCorridor),
      Tuple.Create(Crossroads, WeightCrossroads),
      Tuple.Create(HorizontalNorthTJunction, WeightHorizontalNorthTJunction),
      Tuple.Create(HorizontalSouthTJunction, WeightHorizontalSouthTJunction),
      Tuple.Create(VerticalWestTJunction, WeightVerticalWestTJunction),
      Tuple.Create(VerticalEastTJunction, WeightVerticalEastTJunction)
    };

    static Tiles()
    {
      var toNorthWall = new Tuple<Tile, double>[0];
      var toSouthWall = new Tuple<Tile, double>[0];
      var toEastOpening = new[]
      {
        Tuple.Create(HorizontalCorridor, WeightHorizontalCorridor),
        Tuple.Create(Crossroads, WeightCrossroads),
        Tuple.Create(HorizontalNorthTJunction, WeightHorizontalNorthTJunction),
        Tuple.Create(HorizontalSouthTJunction, WeightHorizontalSouthTJunction),
        Tuple.Create(VerticalWestTJunction, WeightVerticalWestTJunction)
      };
      var toWestOpening = new[]
      {
        Tuple.Create(HorizontalCorridor, WeightHorizontalCorridor),
        Tuple.Create(Crossroads, WeightCrossroads),
        Tuple.Create(HorizontalNorthTJunction, WeightHorizontalNorthTJunction),
        Tuple.Create(HorizontalSouthTJunction, WeightHorizontalSouthTJunction),
        Tuple.Create(VerticalEastTJunction, WeightVerticalEastTJunction)
      };
      var toNorthOpening = new[]
      {
        Tuple.Create(VerticalCorridor, WeightVerticalCorridor),
        Tuple.Create(Crossroads, WeightCrossroads),
        Tuple.Create(HorizontalSouthTJunction, WeightHorizontalSouthTJunction),
        Tuple.Create(VerticalWestTJunction, WeightVerticalWestTJunction),
        Tuple.Create(VerticalEastTJunction, WeightVerticalEastTJunction)
      };
      var toSouthOpening = new[]
      {
        Tuple.Create(VerticalCorridor, WeightVerticalCorridor),
        Tuple.Create(Crossroads, WeightCrossroads),
        Tuple.Create(HorizontalNorthTJunction, WeightHorizontalNorthTJunction),
        Tuple.Create(VerticalWestTJunction, WeightVerticalWestTJunction),
        Tuple.Create(VerticalEastTJunction, WeightVerticalEastTJunction)
      };
      var toEastWall = new Tuple<Tile, double>[0];
      var toWestWall = new Tuple<Tile, double>[0];

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

      HorizontalNorthTJunction.North = toNorthOpening;
      HorizontalNorthTJunction.South = toSouthWall;
      HorizontalNorthTJunction.East = toEastOpening;
      HorizontalNorthTJunction.West = toWestOpening;

      HorizontalSouthTJunction.North = toNorthWall;
      HorizontalSouthTJunction.South = toSouthOpening;
      HorizontalSouthTJunction.East = toEastOpening;
      HorizontalSouthTJunction.West = toWestOpening;

      VerticalWestTJunction.North = toNorthOpening;
      VerticalWestTJunction.South = toSouthOpening;
      VerticalWestTJunction.East = toEastWall;
      VerticalWestTJunction.West = toWestOpening;

      VerticalEastTJunction.North = toNorthOpening;
      VerticalEastTJunction.South = toSouthOpening;
      VerticalEastTJunction.East = toEastOpening;
      VerticalEastTJunction.West = toWestWall;
    }
  }
}