using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerascrift : MonoBehaviour
{
    public Transform followplayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 camerapos = transform.position;
        camerapos.z = followplayer.position.z;
    }
}
