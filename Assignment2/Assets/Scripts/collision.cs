using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.name == "player(Clone)")
        {
            PlayerBehavior player = gameObject.GetComponent<PlayerBehavior>();
            PlayerBehavior enemy = collision.gameObject.GetComponent<PlayerBehavior>();
            double playerAttack = player.agro * Random.Range(1,100) *(1.2-0.8) * (1 - (player.Exhaustion/enemy.Exhaustion));
            double enemyAttack  = enemy.agro * Random.Range(1,100) *(1.2-0.8) * (1 - (enemy.Exhaustion/player.Exhaustion));

            Debug.Log(player.Exhaustion/enemy.Exhaustion);
            if(playerAttack > enemyAttack)
            {
                //Debug.Log(collision.gameObject.name);
                if(player.team != enemy.team)
                    Destroy(collision.gameObject);
                else if(player.team == enemy.team && ( Random.Range(0,100) > 95))
                {
                    Destroy(gameObject);
                }
            }

        }
    }
}
