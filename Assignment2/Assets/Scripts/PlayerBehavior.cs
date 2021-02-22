using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public int weight;
    public int maxVelocity;
    public int agro;
    public int stamina;

    public int team;
    public GameObject snitch;
    private Rigidbody physicsBody;
    // Start is called before the first frame update
    public void constructor(int weight, int maxVelocity, int agro, int stamina , int team)
    {
        this.weight = weight;
        this.maxVelocity = maxVelocity;
        this.agro = agro;
        this.stamina = stamina;
        this.team = team;
    }
    void Start()
    {
        physicsBody = GetComponent<Rigidbody>();   
        snitch = GameObject.Find("Snitch");
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, snitch.transform.position);
        Vector3 force = (snitch.transform.position - transform.position);
        force.Normalize();
        physicsBody.AddForce(distance*force);
        globals.Instance.numberOfGrifs = 3;
    }
}
