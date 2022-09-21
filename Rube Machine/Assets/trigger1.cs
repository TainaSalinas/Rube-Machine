using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger1 : MonoBehaviour
{


    public GameObject Cam;
    public GameObject Cam1;
    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.name == "roulette ball")
        {
            Cam.SetActive(false);
            Cam1.SetActive(true);
        }
    }
}
