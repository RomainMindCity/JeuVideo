using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelingSystem : MonoBehaviour
{
    [Header("LumberJack")]
    public int LumberJackLevel = 1;
    public int LumberJackCurrentExp = 0;
    public int LumberJackExpToNextLevel = 100;
    [Header("Miner")]
    public int MinerLevel = 1;
    public int MinerCurrentExp = 0;
    public int MinerExpToNextLevel = 100;
    [Header("Crafting")]
    public int CraftingLevel = 1;
    public int CraftingCurrentExp = 0;
    public int CraftingExpToNextLevel = 100;
    [Header("Smelting")]
    public int SmeltingLevel = 1;
    public int SmeltingCurrentExp = 0;
    public int SmeltingExpToNextLevel = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
