using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningSound : MonoBehaviour
{

    public AudioSource warningSound;
    // Start is called before the first frame update
    void Start()
    {
        warningSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            warningSound.Play();
        }
        else
        {
            warningSound.Stop();
        }
    }
}
