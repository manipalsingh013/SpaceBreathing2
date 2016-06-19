using UnityEngine;
using System.Collections;

public class rotateAroundEarth : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {

	
	}
    GameObject Earth;


    void Awake()
    {
        Earth =GameObject.FindWithTag("earth");
    }
	// Update is called once per frame
	void Update () {
        transform.RotateAround(new Vector3(Earth.GetComponent<Transform>().position.x, Earth.GetComponent<Transform>().position.y + GetComponent<Transform>().position.y, Earth.GetComponent<Transform>().position.z), new Vector3(0f,1f,0f), 1 * Time.deltaTime);
    }
}
