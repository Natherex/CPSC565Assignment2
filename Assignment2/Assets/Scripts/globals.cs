﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globals : MonoBehaviour
{
    public static globals Instance { get; private set; }
    // Start is called before the first frame update
    //[5]Reso Coder (2017, Mar 24) Singletons in Unity - Simple Tutorial for Beginners - https://www.youtube.com/watch?v=CPKAgyp8cno&ab_channel=ResoCoder
    public int numberOfGrifs;
    public int numberOfSlyth;
    public int spawnRate;

    public int gScore = 0;
    public int sScore = 0;
    private void Awake()
    {
        if ( Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }
}
