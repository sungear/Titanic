using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Water : MonoBehaviour {

   //public float minimumScale;
   public float scaleFactor;
   private Vector3 currentScale;
   private float t;
   private float s;
   public float time;
   public Text breathBar;
   
   public GameObject player;
   public float timeToDie;
   private GameObject wave;
   private Vector3 wavePos;
   private  float maxWater;
   public float waveUp;
   
   



    //public float speed;
    //public float augm ; 
    //public GameObject water;
    //public float y;

	// Use this for initialization
	void Start () 
    {
	
        player = GameObject.FindGameObjectWithTag("Player");
            //maximumScale = transform.localScale
        wave = (GameObject)Resources.Load("wave");
        wave = (GameObject)Instantiate(wave,transform.position, transform.rotation);

        Sprite spWater = GetComponent<SpriteRenderer>().sprite;
        maxWater = spWater.bounds.max.y * transform.localScale.y + transform.position.y;

        Vector3  wavePos = new Vector3(transform.position.x, maxWater + waveUp,transform.position.z);

        wave.transform.position = wavePos ;

        breathBar.text = timeToDie.ToString();

        
	}

	// Update is called once per frame
	void Update () 
    {
	
      t-= Time.deltaTime;

      if(t<=0)
      {

        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.y *= scaleFactor;   
        transform.localScale += new Vector3(0,transform.localScale.y*scaleFactor,0);

        t = time;
       
         

        }
            Bordures();




    }

    void Bordures()// calculer les bords du hauts du cube et du perso.

    {

        Sprite spPlayer = player.GetComponent<SpriteRenderer>().sprite;
        Sprite spWater = GetComponent<SpriteRenderer>().sprite;

        float maxSprite = spPlayer.bounds.max.y * player.transform.localScale.y + player.transform.position.y;
                maxWater = spWater.bounds.max.y * transform.localScale.y + transform.position.y;

                Vector3  wavePos = new Vector3(transform.position.x, maxWater + waveUp,transform.position.z);

                 wave.transform.position = wavePos ;

        // print(maxSprite);
        // print(maxWater);

        if (maxSprite <= maxWater)
        {

           s += Time.deltaTime;
           int breathTime = (int)(timeToDie - s);
           breathBar.text = breathTime.ToString();
           {
                if(s >= timeToDie)
                {
                  Destroy(player);
                  SceneManager.LoadScene("GameOver");
                }
           }
          




        }
        else
        {

            s = 0;




        }





/*        Vector3[] = SpriteLocalToWorld (Sprite spPlayer);

        Vector3 pos= transform.position;

        Vector3[] array = new Vector3[2];
        array[0] = pos + Sprite.bounds.max.y;

        print(array[0]);*/

    }
}


