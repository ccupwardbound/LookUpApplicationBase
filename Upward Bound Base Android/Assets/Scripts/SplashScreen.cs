using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreen : MonoBehaviour
{

    public float Delay;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(SplashDelay(Delay));
    }


    private IEnumerator SplashDelay(float Delay)
    {
        yield return new WaitForSeconds(Delay);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Lookup_Home");

    }
}
