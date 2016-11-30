using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Electrify : MonoBehaviour {

    private bool inWater;
    private GameObject player;
	// Use this for initialization
	void Start () {
        inWater = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay2D (Collider2D other) {
        print("other.tag");
        if (other.tag == "Player"){
            print("First");
            player = other.gameObject;
            inWater = true;
        }       
        if (other.tag == "Cable" && inWater) {  
        print("Secend");       
            if (other.GetComponent<ElectricityEmissionTiming>().emitting){
                Destroy(player);
                SceneManager.LoadScene("GameOver");
            }
        }
    }

    void OnTriggerExit2D (Collider2D other){
        print("Exit");
        if (other.tag == "Player") {
            inWater = false;
        }
    }
}
