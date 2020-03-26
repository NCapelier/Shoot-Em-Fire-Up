using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    /// <summary>
    /// Manages all the player's movement interactions.
    /// </summary>
    public class PlayerController : MonoBehaviour
    {
        // Player speed
        [Range(0f, 1500)]
        [SerializeField] float speed = 1;

        //Player's rb
        Rigidbody2D rb;

        void Awake()
        {

        }

        void Start()
        {
            rb = PlayerManager.Instance.GetComponent<Rigidbody2D>();
        }


        void Update()
        {
            Move();
        }

        /// <summary>
        /// Moves the Player object depending on the keyboard pressed buttons.
        /// </summary>
        void Move()
        {
            //inputs
            int vertical, horizontal;

            //horizontal input
            if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.Q))
            {
                horizontal = 1;
            }
            else if (Input.GetKey(KeyCode.Q) && !Input.GetKey(KeyCode.D))
            {
                horizontal = -1;
            }
            else
            {
                horizontal = 0;
            }

            //vertical input
            if(Input.GetKey(KeyCode.Z) && !Input.GetKey(KeyCode.S))
            {
                vertical = 1;
            }
            else if (Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.Z))
            {
                vertical = -1;
            }
            else
            {
                vertical = 0;
            }

            //actual movement
            rb.velocity = new Vector2(horizontal, vertical).normalized * Time.deltaTime * speed;

        }

    }
}