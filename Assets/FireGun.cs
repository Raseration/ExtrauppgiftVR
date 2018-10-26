using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class FireGun : MonoBehaviour {

    private GameObject bullet;
    private float bulletSpeed = 1000f;
    private float bulletLife = 5f;

    // Use this for initialization
    void Start ()
    {
        
    }
	
	// Update is called once per frame
	public void FireBullet()
    {
        bullet = transform.Find("Bullet").gameObject;
        bullet.SetActive(false);
        GameObject bulletClone = Instantiate(bullet, bullet.transform.position, bullet.transform.rotation) as GameObject;
        bulletClone.SetActive(true);
        Rigidbody rb = bulletClone.GetComponent<Rigidbody>();
        rb.AddForce(-bullet.transform.forward * bulletSpeed);
        Destroy(bulletClone, bulletLife);
    }
}
