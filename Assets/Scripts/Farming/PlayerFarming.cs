using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerFarming : MonoBehaviour
{

    private bool isCollisioning = false;
    private bool isFarming = false;
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
            Debug.Log(other.gameObject.layer);
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
        if (10 <= CurrentCase && CurrentCase < 15)
        {
            //LootChest
            LootChest(CurrentCase);
        }
        else if (15 <= CurrentCase && CurrentCase < 20)
        {
            //Lumberjack
            LumberJack(CurrentCase);
        }
        else if (20 <= CurrentCase && CurrentCase < 25)
        {
            //Miner
            Miner(CurrentCase);
        }

        yield return new WaitForSeconds(0.1f);
        isFarming = false;
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
        Debug.Log("LumberJack");
    }

    private void Miner(int CurrentCase)
    {
        isFarming = true;
        Debug.Log("Miner");
    }
}
