using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidParticlesChangePos : MonoBehaviour
{

    public Material vidMat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vidMat.SetVector("_SystemPos",transform.position);
    }
}
