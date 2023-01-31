using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Flags]
public enum TileConnectionType : int
{
    NONE = 0,
    GRASS = 1 << 0,
    RIVER = 1 << 1,
}

[CreateAssetMenu(fileName = "TileData", menuName = "MapGenerator/TileData", order = 2)]
public class TileSO : ScriptableObject
{
    public class TileSOComparer : IEqualityComparer<TileSO>
    {
        public bool Equals(TileSO x, TileSO y) => x.GetHashCode() == y.GetHashCode();
        public int GetHashCode(TileSO obj) => obj.GetHashCode();
    }

    public GameObject TilePrefab;
    public TileConnectionType[] Connections = new TileConnectionType[6];

    public override int GetHashCode()
    {
        TileConnectionType hash = TileConnectionType.NONE;

        for (int i = 0; i < Connections.Length; i++)
        {
            hash |= Connections[i];
        }

        return (int)hash;
    }
}
