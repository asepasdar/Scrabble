﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Word", menuName = "Word")]
public class Word : ScriptableObject {
    public Sprite sprite;
    public int point;
    public string huruf;
}
