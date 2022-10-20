using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerFarming : MonoBehaviour
{

    private bool isCollisioning = false;
    private bool isFarming = false;

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
            int Layer = other.gameObject.layer;
            switch(Layer)
            {
                case 10:
                    
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    break;
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    break;
                case 21:
                    break;
                case 22:
                    break;
                case 23:
                    break;
                case 24:
                    break;
                default:
                    isCollisioning = false;
                    break;

            }
        }
    }
    IEnumerator StartFarming(int CurrentCase)
    {
        Debug.Log("Farming");
        Debug.Log(CurrentCase);
        yield return new WaitForSeconds(1);
        isFarming = false;
    }

    void Update()
    {
        if(isCollisioning && isFarming)
        {
            int CurrentCase = 0;
            if (Input.GetKeyDown(KeyCode.E))
            {
                isFarming = true;
                StartCoroutine(StartFarming(CurrentCase));
            }
        }
    }
}
