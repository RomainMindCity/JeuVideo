using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Unity Invenotry", order = 0 )]
public class Item : ScriptableObject
{
    public int ID;
    public string Name;
    public Sprite Icon;

    public int maxStack;
    public int weight;

}

