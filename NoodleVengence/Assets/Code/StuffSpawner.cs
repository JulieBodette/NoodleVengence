using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StuffSpawner : MonoBehaviour {

	public float timeBetweenSpawns;

	public GameObject object1;

		float timeSinceLastSpawn;

		void FixedUpdate () {
			timeSinceLastSpawn += Time.deltaTime;
			if (timeSinceLastSpawn >= timeBetweenSpawns) {
				timeSinceLastSpawn -= timeBetweenSpawns;
				SpawnStuff();
			}
		}

		void SpawnStuff () {
		Instantiate(object1, this.transform.position, this.transform.rotation);
		}





	}

