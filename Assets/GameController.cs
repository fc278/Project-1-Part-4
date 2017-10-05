using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	int bronzePlayer;
	int silverPlayer;
	int goldPlayer;
	int miningSpeed;
	int timeToMine;
	float xPosition;

	public GameObject cubePrefab;

	Vector3 cubePosition;
	GameObject currentCube;

	// Use this for initialization
	void Start () {
		goldPlayer = 0;
		bronzePlayer = 0;
		silverPlayer = 0;
		miningSpeed = 2;
		timeToMine = 3;

	}
		
	// Update is called once per frame
	void Update () {

		if (Time.time > timeToMine) {

			if (bronzePlayer == 2 && silverPlayer == 2 && goldPlayer < 1) {
				goldPlayer += 1;

				cubePosition = new Vector3 (Random.Range(-5, 5), Random.Range(-5, 5),0);
				currentCube = Instantiate (cubePrefab, cubePosition, Quaternion.identity);
				xPosition += 2;

				currentCube.GetComponent<Renderer> ().material.color = Color.yellow;
			}

			else if (bronzePlayer < 4) {
				bronzePlayer += 1;

				cubePosition = new Vector3 (Random.Range(-5, 5), Random.Range(-5, 5),0);
				currentCube = Instantiate (cubePrefab, cubePosition, Quaternion.identity);
				xPosition += 2;

				currentCube.GetComponent<Renderer> ().material.color = Color.red;
			}

			else if (bronzePlayer >= 4) {
				silverPlayer += 1;

				cubePosition = new Vector3 (Random.Range(-5, 5), Random.Range(-5, 5),0);
				currentCube = Instantiate (cubePrefab, cubePosition, Quaternion.identity);
				xPosition += 2;

				currentCube.GetComponent<Renderer> ().material.color = Color.white;
			}

			timeToMine += miningSpeed;

		}

	}
}

// I thought that the instruction to "spawn 1 gold and then go back to the normal rules" was a bit confusing.
// I wasn't sure if the player is supposed to keep the gold ore afterward, and if we were supposed create an integer
// for the supply of gold.
// I think the instructions for the previous parts were pretty clear and understandable; it is just hard to 
// know how to start off.
