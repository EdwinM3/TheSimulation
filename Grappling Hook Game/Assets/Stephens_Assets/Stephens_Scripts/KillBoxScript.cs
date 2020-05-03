using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KillBoxScript : MonoBehaviour
{
    public Vector3 respawnPosition;

    public TextMeshProUGUI warningTextmeshPro;

    public GameObject reticle;

    private IEnumerator coroutine;

    public AudioSource warningSound;

    private int AmountofTime = 150;

    // Start is called before the first frame update
    void Start()
    {
        

        
    }

    // Update is called once per frame
    void Update()
    {
      if(AmountofTime < 150)
        {
            reticle.SetActive(false);
        }
      else
        {
            reticle.SetActive(true);
        }

      if(warningTextmeshPro.text.Equals("Warning ! Please turn back! :" + AmountofTime.ToString()))
        {
            warningSound.Play();
        }
        else
        {
            warningSound.Stop();
        }
    }

   void OnControllerColliderHit(ControllerColliderHit hit)
    {       
        if (hit.gameObject.tag == "Killbox")
        {
            
            StartCoroutine("OutofBounds", true);
            
            
        }
        else
        {
            
            StopCoroutine("OutofBounds");
            warningSound.Stop();
            AmountofTime = 150;

            warningTextmeshPro.text = "";
            
        }
    } 
    
    public IEnumerator OutofBounds()
    {
        
        for (int i = AmountofTime; i >= 0; i--)
        {
            yield return new WaitForSeconds(2);

            if(AmountofTime >= 0)
            {
                AmountofTime--;

                yield return new WaitForSeconds(.5f);
                warningTextmeshPro.text = "Warning ! Please turn back! :" + AmountofTime.ToString();

                yield return new WaitForSeconds(.5f);
                warningTextmeshPro.text = "";
                yield return new WaitForSeconds(.5f);
                warningTextmeshPro.text = "Warning ! Please turn back! :" + AmountofTime.ToString();
                yield return new WaitForSeconds(.5f);
            }
            else
            {
                warningTextmeshPro.text = "";
                transform.position = respawnPosition;
            }
            
                
            
        }
    }
}
