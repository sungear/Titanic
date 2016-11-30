using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void GoToNextScene (string name){
        SceneManager.LoadScene(name);
    }

    public void ExitGame (){
        Application.Quit();
    }
}
