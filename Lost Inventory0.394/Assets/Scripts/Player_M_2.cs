using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_M_2 : MonoBehaviour
{
    Rigidbody rb;
    public float speed, jumpForce;
    public LayerMask groundLayer;
    public MeshCollider col;
    private float moveH, moveV;
    Vector3 movement;
    public float fallSpeed;
    public string midJump = "f";

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<MeshCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        moveH = Input.GetAxis("Horizontal");
        moveV = Input.GetAxis("Vertical");
        //print(moveH);
        //Debug.Log(moveF + moveB);

        if (rb.velocity.x > speed && moveH > 0)
        {
            moveH = 0;
        }
        if (rb.velocity.x < -speed && moveH < 0)
        {
            moveH = 0;
        }

        if (rb.velocity.z > speed && moveV > 0)
        {
            moveV = 0;
        }
        if (rb.velocity.z < -speed && moveV < 0)
        {
            moveV = 0;
        }

        //Debug.Log(movement);
        movement = new Vector3(moveH, 0, moveV);

        
        //rb.velocity = movement * speed;
        if (Input.GetKeyDown(KeyCode.Space) && (midJump == "f"))
        {
            movement.y = 2;
            midJump = "t";
        }
        else
        {
            movement.y = -0.1f;
           
        }

        if (GetComponent<Rigidbody> ().velocity.y == 0)
        {
            midJump = "f";
        }      
        
        

    }

    void FixedUpdate()
    {
        //Debug.Log(movement);

        rb.AddForce(movement * speed, ForceMode.Impulse);
    }

    void Jump()
    {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
    }
}
