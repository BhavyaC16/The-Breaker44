using UnityEngine;
using System.Collections;

public class PaddleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
				transform.Translate(10f * Time.deltaTime * Input.GetAxis("Horizontal"), 0, 0);
		}

	void OnCollisionEnter (Collision colOne){
		foreach (ContactPoint contact in colOne.contacts){
			if(contact.thisCollider == collider) {
				float chill = contact.point.x - transform.position.x;

				contact.otherCollider.rigidbody.AddForce(300f * chill,0,0);
			}
		}
	}
}
