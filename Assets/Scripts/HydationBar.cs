using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HydationBar : MonoBehaviour
{
   
    private Slider slider;
    public TextMeshProUGUI hydrationCounter;

    public GameObject playerState;

    private float currentHydration, maxHydration;

    void Awake()
    {
        slider = GetComponent<Slider>();
    }


    void Update()
    {
        currentHydration = playerState.GetComponent<PlayerState>().currentHydrationPercent;
        maxHydration = playerState.GetComponent<PlayerState>().maxHydrationPercent;

        float fillValue = currentHydration / maxHydration;
        slider.value = fillValue;

        hydrationCounter.text = currentHydration + "%";


    }
}
