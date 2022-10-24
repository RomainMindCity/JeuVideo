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
}
