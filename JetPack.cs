﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetPack : MonoBehaviour
{
    public GameObject jetPack;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "JetPack")
        {
            jetPack.SetActive(true);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
