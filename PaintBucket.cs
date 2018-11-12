using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintBucket : MonoBehaviour {
    private UsefulFunctions Functions;
    public GameObject UsefulFunctionsObject;
    int AidanExecutable;
    public float WindPower, Temp, Humidity, Light;
    public List<Vector3> positions;
    public GameObject PaintCube;
    public float WaitSeconds;
    bool CanDrop = true;
    private void Start()
    {
        Functions = UsefulFunctionsObject.GetComponent<UsefulFunctions>();
    }

    void Update ()
    {
        Vector3 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pz.z = 0;
        gameObject.transform.position = pz;
        /*Setting position based on weather vals*///transform.position = new Vector3(transform.position.x + WindPower, transform.position.y + Temp, transform.position.z);
                                                  /*Random long code line for creating paint...*/
        int i = 0; i++; positions.Add(transform.position); if (positions[i] != positions[i - 1] && CanDrop) {
            StartCoroutine(SmoothFactor(WaitSeconds, CanDrop));  GameObject NEWPAINT = Instantiate(PaintCube, positions[i], Quaternion.identity); NEWPAINT.transform.parent = transform;
            NEWPAINT.GetComponent<SpriteRenderer>().color = new Color(Temp*100, Light*100, Humidity*100);
            transform.position = pz;           /*Just testing my attempt at a universal function class*/
            Debug.Log(AidanExecutable); Functions.Function_0(AidanExecutable); Debug.Log(AidanExecutable);
        } 
	}
    IEnumerator SmoothFactor(float Seconds, bool TrueFalse)
    /*Another long line of code simply for a smoothfactor for the paint "droplet" creation*/{TrueFalse = !TrueFalse; yield return new WaitForSeconds(Seconds); TrueFalse = !TrueFalse;}}