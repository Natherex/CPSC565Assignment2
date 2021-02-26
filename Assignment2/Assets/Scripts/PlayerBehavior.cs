using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float weight;
    public float maxVelocity;
    public float agro;

    public float Exhaustion = 100;
    public float maxExhaustion;
    bool resting = false;
    public int team;
    public GameObject snitch;
    private Rigidbody physicsBody;
    // Start is called before the first frame update
    public void constructor(float weight, float maxVelocity, float agro, float exhaustion , int team)
    {
        this.weight = weight;
        this.maxVelocity = maxVelocity;
        this.agro = agro;
        this.Exhaustion = exhaustion;
        this.maxExhaustion = exhaustion;
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
        if(Exhaustion > 5 && resting == false )
        {
        float distance = Vector3.Distance(transform.position, snitch.transform.position);
        Vector3 direction = (snitch.transform.position - transform.position);
        direction.Normalize();
        if(physicsBody.velocity.magnitude > maxVelocity)
        {
            physicsBody.velocity = physicsBody.velocity.normalized * maxVelocity;
        }else{
            //physicsBody.AddForce(distance*force);
            physicsBody.AddForce(direction * distance /5);
        }
        Exhaustion -= ((Mathf.Abs(physicsBody.velocity.x)) + (Mathf.Abs(physicsBody.velocity.x)) + (Mathf.Abs(physicsBody.velocity.x)) )* weight/50000;
    
        }else
        {
            resting = true;
            physicsBody.velocity = Vector3.zero;
            Exhaustion += 0.1f;
            if(Exhaustion >= maxExhaustion -1)
                resting = false;
        }
    }
}
