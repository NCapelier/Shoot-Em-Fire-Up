using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class Enemy3Shoot : MonoBehaviour
    {
        //shoot cooldown variables
        bool canShoot = true;
        [Range(0.1f, 5f)]
        [SerializeField] float cooldownTime = 1f;
        
        void Awake()
        {
            
        }
        
        void Start()
        {
            
        }
        
        void Update()
        {
            Shoot();
        }
        
        void Shoot()
        {
            if(canShoot)
            {
                StartCoroutine(ShootCooldown());
                Instantiate(Resources.Load("Prefabs/Enemies/Tir 3 1"), gameObject.transform.position, Quaternion.identity);
                Instantiate(Resources.Load("Prefabs/Enemies/Tir 3 2"), gameObject.transform.position, Quaternion.identity);
            }
        }

        IEnumerator ShootCooldown()
        {
            canShoot = false;
            yield return new WaitForSeconds(cooldownTime);
            canShoot = true;
        }
        
    }
}