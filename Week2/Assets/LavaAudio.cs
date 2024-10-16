﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaAudio : MonoBehaviour
{
    AudioSource audioData;

    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
        Debug.Log("Lava started");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
