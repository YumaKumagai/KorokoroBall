using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorOrbit : MonoBehaviour
{
    private Vector3 centerPoint = new Vector3(0, 2, 5);
    private float radius = 12

        ;
    private int timer = 0;
    private int angleVelo = 1;


    private double DegToRad(double deg)
    {
        return (double)(deg * Mathf.PI / 180);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer++;
        timer = timer % (360 / angleVelo);
        int phase = timer * angleVelo;
        transform.position =
            new Vector3(centerPoint.x + radius * Mathf.Sin((float)DegToRad(phase)),
                centerPoint.y - radius * Mathf.Cos((float)DegToRad(phase)), 5);
    }
}
