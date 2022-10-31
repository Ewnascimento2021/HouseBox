using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePrefs : MonoBehaviour
{

    private int score;
    private int scoreAtual;

    // Start is called before the first frame update
    void Start()
    {
        score = HUDController.Instance.gameScore;
    }
    private void Update()
    {
        
    }

    private void BestPotuation()
    {
       
    }
}
