using UnityEngine;
using System.Collections;

public class ValveManager : MonoBehaviour {

    public Transform door;
    public float doorMoveX;
    public float doorMoveY;
    public bool open;
    private float waiting;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	   if(waiting > 0) {
            waiting -= Time.deltaTime;
       }
	}

    void OnTriggerStay2D(Collider2D other) {
        if (other.tag == "Player" && Input.GetKey(KeyCode.T) && waiting <= 0) {
            if (open) {
                door.Translate(doorMoveX, doorMoveY, 0);
                open = false;
            }
            else {
                door.Translate(- doorMoveX, - doorMoveY, 0);
                open = true;
            }
            waiting = 1;
        }
    }
}
