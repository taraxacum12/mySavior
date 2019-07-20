using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vsriv : MonoBehaviour {

    public GameObject gb;
    public float explTime = 10f;

    private void Start()
    {
        Invoke("st", explTime);
    }

     void st(){
        gb.SetActive(true);
              }

}
