using UnityEngine;
using System.Collections;

public class PodBehaviour : MonoBehaviour {

    public GameObject[] objekti;
    public int brojSpawna = 1;
    // Use this for initialization
    void Start () {
        objekti = new GameObject[3];/*
        objekti[0] = GameObject.FindGameObjectWithTag("kamen");
        objekti[1] = GameObject.FindGameObjectWithTag("novcic");
        objekti[2] = GameObject.FindGameObjectWithTag("cigla");*/

    }
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.gameObject.tag == "kamen")
        {
            Destroy(col.collider.gameObject);
        }
        if(col.gameObject.gameObject.tag =="novcic")
        {
            Destroy(col.collider.gameObject);
        }
        if(col.gameObject.gameObject.tag == "cigla")
        {
            Destroy(col.collider.gameObject);
        }
        
    }
}
