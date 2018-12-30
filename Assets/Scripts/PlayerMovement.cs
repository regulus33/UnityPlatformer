using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed = 10.0f;

	private float leftWall = -4f;
	private float rightWall = 4f;
	private Animator anim;
	// Use this for initialization
	void Start () {
	
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        //get the horizontal axis that by default is bound by the arrow.
   
        //the value is in the range -1 to 1 
        //make it move per seconds instead of frames
        float translation = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;

//		if (translation > 0) {
//			transform.localScale = new Vector3 (1, 1, 1);
//		} 
//		else if(translation < 0) {
//			transform.localScale = new Vector3 (-1, 1, 1);			
//		}

		if (transform.position.x + translation < rightWall && transform.position.x + translation > leftWall) {
			transform.Translate (translation, 0, 0);
		}		
	    //switching between idale and walk states in anim
		if (translation != 0) {
			anim.SetFloat("PlayerSpeed", speed);
		} else {
			anim.SetFloat ("PlayerSpeed", 0);
		}

		if (Input.GetKeyUp (KeyCode.Space)) {
			anim.SetBool("Jump", !(anim.GetBool("Jump")));
		}
	
	}
		
}
