using UnityEngine;
using System.Collections;

public class Daycycle : MonoBehaviour {


	public float minutesPerSecond;


	
	// Update is called once per frame
	void Update () {
	float angleThisFrame = Time.deltaTime / 360 * minutesPerSecond;
		transform.RotateAround (transform.position, Vector3.forward, angleThisFrame);
	}
}
