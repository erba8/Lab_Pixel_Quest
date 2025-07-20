using UnityEngine;

public class HW2PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    private float xSpd;
    private float ySpd;

    private float spd = 3;

    private string InputX = "Horizontal";
    private string InputY = "Vertical";
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        xSpd = Input.GetAxis(InputX);
        ySpd = Input.GetAxis(InputY);

        rb.velocity = new Vector2 (xSpd * spd, ySpd * spd);
    }
}
