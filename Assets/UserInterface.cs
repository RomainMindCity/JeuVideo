using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UserInterface : MonoBehaviour
{

    public Slider slider;
    public TMPro.TextMeshProUGUI text;
    private bool Showing = false;

    public void UpdateSlider(float MaxValue, float CurrentValue, string Text)
    {
        slider.maxValue = MaxValue;
        slider.value = CurrentValue;
        text.text = Text;
        slider.gameObject.SetActive(true);
        Showing = true;
        
    }

    private void Start()
    {
        slider.gameObject.SetActive(false);
        
    }


}

