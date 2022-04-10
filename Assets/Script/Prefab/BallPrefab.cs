using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPrefab : MonoBehaviour
{
    public float speed;
    public new Rigidbody2D rigidbody;
    public BoxCollider2D boxCollider;
    public RectTransform rectTransform;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 force = new Vector2(50,50) * speed;
        rigidbody.AddForce(force);
        boxCollider.size = new Vector2(rectTransform.sizeDelta.x, rectTransform.sizeDelta.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
