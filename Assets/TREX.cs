using UnityEngine;
using System.Collections;

public class TREX : MonoBehaviour {
    public float speed = 2f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + (speed * Time.deltaTime));
	}
}
