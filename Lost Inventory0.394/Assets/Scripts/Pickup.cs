using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pickup : MonoBehaviour
{
    public Transform Dest;
    GameObject The_Key;
    GameObject Door;
    AudioSource audioData;
    SphereCollider colKey;
    public BoxCollider colDoor;
    public static bool itemPicked = false;
    //declare a radius field
    //public int radius;


        //if the player is in the radius and presses e pickup the key
        

    private void Start()
    {
        //audioData = GetComponent<AudioSource>();
        The_Key = GameObject.Find("The_Key");
        audioData = The_Key.GetComponent<AudioSource>();
        Door = GameObject.Find("DoorV1");

        if (this.gameObject.name == "DoorV1")
        {
            colDoor = this.gameObject.GetComponent<BoxCollider>();
        }

        if (this.gameObject.name == "The_Key")
        {
            colKey = this.gameObject.GetComponent<SphereCollider>();
        }
        
    }
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

   

    public void OnTriggerStay(Collider col)
    {
        //if (col.name == "Player" && Input.GetKeyDown(KeyCode.E) && colKey.gameObject.name == "The_Key")
        //{
        //   Debug.Log("Player is near me");
        //    GameObject.Find("The_Key").transform.localScale = new Vector3(0, 0, 0);
        //    audioData.Play(0);
        //    //The_Key.GetComponent<BoxCollider>().enabled = false;
        //    //The_Key.GetComponent<SphereCollider>().enabled = false;
        //    itemPicked = true;
        
        //}
        if (col.name == "Player" && Input.GetKeyDown(KeyCode.E) && this.gameObject.name == "The_Key")
        {
           Debug.Log("Player is near me");
            GameObject.Find("The_Key").transform.localScale = new Vector3(0, 0, 0);
            audioData.Play(0);
            //The_Key.GetComponent<BoxCollider>().enabled = false;
            //The_Key.GetComponent<SphereCollider>().enabled = false;
            itemPicked = true;
        
        }

        //if (itemPicked = true && col.name == "Player" && Input.GetKeyDown(KeyCode.E) && colDoor.name == "DoorV1")
        //{
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //}
        if (itemPicked && col.name == "Player" && Input.GetKeyDown(KeyCode.E) && this.gameObject.name == "DoorV1")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
