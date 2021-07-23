using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrackEm
{
    public class MolotovObstacle : ObstacleBase
    {
        protected override void DestroyObstacle()
        {
            Explode();
            base.DestroyObstacle();
        }

        private void Explode()
        {
            //TODO förstör närliggande hinder
        }
    }
}


