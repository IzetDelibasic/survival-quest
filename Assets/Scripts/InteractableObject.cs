using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public bool playerinRange;


    public string ItemName;

    public string GetItemName()
    {
        return ItemName;
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && playerinRange && SelectionManager.Instance.onTarget){
            Debug.Log("Item added to inventory");

            Destroy(gameObject);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerinRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerinRange = false;
        }
    }

}