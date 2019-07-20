using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changepos : MonoBehaviour {

	public void pus()
    {
        MagnetSensor.OnCardboardTrigger += () =>
        {
            transform.position = new Vector3(0, 0, 0);

        };
    }
}
