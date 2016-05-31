using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Assets.Classes;

public class LikBehaviour : MonoBehaviour {
    public Lik lik;
    Cigla cigla;
    Kamen kamen;
    Novac novac;

    public Text textScore;
    public Text textHealth;
    public Text textLives;

    public int zivoti = 3;
    public float brzina = 4f;
    public float pomak = 0.0001f;
    public int health = 100;
    public int poeni = 0;
    public int brojUnistenihObjekata;
    public int brojSpawn = 1;

    public Canvas gameOver;
    public Canvas kviz;


    bool desno = true;
    // Use this for initialization
    void Start()
    {
        lik = new Lik(zivoti, health, brzina);
        cigla = new Cigla("cigla", -50);
        kamen = new Kamen("kamen", -20);
        novac = new Novac("novac", 10);
        textScore.text = "Poeni: 0";

        gameOver.enabled = false;
        kviz.enabled = false;  
        Vector2 pocetnaPozicija = this.transform.position;
        pocetnaPozicija.x = 0;
        pocetnaPozicija.y = -4.1f;
        this.transform.position = pocetnaPozicija;
        brojUnistenihObjekata = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (this.transform.position.x > 7.5 && this.transform.position.x < -7.5)
            return;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector2 newPosition = this.transform.position;
            newPosition.x += lik.getSpeed() * Time.deltaTime*4;
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
            newPosition.x -= lik.getSpeed() * Time.deltaTime*4;
            this.transform.position = newPosition;

            if (desno)
            {
                this.transform.Rotate(new Vector3(0, 180, 0));
                desno = false;
            }
        }
        textScore.text = "Score: " + lik.getPoeni();
        textHealth.text = "Health: " + lik.getHealth();
        textLives.text = "Lives: " + lik.getLives();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.gameObject.tag == "kamen")
        {
            Instantiate(col.collider.gameObject, new Vector3(Random.Range(-8.5f, 8.5f), 5.5f, 0), Quaternion.identity);
            Destroy(col.collider.gameObject);
            lik.changeHealth(kamen.getDamage());
           
            brojUnistenihObjekata++;
        }
        if (col.gameObject.gameObject.tag == "novcic")
        {
            Instantiate(col.collider.gameObject, new Vector3(Random.Range(-8.5f, 8.5f), 5.5f, 0), Quaternion.identity);
            Destroy(col.collider.gameObject);
            lik.addPoints(5);
        }
        if (col.gameObject.gameObject.tag == "cigla")
        {
            Instantiate(col.collider.gameObject, new Vector3(Random.Range(-8.5f, 8.5f), 5.5f, 0), Quaternion.identity);
            Destroy(col.collider.gameObject);
            lik.changeHealth(cigla.getDamage());
            brojUnistenihObjekata++;

        }

        if(poeni == 100)
        {
            
        }

        if(lik.getHealth() <= 0)
        {
            if(lik.umro())
            {
                gameOver.enabled = true;
                Time.timeScale = 0;
            } else
            {
                lik.setHealth(100);
            }
        }
        
    }

    public float getBrzina()
    {
        return brzina;
    }

    public void quit()
    {
        Application.Quit();
    }

    public void startNew()
    {
        Time.timeScale = 1;
        Application.LoadLevel(0);
    }

}
