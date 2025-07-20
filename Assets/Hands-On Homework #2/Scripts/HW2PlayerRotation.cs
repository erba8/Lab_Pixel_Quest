using UnityEngine;

public class HW2PlayerRotation : MonoBehaviour
{
    private Camera cam;

    private string CamName = "Game_Camera";

    private Vector3 posMouse;

    private void Start()
    {
        cam = GameObject.Find(CamName).GetComponent<Camera>();
    }

    private void Update()
    {
        posMouse = cam.ScreenToWorldPoint(Input.mousePosition);

        Vector3 pos = posMouse - transform.position;

        float rotz = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rotz - 90);
    }
}
