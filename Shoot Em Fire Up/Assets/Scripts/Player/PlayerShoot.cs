using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class PlayerShoot : MonoBehaviour
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
            if(Input.GetKey(KeyCode.Space) && canShoot)
            {
                StartCoroutine(ShootCooldown());
                Instantiate(Resources.Load("Prefabs/Player/Tir"), gameObject.transform.position, Quaternion.identity);
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