using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sSpawner : MonoBehaviour
{
    public GameObject player;
    public static int numberOfPlayers;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0 ; i < globals.Instance.numberOfSlyth ; i++)
        {
            createPlayer();
        }
        StartCoroutine(spawner());
    }
    IEnumerator spawner(){
        int max = globals.Instance.numberOfSlyth;
        while(true)
        {
            yield return new WaitForSeconds(globals.Instance.spawnRate);
            if( max > globals.Instance.numberOfSlyth)
            {
                yield return new WaitForSeconds(globals.Instance.spawnRate);
                createPlayer();
                globals.Instance.numberOfSlyth++;
            }

        }
    }
    private void createPlayer()
    {
        GameObject newPlayer = Instantiate(player) as GameObject;
        newPlayer.transform.position = new Vector3(45,1.5f,Random.Range(-30,30) );

        newPlayer.GetComponent<PlayerBehavior>().constructor(createattribute(85,17),createattribute(16,2),createattribute(30,7),createattribute(50,15),1);
        
    }
    private float createattribute(int mean,int devi)
    {
        float x = 1 - Random.Range(0.0f,1.0f);
        float y = 1 - Random.Range(0.0f,1.0f);
        float num = Mathf.Sqrt(-2 * Mathf.Log(x)) * Mathf.Sin(2.0f * Mathf.PI * y);
        return (num*devi) + mean ;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
