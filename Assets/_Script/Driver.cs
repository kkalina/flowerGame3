using UnityEngine;
using System.Collections;

public class Driver : MonoBehaviour {
    public GameObject sphere;
    public Objective1 grabDriver;
    //public AudioSource welcome;
    public bool playAudio = true;
    private bool pickADaisy = true;
    private bool waterPlants = false;
    private bool sunPlants = false;
    private bool smellRoses = false;
    private bool pickRifle = false;
    private bool fightTrex = false;


    void Start() {
        grabDriver = sphere.GetComponent<Objective1>();
        grabDriver.plant.GetComponent<Light>().enabled = true;
    }
    //Pick a daisy
    //Water the flower (pick it up lol)
    //move the flower into the sunlight (pick it up lol)
    //smell the roses
    // //stop the assasination????
    //Pick up assault rifle
    //Fight the trex
    //Pick your favorite flower
    //Move the cactus
    //Pet the daisy
    //Relocate rock to more zen location
        //You dummy
    //Pick another daisy

	// Use this for initialization
	void Update() {
        if (pickADaisy)
        {
            if (playAudio)
            {
                //welcome.Play();
                playAudio = false;
            }
            if (grabDriver.dropped)
            {
                pickADaisy = false;
                //playAudio = true;
                waterPlants = true;
            }
        }

        //CHANGE THE THING WE CAN PICK UP
        else if (waterPlants) {
            grabDriver.plant = GameObject.Find("_water_2");
            grabDriver.plant.GetComponent<Light>().enabled = true;
            if (playAudio)
            {
                //welcome.Play();
                playAudio = false;
            }
            if (grabDriver.dropped)
            {
                waterPlants = false;
                //playAudio = true;
                sunPlants = true;
                grabDriver.dropped = false;
            }
        }
        else if (sunPlants)
        {
            grabDriver.plant = GameObject.Find("_move_3");
            grabDriver.plant.GetComponent<Light>().enabled = true;
            if (playAudio)
            {
                //welcome.Play();
                playAudio = false;
            }
            if (grabDriver.dropped)
            {
                sunPlants = false;
                //playAudio = true;
                smellRoses = true;
                grabDriver.dropped = false;

            }
        }
        else if (smellRoses)
        {
            grabDriver.plant = GameObject.Find("_smell_4");
            grabDriver.plant.GetComponent<Light>().enabled = true;
            if (playAudio)
            {
                //welcome.Play();
                playAudio = false;
            }
            if (grabDriver.dropped)
            {
                sunPlants = false;
                //playAudio = true;
                fightTrex = true;
                grabDriver.dropped = false;
            }
        }
    }
	
	
}
