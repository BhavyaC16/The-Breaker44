using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		rigidbody.AddForce(0, 200f, 0);	 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
