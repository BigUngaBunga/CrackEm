using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace CrackEm
{
	public class PlayerController : MonoBehaviour
	{
		public float speed = 4.0f;
		//public float horizontalInput;
		public Vector3 movement_v;

		// Start is called before the first frame update
		void Start()
		{
		}

		void Move(){
			movement_v = new Vector3(0.0f,0.0f,0.0f);

			if(Input.GetKey(KeyCode.LeftArrow)){movement_v += new Vector3(-1.0f,0.0f,0.0f);}
			if(Input.GetKey(KeyCode.RightArrow)){movement_v += new Vector3(1.0f,0.0f,0.0f);}
			if(Input.GetKey(KeyCode.DownArrow)){transform.Rotate(0,0,45 * Time.deltaTime);}
			if(Input.GetKey(KeyCode.UpArrow)){transform.Rotate(0,0,-45 * Time.deltaTime);}

			// Object Follows Cursor
			/*
	        	horizontalInput = Input.GetAxis("Mouse X");
			Vector3 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			transform.position = new Vector3(cursorPos.x, cursorPos.y, 0);
			*/

			// All added movement vectors gets translated relative to World Space
			transform.Translate(movement_v.x * Time.deltaTime * speed,0,0,Space.World);
		}
		// Update is called once per frame
		void Update(){
			Move();

		}
	}
}
