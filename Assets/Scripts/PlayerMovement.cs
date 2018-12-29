using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed = 10.0f;

	private float leftWall = -4f;
	private float rightWall = 4f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//get the horizontal axis that by default is bound by the arrow.

		//the value is in the range -1 to 1 
		//make it move per seconds instead of frames
		float translation = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;

		if (transform.position.x + translation < rightWall && transform.position.x + translation > leftWall)
			transform.Translate (translation, 0, 0);
		
	
	
	}
}
