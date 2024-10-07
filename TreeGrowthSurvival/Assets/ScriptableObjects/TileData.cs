using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


[CreateAssetMenu]
public class TileData : ScriptableObject
{
    public TileBase[] tiles;

    public bool Tree;
    public bool TreeGrowthCentre;
    public bool TreeGrowthOne, TreeGrowthTwo, TreeGrowthThree;
    public bool BarrenWasteland;
    public bool City;
    public bool TreeCut;
}
