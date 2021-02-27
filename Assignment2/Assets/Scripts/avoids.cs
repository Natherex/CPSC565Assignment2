using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avoids : MonoBehaviour
{
    private Rigidbody physicsBody;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        PlayerBehavior player = gameObject.GetComponent<PlayerBehavior>();
        physicsBody = GetComponent<Rigidbody>();
        if(other.gameObject.tag == "Arena")
        {
    
                Vector3 direction = ( other.transform.position - transform.position );
                float distance = Vector3.Distance(transform.position, other.transform.position);

                physicsBody.AddForce(direction * distance);
                player.Exhaustion -= ((Mathf.Abs(physicsBody.velocity.x)) + (Mathf.Abs(physicsBody.velocity.x)) + (Mathf.Abs(physicsBody.velocity.x)) )* player.weight/50000;
        }
        else if(other.gameObject.name == "player(Clone)")
        {
                PlayerBehavior enemy = other.GetComponent<PlayerBehavior>();
                if(enemy.team == player.team)
                {
                    float distance = Vector3.Distance(transform.position, other.transform.position);
                    Vector3 direction = (transform.position - other.gameObject.transform.position);
                    physicsBody.AddForce(direction * distance);
                    player.Exhaustion -= ((Mathf.Abs(physicsBody.velocity.x)) + (Mathf.Abs(physicsBody.velocity.x)) + (Mathf.Abs(physicsBody.velocity.x)) )* player.weight/50000;
                }else if(player.agro > enemy.agro && (player.Exhaustion > 10))
                {
                    float distance = Vector3.Distance(transform.position, other.transform.position);
                    Vector3 direction = (other.gameObject.transform.position - transform.position);
                    physicsBody.AddForce(direction * distance);
                    player.Exhaustion -= ((Mathf.Abs(physicsBody.velocity.x)) + (Mathf.Abs(physicsBody.velocity.x)) + (Mathf.Abs(physicsBody.velocity.x)) )* player.weight/50000;
                }else{
                    float distance = Vector3.Distance(transform.position, other.transform.position);
                    Vector3 direction = (transform.position - other.gameObject.transform.position);
                    physicsBody.AddForce(direction * distance);
                    player.Exhaustion -= ((Mathf.Abs(physicsBody.velocity.x)) + (Mathf.Abs(physicsBody.velocity.x)) + (Mathf.Abs(physicsBody.velocity.x)) )* player.weight/50000;
                }
        }
    }

}
