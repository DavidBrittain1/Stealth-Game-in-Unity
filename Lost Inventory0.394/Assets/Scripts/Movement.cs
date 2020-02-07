using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float XDirection, YDirection;
    Rigidbody ridb;
    [SerializeField] float speed;
    bool jump;
    void Start()
    {
        ridb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        XDirection = Input.GetAxis("Horizontal");
        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetButtonUp("Jump"))
        {
            jump = false;
        }

        if (jump)
        {
            YDirection = 15f;
        }
        else 
        {
            YDirection = -15f;
        }
        ridb.velocity = new Vector3(XDirection*speed, YDirection, 0f);
    }
}
