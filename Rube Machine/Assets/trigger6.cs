using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger6 : MonoBehaviour
{

    public GameObject Cam5;
    public GameObject Cam6;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "chalk")
        {
            Cam5.SetActive(false);
            Cam6.SetActive(true);
        }
    }
}
