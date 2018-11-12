using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WeatherEffects : MonoBehaviour {
    public float WindPower;
    public float Temp;
    public float light;
    public GameObject Crayon, R, G, B;

    public Material Mat;
	// Use this for initialization
	void Start () {
        Mat = Crayon.GetComponent<TrailRenderer>().material;		
	}

    private void OnTriggerExit(Collider collision)
    {
        if (collision.transform.name == "Cube_1")
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }

    // Update is called once per frame
    void Update () {
        Vector3 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pz.z = 0;
        gameObject.transform.position = pz;
        transform.position = new Vector3(transform.position.x + (Input.GetAxis("Horizontal") * Mathf.Clamp(Temp/10, -2, 2)), transform.position.y + (Input.GetAxis("Vertical") * Mathf.Clamp(WindPower/10, -2, 2)), 0);
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
        Mat.color = new Color(R.GetComponent<Slider>().value, G.GetComponent<Slider>().value, B.GetComponent<Slider>().value);
	}
}
