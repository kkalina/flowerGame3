using UnityEngine;
using System.Collections;

public class Intro : MonoBehaviour {
	public AudioSource part1;
	public AudioSource part2;
	public AudioSource part3;
	public AudioSource part4;
	// Use this for initialization
	IEnumerator execute1()
	{
		yield return new WaitForSeconds(19F);
		part2.Play();
		yield return new WaitForSeconds(4F);
		part3.Play();
		yield return new WaitForSeconds(4F);
		part4.Play();
		yield return new WaitForSeconds(8F);
		Application.LoadLevel ("karl_scene_2");
	}

	void Start () {
		part1.Play();
		StartCoroutine (execute1());


	}
	
	// Update is called once per frame

}
