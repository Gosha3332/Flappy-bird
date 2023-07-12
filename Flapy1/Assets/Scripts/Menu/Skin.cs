using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skin : MonoBehaviour
{
    [SerializeField] private Material[] material;
    private void Start()
    {
        gameObject.GetComponent<MeshRenderer>().material = material[Money.selectSkin];
    }

}
