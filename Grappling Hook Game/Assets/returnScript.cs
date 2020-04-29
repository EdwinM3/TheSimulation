using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class returnScript : MonoBehaviour
{
    static string lastScene;
    static string currentScene;
    private int prevSceneToLoad;

   public List<string> sceneHistory = new List<string>();
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this.transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
      
    }


    public void LoadScene(string newScene)
    {
        sceneHistory.Add(newScene);
        SceneManager.LoadScene(newScene);
    }

    public bool PreviousScene()
    {
        bool returnInt = false;
        if(sceneHistory.Count >= 2)
        {
            returnInt = true;
            sceneHistory.RemoveAt(sceneHistory.Count - 1);
            SceneManager.LoadScene(sceneHistory[sceneHistory.Count - 1]);
        }
        return returnInt;
    }



    public static void ChangeScene(string sceneName)
    {
        lastScene = currentScene;
        currentScene = sceneName;
        SceneManager.LoadScene(currentScene);
    }

    public static void LoadLastScene()
    {
        string last = lastScene;
        lastScene = currentScene;
        currentScene = last;
        SceneManager.LoadScene(currentScene);
    }
}
