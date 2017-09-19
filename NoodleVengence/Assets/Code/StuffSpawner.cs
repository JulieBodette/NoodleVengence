using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StuffSpawner : MonoBehaviour {

	public float timeBetweenSpawns;

	public Dissapearonbuttonpress[] stuffPrefabs;

		float timeSinceLastSpawn;

		void FixedUpdate () {
			timeSinceLastSpawn += Time.deltaTime;
			if (timeSinceLastSpawn >= timeBetweenSpawns) {
				timeSinceLastSpawn -= timeBetweenSpawns;
				SpawnStuff();
			}
		}

		void SpawnStuff () {
		Dissapearonbuttonpress prefab = stuffPrefabs[Random.Range(0, stuffPrefabs.Length)];
		Dissapearonbuttonpress spawn = Instantiate<Dissapearonbuttonpress>(prefab);
		//Dissapearonbuttonpress spawn = prefab.GetPooledInstance<Dissapearonbuttonpress>();
		spawn.transform.localPosition = transform.position;
		}
	}

