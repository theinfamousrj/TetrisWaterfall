using UnityEngine;
using System.Collections;

public class rand_color : MonoBehaviour {
	
	public Material[] materialList;
	private Renderer[] renderers;
	
	// Use this for initialization
	void Start () {
		renderers = GetComponentsInChildren<Renderer>();
		Solid(this.materialList[Random.Range(0,this.materialList.Length)]);
	}
	
	// Update is called once per frame
	void Update () {
		//renderer.material = materialList[Random.Range(0,this.materialList.Length)];
	}
	
	void Twinkle (Material theMaterial) {
		
	}
	
	void Solid (Material theMaterial) {
		foreach(Renderer child in renderers) {
			child.material = theMaterial;
		}
	}
}
