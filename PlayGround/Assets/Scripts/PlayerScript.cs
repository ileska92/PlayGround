using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 10;
    public GameObject projectile;
    public GameObject bulletSpawner;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //---Player Movement---//
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(hor, ver, 0)* speed * Time.deltaTime);

        //---Projectile Spawning---//
        if(Input.GetButtonDown("Fire1"))
        {
            InvokeRepeating("Shoot", 0, 0.1f);
        }

        if(Input.GetButtonUp("Fire1"))
        {
            CancelInvoke();
        }

        //---Targeting---//
        bulletSpawner.transform.LookAt(target);
        
    }

    void Shoot()
    {
        Instantiate(projectile, bulletSpawner.transform.position, bulletSpawner.transform.rotation);
    }
}
