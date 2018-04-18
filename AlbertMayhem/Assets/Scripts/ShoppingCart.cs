using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppingCart : MonoBehaviour
{
	public float speed;
	private Rigidbody body;

	// Use this for initialization
	void Start ()
	{
		body = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {		
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * (speed / 10);
		var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;

		body.AddRelativeForce(0, 0, z);
		body.MoveRotation(body.rotation * Quaternion.Euler(0, x, 0));
	}
}
