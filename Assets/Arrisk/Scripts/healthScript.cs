﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameController.health += 1;
        Destroy(this.gameObject);
    }
}
