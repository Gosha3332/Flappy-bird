using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menedjer : MonoBehaviour
{
    [SerializeField] private Behaviour script;
    [SerializeField] private GameObject Deat;
    [SerializeField] private GameObject Score;

    private void Start()
    {
        Time.timeScale = 1f;
        Score.SetActive(true);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<NewBehaviourScript>())
        {
            script.enabled = (false);
            Invoke("Ymer",1f);
        }
    }
    private void Ymer()
    {
        Time.timeScale = 0f;
        Deat.SetActive(true);
        Score.SetActive(false);
    }
}
