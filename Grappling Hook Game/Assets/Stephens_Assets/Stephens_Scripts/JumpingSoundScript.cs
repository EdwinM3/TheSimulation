using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingSoundScript : MonoBehaviour
{

    public static AudioSource audio;
    public static AudioClip jumpSound;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            audio.PlayOneShot(jumpSound);
        }
        
             
    }
}

