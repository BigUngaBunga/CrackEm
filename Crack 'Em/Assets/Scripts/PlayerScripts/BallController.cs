using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace CrackEm
{
	public class BallController : MonoBehaviour
	{
	    public Vector2 velocity;
	    public float speed = 1.0f;


	    // Start is called before the first frame update
	    void Start()
	    {
		velocity = new Vector2(0.0f,-1.0f);
	    }

	    void Movement(){
		transform.Translate(velocity * Time.deltaTime * speed);

	    }
	    // Update is called once per frame
	    void Update()
	    {
		Movement();
	    }

	    void OnCollisionEnter2D(Collision2D collision)
	    {
		print(velocity);
		velocity = Vector2.Reflect(velocity, collision.contacts[0].normal);
		print(velocity);

		print(collision.contacts[0]);

		if(collision.gameObject.tag == "Obstacle"){
			collision.gameObject.GetComponent<ObstacleBase>().TakeDamage(1);
		}
	    }
	}
}
