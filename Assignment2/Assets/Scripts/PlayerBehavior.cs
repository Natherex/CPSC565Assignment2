using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public GameObject snitch;
    private Rigidbody physicsBody;
    // Start is called before the first frame update
    void Start()
    {
        physicsBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, snitch.transform.position);
        Vector3 force = (snitch.transform.position - transform.position);
        force.Normalize();
        physicsBody.AddForce(distance*force);
    }
}
