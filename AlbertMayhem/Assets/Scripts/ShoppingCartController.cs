using UnityEngine;

public class ShoppingCartController : MonoBehaviour
{
	public float speed;
	private Rigidbody body;

	void Start ()
	{
		body = GetComponent<Rigidbody>();
	}
	
	void Update () {		
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * (speed / 10);
		var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;

		body.AddRelativeForce(0, 0, z);
		body.MoveRotation(body.rotation * Quaternion.Euler(0, x, 0));
	}
}
