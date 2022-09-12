using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameManager gm;
    //private int health;
    public bool woodandknife = false;
    // Start is called before the first frame update
    void Start()
    {
        //health = 3;
        gm = GameManager.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Wood"))
        {
            woodandknife = true;
            rb.velocity = Vector2.zero;
            transform.parent = other.transform;


        }
        // if (other.gameObject.CompareTag("Knife"))
        // {
        //     if (other.gameObject.GetComponent<Knife>().attachedtoWood == true)
        //     {
        //         rb.velocity = Vector2.zero;
        //         rb.gravityScale = 1;
        //         Debug.Log("error");
        //     }
        // }
        if (other.gameObject.CompareTag("Knife") && woodandknife == true)
        {
            gm.health -= 1;
            if (gm.health > 0)
            {
                Destroy(gameObject);
                Destroy(other.gameObject);
                Debug.Log(gm.health);
                gm.Score();
            }
            else
            {
                //restart;
                Debug.Log(gm.health);
                Debug.Log("game over");

                gm.RestartGame();
                //gameover
            }


        }
        if (other.gameObject.CompareTag("Apple"))
        {
            Destroy(other.gameObject);
            gm.NextLevel();
        }
    }
}
