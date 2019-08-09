using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Movement : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField]
    private Vector3 impulseForce = new Vector3(0, 0, 0);

    private CircleCollider2D _collider;
    public PhysicsMaterial2D mat;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        float Imp = Random.Range(-18, -23);
        impulseForce.x=Imp;
        rb.AddForce(impulseForce, ForceMode2D.Impulse);
        _collider = gameObject.GetComponent<CircleCollider2D>();
        //mat = gameObject.GetComponent<PhysicsMaterial2D>();
        float friction = Random.Range(1f, 2.5f);
        mat.friction = friction;
        float bounce = Random.Range(.3f, .8f);
        mat.bounciness = bounce;
        Debug.Log("Friction "+mat.friction);
        Debug.Log("Bounce " + mat.bounciness);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 10.3f || transform.position.x < -9.3f)
        {
            Destroy(this.gameObject);
        }

        if (transform.position.x < 7.8f)
        {
            _collider.enabled = true;
        }
    }
    /**private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "RunBar")
        {
            Debug.Log("Run Scored");
        }
    }**/
}

