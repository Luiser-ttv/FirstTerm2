using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float bottomY= -20;
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("orange"))
        {
            float speed = -6f;
            Vector3 pos = transform.position;
            pos.y += speed * Time.deltaTime;
            transform.position = pos;

        }

        if (transform.position.y < bottomY && GameObject.FindWithTag("apple"))
        {
                Destroy(this.gameObject);
                Limit apScript = Camera.main.GetComponent<Limit>();
                apScript.AppleDestroyed();
            
        }else if (transform.position.y < bottomY && GameObject.FindWithTag("orange"))
        {
                Destroy(this.gameObject);
                Limit apScript = Camera.main.GetComponent<Limit>();
                apScript.OrangeDestroyed();
            
        }
        

    }

    
    
}
