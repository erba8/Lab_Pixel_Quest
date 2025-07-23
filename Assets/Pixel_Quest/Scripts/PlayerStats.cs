using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public string nextLevel = "GeoLevel_2";
    private int counter = 0;
    private int health = 3;
    public Transform RespawnPoint;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Debug.Log("hit");
        //Debug.Log(collision.tag);

        switch (collision.tag)
        {
            case "Death":
                {
                    //Debug.Log("Player Has Died");
                    //string thisLevel = SceneManager.GetActiveScene().name;
                    //
                    health--;
                    if (health <= 0)
                    {
                        string thisLevel = SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(thisLevel);
                    }
                    else
                    {
                        transform.position = RespawnPoint.position;
                    }
                    break;
                }
            case "Finish":
                {
                    string nextLevel = collision.GetComponent<LevelGoal>().nextLevel;
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
            case "Coin":
                {
                    counter++;
                    Destroy(collision.gameObject);
                    break;
                }
            case "Health":
                {
                    if (health < 3)
                    {
                        health++;
                        Destroy(collision.gameObject);
                    }
                    break;
                }
            case "Respawn":
                {
                   RespawnPoint.position = collision.transform.Find("Point").position;
                   break;
                }
        }
    }
}
