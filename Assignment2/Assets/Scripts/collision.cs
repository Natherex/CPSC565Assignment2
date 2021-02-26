using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    void OnCollisionEnter (Collision collision)
    {
        PlayerBehavior player = gameObject.GetComponent<PlayerBehavior>();
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "player(Clone)")
        {
            PlayerBehavior enemy = collision.gameObject.GetComponent<PlayerBehavior>();
            double playerAttack = player.agro * Random.Range(1,100) *(1.2-0.8) * (1 - (player.Exhaustion/enemy.Exhaustion));
            double enemyAttack  = enemy.agro * Random.Range(1,100) *(1.2-0.8) * (1 - (enemy.Exhaustion/player.Exhaustion));

            Debug.Log(collision.gameObject.name);
            if(playerAttack > enemyAttack)
            {
                //Debug.Log(collision.gameObject.name);
                if(player.team != enemy.team)
                {
                    Destroy(collision.gameObject);
                    if(player.team == 1)
                        globals.Instance.numberOfGrifs --; 
                    else
                        globals.Instance.numberOfSlyth --; 
                }
                else if(player.team == enemy.team && ( Random.Range(0,100) > 95))
                {
                    Destroy(gameObject);
                    if(player.team == 1)
                        globals.Instance.numberOfSlyth --; 
                    else
                        globals.Instance.numberOfGrifs --; 
                }
            }

        }
        else if((collision.gameObject.tag == "Arena"))
        {
            if(player.team == 1)
                globals.Instance.numberOfSlyth --; 
            else
                globals.Instance.numberOfGrifs --; 
            Destroy(gameObject);
        }
        else if((collision.gameObject.name == "Snitch"))
        {
            if(player.team == 1)
                globals.Instance.sScore ++;
            else
                globals.Instance.gScore ++;
            Destroy(gameObject);
        }
    }
}
