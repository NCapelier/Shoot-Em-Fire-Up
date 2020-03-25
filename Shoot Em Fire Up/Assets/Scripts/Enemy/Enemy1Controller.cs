using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class Enemy1Controller : MonoBehaviour
    {
        [SerializeField] float speed = 1;

        Rigidbody2D rb;
        
        void Awake()
        {
            
        }
        
        void Start()
        {
            rb = GetComponentInParent<Rigidbody2D>();
        }
        
        void Update()
        {
            rb.velocity = Vector2.down * speed * Time.deltaTime;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.gameObject.tag == "Player")
            {
                collision.GetComponent<PlayerManager>().TakeDamage = 1;
                Destroy(gameObject);
            }
        }

    }
}