using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject Magazin;
    [SerializeField] private GameObject menu;

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }
    public void loadMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
    public void LoadMagazin()
    {
        Magazin.SetActive(true);
    }

    public void LoadMenu()
    {
        Magazin.SetActive(false);
        menu.SetActive(true);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
