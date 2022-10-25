using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public GameObject Inventory;
    public bool playerRenderer = false;
    
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
            Cursor.visible = !Cursor.visible;
            Cursor.lockState = Cursor.lockState == CursorLockMode.Locked ? CursorLockMode.None : CursorLockMode.Locked;
            
        }
    }
}
