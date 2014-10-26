using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	// Target for the camera to follow
	public Transform target;

	// Give camera some lag when following so it isn't harsh
	public float smoothing = 5f;

	// Vector from the camera to player
	Vector3 offset;

	void Start() {
		// Store offset at the beginning of the game so it will stay constant throughout the game
		offset = transform.position - target.position;
	}

	// Moves the camera after every physics step
	void FixedUpdate() {
		// Target position for camera to reach
		Vector3 targetCamPos = target.position + offset;

		// Smooth the transition movement
		transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
	}

	
}
