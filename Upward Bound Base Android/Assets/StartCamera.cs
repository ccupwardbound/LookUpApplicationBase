using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartCamera : MonoBehaviour
{

   
    public GameObject textpanel;

    private void Start()
    {
        textpanel.SetActive(false);
    }


    public void StartTheCamera()
    {
        textpanel.SetActive(true);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Lookup_Finder");
    }
}
