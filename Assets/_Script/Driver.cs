using UnityEngine;
using System.Collections;

public class Driver : MonoBehaviour {
    public float duration = 10;
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
    private bool pickADaisy = true;
    private bool waterPlants = false;
    private bool sunPlants = false;
    private bool smellRoses = false;
    private bool pickRifle = false;
    private bool fightTrex = false;
    private float t = 0;


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


    void distraction(int i){
        if (i == 1)
            dandolions.Play();
        else if (i == 2)
            tyPlants.Play();
        else if (i == 3)
            poppies.Play();
        else
            squirrels.Play();
        t = 0;
        while (t < duration) {
            t += Time.deltaTime;
        }

        return;
    }

    // Use this for initialization
    void Update() {
        if (playAudio) {
            welcome.Play();
            playAudio = false;
        }

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
                waterPlants = true;
            }
            distraction(1);
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
                sunPlants = true;
                grabDriver.dropped = false;
                flowerPerson.Play();
            }
            t = 0;
            while (t < duration * .6)
                t += Time.deltaTime;
            distraction(2);
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
                smellRoses = true;
                grabDriver.dropped = false;

            }
            distraction(3);
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
                fightTrex = true;
                grabDriver.dropped = false;
            }
            distraction(4);
        }
    }	
}
