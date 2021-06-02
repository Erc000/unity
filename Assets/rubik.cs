using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rubik : MonoBehaviour {
	
	public GameObject up,down,right,left,front,back;
	public int invert;

	// Use this for initialization
	void Start () {
		invert = 90;
	}

	// Update is called once per frame
	void Update () {
		invert = 90;
		if(Input.GetKeyDown(KeyCode.LeftShift)){
			invert = -90;
		}

		if(Input.GetKeyDown(KeyCode.W)){
			Instantiate(up,up.transform.position,up.transform.rotation);
		}
		if(Input.GetKeyDown(KeyCode.S)){
			Instantiate(down,down.transform.position,down.transform.rotation);
		}
		if(Input.GetKeyDown(KeyCode.D)){
			Instantiate(right,right.transform.position,right.transform.rotation);
		}
		if(Input.GetKeyDown(KeyCode.A)){
			Instantiate(left,left.transform.position,left.transform.rotation);
		}
		if(Input.GetKeyDown(KeyCode.E)){
			Instantiate(front,front.transform.position,front.transform.rotation);
		}
		if(Input.GetKeyDown(KeyCode.Q)){
			Instantiate(back,back.transform.position,back.transform.rotation);
		}

	}
}
