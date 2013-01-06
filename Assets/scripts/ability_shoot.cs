using UnityEngine;
using System.Collections;

public class ability_shoot : MonoBehaviour {
	
	public GameObject bulletPrefab;
	public float bulletForce = 1.0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0)) {
			GameObject bulletInstance = (GameObject) Instantiate(this.bulletPrefab, transform.position, Quaternion.identity);
			bulletInstance.transform.eulerAngles = gameObject.transform.eulerAngles;
			bulletInstance.rigidbody.AddForce(transform.forward * bulletForce);
		}
	}
}
