using UnityEngine;

public class HW2PlayerDie : MonoBehaviour
{
    public GameObject endPanel;
    private string enemy = "Enemy";

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == enemy)
        {
            endPanel.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
