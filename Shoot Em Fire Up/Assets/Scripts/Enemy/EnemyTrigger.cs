using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class EnemyTrigger : MonoBehaviour
    {
        [Range(1,50)]
        [SerializeField] int hp = 10;
        
        void Awake()
        {
            
        }
        
        void Start()
        {
            
        }
        
        void Update()
        {
            if(hp <= 0)
            {
                Destroy(transform.parent.gameObject);
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.tag == "PlayerShoot")
            {
                hp--;
                Destroy(collision.gameObject);
            }
            if(collision.tag == "Death")
            {
                GetComponentInParent<EnemyManager>().mustDie = true;
                Destroy(gameObject);
            }
        }

    }
}