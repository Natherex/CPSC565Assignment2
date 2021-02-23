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
        if(team == 1){
            gameObject.GetComponent<Renderer>().material.SetColor("_Color",Color.red);
        }else{
            gameObject.GetComponent<Renderer>().material.SetColor("_Color",Color.green);
        }
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
        Vector3 direction = (snitch.transform.position - transform.position);
        direction.Normalize();
        if(physicsBody.velocity.magnitude > maxVelocity)
        {
            physicsBody.velocity = physicsBody.velocity.normalized * maxVelocity;
        }else{
            //physicsBody.AddForce(distance*force);
            physicsBody.AddForce(direction * distance);
        }
    }
}
