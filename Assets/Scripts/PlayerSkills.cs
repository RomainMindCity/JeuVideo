using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerSkills : MonoBehaviour
{
    [Header("PlayerLevel")]
    public TMPro.TextMeshProUGUI PlayerLevel;
    
    [Header("PlayerLevel")]
    public TMPro.TextMeshProUGUI LumberJackLevel;
    public Slider LumberJackExp;

    [Header("PlayerLevel")]
    public TMPro.TextMeshProUGUI MinerLevel;
    public Slider MinerExp;

    [Header("PlayerLevel")]
    public TMPro.TextMeshProUGUI CraftingLevel;
    public Slider CraftingExp;

    [Header("PlayerLevel")]
    public TMPro.TextMeshProUGUI SmeltingLevel;
    public Slider SmeltingExp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UserInterface UI = GameObject.Find("UserInterface").GetComponent<UserInterface>();
        LevelingSystem Level = GetComponent<LevelingSystem>();
        
        if (Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log(Level.PlayerLevel);
        }
    }
}
