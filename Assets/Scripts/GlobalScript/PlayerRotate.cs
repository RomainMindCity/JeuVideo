using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    public GameObject Player;

    // Update is called once per frame
    void Update()
    {
        Player.transform.Rotate(0f, 50 * Time.deltaTime, 0f, Space.Self);        
    }
}
