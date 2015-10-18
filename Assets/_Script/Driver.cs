using UnityEngine;
using System.Collections;

public class Driver : MonoBehaviour {
    public float duration = 8;
    public double multiplier = 1;
    public GameObject sphere;
    public GameObject tRex;
    public GameObject player;
    public GameObject playerMusicObj;
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
    public AudioSource shootTrex;

    public AudioSource itsComingForUs;
    public AudioSource CoD;

    public bool playAudio = true;
    private bool pickADaisy = false;
    private bool waterPlants = false;
    private bool sunPlants = false;
    private bool smellRoses = false;
    private bool pickRifle = false;
    private bool fightTrex = false;
    private float t = 0;
    public bool tRexDead = false;
    public GameObject iPrompt;


    IEnumerator distraction(int i) {
        //yield return new WaitForSeconds(50f);

        if (i == 0) {
            yield return new WaitForSeconds(5f);
            welcome.Play();
            yield return new WaitForSeconds(8f);
            daisy.Play();

            grabDriver.plant.transform.FindChild("GodRays").gameObject.SetActive(true);
            yield return new WaitForSeconds(5f);
        }
        if (i == 1)
        {
            yield return new WaitForSeconds(1f);
            gj.Play();
            yield return new WaitForSeconds(8f);
            water.Play();
            grabDriver.plant = GameObject.Find("_water_2");
            grabDriver.plant.GetComponent<Light>().enabled = true;

            grabDriver.plant.transform.FindChild("GodRays").gameObject.SetActive(true);
        }

        else if (i == 2)
        {
            yield return new WaitForSeconds(1f);
            flowerPerson.Play();
            yield return new WaitForSeconds(12f);
            tyPlants.Play();
            yield return new WaitForSeconds(10f);
            move.Play();
            grabDriver.plant = GameObject.Find("_move_3");
            grabDriver.plant.GetComponent<Light>().enabled = true;

            grabDriver.plant.transform.FindChild("GodRays").gameObject.SetActive(true);
        }
        else if (i == 3)
        {
            yield return new WaitForSeconds(8f);
            poppies.Play();
            yield return new WaitForSeconds(12f);
            smell.Play();
            grabDriver.plant = GameObject.Find("_smell_4");
            grabDriver.plant.GetComponent<Light>().enabled = true;

            grabDriver.plant.transform.FindChild("GodRays").gameObject.SetActive(true);
        }
        else if (i == 4) {
            yield return new WaitForSeconds(10f);
            squirrels.Play();
            yield return new WaitForSeconds(8f);
            playerMusicObj.GetComponent<AudioSource>().Stop();
            tRex.SetActive(true);
            fightTrex = true; 
            yield return new WaitForSeconds(3f);
            iPrompt.SetActive(true);
            shootTrex.Play();
            player.GetComponent<interactMode>().safety = false;
            yield return new WaitForSeconds(10f);
            itsComingForUs.Play();

        }
        //yield return new WaitForSeconds(5f);
    }

    void Start() {
        grabDriver.plant = GameObject.Find("_daisy_1");
        grabDriver = sphere.GetComponent<Objective1>();
        grabDriver.plant.GetComponent<Light>().enabled = true;
        //welcome.Play();
        pickADaisy = true; //distraction(.5f);
        //playAudio = pickADaisy;

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
                StartCoroutine(distraction(0));
                playAudio = false;
            }
            if (grabDriver.dropped)
            {
                //gj.Play();
                pickADaisy = false;
                playAudio = true;
                waterPlants = true; StartCoroutine(distraction(1));
            }
            
        }

        //CHANGE THE THING WE CAN PICK UP
        else if (waterPlants) {
            //grabDriver.plant = GameObject.Find("_water_2");
            //grabDriver.plant.GetComponent<Light>().enabled = true;
            if (playAudio)
            {
                //water.Play();
                playAudio = false;
            }
            if (grabDriver.dropped)
            {
                waterPlants = false;
                playAudio = true;
                grabDriver.dropped = false;
                //flowerPerson.Play();
                sunPlants = true; StartCoroutine(distraction(2));
            }
           
        }
        else if (sunPlants)
        {
            //grabDriver.plant = GameObject.Find("_move_3");
            //grabDriver.plant.GetComponent<Light>().enabled = true;
            if (playAudio)
            {
                //move.Play();
                playAudio = false;
                //notHard.Play();
            }
            if (grabDriver.dropped)
            {
                sunPlants = false;
                playAudio = true;
                grabDriver.dropped = false;
                smellRoses = true; StartCoroutine(distraction(3));

            }
        }
        else if (smellRoses)
        {
            //grabDriver.plant = GameObject.Find("_smell_4");
            //grabDriver.plant.GetComponent<Light>().enabled = true;
            if (playAudio)
            {
                //smell.Play();
                playAudio = false;
            }
            if (grabDriver.dropped)
            {
                sunPlants = false;
                playAudio = true;
                grabDriver.dropped = false;
                smellRoses = false;
                //fightTrex = true; 
                StartCoroutine(distraction(4));
            }
        }
        else if (fightTrex)
        {
            if (tRexDead)
            {
                CoD.Play();
                player.GetComponent<interactMode>().interactionMode = interactMode.modes.admire;
                //next scene
            }
        }
    }	
}
