using UnityEngine;
using System.Collections;

public class rifleKick : MonoBehaviour {
    private Vector3 homePosition;
    public float intensity = 0.1f;
    public GameObject anchor;
	// Use this for initialization
	void Start () {
        homePosition = anchor.transform.position;
        this.transform.position = anchor.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            this.transform.position = new Vector3(anchor.transform.position.x + (Random.value * intensity), anchor.transform.position.y + (Random.value * intensity), anchor.transform.position.z + (Random.value * intensity));
            //if (!this.GetComponent<AudioSource>().isPlaying) { 
            //    this.GetComponent<AudioSource>().Play();
            //}
        }
        else
        {
            this.transform.position = anchor.transform.position;
            //if (this.GetComponent<AudioSource>().isPlaying)
            //{
            //    this.GetComponent<AudioSource>().Stop();
            //}
        }
        this.transform.rotation = anchor.transform.rotation;
    }
}
