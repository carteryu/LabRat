using UnityEngine;
using System.Collections;

public class Cubes : MonoBehaviour {
	public GameObject[] mazeBlocks;
	public float resetDelay = 2f;
	// Use this for initialization
	void Start () {
		mazeBlocks = GameObject.FindGameObjectsWithTag("mazeBlock");
		
		for(int i = 0; i < mazeBlocks.Length; i++){
			Debug.Log("tile: " + i+ "is growing");
		}
	}
	
	void Grow(){
		transform.localScale += new Vector3(0, 9, 0);
	}
}
