﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionControl : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        print("Landed on the " + collision.gameObject.name);
    }    
}
