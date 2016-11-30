using UnityEngine;
using System.Collections;

public class SurfaceSwim : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            Vector3 velo = other.GetComponent<Rigidbody2D>().velocity;
            velo.y = 0;
            other.GetComponent<Rigidbody2D>().velocity = velo;
        }
    }
}
