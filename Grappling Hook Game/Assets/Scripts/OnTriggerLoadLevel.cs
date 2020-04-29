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

    void Update()
    {
        
    }

    // Update is called once per frame
    void OnTriggerStay (Collider Other)
    {
        if (Other.gameObject.tag == "Player")
        {
            SceneChecker();
            
               
           
        }
    }


    void SceneChecker()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        int buildIndex = currentScene.buildIndex;

        if(buildIndex == 2)
        {
            SceneManager.LoadScene(3);
        }
        if(buildIndex == 3)
        {
            SceneManager.LoadScene(4);
        }

    }
}
