using UnityEngine;
using System.Collections;

public class casingEject : MonoBehaviour {
    public GameObject casingObj;
    public float frequency = 0.15f;
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
                GameObject casingInstance = Instantiate(casingObj);
                casingInstance.transform.position = this.transform.position;
                lastOccruance = Time.time;
            }
        }
    }
}
