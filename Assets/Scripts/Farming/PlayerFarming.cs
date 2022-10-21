using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerFarming : MonoBehaviour
{

    private bool isCollisioning = false;
    public bool isFarming = false;
    private int CurrentCase;

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
            switch(Layer)
            {
                case 10:
                    CurrentCase = Layer;
                    break;
                case 11:
                    CurrentCase = Layer;
                    break;
                case 12:
                    CurrentCase = Layer;
                    break;
                case 13:
                    CurrentCase = Layer;
                    break;
                case 14:
                    CurrentCase = Layer;
                    break;
                case 15:
                    CurrentCase = Layer;
                    break;
                case 16:
                    CurrentCase = Layer;
                    break;
                case 17:
                    CurrentCase = Layer;
                    break;
                case 18:
                    CurrentCase = Layer;
                    break;
                case 19:
                    CurrentCase = Layer;
                    break;
                case 20:
                    CurrentCase = Layer;
                    break;
                case 21:
                    CurrentCase = Layer;
                    break;
                case 22:
                    CurrentCase = Layer;
                    break;
                case 23:
                    CurrentCase = Layer;
                    break;
                case 24:
                    CurrentCase = Layer;
                    break;
                default:
                    isCollisioning = false;
                    break;

            }
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
            LumberJack(CurrentCase);
            switch (CurrentCase)
            {
                case 15:
                    yield return new WaitForSeconds(2f);
                    isFarming = false;
                    break;
                case 16:
                    yield return new WaitForSeconds(3f);
                    isFarming = false;
                    break;
                case 17:
                    yield return new WaitForSeconds(4f);
                    isFarming = false;
                    break;
                case 18:
                    yield return new WaitForSeconds(5f);
                    isFarming = false;
                    break;
                case 19:
                    yield return new WaitForSeconds(7.5f);
                    isFarming = false;
                    break;
            }
        }
        else if (20 <= CurrentCase && CurrentCase < 25)
        {
            Miner(CurrentCase);
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
        Debug.Log(CurrentCase);
    }

    private void LumberJack(int CurrentCase)
    {
        isFarming = true;
        LevelingSystem Level = GetComponent<LevelingSystem>();
        switch (CurrentCase)
        {
            case 15:
                if (Level.LumberJackLevel >= 1 && Level.LumberJackLevel < 12)
                {
                    Level.LumberJackCurrentExp += Random.Range(10, 51);
                }
                break;
            case 16:
                if (Level.LumberJackLevel >= 10 && Level.LumberJackLevel < 22)
                {
                    Level.LumberJackCurrentExp += Random.Range(25, 76);
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
                    Level.LumberJackCurrentExp += Random.Range(50, 101);
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
                    Level.LumberJackCurrentExp += Random.Range(75, 151);
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
                    Level.LumberJackCurrentExp += Random.Range(100, 201);
                    isFarming = false;

                }
                else
                {
                    Debug.Log("You need to be level 40 to farm this");
                }
                break;
        }

        if (Level.LumberJackCurrentExp > Level.LumberJackExpToNextLevel)
        {
            Level.LumberJackLevel++;
            Level.LumberJackCurrentExp = 0;
            Level.LumberJackExpToNextLevel += (int)(Level.LumberJackExpToNextLevel * 1.2f);
        }
    }

    private void Miner(int CurrentCase)
    {
        isFarming = true;
        Debug.Log("Miner");
    }
}
