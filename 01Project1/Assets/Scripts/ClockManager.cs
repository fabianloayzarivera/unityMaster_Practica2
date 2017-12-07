using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockManager : MonoBehaviour {

	public float hoursAngle = 0;
	public float minutesAngle = 0;
	public float secondsAngle = 0;

	public GameObject hoursPivot;
	public GameObject minutesPivot;
	public GameObject secondsPivot;

	private float timePassed = 0;

	// Use this for initialization
	void Start () {

		System.DateTime date = System.DateTime.Now;
		int hours = date.Hour > 12 ? date.Hour-12 : date.Hour;
		int minutes =date.Minute;
		int seconds = date.Second;

		secondsPivot.transform.Rotate (0, 6 * seconds, 0);
		minutesPivot.transform.Rotate (0, (0.1f * (minutes * 60 + seconds)), 0);
		hoursPivot.transform.Rotate (0, (0.0083f * (hours * 3600 + minutes * 60 + seconds)), 0);
		Debug.Log (hours +"  "+ minutes+"  "+ seconds);
	}
	
	// Update is called once per frame
	void Update () {
		//marsRot.transform.Rotate(0,marsOrbitSpeed * Time.deltaTime,0);
		timePassed += Time.deltaTime;
		secondsAngle += (int)(timePassed);
		if (timePassed >= 1) {
			if (secondsAngle == 360)
				secondsAngle = 0;
			secondsAngle += 6;
			secondsPivot.transform.Rotate (0, 6, 0);
			timePassed = 0;

		}
		minutesPivot.transform.Rotate (0, (0.1f * Time.deltaTime), 0);
		hoursPivot.transform.Rotate (0, (0.0083f * Time.deltaTime), 0);

	}
}
