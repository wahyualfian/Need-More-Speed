using UnityEngine;
using System.Collections;

public class carController : MonoBehaviour {
	public float carSpeed;
	public float maxPos = 1.8f;
	Vector2 position;
	public uiManager ui;
	public audioManager am;

		bool currentPlatformAndroid = false;

		Rigidbody2D rb;
	// Use this for initialization
	void Awake(){
				rb = GetComponent<Rigidbody2D> ();
			#if UNITY_ANDORID
				currentPlatformAndroid = true;
			#else
				currentPlatformAndroid = false;
			#endif
	}
	void Start () {
		position = transform.position;
				if (currentPlatformAndroid == true) {
						Debug.Log ("android");
				} else {
						Debug.Log ("Windows");
				}
	}
	
	// Update is called once per frame
	void Update () {
		if (currentPlatformAndroid == true) {
		
		}else{
		position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;
		position.x = Mathf.Clamp (position.x, -1.8f, 1.8f);
		transform.position = position;
		}
		position = transform.position;
		position.x = Mathf.Clamp (position.x, -1.8f, 1.8f);
		transform.position = position;
	}

	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "Enemy"){
			gameObject.SetActive (false);
			ui.gameOverActivated ();
			am.carCrash.Play ();
		}
	}
		public void moveRight(){
				rb.velocity = new Vector2 (carSpeed, 0);
		}
		public void moveLeft(){
				rb.velocity = new Vector2 (-carSpeed, 0);
		}
		public void setVelocityZero(){
				rb.velocity = Vector2.zero;
		}
}
