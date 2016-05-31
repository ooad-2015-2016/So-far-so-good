using UnityEngine;
using System.Collections;

public class PodBehaviour : MonoBehaviour {

    public GameObject[] objekti;
    GameObject gameO;
    public int brojSpawna = 1;
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.gameObject.tag == "kamen")
        {
            gameO = Instantiate(col.gameObject.gameObject, new Vector3(Random.Range(-8.2f, 8.2f), 6.5f, 0), Quaternion.identity) as GameObject;
            Destroy(col.collider.gameObject);

        }
        if(col.gameObject.gameObject.tag =="novcic")
        {
            gameO = Instantiate(col.gameObject.gameObject, new Vector3(Random.Range(-8.2f, 8.2f), 6.5f, 0), Quaternion.identity) as GameObject;
            Destroy(col.collider.gameObject);
        }
        if(col.gameObject.gameObject.tag == "cigla")
        {
            gameO = Instantiate(col.collider.gameObject, new Vector3(Random.Range(-8.2f, 8.2f), 6.5f, 0), Quaternion.identity) as GameObject;
            Destroy(col.collider.gameObject);
        }
        
    }
}
