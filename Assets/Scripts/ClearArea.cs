using UnityEngine;
using System.Collections;

public class ClearArea : MonoBehaviour {

	public float timeSinceLastTrigger = 0f;

	private bool foundClearArea = false;
	
	// Update is called once per frame
	void Update ()
	{
		timeSinceLastTrigger += Time.deltaTime;

		if (timeSinceLastTrigger > 5f && Time.realtimeSinceStartup > 15f && !foundClearArea) {
			SendMessageUpwards ("OnFindClearArea");
			foundClearArea = true;
		}
	}
	void OnTriggerStay (Collider collider)
	{
		if (collider.tag != "Player") {
			timeSinceLastTrigger = 0;

		}
	}
}
