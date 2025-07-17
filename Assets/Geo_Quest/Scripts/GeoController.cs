using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GeoController : MonoBehaviour
{
    //=============================================
    //Variables
    //============================================


    private Rigidbody2D rb;
    public int xSpeed = 5;
    public string nextLevel = "Level_2";
    public string lastLevel = "Level_3";
    public string end = "End";
    public SpriteRenderer sr;


    void Start()// Start is called before the first frame update
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
           rb.velocity += new Vector2(-1, rb.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
           rb.velocity += new Vector2(1, rb.velocity.y);
        }

        float xInput = Input.GetAxis("Horizontal");
        //Debug.Log(xInput);
        rb.velocity = new Vector2 (xInput* xSpeed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ChangeColor(Color.cyan);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ChangeColor(Color.yellow);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ChangeColor(Color.blue);
        }
    }

    private void ChangeColor(Color newColor)
    {
        sr.color = newColor; 
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Debug.Log("hit");
        //Debug.Log(collision.tag);

        switch (collision.tag)
        {
            case "Win":
                {
                    break;
                }
            case "Lose":
                {
                    break;
                }
            case "Death":
                {
                    Debug.Log("Player Has Died");
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                }
            case "Water":
                {
                    nextLevel = "Level_2";
                    SceneManager.LoadScene(nextLevel);
                    break;
                }

            case "Finish":
                {
                    lastLevel = "Level_3";
                    SceneManager.LoadScene(lastLevel);
                    break;
                }
            case "Goal":
                {
                    end = "End";
                    SceneManager.LoadScene(end);
                    break;
                }
        }
    }
}
