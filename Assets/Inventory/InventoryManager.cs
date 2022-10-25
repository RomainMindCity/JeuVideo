using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [Header("Inventory & Management")]
    public GameObject Inventory;
    public GameObject CraftInventory;

    public Transform InventorySlotHolder;
    public Transform InventoryHotBarHolder;

    public Transform Cursor;
    public Vector3 offset;

    public List<bool> isFull;
    public List<Transform> slots;
    public List<Transform> hotBarSlots;

    public int CurrentSlot;

    [Header("Rarity & Items")]
    public Color[] rarityColors;
    public Color defaultColorSlot;


    public GameObject ItemToAdd;


    private void Start()
    {
        InitializeInventory();
        SetItemIDs();
        CheckSlots();
    }
    private void Update()
    {
        if (Inventory.activeSelf)
        {
            Cursor.position = Input.mousePosition + offset;
        }
        if (Cursor.childCount > 0)
        {
            Cursor.gameObject.SetActive(true);
        }
        else
        {
            Cursor.gameObject.SetActive(false);
        }

        if(Input.GetKeyDown(KeyCode.C))
        {
            CraftInventory.SetActive(!CraftInventory.activeSelf);
        }
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

    public void CraftItem(int[] IDs, int[] IDsAmounts, GameObject outcome, int outcomeAmount)
    {
        bool[] collected = new bool[IDs.Length];
        Transform[] collectedSlots = new Transform[IDs.Length];
        for (int x = 0; x < IDs.Length; x++)
        {
            for (int i = 0; i < slots.Count; i++)
            {
                if (isFull[i] == true)
                {
                    if (slots[i].GetChild(0).GetComponent<InventoryItem>().itemData.ID == IDs[0] && slots[i].GetChild(0).GetComponent<InventoryItem>().Amount >= IDsAmounts[x])
                    {
                        collected[x] = true;
                        collectedSlots[x] = slots[i].GetChild(0);
                    }
                }
            }
        }
        for (int i = 0; i < collected.Length; i++)
        {
            if (collected[i] == false)
            {
                return;
            }
        }
        for (int i = 0; i < collectedSlots.Length; i++)
        {
            collectedSlots[i].GetComponent<InventoryItem>().Amount -= IDsAmounts[i];
        }
        for (int i = 0; i < outcomeAmount; i++)
        {
            AddItem(outcome);
        }
    }
    
    public void AddItem(GameObject item)
    {
        for (int x = 0; x < slots.Count - hotBarSlots.Count; x++)
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
        Debug.Log("No empty slots");
    }

    public void PickUpDropInventory()
    {
        if (slots[CurrentSlot].childCount > 0 && Cursor.childCount < 1)
        {
            Instantiate(slots[CurrentSlot].GetChild(0).gameObject, Cursor);
            Destroy(slots[CurrentSlot].GetChild(0).gameObject);
        }
        else if (slots[CurrentSlot].childCount < 1 && Cursor.childCount > 0)
        {
            Instantiate(Cursor.GetChild(0).gameObject, slots[CurrentSlot]);
            Destroy(Cursor.GetChild(0).gameObject);
        }
        else if (slots[CurrentSlot].childCount > 0 && Cursor.childCount > 0)
        {
            if (slots[CurrentSlot].GetChild(0).GetComponent<InventoryItem>().itemData.ID == Cursor.GetChild(0).GetComponent<InventoryItem>().itemData.ID)
            {
                if (slots[CurrentSlot].GetChild(0).GetComponent<InventoryItem>().Amount <= Cursor.GetChild(0).GetComponent<InventoryItem>().itemData.maxStack - slots[CurrentSlot].GetChild(0).GetComponent<InventoryItem>().Amount)
                {
                    slots[CurrentSlot].GetChild(0).GetComponent<InventoryItem>().Amount += Cursor.GetChild(0).GetComponent<InventoryItem>().Amount;
                    Destroy(Cursor.GetChild(0).gameObject);
                }
            }
        }
        CheckSlots();
    }
}
