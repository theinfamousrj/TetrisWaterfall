using UnityEngine;
using System.Collections;

public class ability_mousemove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//transform.eulerAngles = Input.mousePosition;
		transform.position = new Vector3(transform.position.x, Input.mousePosition.y, Input.mousePosition.z);
	}
}
