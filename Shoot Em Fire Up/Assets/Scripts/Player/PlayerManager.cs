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

        #region Properties

        public int TakeDamage
        {
            set
            {
                hp -= value;
                if(hp <= 0)
                {
                    ResetGame();
                }
                else
                {
                    Death();
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


            if(Input.GetKeyDown(KeyCode.UpArrow))
            {
                Heal = 1;
            }
            if(Input.GetKeyDown(KeyCode.DownArrow))
            {
                TakeDamage = 1;
            }

        }

        #endregion

        void Death()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }

        void ResetGame()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Main_Menu");
        }

    }
}