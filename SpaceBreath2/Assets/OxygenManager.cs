using UnityEngine;
using System.Collections;

public class OxygenManager : MonoBehaviour {

    public GameObject micController;


    float x,y,z;
    float enterTime, exitTime, exhaleStart;
    float destroyTime;
    bool enter,destroyed;
    int negpos;
    public GameObject oxygen;
    float getLoudness;

    public float oxygenAvailable;
    GameObject player;
    collectOxygen collectoxygen;
    void Awake()
    {
        player = GameObject.FindWithTag("player");
        collectoxygen = player.GetComponent<collectOxygen>();
        //oxygenAvailabe = 
    }
	// Use this for initialization
	void Start ()
    {
        destroyed = false;
	}

    // Update is called once per frame


    void Update()
    {
        getLoudness = micController.GetComponent<MicControl>().loudness;
        //  moveOxygen();
        if(getLoudness < 0.01)
            exhaleStart = Time.time;
        if ( Time.time - enterTime>= 5f && enter==true && destroyed == false && Time.time - exhaleStart>=5f)
        {
            destroyTime = Time.time;
            enterTime = Time.time;
            destroyed = true;

            oxygen.GetComponent<MeshRenderer>().enabled = false;
            oxygen.GetComponent<ParticleSystem>().enableEmission = false;
            oxygen.GetComponent<SphereCollider>().enabled = false;

            if (collectoxygen.oxygenAvailable < 100.0f)
            {
                collectoxygen.oxygenAvailable += 10.0f;
                if (collectoxygen.oxygenAvailable > 100.0f)
                    collectoxygen.oxygenAvailable = 100.0f;
                

            }
        }
        if (Time.time > destroyTime + 10f && destroyed == true)
        {
            oxygen.GetComponent<MeshRenderer>().enabled = true;
            oxygen.GetComponent<ParticleSystem>().enableEmission = true;
            oxygen.GetComponent<SphereCollider>().enabled = true;
            moveOxygen();
            destroyed = false;
        }
    }

    public void moveOxygen()
    {
        x = Random.Range(0, 1188999);
        x = x /(-1000000);

        y = Random.Range(-706,-650);
        y = (float)y / 10;
        z = (float)Mathf.Sqrt((float)(1.188999 * 1.188999) - x * x);


        negpos = Random.Range(0, 2);
        if(negpos>=1)
        {
            z = z * -1;
            z = (float)(z - 1.188999);
        }
        else
        {
            z = (float)(z - 1.188999);
        }
        oxygen.transform.localPosition = new Vector3(x,y, z);

    }
    public void enterTimer()
    {
        enter = true;
        enterTime = Time.time;
    }
    public void exitTimer()
    {
        enter = false;
        exitTime = Time.time;
    }

}
