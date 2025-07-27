using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escape : MonoBehaviour
{
    // Start is called before the first frame update

    public string nextLevel = "HW3_Scene 2";
    public SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Goal":
                {
                    nextLevel = "HW3_Scene 2";
                    SceneManager.LoadScene(nextLevel);
                    break;
                }

        }
    }
}
