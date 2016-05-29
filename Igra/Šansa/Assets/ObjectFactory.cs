using UnityEngine;
using System.Collections;

public class ObjectFactory : MonoBehaviour {

    private int y = 7;
    private int x;
    GameObject gameObj;
	// Use this for initialization

        public ObjectFactory(GameObject o)
    {
        gameObj = o;
    }
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
	       
	}

    void Generisi(GameObject o)
    {
        x = Random.Range(-5, 5);
        
        GameObject newParent = GameObject.Find("Background");
        Vector3 newPos = new Vector3(x, y, 0);
        GameObject obj = Instantiate(o, newPos, Quaternion.identity) as GameObject;
        obj.transform.parent = newParent.transform;
    }
}
