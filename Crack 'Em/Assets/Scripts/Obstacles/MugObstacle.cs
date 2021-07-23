using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrackEm
{
    public class MugObstacle : ObstacleBase
    {
        [SerializeField] private int damageThreshold;

        public override void TakeDamage(int damage)
        {
            if (damage >= damageThreshold)
                base.TakeDamage(damage);
        }
    }
}
