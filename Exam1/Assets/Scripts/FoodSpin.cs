using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpin : MonoBehaviour
{
    public Animator food;

    void Start()
    {
        food = GetComponent<Animator>();
    }

    public void DessertSpin()
    {
        food.enabled = true;
        food.Play("IceSpin");
    }

    public void NoMoreDessert()
    {
        food.enabled = false;
    }


}
