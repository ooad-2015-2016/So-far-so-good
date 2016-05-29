using UnityEngine;
using System.Collections;

public class GameBehaviour : MonoBehaviour {

    public GameObject kamen;
    public GameObject cigla;
    public GameObject coin;

    float timer = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer > 0.4)
        {
            int obj = Random.Range(0, 2);
            if(obj == 0)
            {
                Instantiate(kamen, new Vector3(Random.Range(-8.6f, 8.6f), 5.5f, 0), Quaternion.identity);
            }
            if(obj == 1)
            {
                Instantiate(cigla, new Vector3(Random.Range(-8.6f, 8.6f), 5.5f, 0), Quaternion.identity);
            }
            if(obj == 2)
            {
                Instantiate(coin, new Vector3(Random.Range(-8.6f, 8.6f), 5.5f, 0), Quaternion.identity);
            }
            timer = 0;
        }
	}
}
