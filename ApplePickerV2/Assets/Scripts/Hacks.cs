using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacks : MonoBehaviour
{
    private GameObject appleHack;
    private GameObject orangeHack;
    private Vector3 applePosHack;
    private Vector3 orangePosHack;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        appleHack = GameObject.FindGameObjectWithTag("apple");
        orangeHack = GameObject.FindGameObjectWithTag("orange");
        if (GameObject.FindGameObjectWithTag("apple") != null && GameObject.FindGameObjectWithTag("apple").transform.position.y < -5)
        {
            applePosHack = appleHack.transform.position;
            Vector3 pos = this.transform.position;
            pos.x = applePosHack.x;
            this.transform.position = pos;
        }
        else if (GameObject.FindGameObjectWithTag("orange") != null && GameObject.FindGameObjectWithTag("orange").transform.position.y < -5)
        {
            orangePosHack = orangeHack.transform.position;
            Vector3 pos = this.transform.position;
            pos.x = orangePosHack.x;
            this.transform.position = pos;
        }
        
    }
}
