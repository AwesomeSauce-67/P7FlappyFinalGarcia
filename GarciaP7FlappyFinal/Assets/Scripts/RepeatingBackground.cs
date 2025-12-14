using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    BoxCollider2D groundCollider;
    private float groundhorizontallength;
    // Start is called before the first frame update
    void Start()
    {
        groundCollider = GetComponent<BoxCollider2D>();
        groundhorizontallength = groundCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -groundhorizontallength) 
        {
          RepositionBackground ();
        }
    }

    private void RepositionBackground()
    {
        Vector2 groundOffset = new Vector2(groundhorizontallength * 2f, 0);
        transform.position = (Vector2)transform.position + groundOffset;
    }
}
