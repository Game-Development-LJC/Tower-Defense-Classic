using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI GameClosingCountdown;
    
    private int time = 6;
    
    void Start () {
        InvokeRepeating("OutputTime", 1f, 1f);  //1s delay, repeat every 1s
    }

    void OutputTime()
    {
        time--;
        if (time <= 0)
        {
            time = 0;
        }
        GameClosingCountdown.text = "Game sluit af in: " + time;

        if (time == 0)
        {
            Debug.Log("Game sluit af");
            Application.Quit();
        }
    }
    
}
