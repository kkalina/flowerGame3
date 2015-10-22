using UnityEngine;
using System.Collections;

public class rexFootsteps : MonoBehaviour {

    public float SPM;
    private float secondsPerStep;
    private float timeOfFirstStep = 0f;
    int i = 1;
    public GameObject playerCam;
    public float shakeStartDelay = 0.12f;
    public float shakeDuration = 0.4f;
    private bool step = false;

	// Use this for initialization
	void Start () {
        secondsPerStep = 60 / SPM;
        timeOfFirstStep = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > (timeOfFirstStep + (secondsPerStep * i)))
        {
            i = i + 1;
            this.gameObject.GetComponent<AudioSource>().Play();
            step = true;
        }


        if ((i>1) && (Time.time > (timeOfFirstStep + (secondsPerStep * (i - 1)) + shakeStartDelay)) && step)
        {
            //playerCam.GetComponent<shakifier>().shaking = true;
            playerCam.GetComponent<shakifier>().shakeTime += shakeDuration;
            step = false;
        }
        /*
        if (Time.time > (timeOfFirstStep + (secondsPerStep * (i-1)) + shakeDuration))
        {
            playerCam.GetComponent<shakifier>().shaking = false;
        }
        */
    }
}
