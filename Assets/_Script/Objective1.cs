using UnityEngine;
using System.Collections;

public class Objective1 : MonoBehaviour {
	
	public GameObject Sphere_of_influence;
	public bool grabable = false;
	public GameObject plant;
    public GameObject hand;
    public bool grabbing = false;
    public bool dropped = false;

    public Canvas pickup_promt;
    public Canvas drop_promt;

    public GameObject leftClickPrompt;
    // Use this for initialization
    void Start () 
	{
        //hand = transform.Find("the hand art").gameObject;
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject == plant) //Current Target
		{
			grabable = true;
			
		}
	}
    void OnTriggerStay(Collider other) {
        if (other.gameObject == plant && !grabbing) {
            pickup_promt.enabled = true;
        }
        else if (other.gameObject == plant && grabbing) {
            pickup_promt.enabled = false;
            drop_promt.enabled = true;
            leftClickPrompt.GetComponent<SpriteRenderer>().enabled = true;
        }
    }

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject == plant) //Current Target
		{
			grabable = false;
		}
	}
	// Update is called once per frame
	void Update () 
	{
        dropped = false;
		if (grabable == true) {
            if (Input.GetMouseButtonDown(0) && !grabbing)
            {
                plant.GetComponent<Light>().enabled = false;
                plant.transform.FindChild("GodRays").gameObject.SetActive(false);
                //dropped = false;
                grabbing = true;
            }
            else if (Input.GetMouseButtonDown(0)) {
                Destroy(plant, 4f);
                //plant.GetComponent<Collider>().enabled = false;
                plant.GetComponent<Rigidbody>().velocity = Vector3.zero;
                grabbing = false;
                dropped = true;
                grabable = false;
            }
        }
        else {
            drop_promt.enabled = false;
            pickup_promt.enabled = false;

            leftClickPrompt.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (grabbing && plant != null) {
            plant.transform.position = Sphere_of_influence.transform.position; //+ new Vector3(-.34f, .26f, 0);
        }
	}
}
