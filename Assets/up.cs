using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class up : MonoBehaviour {
	public Transform ypos;
	GameObject u1;
	public int invert =90;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		invert = GetComponent<rubik> ().invert;
		Destroy(gameObject);
	}
	private void OnCollisionEnter(Collision collision){
		u1 = collision.gameObject;

		u1.transform.RotateAround(ypos.position,transform.up,invert);
	}
}
