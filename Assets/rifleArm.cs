using UnityEngine;
using System.Collections;

public class rifleArm : MonoBehaviour {

    public float delay = 2f;
    private float birthDate;

	// Use this for initialization
	void Awake () {
        birthDate = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
	    if(Time.time > (birthDate + delay))
        {
            this.gameObject.GetComponent<AudioSource>().enabled=true;
            //print("PLAYING ARM AUDIO");
        }
        if (Time.time > (birthDate + delay + 2f))
        {
            this.gameObject.GetComponent<AudioSource>().enabled = false;
        }
    }
}
