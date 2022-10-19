using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkills : MonoBehaviour
{
    [Header("Farming")]
    public bool isFarming;
    
    [Header("Skills")]
    public bool Bucheron;
    public bool Minage;
    public bool Combat;
    public bool Craft;
    public bool P�che;

    [Header("Bucheron")]
    
    public int BucheronLevel;
    public int BucheronExperiance;
    public int BucheronItem;
    public int BucheronToNextExperiance = 100;
    public int BucheronTime = 5;

    [Header("Minage")]
    
    public int MinageLevel;
    public int MinageExperiance;
    public int MinageItem;
    public int MinageToNextExperiance = 100;
    public int MinageTime = 5;

    [Header("Combat")]
    
    public int CombatLevel;
    public int CombatExperiance;
    public int CombatItem;
    public int CombatToNextExperiance = 100;
    public int CombatTime = 5;

    [Header("Craft")]
    
    public int CraftLevel;
    public int CraftExperiance;
    public int CraftItem;
    public int CraftToNextExperiance = 100;
    public int CraftTime = 5;

    [Header("P�che")]
    
    public int P�cheLevel;
    public int P�cheExperiance;
    public int P�cheItem;
    public int P�cheToNextExperiance = 100;
    public int P�cheTime = 5;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
