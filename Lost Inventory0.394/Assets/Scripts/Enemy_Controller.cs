using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Controller : MonoBehaviour
{
    void Start()
    {

    }
    [SerializeField] public float Enemy_Movement_Speed;
    public GameObject[] Security_Guard;
    public GameObject player;

    // Update is called once per frame
    void FixedUpdate()
    {
        GameObject SecurityGuardObject = GameObject.Find("Security_Guard");
        GameObject PlayerObject = GameObject.Find("Player");

        float distance = Vector3.Distance(SecurityGuardObject.transform.position, PlayerObject.transform.position);
        if (distance < 50)
        {
            transform.LookAt(PlayerObject.transform);
            transform.position += transform.forward * Enemy_Movement_Speed * Time.deltaTime;
        }
    }
}
