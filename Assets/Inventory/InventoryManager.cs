using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public Transform InventorySlotHolder;
    public Transform InventoryHotBarHolder;
    

    public List<bool> isFull;
    public List<Transform> slots;
    public List<Transform> hotBarSlots;

    public int CurrentSlot;

    private void Start()
    {
        InitializeInventory();
        SetItemIDs();
        CheckSlots();
    }
    void InitializeInventory()
    {
        for (int i = 0; i < InventorySlotHolder.childCount; i++)
        {
            slots.Add(InventorySlotHolder.GetChild(i));
            isFull.Add(false);
        }

        for (int i = 0; i < InventoryHotBarHolder.childCount; i++)
        {
            slots.Add(InventoryHotBarHolder.GetChild(i));
            hotBarSlots.Add(InventoryHotBarHolder.GetChild(i));
            isFull.Add(false);
        } 
    }

    void SetItemIDs()
    {
        for (int i = 0; i < slots.Count; i++)
        {
            if (slots[i].GetComponent<Slot>() != null)
            {
                slots[i].GetComponent<Slot>().ID = i;
            }
        }
    }

    void CheckSlots()
    {
        for (int i = 0; i < slots.Count; i++)
        {
            if (slots[i].childCount > 0)
            {
                isFull[i] = true;
            }
            else
            {
                isFull[i] = false;
            }
        }
    }

    void AddItem(GameObject item, int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            for (int x = 0; x < slots.Count; x++)
            {
                if (isFull[x] == false)
                {
                    // Add item to slot
                    Instantiate(item, slots[x]);
                    CheckSlots();
                    return;
                }
                else
                {
                    Debug.Log("Inventory is full");
                }
            }
            
        }
        Debug.Log("No empty slots");
    }

    void PickUpDropInventory()
    {
        
    }
}
