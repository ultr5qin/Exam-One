using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Duplicator : MonoBehaviour
{
    private int donutsDuplicated = 0;
    private int maximumDonuts = 3;
    public GameObject donut;


    private int iceCreamsDuplicated = 0;
    private int maximumIceCreams = 3;
    public GameObject iceCream;

    public GameObject ice;
    public GameObject don;
    public GameObject closed;


    void Update()
    {
        if(donutsDuplicated == 3 && iceCreamsDuplicated == 3)
        {
            closed.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void IceCreamParlor()
    {
        if(iceCreamsDuplicated < maximumIceCreams)
        {
            Duplication(iceCream);
            iceCreamsDuplicated = iceCreamsDuplicated + 1;
        }
        else if(iceCreamsDuplicated == maximumIceCreams)
        {
            ice.SetActive(true);
        }
    }

    public void PastryShop()
    {
        if(donutsDuplicated < maximumDonuts)
        {
            Duplication(donut);
            donutsDuplicated = donutsDuplicated + 1;
        }
        else if(donutsDuplicated == maximumDonuts)
        {
            don.SetActive(true);
        }
    }

    public void Duplication(GameObject duplex)
    {
        GameObject d1 = GameObject.Instantiate(duplex);
        Vector3 newPos = new Vector3(Random.Range(-1f, 1f), 1.5f, Random.Range(1.3f, 4f));
        d1.transform.position = newPos;
    }
    
    void OnGUI()
    {
        GUI.Box(new Rect(20, 10, 150, 25), "Donuts Bought: " + donutsDuplicated);
        GUI.Box(new Rect(20, 40, 150, 25), "Ice Cream Bought: " + iceCreamsDuplicated);
    }


}
