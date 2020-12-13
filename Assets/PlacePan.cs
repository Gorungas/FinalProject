using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacePan : MonoBehaviour
{
    public Transform dest;
    public GameObject pan;

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
        if(col.gameObject.name == "pan")
        {
            pan.transform.position = this.dest.position;
        }
    }
}
