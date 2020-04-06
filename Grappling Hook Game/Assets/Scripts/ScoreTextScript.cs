using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreTextScript : MonoBehaviour
{
    public TextMeshProUGUI coinTextmeshPro;
    public static int coinAmount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinTextmeshPro.text = "Amount of coins : " + coinAmount.ToString();
    }
}
