using UnityEngine;
using System.Collections;

public class flashingLight : MonoBehaviour {
    //public GameObject muzzleFlare;
    //public GameObject muzzleLight;

    public float frequency = 1f;
    private float lastOccruance = 0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Time.time > lastOccruance + frequency)
            {
                this.gameObject.GetComponent<Light>().enabled = true;
                lastOccruance = Time.time;
            }
        }
        if (Time.time > lastOccruance + 0.02f)
        {
            this.gameObject.GetComponent<Light>().enabled = false;
        }
    }


}
