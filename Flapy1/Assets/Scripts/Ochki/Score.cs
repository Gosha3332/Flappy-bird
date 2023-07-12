using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public static int  NewMoney;
    private void Start()
    {        
        score = 0;
        NewMoney = PlayerPrefs.GetInt("NewMoney");
    }

    private void FixedUpdate()
    {
        PlayerPrefs.SetInt("NewMoney",NewMoney);
        NewMoney = score;
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
    }
}
