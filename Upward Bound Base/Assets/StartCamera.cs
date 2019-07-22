using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCamera : MonoBehaviour
{
    public void StartTheCamera()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Lookup_Finder");
    }
}
