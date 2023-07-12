using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skin : MonoBehaviour
{
    [SerializeField] private Material Defolt;
    [SerializeField] private Material Eloy;
    [SerializeField] private Material Blue;
    [SerializeField] private Material white;

    private void Start()
    {
        if (Money.selectSkin == 1)
        {
            gameObject.GetComponent<MeshRenderer>().material = Eloy;
        }
        else if (Money.selectSkin == 2)
        {
            gameObject.GetComponent<MeshRenderer>().material =  Blue;
        }
        else if (Money.selectSkin == 3)
        {
            gameObject.GetComponent<MeshRenderer>().material =  white;
        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().material =  Defolt;
        }
    }

}
