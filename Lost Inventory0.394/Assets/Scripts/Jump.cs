using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float multiplyingFall = 2.7f;
    public float jumpinglowMultiplier = 2.3f;

    Rigidbody rg;

    void Awake()
    {
        rg = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (rg.velocity.y < 0) 
        {
            rg.velocity += Vector3.up * Physics.gravity.y * (multiplyingFall - 1) * Time.deltaTime;
        }
        else if (rg.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rg.velocity += Vector3.up * Physics.gravity.y * (jumpinglowMultiplier - 1) * Time.deltaTime;
        }
    }
}
