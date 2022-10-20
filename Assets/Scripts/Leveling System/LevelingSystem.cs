using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelingSystem : MonoBehaviour
{

    struct LevelFormat
    {
        public string Name;
        public string Type;
        public int Level;
        public int CurrentExperiance;
        public int ToNextExperiance;
        public int MaxLevel;      
    }

    public class Bucheron
    {
        public static void Main(string[] args)
        {
            LevelFormat Lumberjack;
            LevelFormat Miner;
            LevelFormat Hunter;
            LevelFormat FisherMan;
            LevelFormat Builder;

            Lumberjack.Name = "Lumberjack";
            Lumberjack.Type = "Craftra";
            Lumberjack.Level = 1;
            Lumberjack.CurrentExperiance = 0;
            Lumberjack.ToNextExperiance = 1280;
            Lumberjack.MaxLevel = 50;

            Miner.Name = "Miner";
            Miner.Type = "Craftra";
            Miner.Level = 1;
            Miner.CurrentExperiance = 0;
            Miner.ToNextExperiance = 1280;
            Miner.MaxLevel = 50;

            Hunter.Name = "Hunter";
            Hunter.Type = "Craftra";
            Hunter.Level = 1;
            Hunter.CurrentExperiance = 0;
            Hunter.ToNextExperiance = 1280;
            Hunter.MaxLevel = 50;

            FisherMan.Name = "Fisherman";
            FisherMan.Type = "Craftra";
            FisherMan.Level = 1;
            FisherMan.CurrentExperiance = 0;
            FisherMan.ToNextExperiance = 1280;
            FisherMan.MaxLevel = 50;

            Builder.Name = "Builder";
            Builder.Type = "Craftra";
            Builder.Level = 1;
            Builder.CurrentExperiance = 0;
            Builder.ToNextExperiance = 1280;
            Builder.MaxLevel = 50;
        }    
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
