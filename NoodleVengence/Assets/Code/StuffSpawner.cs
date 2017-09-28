using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StuffSpawner : MonoBehaviour {

	public float timeBetweenSpawns;
	public Vector2 vel; //the velocity of the noodles that it spawns

	public GameObject object1;

	public GameObject temp;

		float timeSinceLastSpawn;

		void FixedUpdate () {
			timeSinceLastSpawn += Time.deltaTime;
			if (timeSinceLastSpawn >= timeBetweenSpawns) {
				timeSinceLastSpawn -= timeBetweenSpawns;
				SpawnStuff();
			}
		}

		void SpawnStuff () {
		temp = Instantiate(object1, this.transform.position, this.transform.rotation);
		temp.GetComponent<Dissapearonbuttonpress>().setVelocity (vel);
		}





	}

