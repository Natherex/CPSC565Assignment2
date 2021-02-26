using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnGUI()
    {
        GUI.Box ( new Rect (50,50,125,50), "Griffon Score: " + globals.Instance.gScore +
        "\n Sliterin Score: " + globals.Instance.sScore);
    }
}
