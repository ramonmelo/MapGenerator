using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    [SerializeField] private int MapSize = 1;
    [SerializeField] private float TileSize = 1;
    [SerializeField] private TileSO[] Tiles;
    
    private List<Tile> SpawnedTiles = new List<Tile>();

    private float TileWidth => TileSize * Mathf.Sqrt(3);
    private float TileHeight => TileSize * 2;


    void Start()
    {
        Generate();
    }

    void Generate()
    {
    }



}
