using UnityEngine;
using System.Collections;

public class instanceDestroyer : MonoBehaviour {

    public float lifeTime = 10f;
    private float birthDate = 0f;

	// Use this for initialization
	void Start () {
        birthDate = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
	    if(Time.time > (birthDate + lifeTime))
        {
            Destroy(this.gameObject);
        }
	}
}
