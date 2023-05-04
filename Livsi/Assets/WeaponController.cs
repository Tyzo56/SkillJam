using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [SerializeField] Transform shootPoint;
    [SerializeField] float shootPower;
    [SerializeField] GameObject bulletPrefab;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           GameObject Bullet = Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);
            Bullet.GetComponent<Rigidbody>().AddForce(-transform.right * shootPower);
        }
    }
}
