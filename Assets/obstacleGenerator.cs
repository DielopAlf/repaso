using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class obstacleGenerator : MonoBehaviour
{

    public GameObject obstaculo;

    public float MinSpeed;

    public float MaxSpeed;

    public float    currentSpeed;

    public float SpeedMultiplier;


    void Awake()
    {
        currentSpeed = MinSpeed;
        generatePlatform();
    }
    public void GenerateNextObstacleWithGap()
    {

        float randomWait = Random.Range(0.1f, 1.2f);
        Invoke("generatePlatform", randomWait);

    }

    public void generatePlatform()
    {
        GameObject ObstaculoIns = Instantiate(obstaculo, transform.position, transform.rotation);

        ObstaculoIns.GetComponent<ObstacleGenerator1>().obstacleGenerator = this;


    }

     void Update()
    {
        if(currentSpeed<MaxSpeed)
        {
            currentSpeed += SpeedMultiplier;

        }
    }





}