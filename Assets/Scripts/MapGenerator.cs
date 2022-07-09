using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    [SerializeField] private int MapSize = 1;
    [SerializeField] private TileSO[] Tiles;
    
    private List<Tile> SpawnedTiles = new List<Tile>();

    void Start()
    {
        Generate();
    }

    void Generate()
    {












    }
}
