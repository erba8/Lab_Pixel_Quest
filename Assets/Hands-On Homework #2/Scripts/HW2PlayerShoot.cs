using UnityEngine;

public class HW2PlayerShoot : MonoBehaviour
{
    public GameObject preFab;
    public GameObject preFab2;
    public Transform bulletTrash;
    public Transform bulletSpawn;

    private bool canShoot = true;
    private bool canShoot2 = true;
    private const float Timer = 0.5f;
    private float currTimer = 0.5f;
    private const float Timer2 = 0.9f;
    private float currTimer2 = 0.9f;
    public void Update()
    {
        TimerMethod();

        //shooting
        if (Input.GetKeyUp(KeyCode.Mouse0) && canShoot)
        {
            GameObject bullet = Instantiate(preFab, bulletSpawn.position, Quaternion.identity);

            bullet.transform.SetParent(bulletTrash);

            canShoot = false;
        }

        if (Input.GetKeyUp(KeyCode.Mouse1) && canShoot2)
        {
            GameObject bullet = Instantiate(preFab2, bulletSpawn.position, Quaternion.identity);
            Debug.Log("FFFF");
            bullet.transform.SetParent(bulletTrash);

            canShoot = false;
        }
     }
    private void TimerMethod()
    {
        if (!canShoot)
        {
            currTimer -= Time.deltaTime;

            if (currTimer < 0)
            {
                canShoot = true;
                currTimer = Timer;
            }
        }

        if (!canShoot2)
        {
            currTimer2 -= Time.deltaTime;

            if (currTimer2 < 0)
            {
                canShoot = true;
                currTimer2 = Timer2;
            }
        }
    }
}
