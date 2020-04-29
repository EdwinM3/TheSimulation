using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LastScene : MonoBehaviour
{
    private int nextSceneToLoad;
    public returnScript returnScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        StartCoroutine("Timer");
    }


    public IEnumerator Timer()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(2);
    }
}
