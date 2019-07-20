using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ochagsagas : MonoBehaviour {

    public GameObject gb;
	public void satushit()
    {
        MagnetSensor.OnCardboardTrigger += () =>
        {
            Destroy(gb);
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.19f, transform.position.z);
        };
       
        if (Input.GetButtonDown("Fire1"))
        {
            Destroy(gb);
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.19f, transform.position.z);
        }
    }
}
