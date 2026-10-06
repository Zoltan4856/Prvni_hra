using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OpenParachute()
    {
        rb.linearDamping = 20;
    }

    void Update()
    {
        if (Input.GetButton("Space"))
            OpenParachute();
    }
}