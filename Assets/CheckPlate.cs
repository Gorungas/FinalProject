using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlate : MonoBehaviour
{
    public static bool nextPlate = false;
    public static bool isCooked = false;

    public GameObject Carrot;
    public GameObject CarrotSpawn;
    public GameObject Tomato;
    public GameObject tomatoSpawn;
    public GameObject Onion;
    public GameObject onionSpawn;
    int CorrectPlate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(nextPlate);
        CorrectPlate = Randomize.whichChop;
    }

    private void OnCollisionEnter(Collision col)
    {

        switch (CorrectPlate){
            case 0:

                if (col.gameObject.tag == "onion" && isCooked == true)
                {
                    ScoreManager.Score += 1;
                    Instantiate(Onion, onionSpawn.transform.position, Quaternion.identity);
                    Destroy(col.gameObject);
                    nextPlate = true;
                }
                break;
            case 1:
                if (col.gameObject.tag == "carrot" && isCooked == true)
                {
                    ScoreManager.Score += 1;
                    Instantiate(Carrot, CarrotSpawn.transform.position, Quaternion.identity);
                    Destroy(col.gameObject);
                    nextPlate = true;
                }

                break;
            case 2:

                if (col.gameObject.tag == "tomato" && isCooked == true)
                {
                    ScoreManager.Score += 1;
                    Instantiate(Tomato, tomatoSpawn.transform.position, Quaternion.identity);
                    Destroy(col.gameObject);
                    nextPlate = true;
                }
                break;
        }
        
    }

public static bool destroyAndPass()
    {
        return nextPlate;

    }
}
