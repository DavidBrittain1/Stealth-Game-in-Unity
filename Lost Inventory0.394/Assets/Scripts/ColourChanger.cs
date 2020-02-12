using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChanger : MonoBehaviour
{
    Renderer colourRend;
    double t = 0;
    [SerializeField] Material playerColour; 

    // Start is called before the first frame update
    void Start()
    {
        GameObject Player = GameObject.Find("Player");
        colourRend = GetComponent<Renderer>();
    }
    void material()
    {
      
    }
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            // Next time on Dragonball Z
            t += Time.deltaTime;
       
            if (t == 4)
            {
                colourRend.material.SetColor("_Color", Color.gray);
            }
         

        }
        else
        {
            t = 0;
            colourRend.material.SetColor("_Color", playerColour.color);
        }
    }

   
}
