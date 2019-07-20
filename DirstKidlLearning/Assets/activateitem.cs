using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateitem : MonoBehaviour {

    public GameObject gb;
    public GameObject thiss;


    public void active()
    {
        Destroy(thiss);
        gb.SetActive(true);
       
    }
}
