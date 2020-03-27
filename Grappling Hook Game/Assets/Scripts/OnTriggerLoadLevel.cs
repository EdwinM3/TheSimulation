using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerLoadLevel : MonoBehaviour
{
    public GameObject guiObject;
    public string levelToLoad;
    // Start is called before the first frame update
    void Start()
    {
        guiObject.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerStay (Collider Other)
    {
        if (Other.gameObject.tag == "Player")
        {
            guiObject.SetActive(true);
            if (guiObject.activeInHierarchy == true && Input.GetButtonDown("Use"))
            {
                Application.LoadLevel(levelToLoad);
            }
        }
    }
     void OnTriggerExit()
    {
        guiObject.SetActive(false);
    }
}
