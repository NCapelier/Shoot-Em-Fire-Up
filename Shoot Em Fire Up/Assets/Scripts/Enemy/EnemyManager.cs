using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class EnemyManager : MonoBehaviour
    {
        [Range(0,50)]
        [SerializeField] int points = 0;

        [HideInInspector] public bool mustDie = false;

        void Awake()
        {
            
        }
        
        void Start()
        {
            
        }
        
        void Update()
        {
            
        }

        private void OnDestroy()
        {
            if(mustDie == false)
            {
                PlayerManager.Instance.points += points;
            }
        }

    }
}