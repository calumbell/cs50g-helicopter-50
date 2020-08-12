using UnityEngine;
using System.Collections;

public class Skyscraper : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {


	}

	void OnTriggerEnter(Collider other) {

		// trigger helicopter to explode when it collides with this
		other.transform.parent.gameObject.GetComponent<HeliController>().Explode();
	}
}
