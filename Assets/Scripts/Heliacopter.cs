using UnityEngine;
using System.Collections;

public class Heliacopter : MonoBehaviour {
	public AudioClip helicopterinbound;

	private bool called = false;
	private AudioSource audioSource;
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("CallHeli") && !called) {
			called = true;
			audioSource.clip =  helicopterinbound;
			audioSource.Play();
		}
	}
}
