using UnityEngine;
using System.Collections;

public class carSpawner : MonoBehaviour {
	public GameObject[] cars;
	public float maxPos = 1.8f;
	public float delayTimer = 1f;
	int carNo;
	float timer;
	// Use this for initialization
	void Start () {
		timer = delayTimer;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0) {
			Vector3 carPos = new Vector3 (Random.Range (-1.8f, 1.8f), transform.position.y, transform.position.z);
			carNo = Random.Range(0,4);
			Instantiate (cars[carNo], carPos, transform.rotation);
			timer = delayTimer;		
		}
	}
}
