﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDestroyer : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        DestroyCube();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DestroyCube()
    {
        Destroy(this.gameObject, 5);
    }
}
