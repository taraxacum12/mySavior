using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gvrTel : MonoBehaviour {

    public int dstOfRay = 10;
    private RaycastHit hit;

    private MagnetSensor mgsens;

	void Start () {

        mgsens = GetComponent<MagnetSensor>();

	}
	
	
	void Update () {

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

        if(Physics.Raycast(ray, out hit, dstOfRay))
        {
            if (Input.GetButtonDown("Fire1") && hit.transform.gameObject.tag == "Ground")
            teleportPlayer(hit.point);

            MagnetSensor.OnCardboardTrigger += () => {
                if (hit.transform.gameObject.tag == "Ground")
                    teleportPlayer(hit.point);
            };
        }
	}

    public void teleportPlayer(Vector3 target)
    {
        transform.position = new Vector3(target.x, transform.position.y, target.z);
    }
}
