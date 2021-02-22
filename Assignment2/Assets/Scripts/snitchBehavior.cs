using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snitchBehavior : MonoBehaviour
{
    private Rigidbody physicsBody;
    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        physicsBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector3(Random.Range(-100,100),Random.Range(-100,100),Random.Range(-100,100));
        physicsBody.AddForce(direction);
    }
    void OnCollisionEnter ()
    {
        direction = -(direction*5);
        physicsBody.AddForce(direction);
    }
}
