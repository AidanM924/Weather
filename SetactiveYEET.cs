using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetactiveYEET : MonoBehaviour
{
    public GameObject Mover;
    public Material Mat;
    string check = "Check_1\r";
void Start()
{
    Mat = GetComponent<TrailRenderer>().material;
}
void Update ()
    {
        if (Mover != null)
        {
            transform.position = Mover.transform.position;
            Mat.color = new Color(Mover.GetComponent<WeatherEffects>().light, Mover.GetComponent<WeatherEffects>().Temp, Mover.GetComponent<WeatherEffects>().WindPower);
            //if (Input.GetMouseButton(0))
          //  {
                Mover.SetActive(true);
            //  }
            //    else
            //   {
            //Mover.SetActive(false);
            //   }

            char[] x = check.ToCharArray();

            /*for (int i = 0; i < x.Length; i++)
            {
                if (x[i].ToString == "\" || )
            }
            */
        }
    }
}