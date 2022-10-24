using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryItem : MonoBehaviour
{
    public Item itemData;
    public TextMeshProUGUI AmountText;

    private Image iconRenderer;

    public int Amount = 1;
    public int ID;


    private void Update()
    {
        if (Amount <= 1)
        {
            AmountText.gameObject.SetActive(false);
        }
        else
        {
            AmountText.gameObject.SetActive(true);
        }
        AmountText.text = Amount.ToString();
    }

    private void OnValidate()
    {
        if (itemData != null)
        {
            if (iconRenderer == null)
            {
                iconRenderer = gameObject.GetComponent<Image>();
            }
            iconRenderer.sprite = itemData.Icon;
        }
    }
}
