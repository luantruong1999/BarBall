﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallPrefab : MonoBehaviour
{
    public BoxCollider2D boxCollider;
    public new RectTransform transform;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider.size = new Vector2(transform.sizeDelta.x, transform.sizeDelta.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
