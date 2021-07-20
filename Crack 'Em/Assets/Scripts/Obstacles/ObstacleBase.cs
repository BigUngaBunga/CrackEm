using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrackEm
{

    public class ObstacleBase : MonoBehaviour
    {
        protected int obstacleHealth;

        protected virtual void WasHit()
        {

        }

        protected virtual void DestroyObstacle()
        {
            Destroy(this);
        }

        public void TakeDamage(int damage)
        {
            obstacleHealth -= damage;
            if (obstacleHealth <= 0)
                DestroyObstacle();
        }
    }
}
