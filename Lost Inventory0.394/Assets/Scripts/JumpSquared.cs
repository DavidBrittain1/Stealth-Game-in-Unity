using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSquared : MonoBehaviour
{
    private CharacterController col;

    private float verticalVel;
    private float grav = 14.0f;
    private float jumpF = 10.0f;

    private void Start()
    {
        col = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (col.isGrounded)
        {
            verticalVel = -grav * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                verticalVel = jumpF;
            }
        }
        else
        {
            verticalVel -= grav * Time.deltaTime;
        }

        Vector3 moveVec = new Vector3(0, verticalVel, 0);
        col.Move(moveVec * Time.deltaTime);
    }

}
