using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTriggerLoadLevel : MonoBehaviour
{ 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerStay (Collider Other)
    {
        if (Other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(3);
        }
    }
}
