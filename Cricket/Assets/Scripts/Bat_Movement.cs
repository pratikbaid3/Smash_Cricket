using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat_Movement : MonoBehaviour
{
    Vector3 touchPosition;
    Rigidbody2D rb;
    Vector3 direction;

    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;
            direction = (touchPosition - transform.position);
            rb.velocity = new Vector2(direction.x, direction.y) * moveSpeed;

            if(touch.phase==TouchPhase.Ended)
            {
                rb.velocity = Vector2.zero;
            }
        }
    }
}
