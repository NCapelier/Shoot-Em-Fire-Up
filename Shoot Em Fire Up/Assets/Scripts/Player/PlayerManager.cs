using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Management;
using UnityEngine.UI;

namespace Game
{
    public class PlayerManager : Singleton<PlayerManager>
    {

        [HideInInspector] public int hp = 10;
        [Range(0,100)]
        [SerializeField] int startingHp = 50;

        [SerializeField] Text hpText = null;
        [SerializeField] Text PointsText = null;

        [HideInInspector] public int points = 0;

        bool canTakeDmg = true;

        bool s1 = false, s2 = false, s3 = false, s4 = false, s5 = false, s6 = false, s7 = false, s8 = false, s9 = false, s10 = false;

        #region Properties

        public int TakeDamage
        {
            set
            {
                if(canTakeDmg)
                {
                    canTakeDmg = false;
                    StartCoroutine(Invunerability());
                    hp -= value;
                    if (hp <= 0)
                    {
                        ResetGame();
                    }
                    else
                    {
                        Death();
                    }
                }
            }
        }

        public int Heal
        {
            set
            {
                hp += value;
            }
        }

        #endregion

        #region Unity Methods

        void Awake()
        {
            MakeSingleton(true);
        }
        
        void Start()
        {
            hp = startingHp;
        }
        
        void Update()
        {
            if(hp <= 99)
            {
                hpText.text = "HP : " + hp;
            }
            else
            {
                hpText.text = "HP : 99+";
            }

            PointsText.text = "Points : " + points;


            if(Input.GetKeyDown(KeyCode.UpArrow))
            {
                points += 10;
            }
            if(Input.GetKeyDown(KeyCode.DownArrow))
            {
                TakeDamage = 1;
            }

            BonusHp();

        }

        #endregion

        void BonusHp()
        {
            if(points > 100 && s1 == false)
            {
                s1 = true;
                hp++;
            }
            else if (points > 200 && s2 == false)
            {
                s2 = true;
                hp++;
            }
            else if(points > 300 && s3 == false)
            {
                s3 = true;
                hp++;
            }
            else if(points > 400 && s4 == false)
            {
                s4 = true;
                hp++;
            }
            else if(points > 500 && s5 == false)
            {
                s5 = true;
                hp++;
            }
            else if(points > 600 && s6 == false)
            {
                s6 = true;
                hp++;
            }
            else if(points > 700 && s7 == false)
            {
                s7 = true;
                hp++;
            }
            else if(points > 800 && s8 == false)
            {
                s8 = true;
                hp++;
            }
            else if(points > 900 && s9 == false)
            {
                s9 = true;
                hp++;
            }
            else if(points > 1000 && s10 == false)
            {
                s10 = true;
                hp++;
            }
        }

        void Death()
        {
            //Instantiate(Resources.Load("Prefabs/Enemies/animationMortPlayer"), gameObject.transform.position, Quaternion.identity);
            gameObject.transform.position = new Vector2(0,3);
        }

        void ResetGame()
        {
            Destroy(gameObject);
            UnityEngine.SceneManagement.SceneManager.LoadScene("MenuScene");
        }

        IEnumerator Invunerability()
        {
            yield return new WaitForSeconds(1f);
            canTakeDmg = true;
        }

    }
}