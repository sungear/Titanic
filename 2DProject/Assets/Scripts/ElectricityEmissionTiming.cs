using UnityEngine;
using System.Collections;

public class ElectricityEmissionTiming : MonoBehaviour {

    public float emissionTime;
    public float noEmissionTime;
    public GameObject emittingParticle;
    public bool emitting;
    float maxEmissionTime;
    float maxNoEmissionTime;

	// Use this for initialization
	void Start () {
       maxEmissionTime = emissionTime;
       maxNoEmissionTime = noEmissionTime;
	}
	
	// Update is called once per frame
	void Update () {
        
        if (emitting){
            emissionTime -= Time.deltaTime;
            if (emissionTime <= 0) {
                emittingParticle.SetActive(false);
                emitting = false;
                emissionTime = maxEmissionTime;
            }
        }

        else {
            noEmissionTime -= Time.deltaTime;
            if (noEmissionTime <= 0) {
                emittingParticle.SetActive(true);
                emitting = true;
                noEmissionTime = maxNoEmissionTime;
            }
        }
	}
}
