﻿using UnityEngine;
using System.Collections;

public class carEnemy : MonoBehaviour {
	public float speed = 1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 (0, 1, 0) * speed * Time.deltaTime);
	}
}
