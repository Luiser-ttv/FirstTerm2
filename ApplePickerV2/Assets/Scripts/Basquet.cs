using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Basquet : MonoBehaviour
{
    [Header("Set dinamically")]
    public TMP_Text scoreGT;
    public TMP_Text scoreOrange;
    private void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        GameObject scoreGOrange = GameObject.Find("ScoreCounterO");
        scoreGT = scoreGO.GetComponent<TMP_Text>();
        scoreOrange = scoreGOrange.GetComponent<TMP_Text>();
        scoreGT.text = "0";
        scoreOrange.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z= -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject collidedWith = collision.gameObject;
        if (collidedWith.tag == "apple")
        {
            //Debug.Log("works");
            Destroy(collidedWith);
            int score = int.Parse(scoreGT.text);
            score += 100;
            scoreGT.text = score.ToString();
        }
        if (collidedWith.tag == "orange")
        {
            //Debug.Log("works");
            Destroy(collidedWith);
            int scoreO = int.Parse(scoreOrange.text);
            scoreO += 100;
            scoreOrange.text = scoreO.ToString();
        }
        

            ///if (score > HighScore.score)
           // {
              //  HighScore.score = score;
           // }
        }
    }


