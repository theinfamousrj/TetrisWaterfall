using UnityEngine;
using System.Collections;

public class auto_destroy : MonoBehaviour {
	
	public double deathTimer = 1.0;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(this.deathTimer <= 0.0) {
			Destroy(gameObject);
		}
		
		this.deathTimer -= Time.deltaTime;
	}
}
