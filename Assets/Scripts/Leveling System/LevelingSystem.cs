using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelingSystem : MonoBehaviour
{

    [Header("Leveling System")]
    [Header("LumberJack")]
    public int LumberJackLevel = 1;
    public int LumberJackCurrentExp = 0;
    public int LumberJackExpToNextLevel = 100;
    [Header("Miner")]
    public int MinerLevel = 1;
    public int MinerCurrentExp = 0;
    public int MinerExpToNextLevel = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
