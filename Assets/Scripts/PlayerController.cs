using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;
    public GameObject gameWonPanel;
    public float speed;
    private bool isGameWon = false;

    // Update is called once per frame
    void Update()
    {
        // This statement is to stop player movement after game is won
        if (isGameWon == true)
        {
            return;
        }
        if(Input.GetAxis("Horizontal") > 0)
        {
            rigidbody2d.velocity = new Vector2(speed , 0f);
        }
        else if(Input.GetAxis("Horizontal") < 0)
        {
            rigidbody2d.velocity = new Vector2(-speed , 0f);
        }
        else if(Input.GetAxis("Vertical") > 0)
        {
            rigidbody2d.velocity = new Vector2(0f , speed);
        }
        else if(Input.GetAxis("Vertical") < 0)
        {
            rigidbody2d.velocity = new Vector2(0f, -speed);
        }
        else if(Input.GetAxis("Vertical") == 0 && Input.GetAxis("Horizontal") == 0)
        {
            rigidbody2d.velocity = new Vector2(0f, 0f);
        }

    }

    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Door")
        {
            Debug.Log("Level Complete!!!"); 
            gameWonPanel.SetActive(true);
        }
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("Button Pressed");
    }
}
