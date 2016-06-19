using UnityEngine;
using System.Collections;

public class EarthRevolution : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.RotateAround(new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z), new Vector3(0f, 1f, 0f), 1 * Time.deltaTime);
    }
}
