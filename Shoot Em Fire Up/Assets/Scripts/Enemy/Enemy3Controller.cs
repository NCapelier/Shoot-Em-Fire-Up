using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class Enemy3Controller : MonoBehaviour
    {
        [SerializeField] float speed = 1;

        Rigidbody2D rb;

        public Enemy2Collider goLeft, goRight;

        bool leftTouch = false;
        bool rightTouch = false;

        Vector2 addition;

        enum Dir { left, right };
        Dir currentDir = Dir.left;

        void Awake()
        {

        }

        void Start()
        {
            rb = GetComponentInParent<Rigidbody2D>();
            addition = Vector2.left;
        }

        void Update()
        {
            leftTouch = goLeft.onTouch;
            rightTouch = goRight.onTouch;

            if (leftTouch == true)
            {
                addition = Vector2.right;
                goLeft.onTouch = false;
                leftTouch = false;
            }
            if (rightTouch == true)
            {
                addition = Vector2.left;
                goRight.onTouch = false;
                rightTouch = false;
            }

            rb.velocity = Vector2.down * speed * Time.deltaTime + addition * Time.deltaTime * 300;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                collision.GetComponent<PlayerManager>().TakeDamage = 1;
                Destroy(gameObject);
            }
        }

        IEnumerator Tempo()
        {
            yield return new WaitForSeconds(Random.Range(1.5f, 3.5f));
            int i = Random.Range(0, 2);
            if (i == 0)
            {
                leftTouch = true;
            }
            else
            {
                rightTouch = true;
            }
            StartCoroutine(Tempo());
        }

    }
}