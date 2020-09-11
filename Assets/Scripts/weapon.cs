using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weapon : MonoBehaviour
{
  
    public Transform firePoint;
    public GameObject bulletPrefab;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
         
            Shoot();

            void Shoot()
            {
                //shooting in project settings "Fire1"
                Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            }

        }
    }
}

