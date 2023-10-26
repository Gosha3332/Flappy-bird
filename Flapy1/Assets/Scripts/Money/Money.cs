using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    [SerializeField] private Text moneyText;
    public static int money;
    public static int selectSkin;

    private void Start()
    {
        selectSkin = PlayerPrefs.GetInt("selectSkin");
        money = PlayerPrefs.GetInt("money");
        moneyText.text = PlayerPrefs.GetString("MoneyText");
        money += Score.NewMoney;
        PlayerPrefs.SetInt("money", money);
        moneyText.text = money.ToString();
        PlayerPrefs.SetInt("selectSkin", selectSkin);
    }
}
