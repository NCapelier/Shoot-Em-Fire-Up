using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class Enemy2Collider : MonoBehaviour
    {
        public bool onTouch = false;

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
            if (collision.tag == "Wall")
            {
                Debug.Log("fheucsbfvb fygizqe");
                onTouch = true;
            }
        }

    }
}