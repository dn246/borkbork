using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

	public int HP = 10;
	public float SpawnTime = 10;
	public float recovery_time = 8;

	public GameObject prefabfire;

	private int HPcounter;

	void Start () {
		HPcounter = HP;

		InvokeRepeating ("add_counter", SpawnTime, recovery_time); 
		InvokeRepeating ("fire_spawn", SpawnTime*2, SpawnTime);
	}

	void add_counter(){
		if (HPcounter < HP)
			HPcounter++;

		Debug.Log (HPcounter);
		Debug.Log (Time.time);
	}
	
	void fire_spawn(){
		if (HPcounter >= HP) {
			Instantiate(prefabfire);
			Debug.Log ("fire poop");
			Debug.Log (Time.time);

		}
	}
}
