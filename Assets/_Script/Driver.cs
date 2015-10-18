using UnityEngine;
using System.Collections;

public class Driver : MonoBehaviour {
    public float duration = 8;
    public double multiplier = 1;
    public GameObject sphere;
    public Objective1 grabDriver;
    public AudioSource welcome;
    public AudioSource daisy;
    public AudioSource water;
    public AudioSource move;
    public AudioSource smell;
    public AudioSource dandolions;
    public AudioSource tyPlants;
    public AudioSource poppies;
    public AudioSource squirrels;
    public AudioSource gj;
    public AudioSource flowerPerson;
    public AudioSource notHard;
    public bool playAudio = true;
    private bool pickADaisy = false;
    private bool waterPlants = false;
    private bool sunPlants = false;
    private bool smellRoses = false;
    private bool pickRifle = false;
    private bool fightTrex = false;
    private float t = 0;



    bool distraction(double i) {
        while (t < duration) {
            t += Time.deltaTime;
        }
        if (i == 1)
            dandolions.Play();
        else if (i == 2)
            tyPlants.Play();
        else if (i == 3)
            poppies.Play();
        else if (i == 4)
            squirrels.Play();
        else
            multiplier = i;
        t = 0;
        while (t < duration) {
            t += Time.deltaTime;
        }
        multiplier = 1;
        return true;
    }

    void Start() {
        grabDriver.plant = GameObject.Find("_daisy_1");
        grabDriver = sphere.GetComponent<Objective1>();
        grabDriver.plant.GetComponent<Light>().enabled = true;
        welcome.Play();
        pickADaisy = distraction(.5);
        playAudio = pickADaisy;

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
                daisy.Play();
                playAudio = false;
            }
            if (grabDriver.dropped)
            {
                gj.Play();
                pickADaisy = false;
                playAudio = true;
                waterPlants = distraction(1);
            }
            
        }

        //CHANGE THE THING WE CAN PICK UP
        else if (waterPlants) {
            grabDriver.plant = GameObject.Find("_water_2");
            grabDriver.plant.GetComponent<Light>().enabled = true;
            if (playAudio)
            {
                water.Play();
                playAudio = false;
            }
            if (grabDriver.dropped)
            {
                waterPlants = false;
                playAudio = true;
                grabDriver.dropped = false;
                flowerPerson.Play();
                sunPlants = distraction(2);
            }
           
        }
        else if (sunPlants)
        {
            grabDriver.plant = GameObject.Find("_move_3");
            grabDriver.plant.GetComponent<Light>().enabled = true;
            if (playAudio)
            {
                move.Play();
                playAudio = false;
                notHard.Play();
            }
            if (grabDriver.dropped)
            {
                sunPlants = false;
                playAudio = true;
                grabDriver.dropped = false;
                smellRoses = distraction(3);

            }
        }
        else if (smellRoses)
        {
            grabDriver.plant = GameObject.Find("_smell_4");
            grabDriver.plant.GetComponent<Light>().enabled = true;
            if (playAudio)
            {
                smell.Play();
                playAudio = false;
            }
            if (grabDriver.dropped)
            {
                sunPlants = false;
                playAudio = true;
                grabDriver.dropped = false;
                fightTrex = distraction(4);
            }
        }
    }	
}
