using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmingBucheron : MonoBehaviour
{
    public GameObject Player;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && gameObject.tag == "Wood")
        {
            Debug.Log("Wood");
            if (Input.GetKeyDown(KeyCode.E))
            {
                StartCoroutine(Farming());
            }
        }
        if (other.gameObject.tag == "Player" && gameObject.tag == "Stone")
        {
            Debug.Log("Stone");
            if (Input.GetKeyDown(KeyCode.E))
            {
                StartCoroutine(Farming());
            }
        }
    }

    IEnumerator Farming()
    {
        Player.GetComponent<PlayerSkills>().Bucheron = true;
        Player.GetComponent<PlayerSkills>().isFarming = true;
        yield return new WaitForSeconds(Player.GetComponent<PlayerSkills>().BucheronTime);
        Player.GetComponent<PlayerSkills>().BucheronItem = Random.Range(1, 5);
        Player.GetComponent<PlayerSkills>().BucheronExperiance += Random.Range(1000000, 20000000);
        Player.GetComponent<PlayerSkills>().Bucheron = false;
        Player.GetComponent<PlayerSkills>().isFarming = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.GetComponent<PlayerSkills>().BucheronExperiance >= Player.GetComponent<PlayerSkills>().BucheronToNextExperiance)
        {
            if (Player.GetComponent<PlayerSkills>().BucheronLevel > 49)
            {
                Debug.Log("Max Level");
            } else {
                Player.GetComponent<PlayerSkills>().BucheronLevel += 1;
                Player.GetComponent<PlayerSkills>().BucheronExperiance = 0;
                Player.GetComponent<PlayerSkills>().BucheronToNextExperiance = (int)(Player.GetComponent<PlayerSkills>().BucheronToNextExperiance * 1.2f);
            }
        }
    }
}
