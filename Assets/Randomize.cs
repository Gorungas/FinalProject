using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Randomize : MonoBehaviour
{
    System.Random Rnd = new System.Random();
    static public int whichChop;
    public GameObject onion;
    public GameObject carrot;
    public GameObject tomato;
    int choppy;
    int lastRandom;
    // Start is called before the first frame update
    void Start()
    {
        ShowFruit();
    }

    // Update is called once per frame
    void Update()
    {
        if (CheckPlate.destroyAndPass() == true)
        {
            ShowFruit();
            CheckPlate.nextPlate = false;
            CheckPlate.isCooked = false;
        }   
    }

    public int ChooseVeg(int fruits)
    {

        while (lastRandom == choppy)
        {
            choppy = Rnd.Next(fruits);
        }
        return choppy;
    }

    public void ShowFruit()
    {
        int fruit = ChooseVeg(3);
        lastRandom = fruit;
        whichChop = fruit;
        Debug.Log(fruit);

        switch (fruit)
        {
            case 0:
                if (tomato.activeSelf == true || carrot.activeSelf == true)
                {
                    onion.SetActive(true);
                    carrot.SetActive(false);
                    tomato.SetActive(false);
                }
                else
                {
                    onion.SetActive(true);
                }
                break;
            case 1:
                if (tomato.activeSelf == true || onion.activeSelf == true)
                {
                    onion.SetActive(false);
                    carrot.SetActive(true);
                    tomato.SetActive(false);
                }
                else
                {
                    carrot.SetActive(true);
                }
                break;
            case 2:
                if (carrot.activeSelf == true || onion.activeSelf == true)
                {
                    onion.SetActive(false);
                    carrot.SetActive(false);
                    tomato.SetActive(true);
                }
                else
                {
                    tomato.SetActive(true);
                }
                break;
        }
    }
}
