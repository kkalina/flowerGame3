using UnityEngine;
using System.Collections;

public class demolish : MonoBehaviour {

    private Vector3 startPos;
    public float intensity = 1f;
    public float distance = 10f;
    private bool demolishing = false;
    public GameObject demolishObj;

	// Use this for initialization
	void Start () {
        startPos = demolishObj.transform.position;
        
	}
	
	// Update is called once per frame
	void Update () {
        if (demolishing)
        {
            demolishObj.transform.position = new Vector3(startPos.x + (Random.value * intensity), demolishObj.transform.position.y - (Random.value * intensity * 0.5f), startPos.z + (Random.value * intensity));

            if (demolishObj.transform.position.y < (startPos.y - distance))
            {
                this.enabled = false;
            }
        }

	}

    void OnTriggerEnter(Collider coll)
    {
        if(coll.tag == "rex")
            demolishing = true;
    }

}
