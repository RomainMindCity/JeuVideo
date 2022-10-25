using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerSelector : MonoBehaviour
{
    public GameObject[] playerPrefabs;
    public int x = 0;

    public TextMeshProUGUI Text;
    public TextMeshProUGUI[] Texts;

    public GameObject SelectorCanvas;
    public GameObject GameCanvas;

    public GameObject[] Player;

    public void SelectPlayer(int index)
    {
        for (int i = 0; i < playerPrefabs.Length; i++)
        {
            if (i == index)
            {
                playerPrefabs[i].SetActive(true);
                playerPrefabs[i].transform.Rotate(0f, 0f, 0f, Space.Self);
                Text.text = playerPrefabs[i].name;
                for (int j = 0; j < Texts.Length; j++)
                {
                    Texts[j].text = "In Progress";
                }
            }
            else
            {
                playerPrefabs[i].SetActive(false);
            }
        }
    }

    void Start()
    {
        SelectPlayer(0);
    }

    private void Update()
    {
        if(x > -1 && x < 6)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow) && x < 5)
            {
                x++;
                SelectPlayer(x);
                
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && x > 0)
            {
                x--;
                SelectPlayer(x);
            }
        }
        else
        {
            Debug.Log("Out of Bound");
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Player[x].SetActive(true);
            SelectorCanvas.SetActive(false);
            GameCanvas.SetActive(true);
        }

        
    }

}
