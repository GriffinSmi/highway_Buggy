using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelBoundary : MonoBehaviour
{
    public static float leftSide = 1.25f;
    public static float rightSide = -7.75f;
    public float internalLeft;
    public float internalRight;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}
