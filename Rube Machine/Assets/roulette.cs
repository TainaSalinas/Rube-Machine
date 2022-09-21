using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class roulette : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.name == "roulette ball")
        {          
            transform.Rotate(new Vector3(0, 0,-0.2f), Space.Self);
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "roulette ball")
        {
            transform.Rotate(new Vector3(0, 0, -0.1f), Space.Self);
        }
    }
}
