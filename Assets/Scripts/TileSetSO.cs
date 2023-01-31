using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TileSetOrientation
{
    FLAT,
    POINTY
}

[CreateAssetMenu(fileName = "TileSet", menuName = "MapGenerator/TileSet", order = 1)]
public class TileSetSO : ScriptableObject
{
    public float Size;
    public TileSO[] BaseTiles;
    public TileSetOrientation TileSetOrientation;

    public HashSet<TileSO> TileSet = new HashSet<TileSO>();

    public float Width => TileSetOrientation switch
    {
        TileSetOrientation.FLAT => 2 * Size,
        TileSetOrientation.POINTY => Mathf.Sqrt(3) * Size,
        _ => 0,
    };

    public float Height => TileSetOrientation switch
    {
        TileSetOrientation.FLAT => Mathf.Sqrt(3) * Size,
        TileSetOrientation.POINTY => 2 * Size,
        _ => 0,
    };

    public void ComputeTileSet()
    {






    }
}