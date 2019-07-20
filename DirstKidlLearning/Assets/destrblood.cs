using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destrblood : MonoBehaviour {

    public GameObject pb;
    public ParticleSystem gb;

    public void Onestro()
    {
       if(pb.active)
        gb.Stop();
    }

}
