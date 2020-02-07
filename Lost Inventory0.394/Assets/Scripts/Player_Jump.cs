using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Player_Jump : MonoBehaviour
{
    Rigidbody rb;
    //public float speed, jumpForce;
    //public LayerMask groundLayer;
    //public MeshCollider col;
    //private float moveF, moveB;
    //Vector3 movement;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //col = GetComponent<MeshCollider>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
        }
       
        //rb.AddForce(movement * speed);
        //Jump();
    }
    
    //void Jump()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    //    }
    //}
}
