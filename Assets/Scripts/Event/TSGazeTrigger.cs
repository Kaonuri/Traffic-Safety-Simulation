﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TSGazeTrigger : MonoBehaviour
{
    public bool clear { private set; get; }

    public void Clear()
    {
        clear = true;
    }
}
