﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PickUp : MonoBehaviour
{
    public GameObject playerModel; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = GameObject.Find("PlayerHand").transform.position;
        this.transform.parent = GameObject.Find("PlayerHand").transform;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll | RigidbodyConstraints.FreezeRotation;


    }

    private void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    }
}
