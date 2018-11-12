using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcceptValuesFINAL : MonoBehaviour {
    public float WindPower, Temp, Humidity, Light;
    public Material MAT;
	// Use this for initialization
	void Start () {
		MAT = GetComponent<TrailRenderer>().material;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x + WindPower, transform.position.y + Temp, transform.position.z);
        Vector3 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pz.z = 0;
        gameObject.transform.position = pz;
        MAT.color = new Color(Temp, Light, WindPower);
        /*Swtting the width of the li*/GetComponent<TrailRenderer>().endWidth = WindPower; GetComponent<TrailRenderer>().startWidth = WindPower;
	}
}