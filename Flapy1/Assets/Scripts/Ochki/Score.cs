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
        InvokeRepeating("Save", 0.5f, 0.5f);
    }

    private void FixedUpdate()
    {               
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
    }
    public void Save()
    {
        PlayerPrefs.SetInt("NewMoney",NewMoney);
        NewMoney = score; 
    }
}
