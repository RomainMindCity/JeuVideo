using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFarm : MonoBehaviour
{
    public int FarmAmount;
    public int FarmingExperiance;
    
    [Header("CurrentLevel")]
    public int Level;
    public int CurrentExperiance;
    public int ExperianceToNextLevel = 100;

    [Header("CurrentStats")]
    public bool isFarming;

    [Header("FarmingLevel")]
    public int FarmLevelTier1 = 1;
    public int FarmLevelTier2 = 10;
    public int FarmLevelTier3 = 25;
    public int FarmLevelTier4 = 35;
    public int FarmLevelTier5 = 45;

    [Header("FarmingExperianceTier1")]
    public int MaxFarmingExperianceTier1 = 100;
    public int MinFarmingExperianceTier1 = 1;
    
    public int MaxFarmingItemAmountTier1 = 5;
    public int MinFarmingItemAmountTier1 = 1;
    
    public int LevelToMinimumTier1 = 12;
    public int FarmingtimeTier1 = 5;

    [Header("FarmingExperianceTier2")]
    public int MaxFarmingExperianceTier2 = 200;
    public int MinFarmingExperianceTier2 = 50;
    
    public int MaxFarmingItemAmountTier2 = 10;
    public int MinFarmingItemAmountTier2 = 1;
    
    public int LevelToMinimumTier2 = 32;
    public int FarmingtimeTier2 = 10;

    [Header("FarmingExperianceTier3")]
    public int MaxFarmingExperianceTier3 = 300;
    public int MinFarmingExperianceTier3 = 100;
    
    public int MaxFarmingItemAmountTier3 = 15;
    public int MinFarmingItemAmountTier3 = 1;
    
    public int LevelToMinimumTier3 = 42;
    public int FarmingtimeTier3 = 15;

    [Header("FarmingExperianceTier4")]
    public int MaxFarmingExperianceTier4 = 400;
    public int MinFarmingExperianceTier4 = 150;
    
    public int MaxFarmingItemAmountTier4 = 20;
    public int MinFarmingItemAmountTier4 = 1;
    
    public int LevelToMinimumTier4 = 50;
    public int FarmingtimeTier4 = 20;

    [Header("FarmingExperianceTier5")]
    public int FarmingExperianceTier5 = 500;

    public int MaxFarmingItemAmountTier5 = 25;
    public int MinFarmingItemAmountTier5 = 10;
    public int FarmingtimeTier5 = 25;

    void Start()
    {
        PlayerSkills skills = new PlayerSkills();
    }
    public void AddExperience(int amount)
    {
        CurrentExperiance += amount;
        if (CurrentExperiance >= ExperianceToNextLevel)
        {
            Level++;
            CurrentExperiance -= ExperianceToNextLevel;
            ExperianceToNextLevel = (int)(ExperianceToNextLevel * 1.5f);
        }
    }

    public int GetLevelNumber()
    {
        return Level;
    }
}
