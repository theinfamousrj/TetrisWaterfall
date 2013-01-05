#pragma strict

var deathTimer:float = 1.0;

function Update () {
	if(deathTimer <= 0.0) {
		Destroy(gameObject);
	}
	
	deathTimer -= Time.deltaTime;
}