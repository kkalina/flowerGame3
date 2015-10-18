using UnityEngine;
using System.Collections;

public class TREX : MonoBehaviour {
    public float speed = 2f;
    public float rotationSpeed = 1f;
    public GameObject target;
    public int health = 1000;
    public GameObject deathSplosion;
    public GameObject playerCam;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + (speed * Time.deltaTime));

        this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
Quaternion.LookRotation(target.transform.position - this.transform.position), rotationSpeed * Time.deltaTime);
        Vector3 movement = new Vector3(this.transform.forward.x, 0f, this.transform.forward.z);
        this.transform.position += movement * speed * Time.deltaTime;

        if(health <= 0)
        {
            GameObject deathSplosionInst = Instantiate(deathSplosion);
            deathSplosionInst.transform.position = this.transform.position;
            playerCam.GetComponent<shakifier>().shaking = false;
            Destroy(this.gameObject);
        }
    }
    /*
    void onCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "bullet")
        {
            health = health - 1;
        }
    }
    */
}
