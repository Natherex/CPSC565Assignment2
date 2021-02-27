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
        direction = new Vector3 (Random.Range(-50,50),Random.Range(-50,50),Random.Range(-50,50));
        physicsBody.AddForce(direction/20);
    }
    void OnCollisionEnter (Collision collision)
    {
        direction = -(direction*5);
        physicsBody.AddForce(direction);

        if(collision.gameObject.name == "player(Clone)"){
            transform.position = new Vector3(Random.Range(1,40),Random.Range(-50,50),Random.Range(-50,50));
        }

    }
}
