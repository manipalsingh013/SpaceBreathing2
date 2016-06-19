using UnityEngine;
using System.Collections;

public class addMeteorites : MonoBehaviour {

    // Use this for initialization

    public float pos_x;
    public float pos_y;
    public float pos_z;

    public GameObject meteoriteXY;
    public GameObject meteoriteYZ;
    public GameObject meteoriteXZ;

    float spawn_time;
	void Start ()
    {
	
	}
    void Awake()
    {
        spawn_time = Time.time;
    }
    float x, y, z;
	// Update is called once per frame
	void Update ()
    {
        if (Time.time > spawn_time + 2.0f)
        {
            //XY
            y = Random.RandomRange(0, 1000);
            x = Random.RandomRange(0, 1000);
            z = -200;
            Instantiate(meteoriteXY , new Vector3(x,y,z) , Quaternion.Euler(x,y,z));
            /*
            y = Random.RandomRange(0, 500);
            x = Random.RandomRange(0, 500);
            z = -1500;
            Instantiate(meteoriteXY, new Vector3(x, y, z), Quaternion.Euler(x, y, z));

            //XZ
            x = Random.RandomRange(0, 500);
            z = Random.RandomRange(0, 500);
            y = 1500;
            Instantiate(meteoriteXZ, new Vector3(x, y, z), Quaternion.Euler(x, y, z));

            x = Random.RandomRange(0, 500);
            z = Random.RandomRange(0, 500);
            y = -1500;
            Instantiate(meteoriteXZ, new Vector3(x, y, z), Quaternion.Euler(x, y, z));

            //YZ
            y = Random.RandomRange(0, 500);
            z = Random.RandomRange(0, 500);
            z = 1500;
            Instantiate(meteoriteYZ, new Vector3(x, y, z), Quaternion.Euler(x, y, z));

            y = Random.RandomRange(0, 500);
            z = Random.RandomRange(0, 500);
            x = -1500;
            Instantiate(meteoriteYZ, new Vector3(x, y, z), Quaternion.Euler(x, y, z));
            */
            spawn_time = Time.time;
        }
	
	}
}
