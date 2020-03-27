using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeSetterLevel : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        audioSource.volume = PlayerPrefs.GetFloat("MusiVolu", audioSource.volume);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
