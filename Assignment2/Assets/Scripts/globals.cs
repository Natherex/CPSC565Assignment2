using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globals : MonoBehaviour
{
    public static globals Instance { get; private set; }
    // Start is called before the first frame update
    public int numberOfGrifs;
    public int numberOfSlyth;
    public int spawnRate;

    public int gScore = 5;
    public int sScore = 5;
    private void Awake()
    {
        if ( Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }
}


//https://www.youtube.com/watch?v=E7gmylDS1C4&ab_channel=PressStart
//https://www.youtube.com/watch?v=4Wh22ynlLyk&ab_channel=PressStart
//https://www.youtube.com/watch?v=gAB64vfbrhI&ab_channel=Brackeys
//https://www.youtube.com/watch?v=CPKAgyp8cno&ab_channel=ResoCoder
//https://mathworld.wolfram.com/Box-MullerTransformation.html