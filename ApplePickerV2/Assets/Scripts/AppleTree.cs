using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppleTree : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject applePrefab;
    public float speed = 5f;
    public float leftAndRightEdge = 10f;
    public float chanceToChangeDirection= 0.1f;
    public float secondsBetweenAppleDrops = 1f;
    
    public GameObject orangePrefab;
    public float secondsBetweenOrangeDrops = 2f;

    void Start()
    {
        InvokeRepeating("DropeApple", 2f, secondsBetweenAppleDrops);
        InvokeRepeating("DropeOrange", 2f, secondsBetweenOrangeDrops);

        /*for (int i = 0; i < 3; ++i)
        {
            GameObject basquet = Instantiate(basquetPrefab) as GameObject;
            basquet.transform.position = new Vector3(0, -15 + i, 0);
        }*/

    }

    void DropeApple()
    {
        GameObject apple = Instantiate(applePrefab) as GameObject;
        apple.transform.position = transform.position;
    }
    void DropeOrange()
    {
        GameObject orange = Instantiate(orangePrefab) as GameObject;
        orange.transform.position = new Vector3(transform.position.x, transform.position.y+1, 0);
    }

    void Update()
    {
        int rndVel = Random.Range(1, 3);
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime * rndVel;
        transform.position = pos;

        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
        else if (Random.value < chanceToChangeDirection)
        {
            speed *= 1;

        }

       /* if (GameObject.FindWithTag("basquet") == null)
        {

            Time.timeScale = 0;
            endText.text = "Game Over";
        }*/
    }

    


    }
