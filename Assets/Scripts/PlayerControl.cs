using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public GameObject Inventory;
    
    void Update()
    {
        UserInterface UI = GameObject.Find("UserInterface").GetComponent<UserInterface>();
        LevelingSystem Level = GetComponent<LevelingSystem>();
        

        if (Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log(Level.PlayerLevel);
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            Inventory.SetActive(!Inventory.activeSelf);
        }
    }
}
