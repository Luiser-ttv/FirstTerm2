using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Limit : MonoBehaviour
{
    
    public GameObject basquetPrefab;
    public int numBasquets = 3;
    public float basquetBottom = -15f;
    public float basquetSpacingY = 2f;
    public List<GameObject> basquetList;
    public  TMP_Text endText;
    

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numBasquets; ++i)
        {
            GameObject basquet = Instantiate<GameObject>(basquetPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basquetBottom + (basquetSpacingY * i);
            basquet.transform.position = pos;
            basquetList.Add(basquet);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AppleDestroyed()
    {
        
        //GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("apple");

        
        /*foreach (GameObject tGO in tAppleArray)
        {
            Destroy(tGO);
        }*/
        int basquetIndex = basquetList.Count - 1;
            GameObject basquet = basquetList[basquetIndex];
            basquetList.RemoveAt(basquetIndex);
            Destroy(basquet);
        if (basquetList.Count == 0)
        {
            Time.timeScale = 0;
            endText.text = "Game Over";
        }

    }
    public void OrangeDestroyed()
    {
        
        //GameObject[] tOrangeArray = GameObject.FindGameObjectsWithTag("orange");

        
        /*foreach (GameObject tGO in tAppleArray)
        {
            Destroy(tGO);
        }*/
        int basquetIndex = basquetList.Count - 1;
            GameObject basquet = basquetList[basquetIndex];
            basquetList.RemoveAt(basquetIndex);
            Destroy(basquet);
        if (basquetList.Count == 0)
        {
            Time.timeScale = 0;
            endText.text = "Game Over";
            if (Input.GetKeyDown("space"))
            {
                //Debug.Log("works");
                SceneManager.LoadScene(0);
            }

        }
    }
    /*
    private void OnCollisionEnter(Collision collision)
    {
        
        GameObject collidedWith = collision.gameObject;
        if (collidedWith.tag == "apple")
        {
            /*for (int i = 0; i < 1; ++i)
        {
            Destroy (GameObject.FindWithTag("basquet"));
        }*/
            //Destroy (GameObject.FindWithTag("apple"));

        //}
    //}

}
