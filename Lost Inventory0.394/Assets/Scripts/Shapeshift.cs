using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shapeshift : MonoBehaviour
{
    float duration = 1.5f;
    float t = 0;
    bool isReset = true;


    // Start is called before the first frame update
    void Start()
    {
        Invoke("changingColour", 4);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            
            isReset = false;
           
        }
        else
        {
            isReset = true;
        }
    }

    void changingColour()
    {
        Color shapeShift = new Color(0, 0, 0, 1);
        {
            

            if (t < 1)
            {
                t += Time.deltaTime / duration;
            }
        }
    }
}
