﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Heliacopter heliacopter;
	private Transform playerSpawnPoints;

	private bool reSpawn = false;
	private bool lastToggle = false;
	private Transform[] spawnPoints;
	// Use this for initialization
	void Start () {
	spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform> ();
	print (spawnPoints.Length);
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (lastToggle != reSpawn) {
			Respawn ();
			reSpawn = true;
		} else {
			lastToggle = reSpawn;
		}
	}
	private void Respawn ()
	{
	int i = Random.Range (1, spawnPoints.Length);
	transform.position = spawnPoints [i].transform.position;
	}
	void OnFindClearArea ()
	{
		Debug.Log ("clear on player");
		heliacopter.Call();
	}
}
