using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    public static PlayerState Instance { get; set; }

    //Player Health
    public float currentHealth;
    public float maxHealth;

    //Player Calories
    public float currentCalories;
    public float maxCalories;

    float distanceTravelled = 0;
    Vector3 lastPosition;

    public GameObject playerBody;

    //Player Hydration
    public float currentHydrationPercent;
    public float maxHydrationPercent;



    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    private void Start()
    {
        currentHealth = maxHealth;
        currentCalories = maxCalories;
    }

    void Update()
    {
        distanceTravelled += Vector3.Distance(playerBody.transform.position, lastPosition);
        lastPosition = playerBody.transform.position;

        if(distanceTravelled >= 20)
        {
            distanceTravelled = 0;
            currentCalories -= 1;
        }


        if(Input.GetKeyUp(KeyCode.N))
        {
            currentHealth -= 10;

        }
    }
}