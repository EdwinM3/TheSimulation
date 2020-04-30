using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{

    public AudioSource coin;
    // Start is called before the first frame update
    void Start()
    {
        coin = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(90 * Time.deltaTime,0 ,0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            //other.GetComponent<PlayerScript>().points++;
            ScoreTextScript.coinAmount += 1;
            Destroy(gameObject, 0.5f);

            coin.Play();

        }
        else
        {
            coin.Stop();
        }

        gameObject.GetComponent<ParticleSystem>().Play();
    }
}
