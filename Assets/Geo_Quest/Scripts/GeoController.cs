using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
// when something is gray it mines its imported and not yet used

// this class inherits from MonoBehaviour class
// inheritance = extension vs. imports = Libraries
// libraries/imports allow for things like inputs, physics, and sprite renderers

public class GeoController : MonoBehaviour
{
    //=============================================
    //Variables
    //============================================

    // global
    int variableOne;
    int variableTwo = 5;
    string str1 = "Hello ";
    public int varOne = 9; // public means it can be acessed and modified by other script
    int challenge = 3;

    private Rigidbody2D rb;
    public int xSpeed = 5;
    public string nextLevel = "Scene_2";
    void Start()// Start is called before the first frame update
    {
        int variableThree = 3; // local
        string str2 = "World";
        // used for initalization
        Debug.Log("Hello World");
        // Debug is a class from unity, use for debugging and displaying
        // . is an access operater, allowing us to use functions or varibles from the debug class
        // Log() is a method from the Debug class, sends message inside the Console

        /*
         * int Integer - 1;
         * float Float = 3.14;
         * bool Boolean = true;
         * char Character = 'a';
         * string String = "hello World";
         

        variableOne = 5;
        print(variableTwo +  variableTwo);
        Debug.Log(str1 + str2);
        */

        rb = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        // runs every frame, like a function, this is where the logic goes
        // Debug.Log(challenge);
        //  challenge += 1;


        //transform.position += new Vector3(0.005f, 0, 0);

        //if(Input.GetKeyDown(KeyCode.W))
        //{
        //    transform.position += new Vector3(0, 1, 0);
        //}
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    transform.position += new Vector3(0, -1, 0);
        //}
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    transform.position += new Vector3(-1, 0, 0);
        //}
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    transform.position += new Vector3(1, 0, 0);
        //}

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
            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
        }
    }
}
