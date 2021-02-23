using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gSpawner : MonoBehaviour
{
    public GameObject player;
    public static int numberOfPlayers;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0 ; i < globals.Instance.numberOfGrifs ; i++)
        {
            createPlayer();
        }
        StartCoroutine(spawner());
    }
    IEnumerator spawner(){
        int max = globals.Instance.numberOfGrifs;
        while(true)
        {
            yield return new WaitForSeconds(globals.Instance.spawnRate);
            if( max > globals.Instance.numberOfGrifs)
            {
                yield return new WaitForSeconds(globals.Instance.spawnRate);
                createPlayer();
            }

        }
    }
    private void createPlayer()
    {
        GameObject newPlayer = Instantiate(player) as GameObject;
        newPlayer.transform.position = new Vector3(-45,Random.Range(5,40),Random.Range(-30,30) );
        newPlayer.GetComponent<PlayerBehavior>().constructor(10,10,10,10,2);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
