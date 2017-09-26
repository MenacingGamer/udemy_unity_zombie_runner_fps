using UnityEngine;
using System.Collections;

public class Heliacopter : MonoBehaviour {
	public AudioClip helicopterinbound;

	private bool called = false;
	private AudioSource audioSource;
	private Rigidbody rigidbody;
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
		rigidbody =GetComponent<Rigidbody>();
	}

	public void Call ()
	{
		if (called) {
			called = true;
			audioSource.clip =  helicopterinbound;
			audioSource.Play();
			rigidbody.velocity = new Vector3 (0, 0, 50f);
		}
	}
}
