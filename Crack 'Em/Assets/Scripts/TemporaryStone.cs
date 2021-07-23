using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrackEm
{
    public class TemporaryStone : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Obstacle")
            {
                collision.gameObject.GetComponent<ObstacleBase>().TakeDamage(1);
            }
        }
    }

}

