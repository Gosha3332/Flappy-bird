using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buy : MonoBehaviour
{
    [SerializeField] private int skinNum;
    [SerializeField] private bool proverkaBuy;
    [SerializeField] private string saveName;
    [SerializeField] private Text priceText;
    [SerializeField] private int price;
    private void Start()
    {
        int purch = PlayerPrefs.GetInt(saveName, 0); // переменная достает из плеер префс проверку на то куплен ли скин
        if (purch == 0)
        {
            priceText.text = price + "руб";
        }
        else
        {
            priceText.text = "Продано";
            proverkaBuy = true;

        }
    }
    public void buy()
    {
        if (Money.money >= price && proverkaBuy == false)
        {
            PlayerPrefs.SetInt(saveName, 1);
            Money.money -= price;
            priceText.text = "Продано";
            proverkaBuy = true;
        }
        else if (proverkaBuy == true)
        {
            StartCoroutine(select());
        }
    }
    IEnumerator select()
    {
        string lastText = priceText.text;
        priceText.text = "Выбран";
        Money.selectSkin = skinNum;
        yield return new WaitForSeconds(0.5f);
        priceText.text = lastText;
    }
}
