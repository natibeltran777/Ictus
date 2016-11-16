using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	public float speed;

	private Rigidbody rbod;

	// Use this for initialization
	void Start () {
		rbod = GetComponent<Rigidbody>();
		rbod.velocity = transform.right * speed;
	}
	
	// Update is called once per frame
	void Update () {
	//rbod.AddForce(transform.right * speed);
	}
}
