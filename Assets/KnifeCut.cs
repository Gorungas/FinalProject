using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeCut : MonoBehaviour
{
    public float yRot = 90;
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
        this.transform.eulerAngles = new Vector3(transform.eulerAngles.x, yRot, transform.eulerAngles.z);

    }
}
