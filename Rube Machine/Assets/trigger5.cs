using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger5 : MonoBehaviour
{

    public GameObject Cam4;
    public GameObject Cam5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "poker chip roll")
        {
            Cam4.SetActive(false);
            Cam5.SetActive(true);
        }
    }
}
