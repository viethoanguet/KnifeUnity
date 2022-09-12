using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int health = 3;
    public Text score;
    //public GameObject wood;

    void Start()
    {
        //wood = gameObject.GetComponent<GameObject>();
        // wood = GameObject.FindObjectOfType<GameObject>();
        Score();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Score()
    {
        score.text = "Health: " + health.ToString();
    }
    public void RestartGame()
    {
        if (health == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        // wood.speed = 100;
        // Debug.Log(wood.speed);
    }
}
