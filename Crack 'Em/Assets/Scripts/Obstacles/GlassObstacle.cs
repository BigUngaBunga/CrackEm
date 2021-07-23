using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrackEm
{
    public class GlassObstacle : ObstacleBase
    {
        [SerializeField] private int hitsPerColour;
        [Range(1,3)]
        [SerializeField] int startingHealth = 1;
        private SpriteRenderer spriteRenderer;
        
        private void Start()
        {
            obstacleHealth = startingHealth * hitsPerColour;
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            UpdateColour();
        }

        public override void TakeDamage(int damage)
        {
            base.TakeDamage(damage);
            UpdateColour();
        }

        private void UpdateColour()
        {
            if (obstacleHealth > hitsPerColour * 2)
                spriteRenderer.color = Color.green;
            else if (obstacleHealth > hitsPerColour)
                spriteRenderer.color = Color.blue;
            else
                spriteRenderer.color = Color.white;
        }
    }
}


