using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitManagerScript : MonoBehaviour {

	public GameObject marsRot;
	public GameObject earthRot;
	public GameObject moonRot;
	public GameObject sun;
	public GameObject mars;
	public GameObject earth;
	public GameObject moon;

	public float marsRotSpeed = 100.0f;
	public float earthRotSpeed = 100.0f;
	public float moonRotSpeed = 100.0f;
	public float sunRotSpeed = 100.0f;

	public float marsOrbitSpeed = 200.0f;
	public float earthOrbitSpeed = 100.0f;
	public float moonOrbitSpeed = 150.0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//solarSystemRotation += solarSystemSpeed * Time.deltaTime;
		marsRot.transform.Rotate(0,marsOrbitSpeed * Time.deltaTime,0);
		earthRot.transform.Rotate(0,earthOrbitSpeed* Time.deltaTime,0);
		moonRot.transform.Rotate(0,moonOrbitSpeed * Time.deltaTime,0);

		sun.transform.Rotate(0,sunRotSpeed * Time.deltaTime,0);
		mars.transform.Rotate(0,marsRotSpeed * Time.deltaTime,0);
		earth.transform.Rotate(0,earthRotSpeed* Time.deltaTime,0);
		moon.transform.Rotate(0,moonRotSpeed * Time.deltaTime,0);

	}
}
