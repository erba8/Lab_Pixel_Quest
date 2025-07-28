using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public string nextLevel = "GeoLevel_2";
    public int counter = 0;
    public int health = 3;
    public int maxHealth = 3;
    public Transform RespawnPoint;
    private PlayerUIController playerUIControl;
    private int coinsInLevel = 0;
    private AudioController audioController;

    // Start is called before the first frame update
    void Start()
    {
        coinsInLevel = GameObject.Find("Coins").transform.childCount;
        playerUIControl = GetComponent<PlayerUIController>();
        playerUIControl.UpdateHealth(health, maxHealth);
        playerUIControl.UpdateCoinText(counter + "/" + coinsInLevel);
        audioController = GetComponent<AudioController>();
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
                    audioController.PlayAudio("DeathSFX");
                    playerUIControl.UpdateHealth(health, maxHealth);
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
                    audioController.PlayAudio("CoinSFX");
                    playerUIControl.UpdateCoinText(counter +"/" + coinsInLevel);
                    Destroy(collision.gameObject);
                    break;
                }
            case "Health":
                {
                    if (health < 3)
                    {
                        health++;
                        audioController.PlayAudio("heart");
                        playerUIControl.UpdateHealth(health, maxHealth);
                        Destroy(collision.gameObject);
                    }
                    break;
                }
            case "Respawn":
                {
                    audioController.PlayAudio("checkpoint");
                   RespawnPoint.position = collision.transform.Find("Point").position;
                   break;
                }
        }
    }
}
