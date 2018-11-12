using System.Collections;
using UnityEngine;
using System.IO.Ports;

public class AcceptValues_COM3 : MonoBehaviour
{
    public string Output = "";
    private TextMesh txt;
    public int X = 0;
    public int Y = 0;
    SerialPort PORT = new SerialPort("COM3", 9600);
    void Start()
    {
        PORT.Open();
        txt = GetComponent<TextMesh>();
    }
	void Update ()
    {
        Output = PORT.ReadLine();
        ReadX(X);
        ReadY(X);

        transform.position = new Vector3(transform.position.x + Y, transform.position.y + X, transform.position.z);

        txt.text = Output;
	}
    void ReadX(int x)
    {
        x = 1;

    }
    void ReadY(int y)
    {
        y = 1;
    }
}
