using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerFarming : MonoBehaviour
{
    public GameObject InventoryCrafting;
    public GameObject Inventory;
    public GameObject InventoryText;
    public GameObject InventoryPlayer;
    public GameObject InventorySlotItem;
    
    private bool isCollisioning = false;
    public bool isFarming = false;
    private int CurrentCase;
    private bool crafting;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ressources")
        {
            isCollisioning = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ressources")
        {
            isCollisioning = false;
        }
    } 
    private void OnTriggerStay(Collider other)
    {
        if(isCollisioning)
        {
            //Show "Press [E] to farm" in UI
            int Layer = other.gameObject.layer;
            CurrentCase = Layer;
        }
    }
    IEnumerator StartFarming(int CurrentCase)
    {
        LevelingSystem Level = GetComponent<LevelingSystem>();
        if (10 <= CurrentCase && CurrentCase < 15)
        {
            LootChest(CurrentCase);
        }
        else if (15 <= CurrentCase && CurrentCase < 20)
        {
            switch (CurrentCase)
            {
                case 15:
                    if (Level.LumberJackLevel >= 1 && Level.LumberJackLevel < 12)
                    {
                        isFarming = true;
                        yield return new WaitForSeconds(2f);
                        LumberJack(CurrentCase);
                        isFarming = false;
                    }
                    break;
                case 16:
                    if (Level.LumberJackLevel >= 10 && Level.LumberJackLevel < 22)
                    {
                        isFarming = true;
                        yield return new WaitForSeconds(3f);
                        LumberJack(CurrentCase);
                        isFarming = false;
                    }
                    else
                    {
                        Debug.Log("You need to be level 10 to farm this");
                    }    
                    
                    break;
                case 17:
                    if (Level.LumberJackLevel >= 20 && Level.LumberJackLevel < 32)
                    {
                        isFarming = true;
                        yield return new WaitForSeconds(4f);
                        LumberJack(CurrentCase);
                        isFarming = false;
                    }
                    else
                    {
                        Debug.Log("You need to be level 20 to farm this");
                    }
                    break;
                case 18:
                    if (Level.LumberJackLevel >= 30 && Level.LumberJackLevel < 42)
                    {
                        isFarming = true;
                        yield return new WaitForSeconds(5f);
                        LumberJack(CurrentCase);
                        isFarming = false;
                    }
                    else
                    {
                        Debug.Log("You need to be level 30 to farm this");
                    }
                    break;
                case 19:
                    if (Level.LumberJackLevel >= 40 && Level.LumberJackLevel < 51)
                    {
                        isFarming = true;
                        yield return new WaitForSeconds(7.5f);
                        LumberJack(CurrentCase);
                        isFarming = false;
                    }
                    else
                    {
                        Debug.Log("You need to be level 40 to farm this");
                    }
                    break;
            }
        }
        else if (20 <= CurrentCase && CurrentCase < 25)
        {
            switch (CurrentCase)
            {
                case 20:
                    if (Level.MinerLevel >= 1 && Level.MinerLevel < 12)
                    {
                        isFarming = true;
                        yield return new WaitForSeconds(2f);
                        Miner(CurrentCase);
                        isFarming = false;
                    }
                    break;
                case 21:
                    if (Level.MinerLevel >= 10 && Level.MinerLevel < 22)
                    {
                        isFarming = true;
                        yield return new WaitForSeconds(3f);
                        Miner(CurrentCase);
                        isFarming = false;
                    }
                    else
                    {
                        Debug.Log("You need to be level 10 to farm this");
                    }
                    break;
                case 22:
                    if (Level.MinerLevel >= 20 && Level.MinerLevel < 32)
                    {
                        isFarming = true;
                        yield return new WaitForSeconds(4f);
                        Miner(CurrentCase);
                        isFarming = false;
                    }
                    else
                    {
                        Debug.Log("You need to be level 20 to farm this");
                    }
                    break;
                case 23:
                    if (Level.MinerLevel >= 30 && Level.MinerLevel < 42)
                    {
                        isFarming = true;
                        yield return new WaitForSeconds(5f);
                        Miner(CurrentCase);
                        isFarming = false;
                    }
                    else
                    {
                        Debug.Log("You need to be level 30 to farm this");
                    }
                    break;
                case 24:
                    if (Level.MinerLevel >= 40 && Level.MinerLevel < 51)
                    {
                        isFarming = true;
                        yield return new WaitForSeconds(7.5f);
                        Miner(CurrentCase);
                        isFarming = false;
                    }
                    else
                    {
                        Debug.Log("You need to be level 40 to farm this");
                    }
                    break;
            }
        }
        else if (CurrentCase == 30)
        {
            Crafting(CurrentCase);
            crafting = !crafting;
        }
        else if (CurrentCase == 31)
        {
            Smelting(CurrentCase);
        }
    }

    void Update()
    {
        if(isCollisioning && !isFarming)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                StartCoroutine(StartFarming(CurrentCase));
            }
        }
    }

    private void LootChest(int CurrentCase)
    {
        switch (CurrentCase)
        {
            case 10:
                Debug.Log("You looted a chest");
                break;
            case 11:
                Debug.Log("You looted a chest");
                break;
            case 12:
                Debug.Log("You looted a chest");
                break;
            case 13:
                Debug.Log("You looted a chest");
                break;
            case 14:
                Debug.Log("You looted a chest");
                break;
        }
    }

    private void LumberJack(int CurrentCase)
    {
        UserInterface UI = GameObject.Find("UserInterface").GetComponent<UserInterface>();
        LevelingSystem Level = GetComponent<LevelingSystem>();
        switch (CurrentCase)
        {
            case 15:
                Level.LumberJackCurrentExp += Random.Range(10, 51);
                break;
            case 16:
                Level.LumberJackCurrentExp += Random.Range(25, 76);
                break;
            case 17:
                Level.LumberJackCurrentExp += Random.Range(50, 101);
                break;
            case 18:
                Level.LumberJackCurrentExp += Random.Range(75, 151);
                break;
            case 19:
                 Level.LumberJackCurrentExp += Random.Range(100, 201);
                break;
        }

        if (Level.LumberJackCurrentExp > Level.LumberJackExpToNextLevel)
        {
            Level.LumberJackLevel++;
            Level.LumberJackCurrentExp = Level.LumberJackCurrentExp - Level.LumberJackExpToNextLevel;
            Level.LumberJackExpToNextLevel = (int)(Level.LumberJackExpToNextLevel * 1.2f);
        }
        UI.UpdateSlider(Level.LumberJackExpToNextLevel, Level.LumberJackCurrentExp, "LumberJack" + " " + Level.LumberJackLevel);
    }
    
    private void Miner(int CurrentCase)
    {
        UserInterface UI = GameObject.Find("UserInterface").GetComponent<UserInterface>();
        LevelingSystem Level = GetComponent<LevelingSystem>();
        switch (CurrentCase)
        {
            case 20:
                Level.MinerCurrentExp += Random.Range(10, 51);
                break;
            case 21:
                Level.MinerCurrentExp += Random.Range(25, 76);
                break;
            case 22:
                Level.MinerCurrentExp += Random.Range(50, 101);
                break;
            case 23:
                Level.MinerCurrentExp += Random.Range(75, 151);
                break;
            case 24:
                Level.MinerCurrentExp += Random.Range(100, 201);
                break;
        }

        if (Level.MinerCurrentExp > Level.MinerExpToNextLevel)
        {
            Level.MinerLevel++;
            Level.MinerCurrentExp = Level.MinerCurrentExp - Level.MinerExpToNextLevel;
            Level.MinerExpToNextLevel = (int)(Level.MinerExpToNextLevel * 1.2f);
        }
        UI.UpdateSlider(Level.MinerExpToNextLevel, Level.MinerCurrentExp, "Miner" + " " + Level.MinerLevel);
    }

    private void Crafting(int recipie)
    {      

    }

    private void Smelting(int recipie)
    {
        Debug.Log("Smelting");
    }
}
