using UnityEngine;
using System.Collections;

public class ADSsound : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            this.GetComponent<AudioSource>().Play();
        }
        else if (Input.GetMouseButtonUp(1))
        {
            this.GetComponent<AudioSource>().Play();
        }
    }
}
