using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrackEm
{
    public class VaseObstacle : ObstacleBase
    {
        [SerializeField] GameObject shardPrefab;

        protected override void DestroyObstacle()
        {
            DropShard();
            base.DestroyObstacle();
        }

        private void DropShard() => Instantiate(shardPrefab);
    }
}
