using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int PlayerHealth = 30;
    public int level = 1;
    int damagae = 10;
    GameObject Canvas;
    private void Start()
    {
        Canvas = GameObject.Find("Image");
        Canvas.gameObject.SetActive(false);
        print(PlayerHealth);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Security_Guard")
        {
            Canvas.gameObject.SetActive(true);
            print("Owie!");
        }
       
       
    }

}
