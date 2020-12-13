using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cook : MonoBehaviour
{
    public Material CookedCarrotMat;
    public Material CookedOnionMat;
    public Material CookedTomatoMat;

    public bool isTouchingBurner = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        if ((isTouchingBurner) && (col.gameObject.tag == "carrot" || col.gameObject.tag == "onion" || col.gameObject.tag == "tomato"))
        {
            if (col.gameObject.tag == "carrot")
            {
                col.gameObject.GetComponent<MeshRenderer>().material = CookedCarrotMat;
            }
            else if (col.gameObject.tag == "tomato")
            {
                col.gameObject.GetComponent<MeshRenderer>().material = CookedTomatoMat;
            }
            else if (col.gameObject.tag == "onion")
            {
                col.gameObject.GetComponent<MeshRenderer>().material = CookedOnionMat;
            }
            CheckPlate.isCooked = true;
        }
        if (col.gameObject.tag == "Burner")
        {
            isTouchingBurner = true;
        }
    }
    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "Burner")
        {
            isTouchingBurner = false;
        }
    }
}
