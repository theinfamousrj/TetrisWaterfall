using UnityEngine;
using System.Collections;

public class ability_move : MonoBehaviour {
	
	public float speed = 1.0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Forward")) {
			transform.position += transform.forward * speed * Time.deltaTime;
		}
		if(Input.GetButton("Backward")) {
			transform.position += -transform.forward * speed * Time.deltaTime;
		}
		if(Input.GetButtonDown("Left")) {
			transform.position -= new Vector3(transform.position.x * speed * Time.deltaTime, 0, 0);
		}
		if(Input.GetButtonDown("Right")) {
			//transform.eulerAngles.y -= speed * Time.deltaTime;
		}
		if(Input.GetButtonDown("TurnLeft")) {
			//transform.eulerAngles.y -= -speed * Time.deltaTime;
		}
		if(Input.GetButtonDown("TurnRight")) {
			//transform.eulerAngles.y -= speed * Time.deltaTime;
		}
	}
}
