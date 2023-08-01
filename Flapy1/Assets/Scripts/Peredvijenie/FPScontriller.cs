using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPScontriller : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float speed = 1f;

    [SerializeField] private Vector3 impulse = new Vector3(0,7,0);
    //[SerializeField] private float yscorenie = 4f;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(-1 * speed, _rigidbody.velocity.y, 0);
    }
    public void Jampforse()
    {
        //_rigidbody.AddForce(impulse.normalized * yscorenie, ForceMode.Impulse);
        _rigidbody.velocity = impulse;
    }


}
