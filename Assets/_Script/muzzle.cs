using UnityEngine;
using System.Collections;

public class muzzle : MonoBehaviour {

    public GameObject muzzleFlare;
    //public GameObject muzzleLight;

    public float frequency = 1f;
    private float lastOccruance = 0f;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            if (Time.time > lastOccruance + frequency)
            {
                GameObject flareInstance = Instantiate(muzzleFlare);
                flareInstance.transform.position = this.transform.position;
                //muzzleLight.GetComponent<Light>().enabled = true;
                lastOccruance = Time.time;
            }
        }
        /*
        if (Time.time > lastOccruance + 0.02f)
        {

            muzzleLight.GetComponent<Light>().enabled = false;
        }
        */
	}
}
