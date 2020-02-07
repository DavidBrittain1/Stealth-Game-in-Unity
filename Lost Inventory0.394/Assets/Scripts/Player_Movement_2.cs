using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement_2 : MonoBehaviour
{
    Rigidbody rb;
    public float speed, jumpForce;
    public LayerMask groundLayer;
    public MeshCollider col;
    private float moveF, moveB;
    Vector3 movement;
    public float fallSpeed;
    public float multiplyingFall = 2.7f;
    public float jumpinglowMultiplier = 2.3f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<MeshCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        moveF = Input.GetAxis("Horizontal");
        moveB = Input.GetAxis("Vertical");
        //Debug.Log(moveF + moveB);
        movement = new Vector3(moveF, 0, moveB);
        rb.AddForce(movement * speed);
        rb.velocity = movement * speed;
        if (Input.GetKeyDown(KeyCode.Space))
        {
          
            Jump();
        }
        else
        {
            rb.velocity = new Vector3(0f, -1f, 0f) * speed;
            rb.AddForce(new Vector3(0f, -1f, 0f) * fallSpeed, ForceMode.Force);
        }

       
    }
    
    void Jump()
    {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
    }

    

   

}
