using UnityEngine;
using System.Collections;

public class OpenElement : MonoBehaviour {

	
	private Animator Opening;


	
	void Start () {
		Opening = GetComponent<Animator>();
	}

	
	public void openDoor () {

        MagnetSensor.OnCardboardTrigger += () =>
        {
            if (Opening.GetInteger("EtatAnim") == 1)
            {
                Opening.SetInteger("EtatAnim", 2);
            }
            else
            {
                Opening.SetInteger("EtatAnim", 1);
            };
        };
            if (Input.GetButtonDown("Fire1")) {            

			if (Opening.GetInteger ("EtatAnim") == 1) {
				Opening.SetInteger("EtatAnim",2);
			} else {
				Opening.SetInteger("EtatAnim",1);
			};
		}
	}
}
