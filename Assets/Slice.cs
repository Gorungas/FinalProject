using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slice : MonoBehaviour
{
    public GameObject tomato;
    public GameObject tomatochild1;
    public GameObject tomatochild2;
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
        if (col.gameObject.name == "knife")
        {
            tomatochild1.transform.parent = null;
            tomatochild2.transform.parent = null;
            tomato.SetActive(false);
            tomatochild1.SetActive(true);
            tomatochild2.SetActive(true);
        }
    }
}
