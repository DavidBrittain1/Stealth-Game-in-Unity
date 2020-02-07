using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelOne : MonoBehaviour
{
    public Transform Dest;
    void OnMouseDown()
    {
        //GameObject.Find("The_Key").transform.localScale = new Vector3(0, 0, 0);
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = Dest.position;
        this.transform.parent = GameObject.Find("Destination").transform;
    }

    void OnMouseUp()
    {
        //Applying Gravity and making a box collider active
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<BoxCollider>().enabled = true;

    }



    private void OnTriggerStay(Collider col)
    {

        //Debug.Log("It works");
        if (col.name == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }

        
    }
    }
