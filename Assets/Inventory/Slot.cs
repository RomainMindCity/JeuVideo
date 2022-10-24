using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public int ID;
    public InventoryManager manager;
    public Image renderer;

    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<InventoryManager>();
        renderer = GetComponent<Image>();
    }

    private void Update()
    {
        if (transform.childCount > 0)
        {
            renderer.color = manager.rarityColors[transform.GetChild(0).GetComponent<InventoryItem>().itemData.rarity];
            if (transform.GetChild(0).GetComponent<InventoryItem>().Amount <= 0)
            {
                Destroy(transform.GetChild(0).gameObject);
            }
        }
        else
        {
            {
                renderer.color = manager.defaultColorSlot;
            }
        }
        
    }

    public void SetID()
    {
        manager.CurrentSlot = ID;
        manager.PickUpDropInventory();
    }

    
}
