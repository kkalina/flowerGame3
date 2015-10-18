using UnityEngine;
using System.Collections;

public class interactMode : MonoBehaviour {

    public enum modes { admire, annihilate };
    public modes interactionMode = modes.admire;
    private modes currentMode = modes.admire;
    public GameObject gunObj1;
    public GameObject gunObj2;
    public GameObject gunObj3;
    public GameObject gunObj4;

    public GameObject iPrompt;

    public GameObject handObj1;
    public GameObject handObj2;

    private float armTime = 9999999f;
    public float armDelay = 3f;
    public bool arming = false;

    public bool safety = true;

    // Use this for initialization
    void Start () {

        gunObj2.SetActive(false);
        gunObj3.SetActive(false);
        gunObj4.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.T) && !safety)
        {
            if (interactionMode == modes.admire)
                interactionMode = modes.annihilate;
            else
                interactionMode = modes.admire;
            safety = true;
        }

	    if((interactionMode == modes.annihilate) && (currentMode == modes.admire))
        {
            currentMode = modes.annihilate;

            iPrompt.SetActive(false);
            armTime = Time.time;
            gunObj1.SetActive(true);
            handObj1.SetActive(false);
            gunObj1.GetComponent<Animator>().SetBool("gunMode", true);
            arming = true;
        }
        if ((interactionMode == modes.admire) && (currentMode == modes.annihilate))
        {

            currentMode = modes.admire;
            gunObj2.SetActive(false);
            gunObj3.SetActive(false);
            gunObj4.SetActive(false);
            handObj1.SetActive(true);
            handObj2.SetActive(true);
            print("DISARMING");
            gunObj1.GetComponent<Animator>().enabled = true;
            gunObj1.GetComponent<Animator>().SetBool("gunMode", false);
            //gunObj1.SetActive(true);
        }
        if((Time.time > (armTime + armDelay)) && (currentMode == modes.annihilate))
        {

            gunObj1.GetComponent<Animator>().enabled = false;
            gunObj2.SetActive(true);
            gunObj3.SetActive(true);
            gunObj4.SetActive(true);
            handObj2.SetActive(false);
            arming = false;
        }
	}
}
