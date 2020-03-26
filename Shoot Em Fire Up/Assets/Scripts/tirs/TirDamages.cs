using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class TirDamages : MonoBehaviour
    {
        
        
        
        void Awake()
        {
            
        }
        
        void Start()
        {
            
        }
        
        void Update()
        {
            
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.tag == "Player")
            {
                collision.GetComponent<PlayerManager>().TakeDamage = 1;
            }
        }

    }
}