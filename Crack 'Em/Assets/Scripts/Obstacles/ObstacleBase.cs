using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrackEm
{

    public class ObstacleBase : MonoBehaviour
    {
        [SerializeField] protected int obstacleHealth = 1;

        protected virtual void DestroyObstacle() => Destroy(gameObject);

        public virtual void TakeDamage(int damage)
        {
            obstacleHealth -= damage;
            if (obstacleHealth <= 0)
                DestroyObstacle();
        }

        private void GenerateModifier()
        {
            //TODO slumpa fram modifierare
        }
    }
}
