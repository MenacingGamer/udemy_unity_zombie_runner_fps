using UnityEngine;
using System.Collections;

public class Helicopter : MonoBehaviour {


	private bool called = false;
	private Rigidbody rigidbody;
	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody>();
	}

	 public void OnDispatchHelicopter ()
	{
		Debug.Log("heliInBound");
		rigidbody.velocity = new Vector3 (0, 0, 50f);
		called = true;
		}
}
