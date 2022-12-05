using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerFoodInfoMenu : MonoBehaviour
{
    public GameObject foodInfoMenu;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "food")
        {
            foodInfoMenu.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "food")
        {
            foodInfoMenu.SetActive(false);
        }
    }
}
