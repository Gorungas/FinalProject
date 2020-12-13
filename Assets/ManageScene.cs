using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManageScene : MonoBehaviour
{
    public Button restart;

    // Start is called before the first frame update
    void Start()
    {
        restart.onClick.AddListener(switchToMain);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void switchToMain()
    {
        SceneManager.LoadScene("MainScene");
    }
}
