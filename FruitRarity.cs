using System;
using UnityEngine;


[Serializable]
public class FruitRarity
{
    public string RarityName;
    [Range(0, 100)]
    public float rarity;
    public float chance;
    public string[] fruits;


}
