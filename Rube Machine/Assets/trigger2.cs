using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger2 : MonoBehaviour
{

    public GameObject Cam1;
    public GameObject Cam2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "roulette ball")
        {
            Cam1.SetActive(false);
            Cam2.SetActive(true);
        }
    }
}
