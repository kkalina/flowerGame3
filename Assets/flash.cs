using UnityEngine;
using System.Collections;

public class flash : MonoBehaviour {

    public float frequency = 0.2f;
        private float lastOccurance;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(Time.time > lastOccurance + frequency)
        {
            lastOccurance = Time.time;
            if (this.gameObject.GetComponent<SpriteRenderer>().enabled)
                this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            else
                this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
	}
}
