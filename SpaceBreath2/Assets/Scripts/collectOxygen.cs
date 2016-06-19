using UnityEngine;
using UnityEngine.UI;

public class collectOxygen : MonoBehaviour
{

    public float oxygenAvailable=100.0f;
    public float maxOxygen;
    AudioSource onCollectingOxygen;
    float awakeTime;

    void Awake()
    {
        awakeTime = Time.time;
        maxOxygen = 100.0f;
        onCollectingOxygen = GetComponent<AudioSource>();

        float adsd= GameObject.FindWithTag("oxygenSlider").GetComponent<Slider>().value;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Time.time > awakeTime + 0.3f)
        {
            awakeTime = Time.time;
            if (oxygenAvailable > 0.0f)
            {
                oxygenAvailable -= 0.5f;
                GameObject.FindWithTag("oxygenSlider").GetComponent<Slider>().value = oxygenAvailable;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "oxygen")
        {
            if (oxygenAvailable < 100.0f)
            {
                oxygenAvailable += 10.0f;
                if (oxygenAvailable > 100.0f)
                    oxygenAvailable = 100.0f;
                       
            }
            Destroy(other.gameObject);
        }
    }


}