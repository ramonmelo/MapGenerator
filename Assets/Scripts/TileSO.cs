using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TileConnectionType
{
    GRASS,
    RIVER,
}

[CreateAssetMenu(fileName = "TileData", menuName = "MapGenerator/TileData", order = 1)]
public class TileSO : ScriptableObject
{
    public GameObject TilePrefab;
    public TileConnectionType[] Connections = new TileConnectionType[6];
}
