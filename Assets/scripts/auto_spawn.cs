using UnityEngine;
using System.Collections;

public class auto_spawn : MonoBehaviour {
	
	public GameObject[] spawnList;
	public int spawnRadius = 1;
	public double spawnTimer = 1.0;
	private double spawnCountdown;
	
	// Use this for initialization
	void Start () {
		this.spawnCountdown = this.spawnTimer;
	}
	
	// Update is called once per frame
	void Update () {
		if(this.spawnCountdown <= 0.0) {
			this.SpawnRandom();
			this.spawnCountdown = this.spawnTimer;
		} else {
			this.spawnCountdown -= Time.deltaTime;
		}
	}
	
	void SpawnRandom () {
		GameObject spawnObject = this.spawnList[Random.Range(0,spawnList.Length)];
		Vector3 spawnPosition = new Vector3(transform.position.x + Random.Range(-this.spawnRadius,spawnRadius), transform.position.y, transform.position.z + Random.Range(-this.spawnRadius,spawnRadius));
		GameObject prefabInstance = (GameObject) Instantiate(spawnObject, spawnPosition, Quaternion.identity);
	}
}
