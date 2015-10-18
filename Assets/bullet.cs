using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {
    public float speed = 100f;
    public GameObject hitExplosion;
    public GameObject tRex;
	// Use this for initialization
	void Start () {
        this.gameObject.GetComponent<Rigidbody>().velocity = this.transform.up * speed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider coll)
    {
        if ((coll.gameObject.tag == "rex") || (coll.gameObject.tag == "enviro"))
        {
            
            GameObject hit = Instantiate(hitExplosion);
            hit.transform.position = this.transform.position;
            hit.transform.rotation = this.transform.rotation;
            tRex.GetComponent<TREX>().health = tRex.GetComponent<TREX>().health - 1;
            Destroy(this.gameObject);
        }
    }

}
