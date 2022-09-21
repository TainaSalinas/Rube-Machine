using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger3 : MonoBehaviour
{

    public GameObject Cam2;
    public GameObject Cam3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "stripe")
        {
            Cam2.SetActive(false);
            Cam3.SetActive(true);
        }
    }
}
