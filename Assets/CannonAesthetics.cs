using UnityEngine;
using System.Collections;

public class CannonAesthetics : MonoBehaviour {

	private Renderer rend;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
		rend.material.color = Color.red;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
