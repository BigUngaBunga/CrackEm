using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrackEm
{
    public class DamageToPlayer : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                //TODO Player looses one life
                Destroy(gameObject);
            }
        }
    }
}

