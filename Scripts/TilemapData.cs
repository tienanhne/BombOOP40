using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(fileName = "TilemapData", menuName = "ScriptableObjects/TilemapData", order = 1)]
public class TilemapData : ScriptableObject
{
    public Tilemap destructibleTiles;
}