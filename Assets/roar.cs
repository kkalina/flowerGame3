using UnityEngine;
using System.Collections;

public class roar : MonoBehaviour {

    public GameObject playerCam;
    public float roarDuration = 3f;
    private bool roaring = false;
    private float timeOfRoar = 0f;

	// Use this for initialization
	void Start () {

        this.gameObject.GetComponent<AudioSource>().Play();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.R) || (Random.Range(1,300)==34))
        {
            timeOfRoar = Time.time;
            roaring = true;
            this.gameObject.GetComponent<AudioSource>().Play();
            playerCam.GetComponent<shakifier>().shaking = true;
        }
        if(roaring && (Time.time > (timeOfRoar + roarDuration)))
        {
            playerCam.GetComponent<shakifier>().shaking = false;
            roaring = false;
        }
	}
}
