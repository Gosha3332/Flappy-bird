using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    [SerializeField] private AudioSource zvuk;
    private void OnTriggerEnter(Collider collision)
    {
        Score.score++;
        zvuk.Play();
    }
}
