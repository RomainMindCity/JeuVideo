using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelingSystem : MonoBehaviour
{
    [Header("PlayerLevel")]
    public string PlayerName;
    public int PlayerLevel = 1;

    [Header("LumberJack")]
    public string LumberJackName = "LumberJack";
    public int LumberJackLevel = 1;
    public int LumberJackCurrentExp = 0;
    public int LumberJackExpToNextLevel = 100;
    [Header("Miner")]
    public string MinerName = "Miner";
    public int MinerLevel = 1;
    public int MinerCurrentExp = 0;
    public int MinerExpToNextLevel = 100;
    [Header("Crafting")]
    public string CraftingName = "Crafting";
    public int CraftingLevel = 1;
    public int CraftingCurrentExp = 0;
    public int CraftingExpToNextLevel = 100;
    [Header("Smelting")]
    public string SmeltingName = "Smelting";
    public int SmeltingLevel = 1;
    public int SmeltingCurrentExp = 0;
    public int SmeltingExpToNextLevel = 100;

    private void Update()
    {
        PlayerLevel = (LumberJackLevel + MinerLevel + CraftingLevel + SmeltingLevel) / 4 ;
    }
}
