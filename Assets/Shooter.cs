using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	public Rigidbody bullet;
	public Transform shotPos;
	public float shotForce = 10f;
	public float speed = 10;
	private float InstantiationTimer = 3f;
	//private Renderer rendCan;
	//private Renderer rendBull;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.A)) {
            transform.Rotate(0, 0, Time.deltaTime * 30.0f);
            //shotPos.Rotate(0, 0, Time.deltaTime * 30.0f);

        }

        else if(Input.GetKey(KeyCode.D)) {
             transform.Rotate(0, 0, Time.deltaTime * -30.0f);
             //shotPos.Rotate(0, 0, Time.deltaTime * -30.0f);
        }

     	InstantiationTimer -= Time.deltaTime;
     	print(InstantiationTimer);
     	if (Input.GetKey(KeyCode.Space) && InstantiationTimer <= 0){
     		CreatePrefab();
		}
	}

	void CreatePrefab(){
		
        Rigidbody shot = Instantiate(bullet, shotPos.position, shotPos.rotation) as Rigidbody;
       	shot.velocity = transform.up * speed;
        InstantiationTimer = 3f;
    }
}
