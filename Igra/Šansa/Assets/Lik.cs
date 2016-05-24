using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Lik : MonoBehaviour {

    public int zivoti = 3;
    public float brzina = 3;
    public int health = 100;
    public int poeni = 0;
    public int brojUnistenihObjekata;
    public int brojSpawn = 1;
    public GameObject[] objekti;
    bool desno = true;
    // Use this for initialization
    void Start()
    {
        objekti = new GameObject[3];

        Vector2 pocetnaPozicija = this.transform.position;
        pocetnaPozicija.x = 0;
        pocetnaPozicija.y = -2.6f;
        this.transform.position = pocetnaPozicija;
        brojUnistenihObjekata = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (this.transform.position.x > 360 && this.transform.position.x < -360)
            return;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector2 newPosition = this.transform.position;
            newPosition.x += brzina * Time.deltaTime;
            this.transform.position = newPosition;
            if (!desno)
            {
                this.transform.Rotate(new Vector3(0, 180, 0));
                desno = true;
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector2 newPosition = this.transform.position;
            newPosition.x -= brzina * Time.deltaTime;
            this.transform.position = newPosition;

            if (desno)
            {
                this.transform.Rotate(new Vector3(0, 180, 0));
                desno = false;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.gameObject.tag == "kamen")
        {
            Destroy(col.collider.gameObject);
            health -= 10;
            brojUnistenihObjekata++;
        }
        if (col.gameObject.gameObject.tag == "novcic")
        {
            Destroy(col.collider.gameObject);
            poeni += 10;
            brojUnistenihObjekata++;
        }
        if (col.gameObject.gameObject.tag == "cigla")
        {
            Destroy(col.collider.gameObject);
            poeni -= 10;
            brojUnistenihObjekata++;
        }

        if(health <= 0)
        {
            zivoti--;
        }
        

    }
    public float getBrzina()
    {
        return brzina;
    }

}
