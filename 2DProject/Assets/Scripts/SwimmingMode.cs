using UnityEngine;
using System.Collections;

public class SwimmingMode : MonoBehaviour {

    public float gravityGround;
    public float gravityWater;
    public float swinUp;
    public float swinDown;
    private float waiting;

	// Use this for initialization
	void Start () {
	   
	}
	
	// Update is called once per frame
	void Update () {
	   if (waiting > 0) {
            waiting -= Time.deltaTime;
       }
	}

    void OnTriggerStay2D(Collider2D other) {
        if (other.tag == "Player") {
            other.GetComponent<Rigidbody2D>().gravityScale = gravityWater;
            if (Input.GetKey(KeyCode.UpArrow)) {
                if (waiting <= 0) {
                    other.transform.Translate(0, swinUp, 0);
                    waiting = .1f;
                }
            }
            if (Input.GetKey(KeyCode.DownArrow)) {
                if (waiting <= 0) {
                    other.transform.Translate(0, -swinDown, 0);
                    waiting = .1f;
                }
            }
        }
    }
    void OnTriggerExit2D(Collider2D other) {
        if (other.tag == "Player") {
            other.GetComponent<Rigidbody2D>().gravityScale = gravityGround;
        }
    }
}
